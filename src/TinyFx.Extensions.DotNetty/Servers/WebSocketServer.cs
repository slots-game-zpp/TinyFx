using DotNetty.Buffers;
using DotNetty.Codecs.Http;
using DotNetty.Handlers.Logging;
using DotNetty.Handlers.Timeout;
using DotNetty.Handlers.Tls;
using DotNetty.Transport.Bootstrapping;
using DotNetty.Transport.Channels;
using DotNetty.Transport.Channels.Sockets;
using DotNetty.Transport.Libuv;
using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.IO;
using System.Net.WebSockets;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using TinyFx.Configuration;
using TinyFx.Logging;

namespace TinyFx.Extensions.DotNetty
{
    public class WebSocketServer : TcpSocketServer
    {
        private IPacketSerializer _packetSerializer;
        private DotNettySection _options;
        //private ConsulClientEx _consulClient;

        //private static int READ_IDEL_TIME_OUT = 0; // 读超时：channelRead()未被调用时长=>userEventTrigger()
        //private static int WRITE_IDEL_TIME_OUT = 0;// 写超时：write()未被调用时长=>userEventTrigger()
        //private static int ALL_IDEL_TIME_OUT = 5; // 所有超时

        public WebSocketServer()
        {
            _packetSerializer = DIUtil.GetRequiredService<IPacketSerializer>();
            _options = DIUtil.GetRequiredService<DotNettySection>();
            Events = DIUtil.GetRequiredService<DefaultServerEventListener>();
            //_consulClient = DIUtil.GetService<ConsulClientEx>();
        }

        public async Task StartAsync()
        {
            if (_options.UseLibuv)
            {
                var dispatcher = new DispatcherEventLoopGroup();
                _bossGroup = dispatcher;
                _workerGroup = new WorkerEventLoopGroup(dispatcher);
            }
            else
            {
                _bossGroup = new MultithreadEventLoopGroup();
                _workerGroup = new MultithreadEventLoopGroup();
            }

            var bootstrap = new ServerBootstrap();
            bootstrap.Group(_bossGroup, _workerGroup);
            if (_options.UseLibuv)
            {
                bootstrap.Channel<TcpServerChannel>();
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux)
                    || RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                {
                    bootstrap
                        .Option(ChannelOption.SoReuseport, true)
                        .ChildOption(ChannelOption.SoReuseaddr, true);
                }
            }
            else
            {
                bootstrap.Channel<TcpServerSocketChannel>();
            }
            bootstrap.Option(ChannelOption.SoBacklog, _options.SoBacklog)
            .Option(ChannelOption.TcpNodelay, true)
            .Option(ChannelOption.SoKeepalive, true) //SO_KEEPALIVE指打开TCP心跳检测
            .Option(ChannelOption.Allocator, PooledByteBufferAllocator.Default) // Netty的内存在堆外直接内存上分配，可避免字节缓冲区的二次拷贝
            .Option(ChannelOption.ConnectTimeout, new TimeSpan(_options.ConnectTimeout))
            .Handler(new LoggingHandler("SRV-LSTN", _options.LogLevel))
            .ChildHandler(new ActionChannelInitializer<IChannel>(channel =>
            {
                var pipeline = channel.Pipeline;
                pipeline.AddLast(new LoggingHandler("SRV-CONN", _options.LogLevel));
                if (_options.Ssl)
                {
                    var cer = new X509Certificate2(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, _options.SslCer), _options.SslPassword);
                    pipeline.AddLast("tls", TlsHandler.Server(cer));
                }
                if (_options.Protocol == ProtocolMode.WebSocket)
                {
                    pipeline.AddLast(new HttpServerCodec());
                    pipeline.AddLast(new WebSocketPacketEncoder());
                    pipeline.AddLast(new HttpObjectAggregator(65536));
                    if (_options.ReadIdelTimeOut != 0)
                    {
                        pipeline.AddLast(new IdleStateHandler(_options.ReadIdelTimeOut, 0, 0));
                        pipeline.AddLast(new HeartbeatServerHandler());
                    }
                    pipeline.AddLast(new WebSocketServerHandler());
                }
            }));

            _serverChannel = await bootstrap.BindAsync(_options.Port).ConfigureAwait(false);
            //_consulClient?.ServiceRegister();
            Events.OnServerStart(this, new ServerStartArgs { Options = _options });
        }

        public async Task StopAsync()
        {
            await Task.Run(() =>
            {
                Dispose();
            }).ContinueWith(task =>
            {
                //_consulClient?.ServiceDeregister();
                if (task.IsCompleted && !task.IsFaulted)
                {
                    Events.OnServerStop(this, new ServerStopArgs { Options = _options });
                }
                if (task.IsFaulted)
                {
                    LogUtil.Error(task.Exception, "WebSocket server exception. options:{options}", _options);
                    Events.OnServerException(this, new ServerExceptionArgs { Options = _options, Exception = task.Exception });
                }
            });
        }
    }
}

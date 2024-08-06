using DotNetty.Buffers;
using DotNetty.Codecs.Http;
using Codecs = DotNetty.Codecs.Http;
using DotNetty.Codecs.Http.WebSockets;
using DotNetty.Common.Utilities;
using DotNetty.Transport.Channels;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using TinyFx.Configuration;
using TinyFx.Logging;
using TinyFx.Net;
using static DotNetty.Codecs.Http.HttpResponseStatus;
using static DotNetty.Codecs.Http.HttpVersion;
using DotNetty.Transport.Libuv.Native;

namespace TinyFx.Extensions.DotNetty
{
    public class WebSocketServerHandler : SimpleChannelInboundHandler<object>
    {
        const string WebsocketPath = "/websocket";
        private WebSocketServerHandshaker _handshaker;

        private DotNettySection _option;
        private ILogger _logger;
        private AppSessionContainer _sessions;
        private IPacketSerializer _serializer;
        private CommandContainer _commands;
        private DefaultServerEventListener _events;

        public WebSocketServerHandler()
        {
            _logger = LogUtil.DefaultLogger;
            _option = ConfigUtil.GetSection<DotNettySection>();
            //ConfigUtil.ConfigChange += (_, _) => {
            //    _option = ConfigUtil.GetSection<DotNettySection>()!.Server;
            //};
            _sessions = DIUtil.GetRequiredService<AppSessionContainer>();
            _serializer = DIUtil.GetRequiredService<IPacketSerializer>();
            _commands = DIUtil.GetRequiredService<CommandContainer>();
            _events = DIUtil.GetRequiredService<DefaultServerEventListener>();
        }

        #region override
        protected override void ChannelRead0(IChannelHandlerContext ctx, object msg)
        {
            // IP黑名单验证
            if (!DotNettyUtil.IsAllowIp(ctx.Channel.RemoteAddress.ToString()))
                return;
            if (msg is IFullHttpRequest request)
                HandleHttpRequest(ctx, request);
            else if (msg is WebSocketFrame frame)
                HandleWebSocketFrame(ctx, frame);
        }
        public override void ChannelReadComplete(IChannelHandlerContext ctx)
        {
            ctx.Flush();
        }
        public override void ExceptionCaught(IChannelHandlerContext ctx, Exception e)
        {
            var session = GetAppSession(ctx);
            var ex = ExceptionUtil.GetInnerException(e);
            // 远程主机关闭
            var isConnReset = ex is SocketException;
            if (!isConnReset)
            {
                if (ex is OperationException)
                {
                    isConnReset = ((OperationException)ex).Name == "ECONNRESET";
                }
            }
            if (isConnReset)
            {
                var args = new ChannelClosedArgs
                {
                    UserId = session?.UserId,
                    Context = ctx,
                    Session = session,
                    ReasonString = ex.Message,
                    Exception = e
                };
                if (_option.EnableClosedEvent)
                    _events.OnChannelClosed(this, args);
                try
                {
                    ctx.CloseAsync();
                }
                catch { }
            }
            else
            {
                var packet = DotNettyUtil.CreateExceptionPacket(e, session, out var isCustomEx);
                if (!isCustomEx)
                {
                    var args = new ChannelExceptionArgs()
                    {
                        UserId = session?.UserId,
                        Context = ctx,
                        Session = session,
                        Exception = e
                    };
                    _events.OnChannelException(this, args);
                }
                ctx.WriteAndFlushAsync(packet);
            }
        }
        public override void ChannelInactive(IChannelHandlerContext context)
        {
            base.ChannelInactive(context);
            var args = new ChannelInactiveArgs()
            {
                Context = context,
                Session = GetAppSession(context)
            };
            args.UserId = args.Session?.UserId;
            _events.OnChannelInactive(this, args);
            args.Session.Close();
            _sessions.Remove(context.Channel.Id);
            context.Channel.CloseAsync();
        }
        private AppSession GetAppSession(IChannelHandlerContext context)
        {
            AppSession ret;
            _sessions.TryGet(context.Channel.Id, out ret);
            return ret;
        }
        #endregion

        #region Handler 
        void HandleHttpRequest(IChannelHandlerContext ctx, IFullHttpRequest req)
        {
            // Handle a bad request.
            if (!req.Result.IsSuccess)
            {
                SendHttpResponse(ctx, req, new DefaultFullHttpResponse(Http11, BadRequest));
                return;
            }

            // Allow only GET methods.
            if (!Equals(req.Method, Codecs.HttpMethod.Get))
            {
                SendHttpResponse(ctx, req, new DefaultFullHttpResponse(Http11, Forbidden));
                return;
            }
            // 握手前验证
            if (_events.HandleVerifyBeforeHandshake != null && !_events.HandleVerifyBeforeHandshake(req))
            {
                SendHttpResponse(ctx, req, new DefaultFullHttpResponse(Http11, BadRequest));
                return;
            }

            // Handshake
            var webSocketUrl = GetWebSocketLocation(req);
            if (string.IsNullOrEmpty(webSocketUrl))
                return;
            var wsFactory = new WebSocketServerHandshakerFactory(webSocketUrl, null, true, 5242880);
            _handshaker = wsFactory.NewHandshaker(req);
            if (_handshaker == null)
            {
                // 版本不支持
                WebSocketServerHandshakerFactory.SendUnsupportedVersionResponse(ctx.Channel);
            }
            else
            {
                try
                {
                    // 握手建立连接
                    _handshaker.HandshakeAsync(ctx.Channel, req)
                        .ContinueWith(task =>
                        {
                            if (task.Status == TaskStatus.RanToCompletion)
                            {
                                var session = new AppSession(ctx.Channel, ctx.Channel.RemoteAddress);
                                _sessions.AddOrUpdate(session);
                                _events.OnChannelActive(this, new ChannelActiveArgs { Context = ctx, Session = session });
                            }
                            else if (task.Status == TaskStatus.Faulted)
                            {
                                LogUtil.Error(task.Exception, $"WebSocket Handshake Error");
                                _events.OnChannelException(this, new ChannelExceptionArgs { Context = ctx, Exception = task.Exception });
                            }
                        });
                }
                catch (WebSocketHandshakeException) // not a WebSocket handshake request: missing upgrade
                { }
            }
        }

        void HandleWebSocketFrame(IChannelHandlerContext ctx, WebSocketFrame frame)
        {
            switch (frame)
            {
                // 断开连接处理
                case CloseWebSocketFrame _:
                    _handshaker.CloseAsync(ctx.Channel, (CloseWebSocketFrame)frame.Retain());
                    return;
                // ping处理
                case PingWebSocketFrame _:
                    ctx.WriteAsync(new PongWebSocketFrame((IByteBuffer)frame.Content.Retain()));
                    return;
                // 非文本不支持
                case TextWebSocketFrame _:
                    throw new Exception($"WebSocket服务不支持文本协议[TextWebSocketFrame]: {frame.GetType().FullName}");
                case BinaryWebSocketFrame _:
                    HandleBinaryWebSocketFrame((BinaryWebSocketFrame)frame.Retain(), ctx);
                    return;
            }
        }

        private void HandleBinaryWebSocketFrame(BinaryWebSocketFrame binaryWebSocketFrame, IChannelHandlerContext ctx)
        {
            var packet = _serializer.Decode(binaryWebSocketFrame.Content);
            AppSession session;
            var waitTime = 0;
            while (true)
            {
                session = _sessions.Get(ctx.Channel?.Id);
                if (session != null || waitTime > _option.ConnectTimeout)
                    break;
                Thread.Sleep(1000);
                waitTime += 1000;
            }
            // 因为异步，客户端连接后立刻发送请求，会造成session尚未完成
            if (session == null)
            {
                ctx.WriteAndFlushAsync(DotNettyUtil.CreateExceptionPacket(GResponseCodes.G_SERVER_CONNECT_ERROR, $"服务器连接未准备好，请再次尝试连接。请求CommandId: {packet.CommandId}"));
                return;
            }
            // User黑名单验证
            if (!IsAllowUser(session))
                return;
            session.LastAccessTime = DateTime.UtcNow; //更新用户激活状态

            // 心跳
            if (packet.CommandId == DotNettyUtil.HeartbeatCommandId)
            {
                Task.Run(() => ctx.WriteAndFlushAsync(HeartbeatServerHandler.HEARTBEAT_PACKAT));
                if (_option.EnableHeartbeatEvent)
                {
                    _events.OnChannelHeartbeat(this, new ChannelHeartbeatArgs { Session = session });
                }
                return;
            }
            // 获取映射Command返回数据
            if (!_commands.TryGet(packet.CommandId, out CommandDescriptor cmd))
                throw new Exception($"CommandDescriptorProvider中不包含接收到的数据包的CommandId: {packet.CommandId}");
            var reqCtx = new RequestContext
            {
                Session = session,
                Packet = packet,
            };
            if (_option.EnableReceiveEvent)
                _events.OnChannelReceive(this, new ChannelReceiveArgs { CommandData = cmd, Session = session, Context = reqCtx });
            cmd.RespondExecute(reqCtx);

        }
        #endregion

        #region Utils
        static void SendHttpResponse(IChannelHandlerContext ctx, IFullHttpRequest req, IFullHttpResponse res)
        {
            // Generate an error page if response getStatus code is not OK (200).
            if (res.Status.Code != 200)
            {
                IByteBuffer buf = Unpooled.CopiedBuffer(Encoding.UTF8.GetBytes(res.Status.ToString()));
                res.Content.WriteBytes(buf);
                buf.Release();
                HttpUtil.SetContentLength(res, res.Content.ReadableBytes);
            }

            // Send the response and close the connection if necessary.
            Task task = ctx.WriteAndFlushAsync(res);
            if (!HttpUtil.IsKeepAlive(req) || res.Status.Code != 200)
            {
                task.ContinueWith((t, c) => ((IChannelHandlerContext)c).CloseAsync(),
                    ctx, TaskContinuationOptions.ExecuteSynchronously);
            }
        }
        private string GetWebSocketLocation(IFullHttpRequest req)
        {
            bool result = req.Headers.TryGet(HttpHeaderNames.Host, out ICharSequence value);
            if (!result)
            {
                _logger.LogInformation("Host header does not exist.");
                return null;
            }
            string location = value.ToString() + WebsocketPath;

            if (_option != null && _option.Ssl)
            {
                return "wss://" + location;
            }
            else
            {
                return "ws://" + location;
            }
        }
        #endregion

        #region LimitIp & LimitUser
        private Packet _limitPacket;
        private Packet GetLimitPacket()
        {
            if (_limitPacket == null)
            {
                _limitPacket = DotNettyUtil.CreateExceptionPacket(GResponseCodes.G_REQUEST_LIMIT
                    , $"用户账户被列入黑名单！");
            }
            return _limitPacket;
        }
        private bool IsAllowUser(AppSession session)
        {
            if (!DotNettyUtil.IsAllowUser(session.UserId))
            {
                session.Channel.WriteAndFlushAsync(GetLimitPacket());
                session.Channel.CloseAsync();
                return false;
            }
            return true;
        }
        #endregion
    }
}

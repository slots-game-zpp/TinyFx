using DotNetty.Codecs.Http;
using DotNetty.Handlers.Logging;
using DotNetty.Transport.Channels;
using System;
using System.Collections.Generic;
using System.Text;
using TinyFx.Configuration;
using TinyFx.Logging;

namespace TinyFx.Extensions.DotNetty
{
    /*
     * channelRegistered            当前channel注册到EventLoop
     * channelActive                当前channel活跃的时候
     * channelRead                  当前channel从远端读取到数据
     * channelReadComplete          channel read消费完读取的数据的时候被触发
     * channelWritabilityChanged    channel的写状态变化的时候触发
     * userEventTriggered           用户事件触发的时候
     * channelInactive              当前channel不活跃的时候，也就是当前channel到了它生命周期末
     * channelUnregistered          当前channel从EventLoop取消注册
     * channelHeartbeat             当前channel心跳
     */
    /// <summary>
    /// 
    /// </summary>
    public interface IServerEventListener
    {
        /// <summary>
        /// 服务器启动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void OnServerStart(object sender, ServerStartArgs args);
        /// <summary>
        /// 服务器关闭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void OnServerStop(object sender, ServerStopArgs args);
        /// <summary>
        /// 服务器执行时出现异常
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void OnServerException(object sender, ServerExceptionArgs args);
        /// <summary>
        /// 客户端建立连接（此时未登陆）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void OnChannelActive(object sender, ChannelActiveArgs args);
        /// <summary>
        /// 接收到客户端消息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void OnChannelReceive(object sender, ChannelReceiveArgs args);
        /// <summary>
        /// 向客户端发送消息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void OnChannelSend(object sender, ChannelSendArgs args);
        /// <summary>
        /// 客户端主动关闭（SocketException），一般不要处理此事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void OnChannelClosed(object sender, ChannelClosedArgs args);
        /// <summary>
        /// 客户端断开连接（包含主动和被动）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void OnChannelInactive(object sender, ChannelInactiveArgs args);
        /// <summary>
        /// 连接通道Channel中出现异常
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void OnChannelException(object sender, ChannelExceptionArgs args);
        /// <summary>
        /// 心跳
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void OnChannelHeartbeat(object sender, ChannelHeartbeatArgs args);

        /// <summary>
        /// Websocket连接握手前验证，返回true表示允许连接
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        bool VerifyBeforeHandshake(IFullHttpRequest req);
    }
    public class DefaultServerEventListener
    {
        private AppSessionContainer _sessions;
        private DotNettySection _options;
        private IServerEventListener _events;
        private LogLevel _logLevel => _options.LogLevel;
        public Func<IFullHttpRequest, bool> HandleVerifyBeforeHandshake;

        public DefaultServerEventListener()
        {
            _options = DIUtil.GetRequiredService<DotNettySection>();
            _sessions = DIUtil.GetRequiredService<AppSessionContainer>();
            _events = DIUtil.GetService<IServerEventListener>();
            if (_events != null)
            {
                ServerStart += _events.OnServerStart;
                ServerStop += _events.OnServerStop;
                ServerException += _events.OnServerException;
                ChannelActive += _events.OnChannelActive;
                ChannelReceive += _events.OnChannelReceive;
                ChannelSend += _events.OnChannelSend;
                ChannelClosed += _events.OnChannelClosed;
                ChannelInactive += _events.OnChannelInactive;
                ChannelException += _events.OnChannelException;
                ChannelHeartbeat += _events.OnChannelHeartbeat;
                HandleVerifyBeforeHandshake = _events.VerifyBeforeHandshake;
            }
        }

        #region Server
        public event EventHandler<ServerStartArgs> ServerStart;
        public void OnServerStart(object sender, ServerStartArgs args)
        {
            LogUtil.Info("WebSocket server started. Port:{Port}", args.Options.Port);
            LogUtil.Debug("========== Commands 开始 ============");
            LogUtil.Debug("CommandId: {0,6} 心跳（Body 返回 {1}）", 0, null);
            LogUtil.Debug("CommandId: {0,6} 自定义或未处理异常（Body 返回 {1}）", -1, nameof(ProtoResponse)); 
            foreach (var cmd in DotNettyUtil.Commands.GetCommands())
            {
                if (cmd.CommandId < 0)
                    continue;
                LogUtil.Debug("CommandId: {0,6} CommandType: {1,-" + DotNettyUtil.Commands.CommandTypeMaxLength + "}", cmd.CommandId
                    , cmd.IsPush ? $"PUSH => {cmd.CommandType.Name}" : $"RPC  => {cmd.CommandType.Name}<{cmd.RequestType.Name}, {cmd.ResponseType.Name}>");
            }
            LogUtil.Debug("========== Commands 结束 ============");
            ServerStart?.Invoke(sender, args);
        }
        public event EventHandler<ServerStopArgs> ServerStop;
        public void OnServerStop(object sender, ServerStopArgs args)
        {
            LogUtil.Info("WebSocket server closed. {Port}", args.Options.Port);
            ServerStop?.Invoke(sender, args);
        }
        public event EventHandler<ServerExceptionArgs> ServerException;
        public void OnServerException(object sender, ServerExceptionArgs args)
        {
            ServerException?.Invoke(sender, args);
        }
        #endregion

        #region Channel

        public event EventHandler<ChannelActiveArgs> ChannelActive;
        public void OnChannelActive(object sender, ChannelActiveArgs args)
        {
            if (_logLevel <= LogLevel.DEBUG)
                LogUtil.Debug("New client to handshake: ChannelId = {channelId}[ {remoteAddress} => {localAddress} ]"
                    , args.Session?.Channel?.Id, args.Session?.RemoteAddressString, args.Session?.LocalAddressString);
            ChannelActive?.Invoke(sender, args);
        }
        public event EventHandler<ChannelReceiveArgs> ChannelReceive;
        public void OnChannelReceive(object sender, ChannelReceiveArgs args)
        {
            if (_logLevel <= LogLevel.DEBUG)
            {
                LogUtil.Debug("[REC <=] UserId={userId} CommandId={commandId} BodyLength={bodyLength} BodyType={bodyType}"
                    , FormatString(args.Context?.Session?.UserId, 38)
                    , FormatString(args.Context?.Packet?.CommandId, 8)
                    , FormatString(args.Context?.Packet?.BodyLength, 8)
                    , args.Context?.Packet?.GetBodyType());
            }
            ChannelReceive?.Invoke(sender, args);
        }
        public event EventHandler<ChannelSendArgs> ChannelSend;
        public void OnChannelSend(object sender, ChannelSendArgs args)
        {
            if (_logLevel <= LogLevel.DEBUG)
                LogUtil.Debug("[SND =>] UserId={userId} CommandId={commandId} BodyLength={bodyLength} BodyType={bodyType}"
                    , FormatString(args.Session?.UserId, 38)
                    , FormatString(args.Response?.CommandId, 8)
                    , FormatString(args.Response?.BodyLength, 8)
                    , args.Response?.GetBodyType());
            ChannelSend?.Invoke(sender, args);
        }
        public event EventHandler<ChannelClosedArgs> ChannelClosed;
        public void OnChannelClosed(object sender, ChannelClosedArgs args)
        {
            if (_logLevel <= LogLevel.DEBUG)
                LogUtil.Debug("Channel Closed: UserId={0} Reason: [{1}] {2}",
                    args.Session?.UserId, args.Session?.RemoteAddressString, args.ReasonString);
            ChannelClosed?.Invoke(sender, args);
        }

        public event EventHandler<ChannelInactiveArgs> ChannelInactive;
        public void OnChannelInactive(object sender, ChannelInactiveArgs args)
        {
            if (args.Context.Channel != null)
            {
                if (_logLevel <= LogLevel.DEBUG)
                    LogUtil.Debug("Channel Inactive: UserId:{userId} clientIp:{remoteAddress}"
                        , args.Session?.UserId, args.Session?.RemoteAddressString);
                ChannelInactive?.Invoke(sender, args);
            }
        }
        public event EventHandler<ChannelExceptionArgs> ChannelException;
        public void OnChannelException(object sender, ChannelExceptionArgs args)
        {
            ChannelException?.Invoke(sender, args);
        }

        public event EventHandler<ChannelHeartbeatArgs> ChannelHeartbeat;
        public void OnChannelHeartbeat(object sender, ChannelHeartbeatArgs args)
        {
            ChannelHeartbeat?.Invoke(sender, args);
        }

        #endregion

        private static string FormatString(object src, int length)
            => string.Format($"{{0,{length}}}", src);
    }
    public class ServerStartArgs
    {
        public DotNettySection Options { get; set; }
    }
    public class ServerStopArgs
    {
        public DotNettySection Options { get; set; }
    }
    public class ServerExceptionArgs
    {
        public DotNettySection Options { get; set; }
        public Exception Exception { get; set; }
    }

    public class ChannelActiveArgs
    {
        public IChannelHandlerContext Context { get; set; }
        public AppSession Session { get; set; }
    }
    public class ChannelReceiveArgs
    {
        public CommandDescriptor CommandData { get; set; }
        public AppSession Session { get; set; }
        public RequestContext Context { get; set; }
    }
    public class ChannelSendArgs
    {
        public IChannelHandlerContext Context { get; set; }
        public IPacket Response { get; set; }
        public AppSession Session { get; set; }
    }
    public class ChannelClosedArgs
    {
        public string UserId { get; set; }
        public IChannelHandlerContext Context { get; set; }
        public AppSession Session { get; set; }
        public Exception Exception { get; set; }
        public string ReasonString { get; set; }
    }
    public class ChannelInactiveArgs
    {
        public string UserId { get; set; }
        public IChannelHandlerContext Context { get; set; }
        public AppSession Session { get; set; }
    }
    public class ChannelExceptionArgs
    {
        public string UserId { get; set; }
        public IChannelHandlerContext Context { get; set; }
        public AppSession Session { get; set; }
        public Exception Exception { get; set; }
    }

    public class ChannelHeartbeatArgs
    {
        public AppSession Session { get; set; }
    }
}

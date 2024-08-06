using DotNetty.Transport.Channels;
using System;
using System.Collections.Generic;
using System.Text;

namespace TinyFx.Extensions.DotNetty
{
    public class TcpSocketServer:TinyFx.Disposable
    {
        protected IEventLoopGroup _bossGroup;
        protected IEventLoopGroup _workerGroup;
        protected IChannel _serverChannel;

        public DefaultServerEventListener Events { get; protected set; }

        protected override void Dispose(bool disposing)
        {
            _serverChannel?.CloseAsync().Wait();
            _bossGroup?.ShutdownGracefullyAsync().Wait();
            _workerGroup?.ShutdownGracefullyAsync().Wait();
        }
    }
}

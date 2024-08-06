using DotNetty.Buffers;
using DotNetty.Codecs.Http.WebSockets;
using DotNetty.Handlers.Timeout;
using DotNetty.Transport.Channels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace TinyFx.Extensions.DotNetty
{
    /*
    public class HeartbeatHandlerInitializer : ChannelInitializer<IChannel>
    {
        private static int READ_IDEL_TIME_OUT = 0; // 读超时：channelRead()未被调用时长=>userEventTrigger()
        private static int WRITE_IDEL_TIME_OUT = 0;// 写超时：write()未被调用时长=>userEventTrigger()
        private static int ALL_IDEL_TIME_OUT = 5; // 所有超时

        protected override void InitChannel(IChannel channel)
        {
            var pipeline = channel.Pipeline;
            pipeline.AddLast(new IdleStateHandler(READ_IDEL_TIME_OUT, WRITE_IDEL_TIME_OUT, ALL_IDEL_TIME_OUT));
            pipeline.AddLast(new HeartbeatServerHandler());
        }
    }
    */
    public class HeartbeatServerHandler : ChannelHandlerAdapter
    {
        public static IPacket HEARTBEAT_PACKAT = new Packet { CommandId = 0 };
        public static IByteBuffer HEARTBEAT_SEQUENCE;
        static HeartbeatServerHandler()
        {
            var a1 = BitConverter.GetBytes(0);
            var a2 = BitConverter.GetBytes(0);
            byte[] arr = new byte[a1.Length + a2.Length];
            Array.Copy(a1, 0, arr, 0, a1.Length);
            Array.Copy(a2, 0, arr, a1.Length, a2.Length);
            HEARTBEAT_SEQUENCE = Unpooled.UnreleasableBuffer(Unpooled.CopiedBuffer(arr));
        }
        public override void UserEventTriggered(IChannelHandlerContext context, object evt)
        {
            var idleEvt = evt as IdleStateEvent;
            if (idleEvt != null)
            {
                if (IdleState.ReaderIdle == idleEvt.State)
                {
                    context.WriteAndFlushAsync(HEARTBEAT_PACKAT)
                        .ContinueWith(task =>
                        {
                            if (task.IsFaulted)
                                context.CloseAsync();
                        });
                    /*
                    context.WriteAndFlushAsync(HEARTBEAT_SEQUENCE.Duplicate())
                        .ContinueWith(task =>
                        {
                            if (task.IsFaulted)
                                context.CloseAsync();
                        });
                    */
                }
            }
            else
                base.UserEventTriggered(context, evt);
        }
    }

}

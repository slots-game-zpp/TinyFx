using DotNetty.Buffers;
using DotNetty.Codecs;
using DotNetty.Codecs.Http.WebSockets;
using DotNetty.Common;
using DotNetty.Common.Utilities;
using DotNetty.Transport.Channels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TinyFx.Configuration;
using TinyFx.Logging;

namespace TinyFx.Extensions.DotNetty
{
    public class WebSocketPacketEncoder : MessageToMessageEncoder<IPacket>
    {
        private IPacketSerializer _serializer;
        private DefaultServerEventListener _events;
        private AppSessionContainer _sessions;
        private DotNettySection _option;

        public WebSocketPacketEncoder()
        {
            _serializer = DIUtil.GetRequiredService<IPacketSerializer>();
            _sessions = DIUtil.GetRequiredService<AppSessionContainer>();
            _events = DIUtil.GetRequiredService<DefaultServerEventListener>();
            _option = ConfigUtil.GetSection<DotNettySection>();
            //ConfigUtil.ConfigChange += (_, _) =>
            //{
            //    _option = ConfigUtil.GetSection<DotNettySection>()?.Server;
            //};
        }
        protected override void Encode(IChannelHandlerContext context, IPacket message, List<object> output)
        {
            var buffer = _serializer.Encode(message);
            output.Add(buffer.Retain());
        }
        public override Task WriteAsync(IChannelHandlerContext ctx, object msg)
        {
            Task result;
            ThreadLocalObjectList output = null;
            try
            {
                if (base.AcceptOutboundMessage(msg))
                {
                    output = ThreadLocalObjectList.NewInstance();
                    var cast = (IPacket)msg;
                    try
                    {
                        Encode(ctx, cast, output);
                    }
                    finally
                    {
                        if (_sessions.TryGet(ctx.Channel.Id, out AppSession session))
                        {
                            if (_option.EnableSendEvent)
                                _events.OnChannelSend(this, new ChannelSendArgs { Context = ctx, Response = cast, Session = session });
                        }
                        else
                        {
                            //LogUtil.LogWarning($"发送数据时AppSessionContainer不包含Channel: {ctx.Channel}");
                        }
                        ReferenceCountUtil.Release(cast);
                    }
                    if (output.Count == 0)
                    {
                        output.Return();
                        output = null;

                        throw new EncoderException(this.GetType().Name + " must produce at least one message.");
                    }
                }
                else
                {
                    return ctx.WriteAsync(msg);
                }
            }
            catch (EncoderException e)
            {
                throw new EncoderException(e);
            }
            catch (Exception ex)
            {
                throw new EncoderException(ex);
            }
            finally
            {
                if (output != null)
                {
                    if (output.Count > 0)
                    {
                        IByteBuffer byteBuffer = Unpooled.CopiedBuffer(output.ConvertAll(v => v as IByteBuffer).ToArray());
                        result = ctx.WriteAsync(new BinaryWebSocketFrame(byteBuffer));
                    }
                    else
                    {
                        // 0 items in output - must never get here
                        result = null;
                    }
                    output.Return();
                }
                else
                {
                    // output was reset during exception handling - must never get here
                    result = null;
                }
            }

            return result;
        }
    }
}

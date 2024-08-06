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

namespace TinyFx.Extensions.DotNetty
{
    /*
    public class PacketCodec : CombinedChannelDuplexHandler<PacketDecoder, PacketEncoder>
    { }
    public class PacketDecoder : ByteToMessageDecoder
    {
        private IPacketSerializer _serializer;
        public PacketDecoder(IPacketSerializer serializer)
        {
            _serializer = serializer;
        }
        protected override void Decode(IChannelHandlerContext context, IByteBuffer input, List<object> output)
        {
            if (!_serializer.IsComplete(input)) return;
            output.Add(_serializer.Decode(input));
        }
    }
    public class PacketEncoder : MessageToByteEncoder<IPacket>
    {
        private IPacketSerializer _serializer;
        public PacketEncoder(IPacketSerializer serializer)
        {
            _serializer = serializer;
        }
        protected override void Encode(IChannelHandlerContext context, IPacket message, IByteBuffer output)
        {
            output.WriteBytes(_serializer.Encode(message));
        }
    }
    */
}

using DotNetty.Buffers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TinyFx.Extensions.DotNetty
{
    public interface IPacketSerializer
    {
        bool IsComplete(IByteBuffer buffer);
        IPacket Decode(IByteBuffer buffer);
        IByteBuffer Encode(IPacket packet);
    }
    public class PacketSerializer : IPacketSerializer
    {
        private const int HeaderLength = 8;
        public bool IsLittleEndian { get; set; }

        private IBodySerializer _serializer;
        private static CommandContainer _commands;

        public PacketSerializer(bool isLittleEndian = false)
        {
            _serializer = DIUtil.GetRequiredService<IBodySerializer>();
            _commands = DIUtil.GetRequiredService<CommandContainer>();
            IsLittleEndian = isLittleEndian;
        }

        /// <summary>
        /// Packet是否接收完毕
        /// </summary>
        /// <param name="buffer"></param>
        /// <returns></returns>
        public bool IsComplete(IByteBuffer buffer)
        {
            if (buffer.ReadableBytes < HeaderLength)
                return false;
            var bodyLength = buffer.GetInt(4);
            return buffer.ReadableBytes >= HeaderLength + bodyLength;
        }
        
        public IPacket Decode(IByteBuffer buffer)
        {
            var cmdid = buffer.ReadInt();
            var bodyLength = buffer.ReadInt();
            // 心跳
            if (cmdid == 0)
            {
                if (bodyLength != 0)
                    throw new Exception("心跳包必须CommandId=0，BodyLength=0");
                return HeartbeatServerHandler.HEARTBEAT_PACKAT;
            }
            if (!_commands.TryGet(cmdid, out CommandDescriptor command))
                throw new Exception($"CommandId没有对应的CommandInfo。CommandId = {cmdid}");
            
            var ret = new Packet { CommandId = cmdid };
            // 没有数据
            //if (bodyLength == 0)
            //    return ret;

            ret.BodyLength = bodyLength;
            var bodyData = new byte[bodyLength];
            buffer.ReadBytes(bodyData);
            // server: request => Packet
            if (command.RequestType == typeof(object))
            {
                if (bodyLength != 0)
                    throw new Exception($"RespondCommand<IRequest, IResponse>请求类型IRequest是object，则请求数据BodyLength必须为0。CommandId={command.CommandId} BodyLength={bodyLength}");
                ret.Body = null;
            }
            else
                ret.Body = _serializer.Deserialize(command.RequestType, bodyData);
            return ret;
        }
        public IByteBuffer Encode(IPacket packet)
        {
            // 心跳包
            if (packet.CommandId == 0)
                return HeartbeatServerHandler.HEARTBEAT_SEQUENCE;
            if (!_commands.TryGet(packet.CommandId, out CommandDescriptor command))
                throw new Exception($"CommandId没有对应的CommandInfo。CommandId = {packet.CommandId}");
            //
            var ret = Unpooled.Buffer();
            ret.WriteInt(packet.CommandId);
            if (packet.Body == null)
            {
                ret.WriteInt(0);
            }
            else
            {
                // TODO: BufferWriter => IByteBuffer
                using (var stream = new MemoryStream())
                {
                    _serializer.Serialize(command.ResponsePacketType, stream, packet.Body);
                    var bodyData = stream.ToArray();
                    var bodyLength = bodyData.Length;
                    packet.BodyLength = bodyLength;
                    ret.WriteInt(bodyLength);
                    ret.WriteBytes(bodyData);
                }
            }
            return ret;
        }
    }

}

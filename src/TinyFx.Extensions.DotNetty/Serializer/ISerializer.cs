using System;
using System.Buffers;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace TinyFx.Extensions.DotNetty
{
    public interface IBodySerializer
    {
        void Serialize(Type type, Stream destination, object instance);
        object Deserialize(Type type, ReadOnlySpan<byte> source);

    }

    public enum SerializerMode
    {
        /// <summary>
        /// protobuf-net
        /// </summary>
        ProtobufNet
    }
}

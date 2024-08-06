using ProtoBuf.Meta;
using System;
using System.Buffers;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace TinyFx.Extensions.DotNetty
{
    public class ProtobufNetSerializer : IBodySerializer
    {
        private static readonly RuntimeTypeModel _serializer;
        static ProtobufNetSerializer()
        {
            _serializer = RuntimeTypeModel.Create();
            _serializer.UseImplicitZeroDefaults = false;
        }

        public object Deserialize(Type type, ReadOnlySpan<byte> source)
            => ProtoBuf.Serializer.NonGeneric.Deserialize(type, source);
            //=> _serializer.Deserialize(type, source);

        public void Serialize(Type type, Stream destination, object instance)
            => ProtoBuf.Serializer.NonGeneric.Serialize(destination, instance);
            //=> _serializer.Serialize(destination, instance);

    }
}

using DotNetty.Buffers;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using TinyFx.Reflection;

namespace TinyFx.Extensions.DotNetty
{
    public class Packet: IPacket
    {
        public int CommandId { get; set; }
        public int BodyLength { get; set; }
        public object Body { get; set; }

        private static ConcurrentDictionary<Type, Type> _bodyTypes = new ConcurrentDictionary<Type, Type>();

        public string GetBodyType()
        {
            var baseType = Body?.GetType();
            var valueType = baseType;
            if (baseType != null)
            {
                if (!_bodyTypes.TryGetValue(baseType, out valueType))
                {
                    if (ReflectionUtil.IsSubclassOfGeneric(baseType, typeof(ProtoResponse<>)))
                        valueType = baseType.GenericTypeArguments[0];
                    _bodyTypes.TryAdd(baseType, valueType);
                }
            }
            return valueType?.FullName;
        }
    }
    public interface IPacket
    {
        int CommandId { get; set; }
        object Body { get; set; }
        int BodyLength { get; set; }
        string GetBodyType();
    }
}

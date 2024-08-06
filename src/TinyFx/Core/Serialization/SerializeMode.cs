using System;
using System.Collections.Generic;
using System.Text;

namespace TinyFx.Serialization
{
    /// <summary>
    /// 序列化方式
    /// </summary>
    public enum SerializeMode
    {
        None,
        Json,
        JsonNet,
        Protobuf,
        Xml
    }
}

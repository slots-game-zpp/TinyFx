using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinyFx.Extensions.DotNetty.NettyInfoCommand
{
    public class ProtoData
    {
        public string PackageName { get; set; }
        public List<MessageData> Messages { get; set; } = new ();
        public string Description { get; set; }
    }
    public class MessageData:IComparable<MessageData>
    {
        /// <summary>
        /// C# 类型
        /// </summary>
        public Type DotNetType { get; set; }
        public bool IsEnum => DotNetType.IsEnum;
        public string Name { get; set; }
        public List<FieldData> Fields { get; set; } = new ();
        public string Description { get; set; }
        public int OrderId { get; set; }

        public int CompareTo(MessageData other)
        {
            return OrderId.CompareTo(other.OrderId);
        }
    }
    public class FieldData : IComparable<FieldData>
    {
        public MessageData Parent { get; set; }
        public Type DotNetType { get; set; }
        public ProtoTypes Type { get; set; } = ProtoTypes.Unknow;

        public string TypeString { get; set; }
        public string Name { get; set; }
        public int Tag { get; set; }
        public string Description { get; set; }

        public int CompareTo(FieldData other)
        {
            return Tag.CompareTo(other.Tag);
        }
    }
    /// <summary>
    /// Proto 3 定义的类型
    /// </summary>
    public enum ProtoTypes
    {
        /// <summary>
        /// 未知
        /// </summary>
        Unknow,

        #region 原始类型
        /// <summary>
        /// double
        /// </summary>
        Double,
        /// <summary>
        /// float
        /// </summary>
        Float,
        /// <summary>
        /// 变长，正数,int
        /// </summary>
        Int32,
        /// <summary>
        /// 变长，正数,long
        /// </summary>
        Int64,
        /// <summary>
        /// 变长，小于2的28次方 uint
        /// </summary>
        UInt32,
        /// <summary>
        /// 变长，小于2的56次方 ulong
        /// </summary>
        UInt64,
        /// <summary>
        /// 变长，负数，int
        /// </summary>
        SInt32,
        /// <summary>
        /// 变长，负数,long
        /// </summary>
        SInt64,
        /// <summary>
        /// 4字节，大于2的28次方 uint
        /// </summary>
        Fixed32,
        /// <summary>
        /// 8字节，大于2的56次方 ulong
        /// </summary>
        Fixed64,
        /// <summary>
        /// 4字节，int
        /// </summary>
        SFixed32,
        /// <summary>
        /// 8字节，long
        /// </summary>
        SFixed64,
        /// <summary>
        /// bool
        /// </summary>
        Bool,
        /// <summary>
        /// string
        /// </summary>
        String,
        /// <summary>
        /// 任意字节 ByteString.CopyFrom(byte[])
        /// </summary>
        Bytes,
        #endregion

        #region 扩展类型
        /// <summary>
        /// SInt64 或者 .google.protobuf.Timestamp
        /// </summary>
        DateTime,
        /// <summary>
        /// 同DateTime
        /// </summary>
        DateTimeOffset,
        /// <summary>
        /// SInt64 或者 .google.protobuf.Duration
        /// </summary>
        TimeSpan,
        /// <summary>
        /// .bcl.Guid 或者 string
        /// </summary>
        Guid,
        /// <summary>
        /// .bcl.Decimal 或者 string
        /// </summary>
        Decimal,
        #endregion

        #region 复杂类型
        /// <summary>
        /// enum
        /// </summary>
        Enum,
        /// <summary>
        /// message
        /// </summary>
        Class,
        /// <summary>
        /// repeated
        /// </summary>
        List,
        /// <summary>
        /// map
        /// </summary>
        Map,
        #endregion
    }
    public enum DataFormat
    {
        Default = 0,
        ZigZag = 1,
        TwosComplement = 2,
        FixedSize = 3,
        Group = 4,
        WellKnown = 5
    }
}

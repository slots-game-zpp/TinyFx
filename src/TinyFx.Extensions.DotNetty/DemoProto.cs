using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
/*
[assembly: CompatibilityLevel(CompatibilityLevel.Level300)]
namespace TinyFx.Extensions.DotNetty
{
    #region Command
    /// <summary>
    /// 测试A-Command
    /// XCSASDF
    /// </summary>
    [Command(2)]
    public class TestCommonCommand : RespondCommand<EmbedProto, DemoProtoAck>
    {
        public override ProtoResponse<DemoProtoAck> Respond(RequestContext ctx, EmbedProto request)
        {
            var ack = new DemoProtoAck();
            return ack;
        }
    }
    [Command(3)]
    public class TestNullCommand : RespondCommand<object, object>
    {
        public override ProtoResponse<object> Respond(RequestContext ctx, object request)
        {
            return null;
        }
    }
    #endregion

    #region Proto
    /// <summary>
    /// 推送数据
    /// </summary>
    [ProtoPush(1)]
    [ProtoContract]
    public class PushProto
    {
        [ProtoMember(1)]
        public int Id { get; set; }
    }

    /// <summary>
    /// DemoProto注释
    /// 所有proto类型映射
    /// </summary>
    [ProtoContract]
    public class DemoProtoAck
    {
        #region 固定类型
        /// <summary>
        /// Byte注释
        /// 多行注释
        /// </summary>
        [ProtoMember(1)]
        public byte Byte { get; set; }
        [ProtoMember(2)]
        public sbyte SByte { get; set; }
        [ProtoMember(3)]
        public short Int16 { get; set; }
        [ProtoMember(4)]
        public ushort UInt16 { get; set; }
        [ProtoMember(5)]
        public int Int32 { get; set; }
        [ProtoMember(6)]
        public uint UInt32 { get; set; }
        [ProtoMember(7)]
        public long Int64 { get; set; }
        [ProtoMember(8)]
        public ulong UInt64 { get; set; }
        [ProtoMember(9)]
        public float Single { get; set; }
        [ProtoMember(10)]
        public double Double { get; set; }
        [ProtoMember(11)]
        public bool Boolean { get; set; }
        [ProtoMember(12)]
        public string String { get; set; }
        [ProtoMember(13)]
        public byte[] Bytes { get; set; }
        [ProtoMember(14)]
        public char Char { get; set; }
        #endregion

        #region 特殊类型
        [ProtoMember(15)]
        public decimal Decimal { get; set; }
        public TimeSpan TimeSpan { get; set; }
        [ProtoMember(16)]
        public long TimeSpanLong
        {
            get { return TimeSpan.Ticks; }
            set { TimeSpan = new TimeSpan(value); }
        }
        public DateTime DateTime { get; set; }
        [ProtoMember(17)]
        public long DateTimeLong
        {
            get { return TinyFxUtil.DateTimeToUnixTime(DateTime); }
            set { DateTime = TinyFxUtil.UnixTimeToDateTime(value); }
        }
        [ProtoMember(18)]
        public Guid Guid { get; set; }
        #endregion
        //
        [ProtoMember(19)]
        public SexEnum Sex { get; set; }
        [ProtoMember(20)]
        public EmbedProto EmbedProto { get; set; }
        [ProtoMember(21)]
        public int[] IntArray { get; set; }
        [ProtoMember(22)]
        public List<string> List { get; set; }
        [ProtoMember(23)]
        public Dictionary<int, string> Dictionary { get; set; }

        [ProtoMember(24)]
        public EmbedProto1 EmbedProto1 { get; set; }
        [ProtoMember(25)]
        public EmbedProto1[] EmbedProto1s { get; set; }
        [ProtoMember(26)]
        public List<EmbedProto1> EmbedProto1List { get; set; }
        [ProtoMember(27)]
        public Dictionary<string, EmbedProto1> EmbedProto1Dict { get; set; }
    }
    /// <summary>
    /// 输入参数
    /// </summary>
    [DataContract]
    public class EmbedProto
    {
        /// <summary>
        /// 用户编码
        /// </summary>
        [DataMember(Order = 1)]
        public int Id { get; set; }
        public DateTime Birthday { get; set; }
    }
    /// <summary>
    /// 内嵌参数
    /// </summary>
    [ProtoContract]
    public class EmbedProto1
    {
        /// <summary>
        /// 用户名称
        /// </summary>
        [ProtoMember(1)]
        public string Name { get; set; }
        public string[] Strings { get; set; }
    }

    /// <summary>
    /// 性别
    /// </summary>
    public enum SexEnum
    {
        /// <summary>
        /// 男性
        /// 多行信息
        /// </summary>
        Man,
        /// <summary>
        /// 女性
        /// </summary>
        Female
    }
    #endregion
}
*/
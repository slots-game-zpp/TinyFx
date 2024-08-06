using Org.BouncyCastle.Asn1.X509;
using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using TinyFx.JavaScript;

namespace TinyFx.Extensions.DotNetty.NettyInfoCommand
{
    #region NettyDemoCmd
    /// <summary>
    /// 有参数的Command Demo
    /// </summary>
    [Command(-3,false)]
    public class NettyDemoCmd : RespondCommand<NettyDemoReq, NettyDemoAck>
    {
        public override async Task<NettyDemoAck> Respond(RequestContext ctx, NettyDemoReq request)
        {
            return await Task.Run(() => {
                var date = DateTimeUtil.ParseTimestamp(request.DateTime);
                Console.WriteLine($"收到DateTime: {date.ToString("yyyy-MM-dd HH:mm:ss")}");
                var dt = DateTime.UtcNow;
                Console.WriteLine($"发送DateTime: {dt.ToString("yyyy-MM-dd HH:mm:ss")}");
                var ack = new NettyDemoAck()
                {
                    Byte = 1,
                    SByte = 2,
                    Int16 = 3,
                    UInt16 = 4,
                    Int32 = 5,
                    UInt32 = 6,
                    Int64 = 7,
                    UInt64 = 8,
                    Single = 9,
                    Double = 10,
                    Boolean = true,
                    String = "字符串",
                    Bytes = BitConverter.GetBytes(13),
                    Char = '字',
                    Decimal = 123.456m,
                    TimeSpan = (int)TimeSpan.FromSeconds(10).TotalMilliseconds,
                    DateTime = dt.ToTimestamp(true),
                    Guid = Guid.NewGuid(),
                    Sex = NettyDemoSexEnum.Female,
                    EmbedProto = new NettyDemoReq
                    {
                        Id = request.Id
                    },
                    IntArray = new int[] { 1, 2 },
                    List = new List<string>() { "aaa", "bbb" },
                    Dictionary = new Dictionary<int, string>() { { 3, "ccc" }, { 4, "ddd" } },
                    EmbedProtos = new NettyDemoReq[] { new NettyDemoReq { Id = 5 }, new NettyDemoReq { Id = 6 } },
                    EmbedProtoList = new List<NettyDemoReq>() { new NettyDemoReq { Id = 7 }, new NettyDemoReq { Id = 8 } },
                    EmbedProtoDict = new Dictionary<string, NettyDemoReq>() { { "eee", new NettyDemoReq { Id = 9 } }, { "ffff", new NettyDemoReq { Id = 10 } } }
                };
                return ack;
            });
        }
    }
    /// <summary>
    /// 输入参数
    /// </summary>
    [DataContract]
    public class NettyDemoReq
    {
        /// <summary>
        /// 用户编码
        /// </summary>
        [DataMember(Order = 1)]
        public int Id { get; set; }
        /// <summary>
        /// 客户端使用Long类型
        /// 服务器转换到TimeSpan: TimeSpan.FromTicks(long)
        /// </summary>
        [DataMember(Order = 2)]
        public long TimeSpan { get; set; }
        /// <summary>
        /// 客户端使用Long类型: DateUtil.getTimestamp(Date)
        /// 服务器转换到DateTime: TinyFxUtil.TimestampToDateTime(long)
        /// </summary>
        [DataMember(Order = 3)]
        public long DateTime { get; set; }
        /// <summary>
        /// 同DateTime
        /// </summary>
        [DataMember(Order = 4)]
        public long DateTimeOffset { get; set; }
    }
    /// <summary>
    /// DemoProto注释
    /// 所有proto类型映射
    /// </summary>
    [ProtoContract]
    public class NettyDemoAck
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
        /// <summary>
        /// 发送到js是number, 通过String.fromCharCode(number)转换
        /// </summary>
        [ProtoMember(14)]
        public char Char { get; set; }
        #endregion

        #region 特殊类型
        [ProtoMember(15)]
        public decimal Decimal { get; set; }
        /// <summary>
        /// 服务器转换: TimeSpan.Ticks
        /// 客户端类型: Long
        /// </summary>
        [ProtoMember(16)]
        public long TimeSpan { get; set; }
        /// <summary>
        /// 服务端转换：TinyFxUtil.DateTimeToTimestamp(DateTime)
        /// 客户端转换: DateUtil.getUTCDate(long)
        /// </summary>
        [ProtoMember(17)]
        public long DateTime { get; set; }
        /// <summary>
        /// 同DateTime
        /// </summary>
        [ProtoMember(18)]
        public long DateTimeOffset { get; set; }
        [ProtoMember(19)]
        public Guid Guid { get; set; }
        #endregion
        //
        [ProtoMember(20)]
        public NettyDemoSexEnum Sex { get; set; }
        [ProtoMember(21)]
        public NettyDemoReq EmbedProto { get; set; }
        [ProtoMember(22)]
        public int[] IntArray { get; set; }
        [ProtoMember(23)]
        public List<string> List { get; set; }
        [ProtoMember(24)]
        public Dictionary<int, string> Dictionary { get; set; }

        [ProtoMember(25)]
        public NettyDemoReq[] EmbedProtos { get; set; }
        [ProtoMember(26)]
        public List<NettyDemoReq> EmbedProtoList { get; set; }
        [ProtoMember(27)]
        public Dictionary<string, NettyDemoReq> EmbedProtoDict { get; set; }
    }

    /// <summary>
    /// 性别
    /// </summary>
    public enum NettyDemoSexEnum
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

    #region NettyDemoNullCmd
    /// <summary>
    /// 有参数的Command Demo
    /// </summary>
    [Command(-4,false)]
    public class NettyDemoNullCmd : RespondCommand<object, object>
    {
        public override async Task<object> Respond(RequestContext ctx, object request)
        {
            // 推送当前用户数据
            await ctx.Session.PushAsync(new NettyDemoPushAck { Id = 10 });
            return null;
        }
    }

    [ProtoPush(-5)]
    [ProtoContract]
    public class NettyDemoPushAck
    {
        [ProtoMember(1)]
        public int Id { get; set; }
    }
    #endregion

}

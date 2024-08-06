using Microsoft.Extensions.Logging;
using Org.BouncyCastle.Asn1.Ocsp;
using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyFx.Configuration;
using TinyFx.Logging;

namespace TinyFx.Extensions.DotNetty.NettyInfoCommand
{
    [Command(-2, false)]
    public class NettyInfoCmd : RespondCommand<NettyInfoReq, NettyInfoAck>
    {
        public override Task<NettyInfoAck> Respond(RequestContext ctx, NettyInfoReq request)
        {
            if (ConfigUtil.Environment.IsDebug)
            {
                return null;
            }
            var ret = new NettyInfoAck();
            var protoData = new ProtoDataBuilder(request).Build();
            ret.ProtosContent = new ProtoT(protoData).TransformText();
            var cmdData = new CommandDataBuilder(request).Build();
            ret.CommandsContent = new CommandT(cmdData).TransformText();
            ret.CommandsDesc = string.Join(Environment.NewLine, DotNettyUtil.Commands.GetCommands().FindAll(item => !item.IsPush).Select(
                    item => $"{item.CommandId.ToString().PadRight(6)} = {item.CommandType.Name}"));
            return Task.FromResult(ret);
        }
    }
    [ProtoContract]
    public class NettyInfoReq
    {
        [ProtoMember(1)]
        public string Package { get; set; }
        [ProtoMember(2)]
        public bool HasDemo { get; set; }
    }
    [ProtoContract]
    public class NettyInfoAck
    {
        [ProtoMember(1)]
        public string ProtosContent { get; set; }
        [ProtoMember(2)]
        public string CommandsContent { get; set; }
        [ProtoMember(3)]
        public string CommandsDesc { get; set; }
    }
}

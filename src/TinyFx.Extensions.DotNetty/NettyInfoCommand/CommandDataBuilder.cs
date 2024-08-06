using Microsoft.Extensions.Options;
using Org.BouncyCastle.Asn1.BC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using TinyFx.Xml;

namespace TinyFx.Extensions.DotNetty.NettyInfoCommand
{
    internal class CommandDataBuilder
    {
        private XmlDocumentParser _xmlParser;
        private NettyInfoReq _request;

        public CommandDataBuilder(NettyInfoReq request)
        {
            _xmlParser = DotNettyUtil.XmlParser;
            _request = request;
        }
        public CommandData Build()
        {
            var ret = new CommandData();
            ret.Package = _request.Package;
            ret.Description = "";
            foreach (var cmd in DotNettyUtil.Commands.GetCommands())
            {
                if (!_request.HasDemo && cmd.CommandId < 0)
                    continue;
                if (cmd.CommandId == -1 || cmd.CommandId == -2)
                    continue;
                var item = new CommandItem
                {
                    CommandType = cmd.CommandType,
                    CommandId = cmd.CommandId,
                    CommandName = cmd.CommandType.Name,
                    CommandNameVar = StringUtil.CamelCase(cmd.CommandType.Name),
                    CommandDescription = _xmlParser.GetSummary(cmd.CommandType),
                    RequestName = cmd.IsPush ? null : GetRequestName(cmd.RequestType),
                    RequestDescription = cmd.IsPush ? null : _xmlParser.GetSummary(cmd.RequestType),
                    ResponseName = GetResponseName(cmd.ResponseType),
                    ResponseDescription = _xmlParser.GetSummary(cmd.ResponseType)
                };
                if (cmd.IsPush)
                    ret.PushCommands.Add(item);
                else
                    ret.RpcCommands.Add(item);
            }
            return ret;
        }
        private string GetRequestName(Type type)
        {
            if (type == typeof(object))
                return "object";
            return type.Name;
        }
        private string GetResponseName(Type type)
        {
            if (type == typeof(object))
                return "ProtoResponse";
            return $"{type.Name}Rsp";
        }
    }
}

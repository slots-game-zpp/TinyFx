using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinyFx.Extensions.DotNetty.NettyInfoCommand
{
    public class CommandData
    {
        public string Package { get; set; }
        public List<CommandItem> RpcCommands { get; set; } = new();
        public List<CommandItem> PushCommands { get; set; } = new();
        public string Description { get; set; }
    }
    public class CommandItem
    {
        public Type CommandType { get; set; }
        public int CommandId { get; set; }
        public string CommandName { get; set; }
        public string CommandNameVar { get; set; }
        public string CommandDescription { get; set; }
        public string RequestName { get; set; }
        public string RequestDescription { get; set; }
        public string ResponseName { get; set; }
        public string ResponseDescription { get; set; }
    }
}

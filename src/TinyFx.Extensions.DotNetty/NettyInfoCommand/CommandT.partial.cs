using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TinyFx.Extensions.DotNetty.NettyInfoCommand
{
    public partial class CommandT
    {
        public string AssemblyName { get; set; }
        public string Version { get; set; }
        public CommandData Data { get; set; }
        public CommandT(CommandData data)
        {
            var assm = Assembly.GetExecutingAssembly();
            AssemblyName = assm.GetName().Name;
            Version = assm.GetCustomAttribute<AssemblyInformationalVersionAttribute>()
                .InformationalVersion.ToString();
            Data = data;
        }
        public string GetCommandDescription(CommandItem cmd)
        {
            /*
            var ret = hasId ? $" * 【CommandId = {cmd.CommandId}】{Environment.NewLine}" : string.Empty;
            if (!string.IsNullOrEmpty(cmd.CommandDescription))
            {
                foreach (var line in StringUtil.SplitNewLine(cmd.CommandDescription))
                {
                    ret += $" * {line.Trim()}{Environment.NewLine}";
                }
            }
            return ret.TrimEnd(Environment.NewLine);
            */
            var lines = cmd.CommandDescription?.SplitNewLine().Select(item => $" * {item.Trim()}")?.ToList();
            if (lines == null || lines.Count == 0)
                return String.Empty;
            var ret = string.Join(Environment.NewLine, lines);
            if (!string.IsNullOrEmpty(ret))
            {
                ret = $"/**{Environment.NewLine}{ret}{Environment.NewLine} */";
            }
            return ret;
        }

    }
}

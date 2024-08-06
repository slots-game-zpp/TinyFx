using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TinyFx.Extensions.DotNetty.NettyInfoCommand
{
    public partial class ProtoT
    {
        public string AssemblyName { get; set; }
        public string Version { get; set; }
        public ProtoData Data { get; set; }
        public ProtoT(ProtoData data)
        {
            var assm = Assembly.GetExecutingAssembly();
            AssemblyName = assm.GetName().Name;
            Version = assm.GetCustomAttribute<AssemblyInformationalVersionAttribute>()
                .InformationalVersion.ToString();
            data.PackageName = null;
            Data = data;
        }
        public string GetMessageDescription(MessageData msg)
        {
            var ret = string.Empty;
            var desc = msg.Description;
            if (!string.IsNullOrEmpty(desc))
            {
                foreach (var line in StringUtil.SplitNewLine(desc))
                {
                    ret += $" * {line.Trim()}{Environment.NewLine}";
                }
            }
            else
                ret = $" * {msg.DotNetType.Name} " + (msg.IsEnum ? "枚举" : "类");
            return ret.TrimEnd(Environment.NewLine);
        }
        public string GetFieldDescription(FieldData field)
        {
            var ret = string.Empty;
            if (!string.IsNullOrEmpty(field.Description))
            {
                foreach (var line in StringUtil.SplitNewLine(field.Description))
                {
                    ret += $"{line.Trim().TrimEnd(',', '，', '。', '.')}。";
                }
                ret = $"/// {ret}";
                var len = $"\t{field.TypeString} {field.Name} = {field.Tag}; ".Length;
                if (len < 4 * 8)
                    ret = ret.PadLeft((4 * 8 - len) + ret.Length);
                else if (len < 4 * 14)
                    ret = ret.PadLeft((4 * 14 - len) + ret.Length);
            }
            return ret;
        }
        public string GetEnumItemDescription(FieldData field)
        {
            var ret = string.Empty;
            var desc = field.Description;
            if (!string.IsNullOrEmpty(desc))
            {
                foreach (var line in StringUtil.SplitNewLine(desc))
                {
                    ret += $"{line.Trim().TrimEnd(',', '，', '。', '.')}。";
                }
                ret = $"/** {ret} */";
            }
            return ret;
        }
    }

}

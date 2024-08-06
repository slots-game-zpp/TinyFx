using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinyFx.Extensions.CommandLineParser
{
    internal static class OptionsUtil
    {
        public const string SECTION_NAME = "options";
        public static CmdLineOptions Options = new CmdLineOptions();
        public static void ParseOptions(CmdLineConfig config)
        {
            if (CmdLineUtil.ConfigFile.ExistsConfigFile && CmdLineUtil.ConfigFile.TryGetSection(SECTION_NAME, out CmdLineOptions opts))
            {
                Options = opts;
                config.LogLevel = Options.LogLevel;
                if (!string.IsNullOrEmpty(Options.DefaultArgs))
                    config.DefaultArgs = Options.DefaultArgs;
            }
            else
            {
                Options = new CmdLineOptions();
                Options.LogLevel = config.LogLevel;
                Options.DefaultArgs = config.DefaultArgs;
            }
        }
    }
}

using Com.Ctrip.Framework.Apollo.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinyFx.Configuration
{
    public class ApolloSection
    {
        public static readonly string SectionName = "Apollo";
        public bool Enabled { get; set; }
        public LogLevel LogLevel { get; set; }
        public string AppId { get; set; }
        public string MetaServer { get; set; }
        public List<string> ConfigServer { get; set; }
        public List<string> Namespaces { get; set; }
    }

}

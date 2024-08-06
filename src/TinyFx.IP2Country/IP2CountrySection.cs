using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyFx.Configuration;

namespace TinyFx.IP2Country
{
    public class IP2CountrySection : ConfigSection
    {
        public override string SectionName => "IP2Country";
        public bool Enabled { get; set; }
        public string DbIpSource { get; set; }
        public string AllowIps { get; set; }
        public HashSet<string> AllowIpDict = new();
        public override void Bind(IConfiguration configuration)
        {
            base.Bind(configuration);
            var ips = AllowIps?.Split(',','|');
            if (ips != null)
            {
                foreach (var ip in ips)
                {
                    if(!AllowIpDict.Contains(ip))
                        AllowIpDict.Add(ip);
                }
            }
        }
    }
}

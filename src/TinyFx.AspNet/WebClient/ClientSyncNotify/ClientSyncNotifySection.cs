using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyFx.Configuration;

namespace TinyFx.AspNet
{
    public class ClientSyncNotifySection : ConfigSection
    {
        public override string SectionName => "ClientSyncNotify";
        public bool Enabled { get; set; }
        public string HeaderName { get; set; }
        public string NotifyProvider { get; set; }
        public override void Bind(IConfiguration configuration)
        {
            base.Bind(configuration);
        }
    }
}

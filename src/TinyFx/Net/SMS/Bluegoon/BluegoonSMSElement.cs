using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyFx.Configuration;

namespace TinyFx.Net.SMS.Bluegoon
{
    internal class BluegoonSMSElement : SMSClientElement
    {
        public override SMSProvider Provider => SMSProvider.Bluegoon;
        public string CompanyCode { get; set; }
        public string MD5Key { get; set; }
    }
}

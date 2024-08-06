using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyFx.Configuration;
using TinyFx.Net.SMS;
using TinyFx.Net.SMS.Bluegoon;
using TinyFx.Net.SMS.Tencent;

namespace TinyFx.Net
{
    public static class SMSUtil
    {
        public static ISMSProvider Create(string name = null)
        {
            var section = ConfigUtil.GetSection<SMSSection>();
            if (!section.Clients.TryGetValue(name ?? section.DefaultClientName, out var element))
                return null;
            /*
            switch (element.Provider)
            {
                case SMSProvider.Tencent:
                    return new TencentSMSProvider(element as TencentSMSElement);
                case SMSProvider.Bluegoon:
                    return new BluegoonSMSProvider(element as BluegoonSMSElement);
            }
            */
            return null;
        }
    }
}

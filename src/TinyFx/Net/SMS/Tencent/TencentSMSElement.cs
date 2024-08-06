using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyFx.Configuration;

namespace TinyFx.Net.SMS.Tencent
{
    public class TencentSMSElement : SMSClientElement
    {
        public override SMSProvider Provider => SMSProvider.Tencent;
        /// <summary>
        /// 腾讯 AppId
        /// </summary>
        public string AppId { get; set; } = "";

        /// <summary>
        /// 腾讯 AppKey
        /// </summary>
        public string AppKey { get; set; } = "";

        /// <summary>
        /// 腾讯 模板 ID
        /// </summary>
        public int TplId { get; set; }

        /// <summary>
        /// 腾讯 应用签名
        /// </summary>
        public string Sign { get; set; } = "";

    }

}

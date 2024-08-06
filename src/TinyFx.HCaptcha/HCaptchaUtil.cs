using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyFx.AspNet;

namespace TinyFx.HCaptcha
{
    public static class HCaptchaUtil
    {
        /// <summary>
        /// 验证HCaptcha返回的token
        /// </summary>
        /// <param name="token"></param>
        /// <param name="remoteIp"></param>
        /// <returns></returns>
        public static async Task<ApiResult<HCaptchaVerifyRsp>> Verify(string token, string remoteIp = null)
        {
            return await DIUtil.GetRequiredService<IHCaptchaService>().Verify(token,remoteIp);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyFx.Configuration;
using TinyFx.Net;
using TinyFx.OAuth.Providers;

namespace TinyFx.OAuth
{
    public static class OAuthUtil
    {
        /// <summary>
        /// 获取验证url
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="redirectUri"></param>
        /// <param name="uuid"></param>
        /// <returns></returns>
        public static Task<string> GetOAuthUrl(OAuthProviders provider, string redirectUri, string uuid = null)
        {
            return DIUtil.GetRequiredService<OAuthService>().GetOAuthUrl(provider, redirectUri, uuid);
        }

        /// <summary>
        /// 第三方登录回调后获取用户信息
        /// </summary>
        /// <param name="ipo"></param>
        /// <returns></returns>
        public static Task<ResponseResult<OAuthUserDto>> GetUserInfo(OAuthUserIpo ipo)
        {
            return DIUtil.GetRequiredService<OAuthService>().GetUserInfo(ipo);
        }
    }
}

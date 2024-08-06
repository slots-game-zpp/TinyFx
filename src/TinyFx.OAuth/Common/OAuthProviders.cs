using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinyFx.OAuth
{
    /// <summary>
    /// 三方枚举类型
    /// </summary>
    public enum OAuthProviders
    {
        /// <summary>
        ///  Facebook = 1,
        /// </summary>
        [Description("Facebook")]
        Facebook = 1,
        /// <summary>
        ///   Google = 2
        /// </summary>
        [Description("Google")]
        Google = 2,
        ///// <summary>
        /////  Twitter = 3,
        ///// </summary>
        //[Description("Twitter")]
        //Twitter = 3,
    }
}

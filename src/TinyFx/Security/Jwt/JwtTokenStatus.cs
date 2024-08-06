using System;
using System.Collections.Generic;
using System.Text;

namespace TinyFx.Security
{
    public enum JwtTokenStatus
    {
        /// <summary>
        /// 有效
        /// </summary>
        Success,
        /// <summary>
        /// 无效
        /// </summary>
        Invalid,
        /// <summary>
        /// 过期
        /// </summary>
        Expired,
    }
}

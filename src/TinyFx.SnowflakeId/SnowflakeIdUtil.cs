using Microsoft.Extensions.Options;
using Org.BouncyCastle.Crypto.Engines;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyFx.Configuration;
using TinyFx.SnowflakeId.Common;
using TinyFx.Extensions.StackExchangeRedis;
using TinyFx.Net;
using TinyFx.Logging;

namespace TinyFx.SnowflakeId
{
    public static class SnowflakeIdUtil
    {
        /// <summary>
        /// 生成雪花算法ID
        /// </summary>
        /// <returns></returns>
        public static long NextId()
        {
            return DIUtil.GetRequiredService<ISnowflakeIdService>().NextId();
        }
    }
}

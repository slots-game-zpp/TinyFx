using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinyFx.AspNet.ResponseCaching
{
    /// <summary>
    /// 使用配置文件配置的缓存策略
    /// </summary>
    public class ResponseCacheEx : ResponseCacheAttribute
    {
        public ResponseCacheEx(string profileName)
        {
            CacheProfileName = profileName;
        }
    }
}

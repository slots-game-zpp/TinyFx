using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinyFx.AspNet.ResponseCaching
{
    /// <summary>
    /// 客户端和服务器同时缓存
    /// Cache-Control : public, max-age=60
    /// </summary>
    public class ResponseCacheAny : ResponseCacheAttribute
    {
        public ResponseCacheAny(int duration)
        {
            Duration = duration;
            Location = ResponseCacheLocation.Any;
            VaryByHeader = "User-Agent";
        }
    }
}

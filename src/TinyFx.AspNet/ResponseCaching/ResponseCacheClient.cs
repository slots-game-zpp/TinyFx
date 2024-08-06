using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinyFx.AspNet.ResponseCaching
{
    /// <summary>
    /// 仅客户端缓存
    /// Cache-Control: private, max-age=600
    /// </summary>
    public class ResponseCacheClient: ResponseCacheAttribute
    {
        public ResponseCacheClient(int duration) 
        {
            Duration = duration;
            Location = ResponseCacheLocation.Client;
            VaryByHeader = "User-Agent";
        }
    }
}

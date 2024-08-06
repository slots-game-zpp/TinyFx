using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinyFx.AspNet.ResponseCaching
{
    /// <summary>
    /// 不缓存
    /// </summary>
    public class ResponseCacheNone: ResponseCacheAttribute
    {
        public ResponseCacheNone(int duration)
        {
            Duration = duration;
            Location = ResponseCacheLocation.None;
            NoStore = true;
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinyFx.AspNet.ResponseCaching
{
    public class ResponseCacheKeys : ResponseCacheAttribute
    {
        public ResponseCacheKeys(int duration, params string[] keys)
        {
            Duration = duration;
            Location = ResponseCacheLocation.Any;
            VaryByQueryKeys = keys ?? new string[] { "*" };
        }
    }
}

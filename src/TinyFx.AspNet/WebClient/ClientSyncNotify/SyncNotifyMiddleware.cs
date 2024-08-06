using Microsoft.AspNetCore.Http;
using Microsoft.Net.Http.Headers;
using Polly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyFx.Configuration;
using TinyFx.Logging;

namespace TinyFx.AspNet
{
    public class SyncNotifyMiddleware
    {
        private readonly RequestDelegate _next;
        public const string DEFAULT_HEADER_NAME = "tfxc-sync";
        private IClientSyncNotifyProvider _provider;
        public string _headerName;
        private bool _enabled;
        public SyncNotifyMiddleware(RequestDelegate next)
        {
            _next = next;
            _provider = DIUtil.GetService<IClientSyncNotifyProvider>();
            var section = ConfigUtil.GetSection<ClientSyncNotifySection>();
            _headerName = section.HeaderName ?? DEFAULT_HEADER_NAME;
            _enabled = section.Enabled && _provider != null;
        }
        public async Task Invoke(HttpContext context)
        {
            if (_enabled)
            {
                var userId = context?.User?.Identity?.Name;
                if (!string.IsNullOrEmpty(userId))
                {
                    var value = await _provider.GetNotifyValue(userId);
                    if (!string.IsNullOrEmpty(value))
                    {
                        context?.Response?.Headers?.Add("Access-Control-Expose-Headers", _headerName);
                        context?.Response?.Headers?.Add(_headerName, value);
                    }
                }
            }
            await _next(context); // 继续执行
        }
    }
}

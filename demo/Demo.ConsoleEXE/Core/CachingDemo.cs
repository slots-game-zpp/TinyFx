using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyFx.Caching;
using TinyFx.Configuration;

namespace TinyFx.Demos.Core
{
    internal class CachingDemo : DemoBase
    {
        public override async Task Execute()
        {
            // 生成ticket(可用于注册或登录时email和sms使用的验证码)
            // 生成时ticket保存到IDistributedCache中
            // 如果没有配置，保存到CachingUtil.MemoryCache
            var key = "jh98net@sina.com";
            var ticket = TicketCacheUtil.GenerateTicket(key, 5, CharsScope.Numbers);
            Console.WriteLine(ticket);
            var success = TicketCacheUtil.ValidateTicket(key, ticket);
            Console.WriteLine(success);
        }
    }
}

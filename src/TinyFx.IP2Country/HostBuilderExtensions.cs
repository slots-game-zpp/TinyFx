using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyFx.Configuration;
using TinyFx.IP2Country;
using TinyFx.Logging;

namespace TinyFx
{
    public static class IP2CountryHostBuilderExtensions
    {
        public static IHostBuilder AddIP2CountryEx(this IHostBuilder builder)
        {
            var section = ConfigUtil.GetSection<IP2CountrySection>();
            if (section == null || !section.Enabled)
                return builder;

            var watch = new Stopwatch();
            watch.Start();
            builder.ConfigureServices(services => 
            {
                var service = new IP2CountryService();
                service.Init();
                services.AddSingleton<IIP2CountryService>(service);
            });

            watch.Stop();
            LogUtil.Info("配置 => [IP2Country] [{ElapsedMilliseconds} 毫秒]", watch.ElapsedMilliseconds);
            return builder;
        }
    }
}

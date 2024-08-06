using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyFx.Configuration;
using TinyFx.HCaptcha;
using TinyFx.Logging;

namespace TinyFx
{
    public static class HCaptchaHostBuilderExtensions
    {
        public static IHostBuilder AddHCaptchaEx(this IHostBuilder builder)
        {
            var section = ConfigUtil.GetSection<HCaptchaSection>();
            if (section == null || !section.Enabled) 
                return builder;

            var watch = new Stopwatch();
            watch.Start();
            builder.ConfigureServices(services =>
            {
                services.AddSingleton<IHCaptchaService>(new HCaptchaService());
            });

            watch.Stop();
            LogUtil.Info("配置 => [HCaptcha] [{ElapsedMilliseconds} 毫秒]", watch.ElapsedMilliseconds);
            return builder;
        }
    }
}

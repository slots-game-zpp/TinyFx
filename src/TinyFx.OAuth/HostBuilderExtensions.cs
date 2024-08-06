using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Diagnostics;
using TinyFx.Configuration;
using TinyFx.Logging;
using TinyFx.OAuth;

namespace TinyFx
{
    public static class OAuthHostBuilderExtensions
    {
        public static IHostBuilder AddOAuthEx(this IHostBuilder builder)
        {
            var section = ConfigUtil.GetSection<OAuthSection>();
            if (section == null || !section.Enabled) 
                return builder;

            var watch = new Stopwatch();
            watch.Start();
            builder.ConfigureServices((context, services) =>
            {
                services.AddSingleton<OAuthService>();
            });

            watch.Stop();
            LogUtil.Info("配置 => [OAuth] [{ElapsedMilliseconds} 毫秒]", watch.ElapsedMilliseconds);
            return builder;
        }
    }
}

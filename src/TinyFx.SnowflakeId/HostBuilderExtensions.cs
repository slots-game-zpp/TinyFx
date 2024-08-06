using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyFx.Configuration;
using TinyFx.Hosting;
using TinyFx.SnowflakeId.Common;
using TinyFx.Logging;
using TinyFx.SnowflakeId;
using System.Diagnostics;

namespace TinyFx
{
    public static class SnowflakeIdHostBuilderExtensions
    {
        public static IHostBuilder AddSnowflakeIdEx(this IHostBuilder builder)
        {
            var section = ConfigUtil.GetSection<SnowflakeIdSection>();
            if (section == null || !section.Enabled)
                return builder;

            var watch = new Stopwatch();
            watch.Start();
            if (section.UseRedis)
            {
                var redisSecion = ConfigUtil.GetSection<RedisSection>();
                if (redisSecion == null)
                    throw new Exception("启动SnowflakeId必须启用Redis");
                if (string.IsNullOrEmpty(section.RedisConnectionStringName))
                    section.RedisConnectionStringName = redisSecion.DefaultConnectionStringName;
                if (!redisSecion.ConnectionStrings.ContainsKey(section.RedisConnectionStringName))
                    throw new Exception($"启动SnowflakeId时不存在redisConnectionName: {section.RedisConnectionStringName}");
            }
            builder.ConfigureServices(services =>
            {
                var service = new SnowflakeIdService();
                services.AddSingleton<ISnowflakeIdService>(service);
                HostingUtil.RegisterStarting(async () =>
                {
                    await service.Init();
                    LogUtil.Info("启动 => 雪花ID服务[SnowflakeId]");
                });
                HostingUtil.RegisterStopping(async () =>
                {
                    await service.Dispose();
                    LogUtil.Info("停止 => 雪花ID服务[SnowflakeId]");
                });
                if (section.UseRedis)
                {
                    HostingUtil.RegisterTimer(new Hosting.Services.TinyFxHostTimerItem
                    {
                        ExecuteCount = 0,
                        Id = "SnowflakeId.Heartbeat",
                        Title = "SnowflakeId心跳",
                        Interval = section.RedisExpireMinutes * 60 * 1000 / 3,
                        TryCount = 5,
                        Callback = async (_) => await service.Active()
                    });
                }
            });

            watch.Stop();
            LogUtil.Info("配置 => [SnowflakeId] [{ElapsedMilliseconds} 毫秒]", watch.ElapsedMilliseconds);
            return builder;
        }
    }
}

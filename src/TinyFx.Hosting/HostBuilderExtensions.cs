using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Polly;
using Polly.Extensions.Http;
using Polly.Timeout;
using Serilog;
using System;
using System.Net.Http;
using System.Text;
using System.Threading;
using TinyFx.Configuration;
using TinyFx.Extensions.Nacos;
using TinyFx.Extensions.Serilog;
using TinyFx.Hosting;
using TinyFx.Hosting.Common;
using TinyFx.Hosting.Services;
using TinyFx.Logging;
using TinyFx.Net;
using TinyFx.Reflection;

namespace TinyFx
{
    public static class TinyFxHostBuilderExtensions
    {
        /// <summary>
        /// 应用程序中配置TinyFx，优先使用应用程序的配置文件，其次使用tinyfx.json
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="envString"></param>
        /// <returns></returns>
        public static IHostBuilder AddTinyFxEx(this IHostBuilder builder, string envString = null)
        {
            if (builder == null)
                throw new ArgumentNullException(nameof(builder));

            // 注册中文字符编码
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            // Logger
            if (Serilog.Log.Logger == null)
                SerilogUtil.CreateBootstrapLogger();
            builder.ConfigureLogging(logger => logger.ClearProviders());
            builder.ConfigureServices((context, services) =>
            {
                // DI
                DIUtil.InitServices(services);
                services.AddSingleton<IAssemblyContainer>(new AssemblyContainer());
                services.AddOptions();
                services.AddSingleton(new LoggerFactory().AddSerilog(Log.Logger)); // ILoggerFactory
                services.AddScoped<ILogBuilder>((sp) => // ILogBuilder
                {
                    var ret = new LogBuilder("TINYFX_CONTEXT");
                    ret.IsContext = true;
                    return ret;
                });
                services.AddHttpClient();

                // DistributedMemoryCache
                services.AddDistributedMemoryCache();
            });

            // Configuration
            var fileConfig = ConfigUtil.BuildConfiguration(envString);
            var configHelper = new ConfigSourceBuilder(builder, fileConfig);
            var configuration = configHelper.Build();
            ConfigUtil.InitConfiguration(configuration);
            builder.ConfigureAppConfiguration((context, builder) =>
            {
                context.Configuration = ConfigUtil.Configuration;
            });

            // ThreadPool
            if (ConfigUtil.Project.MinThreads > 0)
                ThreadPool.SetMinThreads(ConfigUtil.Project.MinThreads, ConfigUtil.Project.MinThreads);

            // Hosting
            builder.ConfigureServices((context, services) =>
            {
                var hostSection = ConfigUtil.GetSection<HostSection>();
                if (hostSection != null && hostSection.ShutdownTimeout > 0)
                {
                    services.Configure<HostOptions>(opts =>
                    {
                        opts.ShutdownTimeout = TimeSpan.FromSeconds(hostSection.ShutdownTimeout);
                    });
                }

                services.AddSingleton<ITinyFxHostLifetimeService>(HostingUtil.LifetimeService);
                services.AddSingleton<ITinyFxHostTimerService>(HostingUtil.TimerService);
                services.AddSingleton<ITinyFxHostRegisterService>(HostingUtil.RegisterService);

                if (hostSection != null && hostSection.RegisterEnabled)
                {
                    HostingUtil.RegisterService.AddProvider(new RedisHostRegisterProvider());
                    services.AddSingleton<ITinyFxHostDataService>(new RedisHostDataService());
                    if (configHelper.From == ConfigSourceFrom.File)
                        services.AddSingleton<ITinyFxHostMicroService>(new RedisHostMicroService());
                }
                if (configHelper.From == ConfigSourceFrom.Nacos)
                    services.AddSingleton<ITinyFxHostMicroService>(new NacosHostMicroService());
                services.AddHostedService<TinyFxHostedService>();
            });

            // HttpClient
            builder.ConfigureServices(services =>
            {
                var clientSection = ConfigUtil.GetSection<JsonHttpClientSection>();
                if (clientSection == null || clientSection.Clients.Count == 0)
                    return;
                foreach (var client in clientSection.Clients)
                {
                    var builder = services.AddHttpClient(client.Key, c =>
                    {
                        if (!string.IsNullOrEmpty(client.Value.BaseAddress))
                            c.BaseAddress = new Uri(client.Value.BaseAddress);
                        if (client.Value.RequestHeaders.Count > 0)
                        {
                            foreach (var header in client.Value.RequestHeaders)
                            {
                                c.DefaultRequestHeaders.Add(header.Key, header.Value);
                            }
                        }
                        if (client.Value.Timeout > 0)
                            c.Timeout = TimeSpan.FromSeconds(client.Value.Timeout);
                    }).SetHandlerLifetime(TimeSpan.FromMinutes(5));

                    if (client.Value.Retry > 0)
                    {
                        builder.AddPolicyHandler(HttpPolicyExtensions
                            .HandleTransientHttpError()
                            .Or<TimeoutRejectedException>() // 若超时则抛出此异常
                            .WaitAndRetryAsync(client.Value.Retry, retryAttempt => TimeSpan.FromSeconds(Math.Pow(2, retryAttempt))));
                        builder.AddPolicyHandler(Policy.TimeoutAsync<HttpResponseMessage>(10));

                    }
                }
            });

            LogUtil.Info("配置 => [TinyFx]");
            return builder;
        }
    }
}

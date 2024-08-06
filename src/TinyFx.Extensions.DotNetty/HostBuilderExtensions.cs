using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ProtoBuf;
using ProtoBuf.Meta;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Security.Principal;
using System.Text;
using TinyFx.Configuration;
using TinyFx.Extensions.DotNetty;
using TinyFx.Logging;
using TinyFx.Reflection;
using static System.Collections.Specialized.BitVector32;

[module: CompatibilityLevel(CompatibilityLevel.Level300)]
namespace TinyFx
{
    public static class DotNettyHostBuilderExtensions
    {
        public static IHostBuilder UseDotNettyWebSocket(this IHostBuilder builder, IServerEventListener eventListener = null)
        {
            // Options
            var section = ConfigUtil.GetSection<DotNettySection>();
            if (section == null)
                throw new Exception("启动UseDotNettyWebSocket服务时，配置文件不存在DotNetty配置节。");
            if (section == null)
                throw new Exception("启动UseDotNettyWebSocket服务时，配置文件不存在DotNetty:Server配置节。");
            var options = section;
            // Consul
            /*
            ConsulClientEx consulClient = null;
            if (consulSection == null)
                consulSection = ConfigUtil.GetSection<ConsulSection>();
            if (consulSection != null)
                consulClient = new ConsulClientEx(consulSection);
            */
            builder.ConfigureServices((ctx, services) =>
            {
                /*
                if(consulClient!= null)
                    services.AddSingleton(consulClient);
                */
                services.AddSingleton(options);
                services.AddSingleton(AppSessionContainer.Instance);
                services.AddSingleton(GetCommandContainer(options));
                services.AddSingleton<IBodySerializer, ProtobufNetSerializer>();

                var packetSerializer = new PacketSerializer(options.IsLittleEndian);
                services.AddSingleton<IPacketSerializer>(packetSerializer);

                if (eventListener != null)
                    services.AddSingleton(eventListener);
                services.AddSingleton(new DefaultServerEventListener());
                services.AddHostedService<WebSocketHostedService>();
            });
            LogUtil.Debug($"配置 => [DotNetty]");
            return builder;
        }
        private static CommandContainer GetCommandContainer(DotNettySection options)
        {
            var asms = DIUtil.GetService<IAssemblyContainer>().GetAssemblies(options?.Assemblies
                , options?.AutoLoad, "配置文件中DotNetty:Server:Assemblies 中配置项不存在。");
            var asmNetty = Assembly.GetExecutingAssembly();
            if (!asms.Contains(asmNetty))
                asms.Add(asmNetty);
            CommandContainer.Instance.AddCommands(asms);
            return CommandContainer.Instance;
        }
    }
}

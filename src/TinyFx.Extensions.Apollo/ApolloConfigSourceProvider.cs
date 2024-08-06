using Com.Ctrip.Framework.Apollo.Logging;
using Com.Ctrip.Framework.Apollo;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyFx.Configuration;
using TinyFx.Configuration.Common;
using Microsoft.Extensions.Hosting;

namespace TinyFx.Extensions.Apollo
{
    public class ApolloConfigSourceProvider : BaseConfigSourceProvider
    {
        public ApolloConfigSourceProvider(IConfiguration config) : base(config)
        {
        }

        public override IConfigurationBuilder CreateBuilder(IHostBuilder hostBuilder)
        {
            IConfigurationBuilder ret = null;
            var hasApollo = InitConfiguration.GetValue("Apollo:Enabled", false);
            if (hasApollo)
            {
                var apollo = InitConfiguration.GetSection("Apollo").Get<ApolloSection>();
                if (string.IsNullOrEmpty(apollo.AppId))
                    apollo.AppId = InitConfiguration.GetValue<string>("Project:ProjectId");
                if (string.IsNullOrEmpty(apollo.AppId))
                    throw new Exception("Apollo配置必须配置AppId");
                if (string.IsNullOrEmpty(apollo.MetaServer))
                    throw new Exception("Apollo配置必须配置MetaServer");
                if (apollo.Namespaces == null || apollo.Namespaces.Count == 0)
                    throw new Exception("Apollo配置必须配置Namespaces");
                LogManager.UseConsoleLogging(apollo.LogLevel);
                ret = new ConfigurationBuilder();
                ret.AddApollo(new ApolloOptions
                {
                    AppId = apollo.AppId,
                    MetaServer = apollo.MetaServer,
                    ConfigServer = apollo.ConfigServer,
                    Namespaces = apollo.Namespaces,
                    CacheFileProvider = new ApolloCacheMyProvider()
                });
                ret.AddEnvironmentVariables();
            }
            return ret;
        }
    }
}

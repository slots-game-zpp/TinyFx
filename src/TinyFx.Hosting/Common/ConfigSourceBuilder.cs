using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyFx.Configuration;
using TinyFx.Extensions.Nacos;
using TinyFx.Logging;

namespace TinyFx.Hosting.Common
{
    internal class ConfigSourceBuilder
    {
        public ConfigSourceFrom From { get; private set; } = ConfigSourceFrom.File;
        private IHostBuilder _builder { get; }
        private IConfiguration _fileConfig { get; }
        public ConfigSourceBuilder(IHostBuilder builder, IConfiguration config)
        {
            _builder = builder;
            _fileConfig = config;
        }

        public IConfiguration Build()
        {
            LogUtil.Info($"配置管理 [加载配置文件] {string.Join('|', ConfigUtil.Environment.ConfigFiles.Select(x => Path.GetFileName(x)))}");

            // nacos
            var ret = new NacosConfigBuilder().Build(_fileConfig, _builder);
            if (ret != null)
            {
                From = ConfigSourceFrom.Nacos;
                return ret;
            }
            //

            // file
            ret = new FileConfigBuilder().Build(_fileConfig, _builder);
            return ret;
        }
    }
    internal enum ConfigSourceFrom
    {
        File,
        Nacos
    }
}

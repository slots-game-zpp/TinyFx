using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinyFx.Configuration
{
    /// <summary>
    /// 外部配置源提供者
    /// </summary>
    public interface IExternalConfigBuilder
    {
        IConfiguration Build(IConfiguration fileConfig, IHostBuilder hostBuilder);
    }
}

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyFx.Logging;

namespace TinyFx
{
    public static class TinyFxHostExtensions
    {
        public static IHost UseTinyFx(this IHost host, Func<IServiceProvider, IServiceProvider> func = null)
        {
            DIUtil.InitServiceProvider(host.Services, func);
            LogUtil.Init();
            return host;
        }
    }
}

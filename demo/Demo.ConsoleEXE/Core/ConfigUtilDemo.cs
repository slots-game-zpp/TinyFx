using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyFx.Configuration;

namespace TinyFx.Demos.Core
{
    internal class ConfigUtilDemo : DemoBase
    {
        public override async Task Execute()
        {
            // 读取配置文件appsettings.json
            Console.WriteLine(ConfigUtil.Project.ProjectId);
            Console.WriteLine(ConfigUtil.AppSettings.Get("myKey"));
        }
    }
}

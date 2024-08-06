using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;
using TinyFx.Configuration;

namespace TinyFx.Configuration
{
    /// <summary>
    /// 日志Section
    /// </summary>
    public class LoggingSection : ConfigSection
    {
        /// <summary>
        /// SectionName
        /// </summary>
        public override string SectionName => "Logging";
        /// <summary>
        /// 绑定
        /// </summary>
        /// <param name="configuration"></param>
        public override void Bind(IConfiguration configuration)
        {
            base.Bind(configuration);
        }
    }
}

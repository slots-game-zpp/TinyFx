using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Serilog;
using Serilog.Configuration;
using Serilog.Enrichers;
using System;
using System.Collections.Generic;
using System.Text;
using TinyFx.Configuration;

namespace Serilog
{
    public static class SerilogExtensions
    {
        #region Enrichers

        /// <summary>
        /// 将 logEvent.MessageTemplate 的 MurmurHash（高效hash）值添加到事件属性
        /// </summary>
        /// <param name="enrich"></param>
        /// <returns></returns>
        public static LoggerConfiguration WithTemplateHash(this LoggerEnrichmentConfiguration enrich)
        {
            if (enrich == null)
                throw new ArgumentNullException(nameof(enrich));
            return enrich.With<TemplateHashEnricher>();
        }
        #endregion 
    }
}

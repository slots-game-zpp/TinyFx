using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyFx.Configuration;

namespace TinyFx.SnowflakeId.Common
{
    internal class ConfigWorkerIdProvider : IWorkerIdProvider
    {
        private SnowflakeIdSection _section;
        public ConfigWorkerIdProvider() 
        {
            _section = ConfigUtil.GetSection<SnowflakeIdSection>();
        }
        public Task Active()
        {
            return Task.CompletedTask;
        }

        public Task<int> GetNextWorkId()
        {
            return Task.FromResult(_section.WorkerId);
        }

        public Task Dispose()
        {
            return Task.CompletedTask;
        }
    }
}

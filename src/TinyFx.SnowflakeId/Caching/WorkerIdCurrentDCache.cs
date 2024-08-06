using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyFx.Configuration;
using TinyFx.Extensions.StackExchangeRedis;

namespace TinyFx.SnowflakeId.Caching
{
    internal class WorkerIdCurrentDCache : RedisStringClient<int>
    {
        private static WorkerIdCurrentDCache _instance = new WorkerIdCurrentDCache();
        public static WorkerIdCurrentDCache Create() => _instance;

        private SnowflakeIdSection _section;
        public WorkerIdCurrentDCache()
        {
            _section = ConfigUtil.GetSection<SnowflakeIdSection>();
            RedisKey = $"{RedisPrefixConst.SNOWFLAKE_ID}:WorkerIdNumber";
            Options.ConnectionStringName = _section.RedisConnectionStringName;
        }

        public async Task<int> GetNextWorkId()
        {
            return (int)await IncrementAsync(1);
        }
    }
}

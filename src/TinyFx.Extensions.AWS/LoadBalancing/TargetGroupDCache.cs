using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyFx.Caching;
using TinyFx.Extensions.StackExchangeRedis;

namespace TinyFx.Extensions.AWS.LoadBalancing
{
    internal class TargetGroupDCache : RedisHashClient<string>
    {
        private LoadBalancingService _lbSvc;
        public TargetGroupDCache(string connectionStringName = null) 
        {
            Options.ConnectionStringName = connectionStringName;
            RedisKey = $"{RedisPrefixConst.AWS}:TargetGroup";
            _lbSvc = new LoadBalancingService();
        }
        protected override async Task<CacheValue<string>> LoadValueWhenRedisNotExistsAsync(string field)
        {
            var ret = new CacheValue<string>();
            var group = await _lbSvc.GetTargetGroup(field);
            if (group != null)
            {
                ret.HasValue = true;
                ret.Value = group.TargetGroupArn;
            }
            return ret;
        }
    }
}

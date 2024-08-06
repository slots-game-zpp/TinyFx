using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyFx.Configuration;
using TinyFx.Extensions.StackExchangeRedis;

namespace TinyFx.Extensions.AWS
{
    public class AwsGlobalDCache : RedisHashClient
    {
        public AwsGlobalDCache(string connectionStringName = null)
        {
            Options.ConnectionStringName = connectionStringName;
            RedisKey = $"{RedisPrefixConst.AWS}:Global";
        }

        public async Task<string> GetVpcId()
        {
            var field = "VpcId";
            var ret = await GetOrDefaultAsync<string>(field, null);
            if (string.IsNullOrEmpty(ret))
            {
                var name = ConfigUtil.GetSection<AwsSection>().VpcName;
                ret = (await new EC2.EC2Service().GetVpc(name))?.VpcId;
                if (!string.IsNullOrEmpty(ret))
                    await SetAsync(field, ret);
            }
            return ret;
        }
    }
}

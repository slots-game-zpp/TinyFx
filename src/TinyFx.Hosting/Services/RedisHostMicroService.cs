using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TinyFx.Extensions.StackExchangeRedis;
using TinyFx.Randoms;

namespace TinyFx.Hosting.Services
{
    public class RedisHostMicroService : ITinyFxHostMicroService
    {
        private string _connectionStringName;
        private RedisSetClient<string> _namesDCache;
        public RedisHostMicroService(string connectionStringName = null)
        {
            _connectionStringName = connectionStringName;
            _namesDCache = RedisUtil.CreateSetClient<string>(RedisHostRegisterProvider.HOST_NAMES_KEY, _connectionStringName, true);
        }

        public async Task<List<string>> GetAllServiceNames()
            => (await _namesDCache.GetAllAsync()).ToList();

        public async Task<string> SelectOneServiceUrl(string serviceName)
        {
            var idsDCache = RedisUtil.CreateSetClient<string>($"{RedisHostRegisterProvider.HOST_IDS_KEY}:{serviceName}", _connectionStringName, true);
            var serviceIds = (await idsDCache.GetAllAsync()).ToList() ?? new List<string>();
            while (serviceIds.Count > 0)
            {
                var idx = RandomUtil.NextInt(serviceIds.Count);
                var serviceId = serviceIds[idx];
                var dataDCache = new TinyFxHostDataDCache(serviceId, _connectionStringName);
                var url = await dataDCache.GetAsync<string>("HostUrl");
                if (url.HasValue && !string.IsNullOrEmpty(url.Value))
                {
                    return url.Value;
                }
                else
                {
                    serviceIds.RemoveAt(idx);
                }
            }
            return null;
        }
    }
}

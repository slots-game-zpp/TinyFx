using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyFx.Caching;

namespace TinyFx.Hosting.Services
{
    public interface ITinyFxHostDataService
    {
        Task<List<string>> GetAllServiceIds(string connectionStringName = null);
        Task<List<string>> GetServiceIds(string serviceName = null, string connectionStringName = null);
        Task SetHostData<T>(string key, T value, string serviceId = null, string connectionStringName = null);
        Task<CacheValue<T>> GetHostData<T>(string key, string serviceId = null, string connectionStringName = null);
    }
}

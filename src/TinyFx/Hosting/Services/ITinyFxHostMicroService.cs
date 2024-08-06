using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyFx.Configuration;
using TinyFx.Net;

namespace TinyFx.Hosting.Services
{
    public interface ITinyFxHostMicroService
    {
        /// <summary>
        /// 获取所有服务名
        /// </summary>
        /// <returns></returns>
        Task<List<string>> GetAllServiceNames();

        /// <summary>
        /// 负载均衡获取服务名中的其中一个服务地址
        /// </summary>
        /// <param name="serviceName"></param>
        /// <returns></returns>
        Task<string> SelectOneServiceUrl(string serviceName);
    }
}

using Microsoft.AspNetCore.Http;
using Nacos;
using Nacos.Naming.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using TinyFx.Configuration;
using TinyFx.Hosting;
using TinyFx.Hosting.Services;

namespace TinyFx.Extensions.Nacos
{
    public class NacosHostMicroService : ITinyFxHostMicroService
    {
        public const string HOST_API_TYPE_KEY = "tinyfx.host_api_type";
        public const string HOST_URL = "tinyfx.host_url";
        /// <summary>
        /// 获取所有服务名
        /// </summary>
        /// <returns></returns>
        public async Task<List<string>> GetAllServiceNames()
            => await new NacosOpenApiService().GetServices();

        public async Task<string> SelectOneServiceUrl(string serviceName)
        {
            var section = DIUtil.GetService<NacosSection>();
            var instance = await DIUtil.GetRequiredService<INacosNamingService>()
                .SelectOneHealthyInstance(serviceName, section.GroupName, true);
            if (instance == null)
                throw new Exception($"NacosHostMicroService.SelectOneServiceUrl时没有有效实例。serviceName:{serviceName}");
            //var secure = instance.Metadata.TryGetValue("secure", out var value)
            //    ? value.ToBoolean(false) : false;
            var url = instance.Metadata.TryGetValue(HOST_URL, out var v)
                ? v : null;
            return url;
            //return new TinyFxHostEndPoint(apiType, instance.Ip, instance.Port, secure);
        }
    }
}

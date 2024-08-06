using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using TinyFx;
using TinyFx.AspNet;
using TinyFx.DbCaching;
using TinyFx.Extensions.StackExchangeRedis;

namespace CorsAPI
{
    [AllowAnonymous]
    public class DemoController : TinyFxControllerBase
    {
        [HttpGet]
        [EnableCors()]
        public string test()
        {
            return "cors OK";
        }

        [HttpGet]
        public async Task add()
        {
            //await DbCachingUtil.PublishUpdate(new List<DbCacheItem> { new DbCacheItem() 
            //{
            //    ConfigId="default",
            //    TableName="s_operator"
            //} });
        }
    }
}

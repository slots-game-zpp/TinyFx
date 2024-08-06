using SqlSugar;
using StackExchange.Redis;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;
using TinyFx.Caching;
using TinyFx.Configuration;
using TinyFx.Data.SqlSugar;
using TinyFx.Extensions.StackExchangeRedis;

namespace TinyFx.DbCaching.Caching
{
    internal class DbCacheDataDCache : RedisHashClient<string>
    {
        public DbCacheDataDCache(string configId, string tableName, string connectionStringName = null)
        {
            Options.ConnectionString = DbCachingUtil.GetRedisConnectionString(connectionStringName);
            RedisKey = $"{RedisPrefixConst.DB_CACHING}:Data:{configId ?? DbUtil.DefaultConfigId}:{tableName}";
        }
    }
}

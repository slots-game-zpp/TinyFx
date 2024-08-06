using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinyFx.Extensions.StackExchangeRedis
{
    public static class RedisPrefixConst
    {
        /// <summary>
        /// 全局缓存前缀
        /// </summary>
        public const string GLOBAL = "Global";//GLOBAL

        /// <summary>
        /// Session前缀
        /// </summary>
        public const string SESSION = "_SESSION";

        /// <summary>
        /// 主机服务注册前缀
        /// </summary>
        public const string HOSTS = "_TINYFX:Host";

        /// <summary>
        /// 分布式锁
        /// </summary>
        public const string REDIS_LOCK = "_TINYFX:RedisLock";
        /// <summary>
        /// 布隆过滤器
        /// </summary>
        public const string BLOOM_FILTER = "_TINYFX:BloomFilter";

        /// <summary>
        /// RabbitMQ 的 PubSub使用
        /// </summary>
        public const string MQ_SUB_QUEUE = "_TINYFX:MQSubQueue";
        /// <summary>
        /// TinyFx.SnowflakeId使用
        /// </summary>
        public const string SNOWFLAKE_ID = "_TINYFX:SnowflakeId";
        /// <summary>
        /// TinyFx.DbCaching.DbCacheDataDCache使用
        /// </summary>
        public const string DB_CACHING = "_TINYFX:DbCaching";

        /// <summary>
        /// TinyFx.AspNet.SyncNotifyAttribute使用
        /// </summary>
        public const string SYNC_NOTIFY = "_TINYFX:SyncNotify";

        /// <summary>
        /// TinyFx.Extensions.AWS.AwsGlobalDCache
        /// </summary>
        public const string AWS = "_TINYFX:AWS";
    }
}

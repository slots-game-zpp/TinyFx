using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static StackExchange.Redis.RedisChannel;

namespace TinyFx.Extensions.StackExchangeRedis
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = false)]
    public class RedisPublishMessageAttribute : Attribute
    {
        public string ConnectionStringName { get; }
        public PatternMode PatternMode { get; }
        public RedisPublishMessageAttribute(string connectionStringName = null, PatternMode mode = PatternMode.Auto)
        {
            ConnectionStringName = connectionStringName;
            PatternMode = mode;
        }
    }
}

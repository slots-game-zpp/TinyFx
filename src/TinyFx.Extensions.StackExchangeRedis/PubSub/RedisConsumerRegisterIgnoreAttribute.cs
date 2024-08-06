using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinyFx.Extensions.StackExchangeRedis
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = false)]
    public class RedisConsumerRegisterIgnoreAttribute: Attribute
    {
    }
}

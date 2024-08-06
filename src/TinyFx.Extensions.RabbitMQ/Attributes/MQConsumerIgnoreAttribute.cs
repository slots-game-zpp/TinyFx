using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinyFx.Extensions.RabbitMQ
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = false)]
    public class MQConsumerIgnoreAttribute: Attribute
    {
        public MQConsumerIgnoreAttribute() { }
    }
}

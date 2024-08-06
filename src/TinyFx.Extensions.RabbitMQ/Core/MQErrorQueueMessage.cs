using EasyNetQ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinyFx.Extensions.RabbitMQ
{
    public class MQErrorQueueMessage
    {
        public string RoutingKey { get; set; }
        public string Exchange { get; set; }
        public string Queue { get; set; }
        public string Exception { get; set; }
        public string Message { get; set; }
        public DateTime DateTime { get; set; }
        public MessageProperties BasicProperties { get; set; }

        public IMQMessage MQMessage { get; set; }
        public MessageReceivedInfo ReceivedInfo { get; set; }
    }
}

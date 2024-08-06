using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyFx.Extensions.RabbitMQ;

namespace MQDemoLib
{
    public class ReqMsg
    {
        public string Message { get; set; }
    }
    public class RspMsg
    {
        public string Message { get; set; }
    }
}

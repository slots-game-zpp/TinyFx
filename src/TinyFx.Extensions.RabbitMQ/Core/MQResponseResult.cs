using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyFx.Net;

namespace TinyFx.Extensions.RabbitMQ
{
    public class MQResponseResult<T>: ResponseResult<T>
    {
        /// <summary>
        /// 消息唯一ID
        /// </summary>
        public string MessageId { get; set; }
        public long Timestamp { get; set; }
        /// <summary>
        /// 消息执行时间ms
        /// </summary>
        public long MessageElasped { get; set; }
    }
}

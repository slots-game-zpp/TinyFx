using EasyNetQ;
using MQDemoLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyFx.Extensions.RabbitMQ;

namespace MQDemo3
{
    public class DemoMQSub : MQSubscribeConsumer<SubMsg>
    {
        public override MQSubscribeMode SubscribeMode => MQSubscribeMode.Broadcast;
        public DemoMQSub()
        {
        }

        protected override void Configuration(ISubscriptionConfiguration x)
        {
        }

        protected override  async Task OnMessage(SubMsg message, CancellationToken cancellationToken)
        {
            Console.WriteLine($"[Broadcast]: {message.Message}");
        }

        protected override Task OnError(MQSubError<SubMsg> error)
        {
            throw new NotImplementedException();
        }
    }
    /*
    public class DemoMQSub1 : MQSubscribeConsumer<SubMsg1>
    {
        protected override bool IsBroadcast => true;

        protected override void Configuration(ISubscriptionConfiguration x)
        {
        }

        protected override async Task OnMessage(SubMsg1 message, CancellationToken cancellationToken)
        {
            Console.WriteLine($"[广播]: {message.Message}");
        }
    }
    */
}

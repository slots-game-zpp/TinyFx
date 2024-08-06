using EasyNetQ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyFx.Configuration;
using TinyFx.Extensions.RabbitMQ;

namespace TinyFx.DbCaching.ChangeConsumers
{
    [MQConsumerIgnore]
    internal class MQDbCacheChangeConsumer : MQSubscribeConsumer<DbCacheChangeMessage>, IDbCacheChangeConsumer
    {
        public override MQSubscribeMode SubscribeMode => MQSubscribeMode.Broadcast;
        private string _connectionStringName;
        private DbCacheUpdator _uploader;
        public MQDbCacheChangeConsumer(string connectionStringName)
        {
            _connectionStringName = connectionStringName;
            _uploader = new DbCacheUpdator(DbCachingPublishMode.MQ);
        }
        protected override string GetConnectionStringName()
        {
            return _connectionStringName;
        }

        protected override void Configuration(ISubscriptionConfiguration x)
        {
            x.WithPrefetchCount(1);
        }
        public Task RegisterConsumer()
        {
            return this.Register();
        }
        protected override async Task OnMessage(DbCacheChangeMessage message, CancellationToken cancellationToken)
        {
            await _uploader.Execute(message);
        }

        protected override Task OnError(MQSubError<DbCacheChangeMessage> error)
        {
            return Task.CompletedTask;
        }
    }
}

using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net;

namespace TinyFx.MessageDriven;

public class MessageDrivenBuilder
{
    private readonly MessageDrivenService messageDriven;
    private readonly IServiceProvider serviceProvider;

    internal MessageDrivenBuilder(IServiceProvider serviceProvider, MessageDrivenService messageDriven)
    {
        this.serviceProvider = serviceProvider;
        this.messageDriven = messageDriven;
        messageDriven.HostName = Dns.GetHostName();
    }
    public MessageDrivenBuilder AddProducer(string clusterId, bool isUseRpc = false)
    {
        this.messageDriven.AddProducer(clusterId, isUseRpc);
        return this;
    }
    public MessageDrivenBuilder AddRpcReplyConsumer(string clusterId)
    {
        this.messageDriven.AddRpcReplyConsumer(clusterId);
        return this;
    }
    public MessageDrivenBuilder AddDelayProducer(string clusterId)
    {
        this.messageDriven.AddDelayProducer(clusterId);
        return this;
    }
    public MessageDrivenBuilder AddStatefulConsumer<TConsumer>(string clusterId, Func<TConsumer, Delegate> consumerHandlerSelector)
    {
        var consumer = serviceProvider.GetService<TConsumer>();
        var methodInfo = consumerHandlerSelector.Invoke(consumer).Method;
        this.messageDriven.AddStatefulConsumer(clusterId, consumer, methodInfo);
        return this;
    }
    public MessageDrivenBuilder AddSubscriber<TConsumer>(string clusterId, string queue, Func<TConsumer, Delegate> consumerHandlerSelector, string routingKey = "#", bool isDelay = false)
    {
        var consumer = serviceProvider.GetService<TConsumer>();
        var methodInfo = consumerHandlerSelector.Invoke(consumer).Method;
        this.messageDriven.AddSubscriber(clusterId, queue, consumer, methodInfo, routingKey, isDelay);
        return this;
    }
}
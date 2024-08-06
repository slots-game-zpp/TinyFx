using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using TinyFx.Core;

namespace TinyFx.MessageDriven;

public static class TaskEngineExtensions
{
    public static IServiceCollection AddTaskEngine(this IServiceCollection services)
    {
        services.AddSingleton<IMessageService, MessageDrivenService>();
        return services;
    }
    public static IApplicationBuilder UseMessageTask(this IApplicationBuilder app, Action<MessageDrivenBuilder> builderInitializer)
    {
        var service = app.ApplicationServices.GetService<IMessageService>();
        var builder = new MessageDrivenBuilder(app.ApplicationServices, service as MessageDrivenService);
        builderInitializer.Invoke(builder);
        service.Start();
        return app;
    }
}

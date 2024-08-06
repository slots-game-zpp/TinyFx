using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinyFx.Extensions.RabbitMQ
{
    public interface IMQSubscribeHandler<TMessage>
         where TMessage : class, new()
    {
        Task OnMessage(TMessage message, CancellationToken cancellationToken);
    }
}

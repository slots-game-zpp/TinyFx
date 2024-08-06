using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace TinyFx.Hosting.Services
{
    /// <summary>
    /// Host定时任务服务
    /// </summary>
    public interface ITinyFxHostTimerService
    {
        bool Register(TinyFxHostTimerItem item, bool tryUpdate = false);
        bool Deregister(string id);
        bool Deregister(List<string> ids);
        Task StartAsync(CancellationToken stoppingToken = default);
        Task StopAsync(CancellationToken cancellationToken = default);
    }
}
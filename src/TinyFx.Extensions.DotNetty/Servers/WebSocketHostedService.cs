using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TinyFx.Common;
using TinyFx.Configuration;
using TinyFx.Hosting.Services;
using TinyFx.Logging;
using TinyFx.Net;

namespace TinyFx.Extensions.DotNetty
{
    public class WebSocketHostedService : BackgroundService
    {
        private WebSocketServer _server;
        private DotNettySection _options;
        protected DefaultTinyFxHostTimerService _timerService = new();
        protected AppSessionContainer Sessions;

        public WebSocketHostedService(IHostApplicationLifetime appLifetime)
        {
            _server = new WebSocketServer();
            _options = DIUtil.GetRequiredService<DotNettySection>();
            Sessions = DotNettyUtil.Sessions;
            RegisterCheckInvalidSessionWork();
        }
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            try
            {
                var _ = _timerService.StartAsync(stoppingToken);
                await _server.StartAsync();
            }
            catch (CustomException ex)
            {
                LogUtil.Error(ex, "DotNetty.WebSocketServer不应该抛出CustomException异常！");
            }
            catch (Exception ex)
            {
                LogUtil.Error(ex, "未处理异常:DotNetty.WebSocketServer！");
            }
        }
        public override async Task StopAsync(CancellationToken cancellationToken)
        {
            await _timerService.StopAsync(cancellationToken);
            await _server.StopAsync();
            await base.StopAsync(cancellationToken);
        }
        private void RegisterCheckInvalidSessionWork()
        {
            if (_options.CheckSessionInterval > 0 && _options.CheckSessionTimeout > 0)
            {
                _timerService.Register(new TinyFxHostTimerItem
                {
                    Id = "DotNetty.CheckInvalidSessionWork",
                    Title = "DotNetty检测有效Session",
                    Interval = _options.CheckSessionInterval,
                    Callback = CheckInvalidSessionWork,
                });
            }
        }
        private Task CheckInvalidSessionWork(CancellationToken stoppingToken)
        {
            return Task.Run(() =>
            {
                foreach (var session in Sessions.Find())
                {
                    if (stoppingToken.IsCancellationRequested)
                        break;
                    if (!session.IsLogin && _options.CheckSessionTimeout > 0 && (DateTime.UtcNow - session.CreateTime).TotalMilliseconds > _options.CheckSessionTimeout)
                    {
                        session.Channel.WriteAndFlushAsync(GetInvalidSessionPacket());
                        session.Channel.CloseAsync();
                    }
                }
            });
        }
        private Packet _invalidSessionPacket;
        private Packet GetInvalidSessionPacket()
        {
            if (_invalidSessionPacket == null)
            {
                _invalidSessionPacket = DotNettyUtil.CreateExceptionPacket(GResponseCodes.G_REQUEST_RATE_LIMIT
                    , $"疑似空连接，服务器关闭连接！（连接但在规定时间内未登录）");
            }
            return _invalidSessionPacket;
        }
    }
}

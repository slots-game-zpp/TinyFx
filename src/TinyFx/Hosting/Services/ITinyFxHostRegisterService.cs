using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyFx.Caching;
using TinyFx.Logging;

namespace TinyFx.Hosting.Services
{
    /// <summary>
    /// host注册服务
    /// </summary>
    public interface ITinyFxHostRegisterService
    {
        bool RegisterEnabled { get; }
        void AddProvider(ITinyFxHostRegisterProvider provider);
        Task Register();
        Task Deregistering();
        Task Deregistered();
        Task Heartbeat();
        Task Health();
    }
    internal class DefaultHostRegisterService : ITinyFxHostRegisterService
    {
        private List<ITinyFxHostRegisterProvider> _providers = new();

        public bool RegisterEnabled => _providers.Count > 0;

        public void AddProvider(ITinyFxHostRegisterProvider provider)
        {
            _providers.Add(provider);
        }
        public async Task Register()
        {
            foreach (var provider in _providers)
            {
                await provider.Register();
            }
        }
        public async Task Deregistering()
        {
            foreach (var provider in _providers)
            {
                await provider.Deregistering();
            }
        }
        public async Task Deregistered()
        {
            foreach (var provider in _providers)
            {
                await provider.Deregistered();
            }
        }
        public async Task Heartbeat()
        {
            foreach (var provider in _providers)
            {
                try
                {
                    await provider.Heartbeat();
                }
                catch (Exception ex)
                {
                    LogUtil.Error(ex, $"{provider.GetType().FullName}.Heartbeat()异常");
                }
            }
        }
        public async Task Health()
        {
            foreach (var provider in _providers)
            {
                try
                {
                    await provider.Health();
                }
                catch (Exception ex)
                {
                    LogUtil.Error(ex, $"{provider.GetType().FullName}.Health()异常");
                }
            }
        }
    }
    public interface ITinyFxHostRegisterProvider
    {
        Task Register();
        Task Deregistering();
        Task Deregistered();
        Task Heartbeat();
        Task Health();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyFx.Configuration;
using TinyFx.Extensions.AWS.LoadBalancing;
using TinyFx.Hosting.Services;
using TinyFx.Logging;

namespace TinyFx.Extensions.AWS.Common
{
    internal class AwsHostRegisterProvider : ITinyFxHostRegisterProvider
    {
        private TargetGroupRegisterService _targetGroupRegistor;

        public AwsHostRegisterProvider()
        {
            _targetGroupRegistor = new TargetGroupRegisterService();
        }
        public async Task Register()
        {
            await _targetGroupRegistor.Register();
            if (_targetGroupRegistor.IsRegister)
                LogUtil.Info($"注册Host => AWS[{GetType().Name}] GroupName:{_targetGroupRegistor.GroupName}");
        }

        public async Task Deregistering()
        {
            await _targetGroupRegistor.Deregister();
        }

        public Task Heartbeat()
        {
            return Task.CompletedTask;
        }

        public Task Health()
        {
            return Task.CompletedTask;
        }

        public Task Deregistered()
        {
            return Task.CompletedTask;
        }
    }
}

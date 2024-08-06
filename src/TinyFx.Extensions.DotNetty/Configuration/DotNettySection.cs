using DotNetty.Handlers.Logging;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using TinyFx.Configuration;
using TinyFx.Extensions.DotNetty;

namespace TinyFx.Configuration
{
    public class DotNettySection : ConfigSection
    {
        public override string SectionName => "DotNetty";

        public bool Enabled { get; set; }
        public bool UseLibuv { get; set; } = true;
        public ProtocolMode Protocol { get; set; }
        public int Port { get; set; }
        public int ReadIdelTimeOut { get; set; } = 8;
        public int ConnectTimeout { get; set; } = 5000;
        public int SoBacklog { get; set; } = 8192;
        public LogLevel LogLevel { get; set; } = LogLevel.DEBUG;

        public bool Ssl { get; set; }
        public string SslCer { get; set; }
        public string SslPassword { get; set; }

        public bool EnableReceiveEvent { get; set; }
        public bool EnableSendEvent { get; set; }
        public bool EnableClosedEvent { get; set; }
        public bool EnableHeartbeatEvent { get; set; }
        public bool IsLittleEndian { get; set; } = false;
        /// <summary>
        /// 检查未登录Session的间隔时间, 小于等于0不检查
        /// </summary>
        public int CheckSessionInterval { get; set; } = 5000;
        /// <summary>
        /// 未登录Session的Timeout时间（防止空连接），小于等于0不检查
        /// </summary>
        public int CheckSessionTimeout { get; set; } = 5000;

        public bool AutoLoad { get; set; }
        public List<string> Assemblies { get; set; } = new List<string>();

        public override void Bind(IConfiguration configuration)
        {
            base.Bind(configuration);
            Assemblies.Clear();
            Assemblies = configuration?.GetSection("Assemblies")
                .Get<List<string>>();
        }
    }
    public enum ProtocolMode
    {
        TCP,
        UDP,
        WebSocket
    }
}

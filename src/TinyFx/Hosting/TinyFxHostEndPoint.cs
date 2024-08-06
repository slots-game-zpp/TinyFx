using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace TinyFx.Hosting
{
    public class TinyFxHostEndPoint
    {
        public HostApiType ApiType { get; set; } = HostApiType.Http;
        public string Ip { get; set; }
        public int Port { get; set; }
        public bool Secure { get; set; }
        public TinyFxHostEndPoint() { }
        public TinyFxHostEndPoint(HostApiType apiType, string ip, int port, bool secure = false)
        {
            ApiType = apiType;
            Ip = ip;
            Port = port;
            Secure = secure;
        }
        public override string ToString()
        {
            switch (ApiType)
            {
                case HostApiType.Http:
                case HostApiType.Grpc:
                    return Secure ? $"https://{Ip}:{Port}" : $"http://{Ip}:{Port}";
                case HostApiType.WebSocket:
                    return Secure ? $"wss://{Ip}:{Port}" : $"ws://{Ip}:{Port}";
            }
            throw new Exception($"未知的HostApiType: {ApiType.ToString()}");
        }
    }
    /// <summary>
    /// 主机API类型
    /// </summary>
    public enum HostApiType
    {
        /// <summary>
        /// Web API
        /// </summary>
        Http,
        Grpc,
        WebSocket
    }
}

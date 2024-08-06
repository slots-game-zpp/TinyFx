﻿namespace Nacos.Remote
{
    public class RemoteServerInfo
    {
        public string ServerIp { get; set; }

        public int ServerPort { get; set; }

        public string GetAddress() => $"{ServerIp}{Nacos.Common.Constants.COLON}{ServerPort}";
    }
}

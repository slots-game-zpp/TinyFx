﻿namespace Nacos.Remote.Requests
{
    using System.Collections.Generic;
    using Nacos.Remote;

    public class ConfigBatchListenRequest : CommonRequest
    {
        [System.Text.Json.Serialization.JsonPropertyName("configListenContexts")]
        public List<ConfigListenContext> ConfigListenContexts { get; set; } = new List<ConfigListenContext>();

        [System.Text.Json.Serialization.JsonPropertyName("listen")]
        public bool Listen { get; set; } = true;

        public void AddConfigListenContext(string tenant, string group, string dataId, string md5)
        {
            var ctx = new ConfigListenContext(tenant, group, dataId, md5);
            ConfigListenContexts.Add(ctx);
        }

        public override string GetRemoteType() => RemoteRequestType.Req_Config_Listen;
    }
}

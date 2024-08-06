﻿namespace Nacos.Config.FilterImpl
{
    using Nacos.Config.Abst;
    using Nacos.Config.Common;
    using Nacos.Utils;

    public class ConfigRequest : IConfigRequest
    {
        private System.Collections.Generic.Dictionary<string, object> param = new System.Collections.Generic.Dictionary<string, object>();

        private IConfigContext configContext = new ConfigContext();

        public string GetTenant() => param.SafeGetValue(ConfigConstants.TENANT, null);

        public void SetTenant(string tenant) => param[ConfigConstants.TENANT] = tenant;

        public string GetDataId() => param.SafeGetValue(ConfigConstants.DATA_ID, null);

        public void SetDataId(string dataId) => param[ConfigConstants.DATA_ID] = dataId;

        public string GetGroup() => param.SafeGetValue(ConfigConstants.GROUP, null);

        public void SetGroup(string group) => param[ConfigConstants.GROUP] = group;

        public string GetContent() => param.SafeGetValue(ConfigConstants.CONTENT, null);

        public void SetContent(string content) => param[ConfigConstants.CONTENT] = content;

        public string GetConfigRequestType() => param.SafeGetValue(ConfigConstants.TYPE, null);

        public void SetType(string type) => param[ConfigConstants.TYPE] = type;

        public string GetEncryptedDataKey() => param.SafeGetValue(ConfigConstants.ENCRYPTED_DATA_KEY, null);

        public object GetParameter(string key) => param.TryGetValue(key, out var obj) ? obj : null;

        public IConfigContext GetConfigContext() => configContext;

        public void PutParameter(string key, object value) => param[key] = value;
    }
}

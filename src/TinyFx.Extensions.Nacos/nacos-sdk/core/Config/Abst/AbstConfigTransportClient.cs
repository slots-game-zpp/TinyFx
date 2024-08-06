﻿using Microsoft.Extensions.Logging;
using Nacos;
using Nacos.Auth;
using Nacos.Common;
using Nacos.Config.Common;
using Nacos.Config.FilterImpl;
using Nacos.Config.Impl;
using Nacos.Logging;
using Nacos.Remote;
using Nacos.Security;
using Nacos.Utils;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Nacos.Config.Abst
{
    public abstract class AbstConfigTransportClient : IConfigTransportClient
    {
        private readonly ILogger _logger = NacosLogManager.CreateLogger<ConfigRpcTransportClient>();

        protected ConcurrentDictionary<string, CacheData> _cacheMap = new();
        protected NacosSdkOptions _options;
        protected IServerListFactory _serverListFactory;
        protected ISecurityProxy _securityProxy;
        protected string _accessKey;
        protected string _secretKey;

        public string GetName() => GetNameInner();

        public string GetNamespace() => GetNamespaceInner();

        public string GetTenant() => GetTenantInner();

        public Task<bool> PublishConfigAsync(string dataId, string group, string tenant, string appName, string tag, string betaIps, string content, string encryptedDataKey, string casMd5, string type)
            => PublishConfig(dataId, group, tenant, appName, tag, betaIps, content, encryptedDataKey, casMd5, type);

        public Task<ConfigResponse> QueryConfigAsync(string dataId, string group, string tenant, long readTimeous, bool notify)
            => QueryConfig(dataId, group, tenant, readTimeous, notify);

        public Task<bool> RemoveConfigAsync(string dataId, string group, string tenant, string tag)
            => RemoveConfig(dataId, group, tenant, tag);

        public Task RemoveCacheAsync(string dataId, string group, string tenant)
        {
            RemoveCache(dataId, group, tenant);
            return Task.CompletedTask;
        }

        public CacheData AddOrUpdateCache(string key, CacheData value) => _cacheMap.AddOrUpdate(key, value, (x, y) => value);

        public bool TryGetCache(string key, out CacheData value) => _cacheMap.TryGetValue(key, out value);

        public int GetCacheCount() => _cacheMap.Count;

        public Task ExecuteConfigListenAsync() => ExecuteConfigListen();

        public Task NotifyListenConfigAsync() => NotifyListenConfig();

        public bool GetIsHealthServer() => IsHealthServer();

        public void Start() => StartInner();

        protected abstract string GetNameInner();

        protected abstract string GetNamespaceInner();

        protected abstract string GetTenantInner();

        protected abstract Task<bool> PublishConfig(string dataId, string group, string tenant, string appName, string tag, string betaIps, string content, string encryptedDataKey, string casMd5, string type);

        protected abstract Task<bool> RemoveConfig(string dataId, string group, string tenant, string tag);

        protected abstract Task<ConfigResponse> QueryConfig(string dataId, string group, string tenant, long readTimeous, bool notify);

        protected abstract void StartInner();

        protected void RemoveCache(string dataId, string group, string tenant = null)
        {
            string groupKey = tenant == null ? GroupKey.GetKey(dataId, group) : GroupKey.GetKeyTenant(dataId, group, tenant);

            _cacheMap.TryRemove(groupKey, out _);

            _logger?.LogInformation("[{0}] [unsubscribe] {1}", GetNameInner(), groupKey);
        }

        protected abstract Task ExecuteConfigListen();

        protected abstract Task NotifyListenConfig();

        protected abstract bool IsHealthServer();

        protected Dictionary<string, string> GetSpasHeaders()
        {
            var spasHeaders = new Dictionary<string, string>(2);

            // STS 临时凭证鉴权的优先级高于 AK/SK 鉴权
            // StsConfig.getInstance().isStsOn()
            /*if (true)
            {
                // StsCredential stsCredential = getStsCredential();
                // _accessKey = stsCredential.accessKeyId;
                // _secretKey = stsCredential.accessKeySecret;
                // stsCredential.securityToken
                // spasHeaders["Spas-SecurityToken"] = string.Empty;
            }*/

            if (_accessKey.IsNotNullOrWhiteSpace() && _secretKey.IsNotNullOrWhiteSpace())
            {
                spasHeaders["Spas-AccessKey"] = _accessKey;
            }

            return spasHeaders;
        }

        protected Dictionary<string, string> GetSecurityHeaders(RequestResource resource)
        {
            return _securityProxy.GetIdentityContext(resource);
        }

        protected Dictionary<string, string> GetCommonHeader()
        {
            var headers = new Dictionary<string, string>(16);

            string ts = DateTimeOffset.Now.ToUnixTimeMilliseconds().ToString();

            var appKey = EnvUtil.GetEnvValue("nacos.client.appKey");
            string token = HashUtil.GetMd5(ts + (appKey.IsNullOrWhiteSpace() ? "" : appKey));

            headers[Constants.CLIENT_APPNAME_HEADER] = AppDomain.CurrentDomain.FriendlyName;
            headers[Constants.CLIENT_REQUEST_TS_HEADER] = ts;
            headers[Constants.CLIENT_REQUEST_TOKEN_HEADER] = token;
            headers[HttpHeaderConsts.CLIENT_VERSION_HEADER] = Constants.CLIENT_VERSION;
            headers["exConfigInfo"] = "true";
            headers[HttpHeaderConsts.REQUEST_ID] = Guid.NewGuid().ToString("N");
            headers[HttpHeaderConsts.ACCEPT_CHARSET] = "UTF-8";
            return headers;
        }

        protected Dictionary<string, string> GetSignHeaders(Dictionary<string, string> paramValues, string secretKey)
        {
            if (paramValues == null) return null;

            var resource = string.Empty;
            if (paramValues.ContainsKey(Constants.TENANT) && paramValues.ContainsKey(Constants.GROUP))
            {
                resource = paramValues[Constants.TENANT] + "+" + paramValues[Constants.GROUP];
            }
            else
            {
                if (paramValues.TryGetValue(Constants.GROUP, out var group) && group.IsNullOrWhiteSpace())
                {
                    resource = group;
                }
            }

            return GetSignHeaders(resource, secretKey);
        }

        protected Dictionary<string, string> GetSignHeaders(string resource, string secretKey)
        {
            var header = new Dictionary<string, string>(2);

            var timeStamp = DateTimeOffset.Now.ToUnixTimeMilliseconds().ToString();
            header["Timestamp"] = timeStamp;

            if (secretKey.IsNotNullOrWhiteSpace())
            {
                var signature = resource.IsNullOrWhiteSpace()
                    ? HashUtil.GetHMACSHA1(timeStamp, secretKey)
                    : HashUtil.GetHMACSHA1($"{resource}+{timeStamp}", secretKey);

                header["Spas-Signature"] = signature;
            }

            return header;
        }
    }
}

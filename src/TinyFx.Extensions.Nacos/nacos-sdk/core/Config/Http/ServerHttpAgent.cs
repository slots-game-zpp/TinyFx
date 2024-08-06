﻿using Google.Protobuf.WellKnownTypes;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Nacos;
using Nacos.Common;
using Nacos.Logging;
using Nacos.Remote;
using Nacos.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Nacos.Config.Http
{
    public class ServerHttpAgent : IHttpAgent
    {
        private readonly ILogger _logger = NacosLogManager.CreateLogger<ServerHttpAgent>();
        private IServerListFactory _serverListMgr;
        private HttpClient _httpClient = new HttpClient();
        private readonly string _namespace;
        private readonly string _tenant;
        private readonly string _contentPath;

        public ServerHttpAgent(IOptions<NacosSdkOptions> optionsAccs, IServerListFactory serverListManager)
        {
            var options = optionsAccs.Value;
            _serverListMgr = serverListManager;
            _namespace = string.IsNullOrWhiteSpace(options.Namespace) ? Constants.DEFAULT_NAMESPACE_ID : options.Namespace;
            _tenant = string.IsNullOrWhiteSpace(options.EndPoint) ? _namespace : $"{options.EndPoint}-{_namespace}";
            _contentPath = options.ContextPath;
        }

        public void Dispose()
        {
            _serverListMgr?.Dispose();
        }

        public string GetEncode() => "UTF-8";

        public string GetName() => _serverListMgr.GetName();

        public string GetNamespace() => _namespace;

        public string GetTenant() => _tenant;

        public async Task<HttpResponseMessage> HttpDelete(string path, Dictionary<string, string> headers, Dictionary<string, string> paramValues, string encoding, long readTimeoutMs)
            => await HttpRequest(path, headers, paramValues, encoding, readTimeoutMs, HttpMethod.Delete).ConfigureAwait(false);

        public async Task<HttpResponseMessage> HttpGet(string path, Dictionary<string, string> headers, Dictionary<string, string> paramValues, string encoding, long readTimeoutMs)
            => await HttpRequest(path, headers, paramValues, encoding, readTimeoutMs, HttpMethod.Get).ConfigureAwait(false);

        public async Task<HttpResponseMessage> HttpPost(string path, Dictionary<string, string> headers, Dictionary<string, string> paramValues, string encoding, long readTimeoutMs)
            => await HttpRequest(path, headers, paramValues, encoding, readTimeoutMs, HttpMethod.Post).ConfigureAwait(false);

        public async Task<HttpResponseMessage> HttpRequest(string path, Dictionary<string, string> headers, Dictionary<string, string> paramValues, string encoding, long readTimeoutMs, HttpMethod method)
        {
            long endTime = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() + readTimeoutMs;

            string currentServerAddr = _serverListMgr.GetCurrentServer();
            int maxRetry = Constants.MAX_RETRY;

            var requestUrl = GetUrl(currentServerAddr, path);
            if (method == HttpMethod.Get)
            {
                requestUrl = $"{requestUrl}?{InitParams(paramValues)}";
            }

            do
            {
                try
                {
                    using var cts = new System.Threading.CancellationTokenSource();
                    cts.CancelAfter(TimeSpan.FromMilliseconds(readTimeoutMs));

                    HttpRequestMessage reqMsg = new HttpRequestMessage(method, requestUrl);

                    if (method != HttpMethod.Get
                        && paramValues.Count > 0)
                    {
                        reqMsg.Content = new FormUrlEncodedContent(paramValues);
                    }

                    foreach (var item in headers)
                    {
                        reqMsg.Headers.TryAddWithoutValidation(item.Key, item.Value);
                    }

                    var resp = await _httpClient.SendAsync(reqMsg, cts.Token).ConfigureAwait(false);

                    if (IsFail(resp))
                    {
                        _logger?.LogError("[NACOS ConnectException] currentServerAddr: {0}, httpCode: {1}", currentServerAddr, resp.StatusCode);
                    }
                    else
                    {
                        // TODO: impl update server
                        // _serverListMgr.UpdateCurrentServerAddr(currentServerAddr);
                        return resp;
                    }
                }
                catch (Exception ex)
                {
                    _logger?.LogError(ex, "[NACOS Exception {0}] currentServerAddr: {1}", method.Method, currentServerAddr);
                }

                maxRetry--;
                if (maxRetry < 0)
                {
                    throw new Exception(
                            $"[NACOS HTTP-{method.Method}] The maximum number of tolerable server reconnection errors has been reached");
                }

                _serverListMgr.GenNextServer();
            }
            while (DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() <= endTime);

            _logger?.LogError("no available server");
            throw new Exception("no available server");
        }

        public Task Start() => Task.CompletedTask;

        private string GetUrl(string serverAddr, string relativePath) => $"{serverAddr.TrimEnd('/')}/{_contentPath}{relativePath}";

        private string InitParams(Dictionary<string, string> dict)
        {
            var builder = new StringBuilder(1024);
            if (dict != null && dict.Any())
            {
                foreach (var item in dict)
                {
                    builder.Append($"{item.Key}={item.Value}&");
                }
            }

            return builder.ToString().TrimEnd('&');
        }

        private bool IsFail(HttpResponseMessage result)
        {
            return result.StatusCode == System.Net.HttpStatusCode.InternalServerError
                || result.StatusCode == System.Net.HttpStatusCode.BadGateway
                || result.StatusCode == System.Net.HttpStatusCode.ServiceUnavailable;
        }
    }
}

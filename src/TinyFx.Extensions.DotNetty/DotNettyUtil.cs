using DotNetty.Codecs.Http;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel.Design;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using TinyFx.Configuration;
using TinyFx.Reflection;
using System.Linq;
using TinyFx.Net;
using TinyFx.Security;
using TinyFx.Logging;
using TinyFx.Xml;

namespace TinyFx.Extensions.DotNetty
{
    /// <summary>
    /// DotNetty辅助类
    /// </summary>
    public static class DotNettyUtil
    {
        /// <summary>
        /// Commands信息CommandId
        /// </summary>
        public const int InfoCommandId = -2;
        /// <summary>
        /// 心跳CommandId
        /// </summary>
        public const int HeartbeatCommandId = 0;
        /// <summary>
        /// 服务器异常时的CommandId
        /// </summary>
        public const int ExceptionCommandId = -1;

        public static readonly AppSessionContainer Sessions;
        public static readonly CommandContainer Commands;
        public static readonly ConcurrentDictionary<string, bool> IpRequestRules = new ConcurrentDictionary<string, bool>();
        public static readonly ConcurrentDictionary<string, bool> UserRequestRules = new ConcurrentDictionary<string, bool>();
        private static DotNettySection _serverOptions;

        static DotNettyUtil()
        {
            Sessions = AppSessionContainer.Instance;
            Commands = CommandContainer.Instance;
            _serverOptions = ConfigUtil.GetSection<DotNettySection>();
            //ConfigUtil.ConfigChange += (_, _) =>
            //{
            //    _serverOptions = ConfigUtil.GetSection<DotNettySection>()!.Server;
            //};
        }
        private static XmlDocumentParser _xmlParser;
        public static XmlDocumentParser XmlParser
        {
            get
            {
                if (_xmlParser == null)
                {
                    var xmlFiles = CommandContainer.Instance.Assemblies.Select(asm
                            => Path.Combine(Path.GetDirectoryName(asm.Location), $"{Path.GetFileNameWithoutExtension(asm.Location)}.xml")
                        ).Where(file => File.Exists(file)).ToList();
                    _xmlParser = new XmlDocumentParser(xmlFiles);
                }
                return _xmlParser;
            }
        }

        public static void LimitIp(string ip)
            => IpRequestRules.AddOrUpdate(ip, false, (k, v) => false);
        public static void AllowIp(string ip)
            => IpRequestRules.AddOrUpdate(ip, true, (k, v) => true);
        public static bool IsAllowIp(string ip)
        {
            if (string.IsNullOrEmpty(ip))
                return true;
            if (IpRequestRules.ContainsKey(ip))
                return IpRequestRules[ip];
            return true;
        }
        public static void LimitUser(string userId)
            => UserRequestRules.AddOrUpdate(userId, false, (k, v) => false);
        public static void AllowUser(string userId)
            => UserRequestRules.AddOrUpdate(userId, true, (k, v) => true);
        public static bool IsAllowUser(string userId)
        {
            if (string.IsNullOrEmpty(userId))
                return true;
            if (UserRequestRules.ContainsKey(userId))
                return UserRequestRules[userId];
            return true;
        }

        internal static async Task SendAsync<T>(Type commandType, T message, AppSession session)
        {
            if (!Commands.TryGet(commandType, out CommandDescriptor cmd))
                throw new Exception($"CommandDescriptorContainer中不存在对应的CommandDescriptor：{commandType.FullName}");
            await SendAsync(cmd.CommandId, message, session);
        }

        internal static async Task SendAsync<T>(int commandId, T message, AppSession session)
        {
            if (session == null)
                throw new ArgumentNullException(nameof(session));
            var rsp = new Packet()
            {
                CommandId = commandId,
                Body = message
            };
            await session.SendAsync(rsp);
        }

        #region PushAsync
        public static async Task PushAsync<T>(this AppSession session, T message)
            => await session?.SendAsync(GetPushPacket(message));
        public static async Task PushAsync(this AppSession session, object message)
            => await session?.SendAsync(GetPushPacket(message));

        /// <summary>
        /// 向指定用户推送消息
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="userId"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public static async Task PushAsync<T>(object userId, T message)
            => await PushAsync(Convert.ToString(userId), message);

        /// <summary>
        /// 向所有用户推送消息
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="message"></param>
        /// <returns></returns>
        public static async Task PushAllAsync<T>(T message)
        {
            var rsp = GetPushPacket(message);
            foreach (var session in Sessions.Find())
            {
                await session?.SendAsync(rsp);
            }
        }
        public static async Task PushAllAsync(object message)
        {
            var rsp = GetPushPacket(message);
            foreach (var session in Sessions.Find())
            {
                await session?.SendAsync(rsp);
            }
        }
        public static IPacket GetPushPacket<T>(T message)
        {
            var type = message.GetType();
            if (!Commands.TryGet(type, out CommandDescriptor cmd))
                throw new Exception($"CommandDescriptorContainer中不存在对应的CommandDescriptor：{type.FullName}");
            return new Packet()
            {
                CommandId = cmd.CommandId,
                Body = new ProtoResponse<T>(message)
            };
        }

        public static IPacket GetPushPacket(object message)
        {
            var type = message.GetType();
            if (!Commands.TryGet(type, out CommandDescriptor cmd))
                throw new Exception($"CommandDescriptorContainer中不存在对应的CommandDescriptor：{type.FullName}");

            return new Packet()
            {
                CommandId = cmd.CommandId,
                Body = ReflectionUtil.CreateInstance(typeof(ProtoResponse<>).MakeGenericType(type), message)
            };
        }
        #endregion 


        /// <summary>
        /// 创建ExceptionPacket
        /// </summary>
        /// <param name="code"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        internal static Packet CreateExceptionPacket(string code, string message)
        {
            return new Packet
            {
                CommandId = ExceptionCommandId,
                Body = new ProtoResponse
                {
                    Success = false,
                    Code = code,
                    Message = ConfigUtil.Project.ResponseErrorMessage ? message : null
                }
            };
        }
        internal static Packet CreateExceptionPacket(Exception ex, AppSession session, out bool isCustomEx)
        {
            var ret = new Packet { CommandId = ExceptionCommandId };
            var exc = ExceptionUtil.GetException<CustomException>(ex);
            isCustomEx = exc != null;
            if (isCustomEx)
            {
                ret.Body = new ProtoResponse
                {
                    Success = false,
                    Code = exc.Code,
                    Message = ConfigUtil.Project.ResponseErrorMessage ? exc.Message : null
                };
                LogUtil.Debug("[CustomException] userId:{userId} exc.code:{exc.code} exc.message:{exc.message}"
                    , session?.UserId, exc.Code, exc.Message);
            }
            else
            {
                ret.Body = new ProtoResponse
                {
                    Success = false,
                    Code = GResponseCodes.G_INTERNAL_SERVER_ERROR,
                    Message = ConfigUtil.Project.ResponseErrorMessage ? ex.Message : null,
                    Exception = ConfigUtil.Project.ResponseErrorDetail ? ex : null
                };
                LogUtil.Error(ex, "未处理异常: session:{session}", session);
            }
            return ret;
        }

        #region VerifyBeforeHandshake
        /// <summary>
        /// 获取Websocket 连接URL的RSA签名后的URL
        /// </summary>
        /// <param name="url"></param>
        /// <param name="rsaPrivateKey"></param>
        /// <returns></returns>
        public static string GetSignWsUrl(string url, string rsaPrivateKey)
        {
            var builder = new UriBuilderEx(url);
            var sign = SecurityUtil.RSASignData(url, rsaPrivateKey);
            builder.AppendQueryString("sign", sign);
            return builder.ToString();
        }
        /// <summary>
        /// 验证websocket请求连接url的rsa签名是否有效
        /// </summary>
        /// <param name="req"></param>
        /// <param name="rsaPublicKey"></param>
        /// <returns></returns>
        public static bool VerifySignWsUrl(IFullHttpRequest req, string rsaPublicKey)
        {
            var builder = new UriBuilderEx(req.Uri.ToString());
            var sign = builder.GetQueryStringValue("sign");
            if (string.IsNullOrEmpty(sign))
                return false;
            builder.RemoveQueryString("sign");
            var url = builder.ToString();
            return SecurityUtil.RSAVerifyData(url, sign, rsaPublicKey);
        }
        #endregion
    }
}

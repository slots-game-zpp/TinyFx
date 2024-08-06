using DotNetty.Common.Utilities;
using DotNetty.Transport.Channels;
using DotNetty.Transport.Channels.Groups;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TinyFx.Extensions.DotNetty
{
    public class AppSession : TinyFx.Disposable
    {
        public IChannel Channel { get; }

        public string ChannelId { get; private set; }

        public DateTime CreateTime { get; private set; }

        public DateTime LastAccessTime { get; set; }

        public EndPoint RemoteAddress { get; private set; }

        #region UserInfo
        private static AttributeKey<IUserIdGetter> _userInfoKey = AttributeKey<IUserIdGetter>.ValueOf("UserInfo");
        public static AttributeKey<string> UserIdKey = AttributeKey<string>.ValueOf("UserId");
        public string UserId
        {
            get => Channel.GetAttribute(UserIdKey).Get();
            set => Channel.GetAttribute(UserIdKey).Set(value);
        }

        public T GetUserInfo<T>()
            where T : class, IUserIdGetter
            => Channel.GetAttribute(_userInfoKey).Get() as T;
        public void SetUserInfo<T>(T value)
            where T : class, IUserIdGetter
        {
            Channel.GetAttribute(_userInfoKey).Set(value);
            Channel.GetAttribute(UserIdKey).Set(value.GetUserId());
        }

        /// <summary>
        /// 是否登录。用于CommandAttribute.CheckLogin
        /// </summary>
        public bool IsLogin { get; set; }
        #endregion

        public AppSession(IChannel channel, EndPoint remoteAddress)
        {
            Channel = channel;
            ChannelId = channel.Id.AsLongText();
            CreateTime = DateTime.UtcNow;
            RemoteAddress = remoteAddress;
            LastAccessTime = CreateTime;

        }

        public async Task SendAsync(IPacket packet)
            => await Channel?.WriteAndFlushAsync(packet);


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                Channel?.CloseAsync();
            }
        }

        #region ToString()
        private string _localAddressString;
        public string LocalAddressString
        {
            get
            {
                if (string.IsNullOrEmpty(_localAddressString))
                    _localAddressString = Channel.LocalAddress.ToString().Replace("[::ffff:", "").Replace("]", "");
                return _localAddressString;
            }
        }
        private string _remoteAddressString;
        public string RemoteAddressString
        {
            get
            {
                if (string.IsNullOrEmpty(_remoteAddressString))
                    _remoteAddressString = Channel.RemoteAddress.ToString().Replace("[::ffff:", "").Replace("]", "");
                return _remoteAddressString;
            }
        }
        #endregion 
    }

    /// <summary>
    /// 获取用户标识接口
    /// 存储在IChannel的AttributeMap中的用户信息
    /// </summary>
    public interface IUserIdGetter
    {
        string GetUserId();
    }

    public class DefaultSessionUserInfo : IUserIdGetter
    {
        public string UserId { get; set; }

        public string GetUserId() => UserId;
    }
}

using DotNetty.Transport.Channels;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;

namespace TinyFx.Extensions.DotNetty
{
    public class AppSessionContainer
    {
        public static readonly AppSessionContainer Instance = new AppSessionContainer();
        private ConcurrentDictionary<IChannelId, AppSession> _connSessions = new ConcurrentDictionary<IChannelId, AppSession>();

        #region _connSessions
        public bool Contains(IChannelId channelId) 
            => _connSessions.ContainsKey(channelId);
        public AppSession AddOrUpdate(AppSession value)
            => _connSessions.AddOrUpdate(value.Channel.Id, value, (k, v) => value);
        public bool TryGet(IChannelId channelId, out AppSession value)
            => _connSessions.TryGetValue(channelId, out value);
        public AppSession Get(IChannelId channelId)
            => TryGet(channelId, out AppSession ret) ? ret : default;
        public bool Remove(IChannelId channelId)
            => _connSessions.TryRemove(channelId, out AppSession _);

        public IEnumerable<AppSession> Find(Predicate<AppSession> critera = null)
        {
            var enumtor = _connSessions.GetEnumerator();
            while (enumtor.MoveNext())
            {
                var ret = enumtor.Current.Value;
                if (critera == null || critera(ret))
                    yield return ret;
            }
        }
        #endregion
    }

}

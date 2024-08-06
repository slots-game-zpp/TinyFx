using Org.BouncyCastle.Asn1.Ocsp;
using Org.BouncyCastle.Bcpg;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyFx.Extensions.DotNetty.NettyInfoCommand;
using TinyFx.Net;

namespace TinyFx.Extensions.DotNetty
{
    public class WSClient : WebSocketClientEx
    {
        public event OnMessageDelegate OnMessage;
        public delegate void OnMessageDelegate(int cmdid, byte[] bodyData);
        private ConcurrentDictionary<int, byte[]> _rspDic = new ();
        public WSClient(string url) : base(url)
        {
            OnReceived += WSClient_OnReceived;
            OnError += WSClient_OnError;
        }

        private void WSClient_OnReceived(byte[] buffer)
        {
            byte[] ids = new byte[4];
            Array.Copy(buffer, ids, 4);
            var cmdid = BitConverter.ToInt32(ids.Reverse().ToArray());
            Array.Copy(buffer, 4, ids, 0, 4);
            var bodyLength = BitConverter.ToInt32(ids.Reverse().ToArray());
            byte[] data = null;
            if (bodyLength > 0)
            {
                data = new ArraySegment<byte>(buffer, 8, bodyLength).ToArray();
            }
            _rspDic.AddOrUpdate(cmdid, data, (k, v) => data);
            OnMessage?.Invoke(cmdid, data);
        }
        private void WSClient_OnError(Exception exc)
        {
        }

        public Task SendAsync(int cmdid, object data)
        {
            using MemoryStream ms = new MemoryStream();
            ms.Write(BitConverter.GetBytes(cmdid).Reverse().ToArray());
            if (data == null)
            {
                ms.Write(BitConverter.GetBytes(0));
            }
            else
            {
                using (var ms2 = new MemoryStream())
                {
                    ProtoBuf.Serializer.NonGeneric.Serialize(ms2, data);
                    var body = ms2.ToArray();
                    ms.Write(BitConverter.GetBytes(body.Length).Reverse().ToArray());
                    ms.Write(body, 0, body.Length);
                }
            }
            return SendAsync(ms.ToArray());
        }
        public ProtoResponse<TRsp> Send<TRsp>(int cmdid, object data)
        {
            _rspDic.AddOrUpdate(cmdid, (byte[])null, (k, v) => null);
            SendAsync(cmdid,data).Wait();
            int tryCount = 25;
            while (tryCount > 0)
            {
                var rspData = _rspDic[cmdid];
                if (rspData != null)
                {
                    return Deserialize<TRsp>(rspData);
                }
                tryCount--;
                Thread.Sleep(200);
            }
            
            throw new Exception("WSClient.Send超时");
        }
        public ProtoResponse<T> Deserialize<T>(byte[] bodyData)
        {
            return (ProtoResponse<T>)ProtoBuf.Serializer.NonGeneric.Deserialize(typeof(ProtoResponse<T>)
                    , new ReadOnlyMemory<byte>(bodyData));
        }
    }
}

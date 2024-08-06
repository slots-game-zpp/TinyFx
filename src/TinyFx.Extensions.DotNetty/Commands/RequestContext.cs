using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TinyFx.Extensions.DotNetty
{
    public class RequestContext
    {
        public AppSession Session { get; set; }
        public IPacket Packet { get; set; }
        public string UserId => Session?.UserId;
    }
    /*
    public class RequestContext<T>
    {
        public AppSession Session { get; set; }
        public IPacket Packet { get; set; }
        public string UserId => Session.UserId;
        public T Request => (T)Packet.Body;

        public RequestContext(RequestContext ctx)
        {
            Session = ctx.Session;
            Packet = ctx.Packet;
        }
        public static implicit operator RequestContext<T>(RequestContext value)
        {
            return new RequestContext<T>(value);
        }
    }*/
}

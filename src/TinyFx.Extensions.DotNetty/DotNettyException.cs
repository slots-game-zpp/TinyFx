using System;
using System.Collections.Generic;
using System.Text;

namespace TinyFx.Extensions.DotNetty
{
    public class DotNettyException:Exception
    {
        public DotNettyException() : base() { }
        public DotNettyException(string msg) : base(msg) { }
    }
}

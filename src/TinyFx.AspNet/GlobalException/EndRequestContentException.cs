using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinyFx.AspNet
{
    public class EndRequestContentException : CustomException
    {
        public EndRequestContentException(string message) : base(message)
        {
        }
    }
}

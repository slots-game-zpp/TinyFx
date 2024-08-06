using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinyFx.Randoms
{
    public class RandomException : Exception
    {
        public RandomException(string msg) : base(msg)
        { }
    }
}

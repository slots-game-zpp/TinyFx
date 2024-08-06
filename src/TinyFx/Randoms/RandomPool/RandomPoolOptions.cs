using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinyFx.Randoms
{
    public class RandomPoolOptions
    {
        public bool UseRNGWhenException { get; set; } = true;
        public int IntBufferSize { get; set; } = 8192;
        public int ByteBufferSize { get; set; } = 8192;// IDQ最大36864
        public int Timeout { get; set; } = 3000;
        public int CheckInterval { get; set; } = 1000;
    }
}

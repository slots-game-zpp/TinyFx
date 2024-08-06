using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinyFx.Randoms
{
    public interface ISamplingContainer : IDisposable
    {
        void AddRandom(int min, int max, params byte[] rnds);
        void AddRandom(int min, int max, params int[] rnds);
        void AddNotRepeat(int range, int size, params int[] rnds);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinyFx.Randoms
{
    /// <summary>
    /// 随机数缓冲池
    /// </summary>
    public class RandomPool : RandomPoolBase
    {
        /// <summary>
        /// 构造函数。默认使用RNGReader
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="options"></param>
        public RandomPool(IRandomReader reader = null, RandomPoolOptions options = null) : base(options)
        {
            Reader = reader ?? new RNGReader();
        }
        public override void Dispose()
        {
            base.Dispose();
            Reader.Dispose();
        }
    }
}

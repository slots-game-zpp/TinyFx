using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinyFx.Caching
{
    /// <summary>
    /// 缓存项未找到
    /// </summary>
    public class CacheNotFound : Exception
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="message"></param>
        public CacheNotFound(string message) : base(message) { }
    }
}

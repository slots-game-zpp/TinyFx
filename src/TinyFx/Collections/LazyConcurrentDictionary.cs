using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TinyFx.Collections
{
    public class LazyConcurrentDictionary<TKey, TValue>
    {
        private readonly ConcurrentDictionary<TKey, Lazy<TValue>> _dict;

        public LazyConcurrentDictionary()
        {
            _dict = new ConcurrentDictionary<TKey, Lazy<TValue>>();
        }

        public TValue GetOrAdd(TKey key, Func<TKey, TValue> valueFactory)
        {
            var ret = _dict.GetOrAdd(key, k => 
            {
                return new Lazy<TValue>(() => valueFactory(k), LazyThreadSafetyMode.ExecutionAndPublication);
            });
            return ret.Value;
        }
        public bool TryRemove(TKey key)
        {
            Lazy<TValue> value;
            var lazyResult = this._dict.TryRemove(key, out value);
            return lazyResult;
        }
    }
}

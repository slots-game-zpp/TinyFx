using Com.Ctrip.Framework.Apollo.Core.Utils;
using Com.Ctrip.Framework.Apollo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyFx.Caching;

namespace TinyFx.Extensions.Apollo
{
    public class ApolloCacheMyProvider : ICacheFileProvider
    {
        public Properties Get(string configFile)
        {
            var key = $"APOLLO_CACHE_{Path.GetFileName(configFile)}";
            return CachingUtil.GetOrDefault<Properties>(key, null);
        }

        public void Save(string configFile, Properties properties)
        {
            var key = $"APOLLO_CACHE_{Path.GetFileName(configFile)}";
            CachingUtil.Set(key, properties);
        }
    }

}

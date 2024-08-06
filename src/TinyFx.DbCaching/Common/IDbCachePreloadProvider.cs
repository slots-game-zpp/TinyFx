using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinyFx.DbCaching
{
    public interface IDbCachePreloadProvider
    {
        List<DbCachePreloadItem> GetPreloadList();
    }
    public class DbCachePreloadItem
    {
        public Type EntityType { get; set; }
        public object SplitDbKey { get; set; }
        public DbCachePreloadItem(Type entityType, object splitDbKey = null)
        {
            EntityType = entityType;
            SplitDbKey = splitDbKey;
        }
    }
}

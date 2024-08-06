using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyFx.Configuration;

namespace TinyFx.Data.SqlSugar
{
    public interface IDbConfigProvider
    {
        ConnectionElement GetConfig(string configId);
    }
    public class DefaultDbConfigProvider : IDbConfigProvider
    {
        public ConnectionElement GetConfig(string configId = null)
        {
            var section = ConfigUtil.GetSection<SqlSugarSection>();
            if (section != null)
            {
                configId ??= section.DefaultConnectionStringName;
                if (section.ConnectionStrings.TryGetValue(configId, out var ret))
                    return ret;
            }
            return null;
        }
    }
}

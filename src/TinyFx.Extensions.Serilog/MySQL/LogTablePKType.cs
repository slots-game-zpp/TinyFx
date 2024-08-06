using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinyFx.Extensions.Serilog.MySQL
{
    public enum LogTablePKType
    {
        Guid = 0,
        Identity = 1,
        Snowflake = 2
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinyFx.SnowflakeId.Common
{
    internal interface IWorkerIdProvider
    {
        Task<int> GetNextWorkId();
        Task Active();
        Task Dispose();
    }
}

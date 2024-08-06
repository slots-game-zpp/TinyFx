using Microsoft.Extensions.Logging;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinyFx.Data.SqlSugar
{
    public class ConnectionElement : ConnectionConfig
    {
        /// <summary>
        /// 定义映射到此连接的命名空间，逗号分割
        /// </summary>
        public string MappingNamespaces { get; set; }
        /// <summary>
        /// 是否开启日志
        /// </summary>
        public bool LogEnabled { get; set; }
        public LogLevel LogLevel { get; set; } = LogLevel.Debug;
        /// <summary>
        /// SQL日志模式0-默认 1-原生 2-无参数化
        /// </summary>
        public int LogSqlMode { get; set; }
        /// <summary>
        /// 是否使用读写分离
        /// </summary>
        public bool SlaveEnabled { get; set; }
    }
}

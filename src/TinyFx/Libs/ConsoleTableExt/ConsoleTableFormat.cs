﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinyFx.ConsoleTableExt
{
    public class ConsoleTableFormat
    {
        /// <summary>
        /// 标题
        /// </summary>
        public string Header { get; set; }
        /// <summary>
        /// 最小宽度
        /// </summary>
        public int MinLength { get; set; }
        /// <summary>
        /// 对齐方式
        /// </summary>
        public TextAligntment TextAlign { get; set; }
    }
}

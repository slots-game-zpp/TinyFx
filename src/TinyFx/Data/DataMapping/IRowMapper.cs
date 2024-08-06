﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace TinyFx.Data
{
    /// <summary>
    /// 提供 IDataReader ==> Entity 映射接口
    /// </summary>
    public interface IRowMapper<T>
    {
        /// <summary>
        /// IDataReader到类型的映射方法
        /// </summary>
        /// <param name="reader">IDataReader对象</param>
        /// <returns></returns>
        T MapRow(IDataReader reader);
    }
}

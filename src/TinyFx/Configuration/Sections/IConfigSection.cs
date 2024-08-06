﻿using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using TinyFx.Reflection;

namespace TinyFx.Configuration
{
    /// <summary>
    /// tinyfx配置节接口
    /// </summary>
    public interface IConfigSection
    {
        /// <summary>
        /// 配置节名称
        /// </summary>
        string SectionName { get; }

        /// <summary>
        /// 绑定配置数据
        /// </summary>
        /// <param name="configuration"></param>
        void Bind(IConfiguration configuration);
    }
    /// <summary>
    /// tinyfx配置节基类
    /// </summary>
    public abstract class ConfigSection : IConfigSection
    {
        /// <summary>
        /// 配置节名称
        /// </summary>
        public abstract string SectionName { get; }
        
        /// <summary>
        /// 配置信息
        /// </summary>
        public IConfiguration Configuration { get; set; }

        /// <summary>
        /// 绑定配置数据
        /// </summary>
        /// <param name="configuration"></param>

        public virtual void Bind(IConfiguration configuration)
        {
            Configuration = configuration;
            configuration?.Bind(this);
        }
    }
}

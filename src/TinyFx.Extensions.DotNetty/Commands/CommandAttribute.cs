using System;
using System.Collections.Generic;
using System.Text;

namespace TinyFx.Extensions.DotNetty
{
    /// <summary>
    /// 定义Command的属性
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
    public class CommandAttribute: Attribute
    {
        public int Id { get; set; }
        public bool CheckLogin { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">0：自动设置CommandId</param>
        /// <param name="checkLogin">是否验证登录</param>
        public CommandAttribute(int id = 0, bool checkLogin = true)
        {
            Id = id;
            CheckLogin = checkLogin;
        }
    }
}

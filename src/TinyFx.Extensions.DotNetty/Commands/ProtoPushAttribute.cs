using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TinyFx.Extensions.DotNetty
{
    /// <summary>
    /// 定义proto返回结构和是否为服务器推送proto
    /// </summary>
    public class ProtoPushAttribute : Attribute
    {
        public int CommandId { get; set; }
        public string CommandName { get; set; }

        public ProtoPushAttribute(int commandId = 0, string commandName = null)
        {
            CommandId = commandId;
            CommandName = commandName;
        }
    }

}

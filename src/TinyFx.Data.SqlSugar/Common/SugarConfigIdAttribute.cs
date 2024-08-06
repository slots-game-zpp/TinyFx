using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinyFx.Data.SqlSugar
{
    [AttributeUsage(AttributeTargets.Class, Inherited = true)]
    public class SugarConfigIdAttribute: Attribute
    {
        public string ConfigId { get; set; }
        public SugarConfigIdAttribute(string configId=null) 
        {
            ConfigId = configId;
        }
    }
}

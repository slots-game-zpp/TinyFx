using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinyFx
{
    public class EnumMapAttribute:Attribute
    {
        public string MapName { get; set; }
        public EnumMapAttribute(string mapName) 
        {
            MapName = mapName;
        }
    }
}

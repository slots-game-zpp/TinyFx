using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinyFx.Extensions.AWS
{
    public class LoadBalancingElement
    {
        public bool RegisterTargetGroup { get; set; }
        public string TargetGroupName { get; set; }
    }
}

using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinyFx.AspNet
{
    public class IgnoreActionFilterAttribute : Attribute
    {
        internal const string ITEM_NAME = "IgnoreActionFilter";
        internal static bool CheckIgnore(HttpContext context)
            => context.Items.ContainsKey(ITEM_NAME);
    }
}

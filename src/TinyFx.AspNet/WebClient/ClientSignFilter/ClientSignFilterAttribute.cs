using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyFx.Configuration;
using TinyFx.Logging;
using TinyFx.Net;

namespace TinyFx.AspNet
{
    /// <summary>
    /// 自有客户端访问API时的sign验证器
    /// </summary>
    public class ClientSignFilterAttribute : Attribute, IAsyncActionFilter
    {
        private ClientSignFilterService _verifySvc;
        public ClientSignFilterAttribute(string name = null)
        {
            _verifySvc = new ClientSignFilterService(name);
        }
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            await _verifySvc.VerifyHeaderSignByAccessKey(context.HttpContext);
            await next.Invoke();
        }
    }
}

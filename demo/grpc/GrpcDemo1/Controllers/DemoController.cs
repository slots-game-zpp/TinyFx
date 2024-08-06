using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TinyFx.AspNet;
using TinyFx.Configuration;

namespace GrpcDemo1.Controllers
{
    public class DemoController : TinyFxControllerBase
    {
        [AllowAnonymous]
        [HttpGet]
        public string Get()
        {
            return ConfigUtil.Service.ServiceId;
        }
    }
}

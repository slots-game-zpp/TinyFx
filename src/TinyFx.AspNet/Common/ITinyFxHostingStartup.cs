using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinyFx.AspNet
{
    public interface ITinyFxHostingStartup
    {
        void ConfigureServices(WebApplicationBuilder builder);
        void Configure(WebApplication app);
    }
}

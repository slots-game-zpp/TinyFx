using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinyFx.AspNet
{
    public interface ICorsPoliciesProvider
    {
        List<CorsPolicyElement> GetPolicies();
        void SetAutoRefresh();
    }
}

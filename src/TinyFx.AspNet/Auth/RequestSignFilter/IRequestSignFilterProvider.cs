using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyFx.Configuration;

namespace TinyFx.AspNet
{
    public interface IRequestSignFilterProvider
    {
        List<RequestSignFilterElement> Build();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyFx.Configuration;

namespace TinyFx.OAuth
{
    public interface IOAuthProvidersProvider
    {
        Task<Dictionary<string, OAuthProviderElement>> GetProvidersAsync();
    }
}

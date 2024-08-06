using System.Net;

namespace TinyFx.IP2Country.Entities
{
    internal interface IIPRangeCountry
    {
        IPAddress Start { get; set; }
        IPAddress End { get; set; }
        string Country { get; set; }
    }
}

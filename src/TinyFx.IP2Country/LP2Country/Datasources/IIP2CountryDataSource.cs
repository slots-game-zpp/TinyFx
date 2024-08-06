using TinyFx.IP2Country.Entities;
using System.Collections.Generic;

namespace TinyFx.IP2Country.Datasources
{
    internal interface IIP2CountryDataSource
    {
        IEnumerable<IIPRangeCountry> Read();
    }
}

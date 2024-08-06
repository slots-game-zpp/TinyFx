using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using TinyFx.IP2Country.DataSources.CSVFile;
using TinyFx.IP2Country.DbIp;
using TinyFx.IP2Country.Entities;

namespace TinyFx.IP2Country
{
    internal class DbIpCSVStreamSource : IP2CountryCSVStreamSource<DbIpIPRangeCountry>
    {
        public DbIpCSVStreamSource(Stream stream)
            : base(stream, new DbIpCSVRecordParser()) { }

        public override IEnumerable<IIPRangeCountry> Read() => ReadStream(Stream, Parser);
    }
}

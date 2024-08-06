using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDBug
{
    internal class BugCurrencyChange
    {
        public async Task Execute()
        {
            var writeConn = "server=my-ing.cluster-cvn4awncphwh.us-west-2.rds.amazonaws.com;port=3306;database=ing;uid=admin;pwd=jfjptKzEg2JRMsnp3Xud0;sslmode=Disabled;allowuservariables=True;AllowLoadLocalInfile=true;ConnectionTimeout=120;ConnectionLifeTime=500";
            var readConn = "server=my-ing.cluster-ro-cvn4awncphwh.us-west-2.rds.amazonaws.com;port=3306;database=ing;user id=admin;password=jfjptKzEg2JRMsnp3Xud0;Allow User Variables=True;sslmode=Disabled;ConnectionTimeout=120;ConnectionLifeTime=500;MaximumPoolSize=500";
        }
    }
}

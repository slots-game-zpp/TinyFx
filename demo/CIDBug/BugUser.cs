using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xxyy.DAL;

namespace CIDBug
{
    internal class BugUser
    {
        public async Task Execute()
        {
            var conn = "server=my-ing.cluster-cvn4awncphwh.us-west-2.rds.amazonaws.com;port=3306;database=ing;uid=admin;pwd=jfjptKzEg2JRMsnp3Xud0;sslmode=Disabled;allowuservariables=True;AllowLoadLocalInfile=true;ConnectionTimeout=120;ConnectionLifeTime=500";
            var userMo = new S_userMO(conn, 180);
            var userDayMo = new S_user_dayMO(conn, 180);
            var channelMo = new S_channelMO(conn, 180);
            var cids = channelMo.GetAll().Select(x => x.ChannelID).ToHashSet();

            var list = await userMo.GetAsync("recdate>='2024-01-02 03:00:00' and fromid=OperatorID and ClientUrl like '%cid=%'");
            Console.WriteLine(list.Count);
            int i = 0;
            var tasks = new List<Task>();
            foreach (var item in list)
            {
                Console.WriteLine(++i);
                var cid = GetCid(item.ClientUrl);
                if (string.IsNullOrEmpty(cid) || !cids.Contains(cid))
                    continue;
                var dayId = item.RecDate.AddHours(-3);
                var t1 = userMo.PutByPKAsync(item.UserID, $"fromMode=2,fromid='{cid}'");
                var t2 = userDayMo.PutByPKAsync(dayId, item.UserID, $"fromMode=2,fromid='{cid}'");
                tasks.Add(t1);
                tasks.Add(t2);
                if (tasks.Count >= 100)
                {
                    Task.WaitAll(tasks.ToArray());
                    tasks.Clear();
                }
            }
        }
        string GetCid(string str)
        {
            var idx = str.IndexOf("cid=");
            str = str.Substring(idx + 4);
            idx = str.IndexOf('&');
            if (idx > 0)
                str = str.Substring(0, idx);
            return str;
        }
    }
}

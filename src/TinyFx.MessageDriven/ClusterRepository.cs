using System.Collections.Generic;
using System.Threading.Tasks;
using TinyFx.Data.SqlSugar;

namespace TinyFx.MessageDriven;

class ClusterRepository
{
    public async Task<(List<Cluster>, List<Binding>)> GetClusterInfo(List<string> clusterIds)
    {
        using var sqlSugar = DbUtil.GetDb();
        var clusters = await sqlSugar.Queryable<Cluster>()
            .Where(f => clusterIds.Contains(f.ClusterId))
            .ToListAsync();
        var bindings = await sqlSugar.Queryable<Binding>()
            .Where(f => clusterIds.Contains(f.ClusterId))
            .ToListAsync();
        return (clusters, bindings);
    }
    public async Task<int> Register(List<Cluster> clusters)
    {
        using var sqlSugar = DbUtil.GetDb();
        return await sqlSugar.Insertable(clusters)
            .ExecuteCommandAsync();
    }
    public async Task<int> Register(List<Binding> bindings)
    {
        using var sqlSugar = DbUtil.GetDb();
        return await sqlSugar.Insertable(bindings)
            .ExecuteCommandAsync();
    }
    public async Task AddLogs(List<ExecLog> logInfos)
    {
        using var sqlSugar = DbUtil.GetDb();
        await sqlSugar.Insertable<ExecLog>(logInfos)
            .ExecuteCommandAsync();
    }
}

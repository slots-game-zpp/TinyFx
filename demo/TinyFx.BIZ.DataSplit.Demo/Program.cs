using Microsoft.AspNetCore.Http;
using TinyFx;
using TinyFx.BIZ.DataSplit;
using TinyFx.BIZ.DataSplit.DAL;
using TinyFx.Security;
using TinyFx.Text;

TinyFxHost.Start();

await new DemoHelper().InitData();

//
var list = new List<S_split_tablePO>
{
    new S_split_tablePO()
    {
        DatabaseId = "default",
        TableName = "demo_tfx_split",
        HandleMode = (int)HandleMode.MaxRows,
        ColumnType = (int)ColumnType.ObjectId,
        ColumnName = "ObjectId",
        MoveKeepMode = (int)MoveKeepMode.None,
        MoveKeepValue = 0,
        MoveTableMode = (int)MoveTableMode.None,
        MoveWhere = null,
        MaxRowCount = 100,
        MaxRowInterval = 2
    },
};
await new DataSplitJob().Execute(list);

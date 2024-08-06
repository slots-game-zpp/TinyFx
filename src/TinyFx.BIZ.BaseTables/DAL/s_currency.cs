using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace TinyFx.BIZ.BaseTables
{
    ///<summary>
    ///货币定义大写 ISO 4217
    ///</summary>
    [SugarTable("s_currency")]
    public partial class S_currencyPO
    {
           public S_currencyPO(){

            this.UnitNum =2;
            this.CurrencyType =0;
            this.BaseUnit =10000.000000000000000000m;
            this.Status =0;

           }
           /// <summary>
           /// Desc:货币编码（ISO 4217大写3位）
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string CurrencyID {get;set;}

           /// <summary>
           /// Desc:货币数字编码（ISO 4217 3位）
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CurrencyCode {get;set;}

           /// <summary>
           /// Desc:商业货币编码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BizCurrencyID {get;set;}

           /// <summary>
           /// Desc:货币最小单位转换十进制的小数位数
           /// Default:2
           /// Nullable:False
           /// </summary>           
           public int UnitNum {get;set;}

           /// <summary>
           /// Desc:货币名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Name {get;set;}

           /// <summary>
           /// Desc:英文名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string EnName {get;set;}

           /// <summary>
           /// Desc:对应语言的名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string LangName {get;set;}

           /// <summary>
           /// Desc:货币类型
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int CurrencyType {get;set;}

           /// <summary>
           /// Desc:存储货币值时货币的转换系数（存储值=money*BaseUnit）
           /// Default:10000.000000000000000000
           /// Nullable:False
           /// </summary>           
           public decimal BaseUnit {get;set;}

           /// <summary>
           /// Desc:扩展
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Meta {get;set;}

           /// <summary>
           /// Desc:状态0-初始1-启用
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int Status {get;set;}

    }
}

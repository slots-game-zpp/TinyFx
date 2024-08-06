using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace TinyFx.BIZ.BaseTables
{
    ///<summary>
    ///国家编码ISO 3166-1三位字母大写 USA
    ///</summary>
    [SugarTable("s_country")]
    public partial class S_countryPO
    {
           public S_countryPO(){

            this.TimeZone =0;
            this.Status =0;

           }
           /// <summary>
           /// Desc:国家编码3位大写（ISO 3166-1）
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string CountryID {get;set;}

           /// <summary>
           /// Desc:国家编码2位大写（ISO 3166-1）
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CountryID2 {get;set;}

           /// <summary>
           /// Desc:国家数字编码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CountryCode {get;set;}

           /// <summary>
           /// Desc:商业国家编码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BizCountryID {get;set;}

           /// <summary>
           /// Desc:中文国家名称
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
           /// Desc:国际电话区号不带+号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CallingCode {get;set;}

           /// <summary>
           /// Desc:主货币编码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CurrencyID {get;set;}

           /// <summary>
           /// Desc:默认国家时区
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int TimeZone {get;set;}

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

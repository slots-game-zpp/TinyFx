using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace TinyFx.BIZ.BaseTables
{
    ///<summary>
    ///域名
    ///</summary>
    [SugarTable("s_domain")]
    public partial class S_domainPO
    {
           public S_domainPO(){

            this.IsCors =true;
            this.Status =0;
            this.RecDate =DateTime.Now;

           }
           /// <summary>
           /// Desc:二级域名
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string DomainID {get;set;}

           /// <summary>
           /// Desc:主域名
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string TopDomain {get;set;}

           /// <summary>
           /// Desc:中文名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Name {get;set;}

           /// <summary>
           /// Desc:是否跨域
           /// Default:1
           /// Nullable:False
           /// </summary>           
           public bool IsCors {get;set;}

           /// <summary>
           /// Desc:备注
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Note {get;set;}

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

           /// <summary>
           /// Desc:记录时间
           /// Default:CURRENT_TIMESTAMP
           /// Nullable:False
           /// </summary>           
           public DateTime RecDate {get;set;}

    }
}

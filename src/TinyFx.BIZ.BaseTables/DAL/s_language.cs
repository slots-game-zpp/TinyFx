using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace TinyFx.BIZ.BaseTables
{
    ///<summary>
    ///系统语言定义（ISO 639-1 中的小写双字母）
	/// zh-cn 简体中文和zh-tw繁体中文
    ///</summary>
    [SugarTable("s_language")]
    public partial class S_languagePO
    {
           public S_languagePO(){

            this.Status =0;

           }
           /// <summary>
           /// Desc:语言代码2位小写（ISO 639-1 ）
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string LangID {get;set;}

           /// <summary>
           /// Desc:语言代码3位小写
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string LangID3 {get;set;}

           /// <summary>
           /// Desc:商业语言编码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BizLangID {get;set;}

           /// <summary>
           /// Desc:中文名称
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

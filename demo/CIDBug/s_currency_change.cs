/******************************************************
 * 此代码由代码生成器工具自动生成，请不要修改
 * TinyFx代码生成器核心库版本号：1.0.0.0
 * git: https://github.com/jh98net/TinyFx
 * 文档生成时间：2023-12-29 15: 09:54
 ******************************************************/
using System;
using System.Data;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using TinyFx;
using TinyFx.Data;
using MySql.Data.MySqlClient;
using System.Text;
using TinyFx.Data.MySql;

namespace Xxyy.DAL
{
	#region EO
	/// <summary>
	/// 用户货币变化表（除s_provider_order,s_bank_order,s_operator_order以外的变化
	/// 【表 s_currency_change 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class S_currency_changeEO : IRowMapper<S_currency_changeEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public S_currency_changeEO()
		{
			this.FromMode = 0;
			this.UserKind = 1;
			this.CurrencyType = 0;
			this.IsBonus = false;
			this.FlowMultip = 0f;
			this.PlanAmount = 0;
			this.SourceType = 1;
			this.Status = 0;
			this.RecDate = DateTime.Now;
			this.Amount = 0;
			this.EndBalance = 0;
			this.AmountBonus = 0;
			this.EndBonus = 0;
			this.SettlStatus = 0;
			this.SettlAmount = 0;
		}
		#region 主键原始值 & 主键集合
	    
		/// <summary>
		/// 当前对象是否保存原始主键值，当修改了主键值时为 true
		/// </summary>
		public bool HasOriginal { get; protected set; }
		
		private string _originalChangeID;
		/// <summary>
		/// 【数据库中的原始主键 ChangeID 值的副本，用于主键值更新】
		/// </summary>
		public string OriginalChangeID
		{
			get { return _originalChangeID; }
			set { HasOriginal = true; _originalChangeID = value; }
		}
	    /// <summary>
	    /// 获取主键集合。key: 数据库字段名称, value: 主键值
	    /// </summary>
	    /// <returns></returns>
	    public Dictionary<string, object> GetPrimaryKeys()
	    {
	        return new Dictionary<string, object>() { { "ChangeID", ChangeID }, };
	    }
	    /// <summary>
	    /// 获取主键集合JSON格式
	    /// </summary>
	    /// <returns></returns>
	    public string GetPrimaryKeysJson() => SerializerUtil.SerializeJson(GetPrimaryKeys());
		#endregion // 主键原始值
		#region 所有字段
		/// <summary>
		/// 货币变化编码(GUID)
		/// 【主键 varchar(38)】
		/// </summary>
		[DataMember(Order = 1)]
		public string ChangeID { get; set; }
		/// <summary>
		/// 应用提供商编码
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 2)]
		public string ProviderID { get; set; }
		/// <summary>
		/// 应用编码
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 3)]
		public string AppID { get; set; }
		/// <summary>
		/// 运营商编码
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 4)]
		public string OperatorID { get; set; }
		/// <summary>
		/// 用户编码(GUID)
		/// 【字段 varchar(38)】
		/// </summary>
		[DataMember(Order = 5)]
		public string UserID { get; set; }
		/// <summary>
		/// 新用户来源方式
		///              0-获得运营商的新用户(s_operator)
		///              1-推广员获得的新用户（userid）
		///              2-推广渠道通过url获得的新用户（s_channel_url)
		///              3-推广渠道通过code获得的新用户（s_channel_code)
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 6)]
		public int FromMode { get; set; }
		/// <summary>
		/// 对应的编码（根据FromMode变化）
		///              FromMode=
		///              0-运营商的新用户(s_operator)==> OperatorID
		///              1-推广员获得的新用户（userid） ==> 邀请人的UserID
		///              2-推广渠道通过url获得的新用户（s_channel_url) ==> CUrlID
		///              3-推广渠道通过code获得的新用户（s_channel_code) ==> CCodeID
		/// 【字段 varchar(100)】
		/// </summary>
		[DataMember(Order = 7)]
		public string FromId { get; set; }
		/// <summary>
		/// 用户类型
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 8)]
		public int UserKind { get; set; }
		/// <summary>
		/// 国家编码ISO 3166-1三位字母
		/// 【字段 varchar(5)】
		/// </summary>
		[DataMember(Order = 9)]
		public string CountryID { get; set; }
		/// <summary>
		/// 货币类型（货币缩写USD）
		/// 【字段 varchar(5)】
		/// </summary>
		[DataMember(Order = 10)]
		public string CurrencyID { get; set; }
		/// <summary>
		/// 货币类型 1-COIN 2--GOLD 3-POINT 4-SWB 8-虚拟货币 9-CASH
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 11)]
		public int CurrencyType { get; set; }
		/// <summary>
		/// 是否赠金
		/// 【字段 tinyint(1)】
		/// </summary>
		[DataMember(Order = 12)]
		public bool IsBonus { get; set; }
		/// <summary>
		/// 要求的流水系数
		/// 【字段 float】
		/// </summary>
		[DataMember(Order = 13)]
		public float FlowMultip { get; set; }
		/// <summary>
		/// 变化原因
		/// 【字段 varchar(255)】
		/// </summary>
		[DataMember(Order = 14)]
		public string Reason { get; set; }
		/// <summary>
		/// 计划变化金额（正负数）
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 15)]
		public long PlanAmount { get; set; }
		/// <summary>
		/// 扩展数据
		/// 【字段 text】
		/// </summary>
		[DataMember(Order = 16)]
		public string Meta { get; set; }
		/// <summary>
		/// 0-未知1-运营活动2
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 17)]
		public int SourceType { get; set; }
		/// <summary>
		/// 源表名
		/// 【字段 varchar(100)】
		/// </summary>
		[DataMember(Order = 18)]
		public string SourceTable { get; set; }
		/// <summary>
		/// 源表编码
		/// 【字段 varchar(100)】
		/// </summary>
		[DataMember(Order = 19)]
		public string SourceId { get; set; }
		/// <summary>
		/// 用户IP
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 20)]
		public string UserIp { get; set; }
		/// <summary>
		/// 状态0-初始1-处理中2-成功3-失败4-已回滚5-异常且需处理6-异常已处理
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 21)]
		public int Status { get; set; }
		/// <summary>
		/// 记录时间
		/// 【字段 datetime】
		/// </summary>
		[DataMember(Order = 22)]
		public DateTime RecDate { get; set; }
		/// <summary>
		/// 处理时间
		/// 【字段 datetime】
		/// </summary>
		[DataMember(Order = 23)]
		public DateTime? DealTime { get; set; }
		/// <summary>
		/// 处理状态数据
		/// 【字段 text】
		/// </summary>
		[DataMember(Order = 24)]
		public string DealStatus { get; set; }
		/// <summary>
		/// 实际金额（正负数）
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 25)]
		public long Amount { get; set; }
		/// <summary>
		/// 处理后余额
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 26)]
		public long EndBalance { get; set; }
		/// <summary>
		/// bonus实际变化数量（正负数）
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 27)]
		public long AmountBonus { get; set; }
		/// <summary>
		/// 处理后bonus余额
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 28)]
		public long EndBonus { get; set; }
		/// <summary>
		/// 结算状态（0-未结算1-已结算）
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 29)]
		public int SettlStatus { get; set; }
		/// <summary>
		/// 结算表名
		/// 【字段 varchar(100)】
		/// </summary>
		[DataMember(Order = 30)]
		public string SettlTable { get; set; }
		/// <summary>
		/// 结算编码
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 31)]
		public string SettlId { get; set; }
		/// <summary>
		/// 结算金额(正负数)
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 32)]
		public long SettlAmount { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public S_currency_changeEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static S_currency_changeEO MapDataReader(IDataReader reader)
		{
		    S_currency_changeEO ret = new S_currency_changeEO();
			ret.ChangeID = reader.ToString("ChangeID");
			ret.OriginalChangeID = ret.ChangeID;
			ret.ProviderID = reader.ToString("ProviderID");
			ret.AppID = reader.ToString("AppID");
			ret.OperatorID = reader.ToString("OperatorID");
			ret.UserID = reader.ToString("UserID");
			ret.FromMode = reader.ToInt32("FromMode");
			ret.FromId = reader.ToString("FromId");
			ret.UserKind = reader.ToInt32("UserKind");
			ret.CountryID = reader.ToString("CountryID");
			ret.CurrencyID = reader.ToString("CurrencyID");
			ret.CurrencyType = reader.ToInt32("CurrencyType");
			ret.IsBonus = reader.ToBoolean("IsBonus");
			ret.FlowMultip = reader.ToSingle("FlowMultip");
			ret.Reason = reader.ToString("Reason");
			ret.PlanAmount = reader.ToInt64("PlanAmount");
			ret.Meta = reader.ToString("Meta");
			ret.SourceType = reader.ToInt32("SourceType");
			ret.SourceTable = reader.ToString("SourceTable");
			ret.SourceId = reader.ToString("SourceId");
			ret.UserIp = reader.ToString("UserIp");
			ret.Status = reader.ToInt32("Status");
			ret.RecDate = reader.ToDateTime("RecDate");
			ret.DealTime = reader.ToDateTimeN("DealTime");
			ret.DealStatus = reader.ToString("DealStatus");
			ret.Amount = reader.ToInt64("Amount");
			ret.EndBalance = reader.ToInt64("EndBalance");
			ret.AmountBonus = reader.ToInt64("AmountBonus");
			ret.EndBonus = reader.ToInt64("EndBonus");
			ret.SettlStatus = reader.ToInt32("SettlStatus");
			ret.SettlTable = reader.ToString("SettlTable");
			ret.SettlId = reader.ToString("SettlId");
			ret.SettlAmount = reader.ToInt64("SettlAmount");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 用户货币变化表（除s_provider_order,s_bank_order,s_operator_order以外的变化
	/// 【表 s_currency_change 的操作类】
	/// </summary>
	[Obsolete]
	public class S_currency_changeMO : MySqlTableMO<S_currency_changeEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`s_currency_change`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public S_currency_changeMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public S_currency_changeMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public S_currency_changeMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(S_currency_changeEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(S_currency_changeEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(S_currency_changeEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`ChangeID`, `ProviderID`, `AppID`, `OperatorID`, `UserID`, `FromMode`, `FromId`, `UserKind`, `CountryID`, `CurrencyID`, `CurrencyType`, `IsBonus`, `FlowMultip`, `Reason`, `PlanAmount`, `Meta`, `SourceType`, `SourceTable`, `SourceId`, `UserIp`, `Status`, `RecDate`, `DealTime`, `DealStatus`, `Amount`, `EndBalance`, `AmountBonus`, `EndBonus`, `SettlStatus`, `SettlTable`, `SettlId`, `SettlAmount`) VALUE (@ChangeID, @ProviderID, @AppID, @OperatorID, @UserID, @FromMode, @FromId, @UserKind, @CountryID, @CurrencyID, @CurrencyType, @IsBonus, @FlowMultip, @Reason, @PlanAmount, @Meta, @SourceType, @SourceTable, @SourceId, @UserIp, @Status, @RecDate, @DealTime, @DealStatus, @Amount, @EndBalance, @AmountBonus, @EndBonus, @SettlStatus, @SettlTable, @SettlId, @SettlAmount);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChangeID", item.ChangeID, MySqlDbType.VarChar),
				Database.CreateInParameter("@ProviderID", item.ProviderID != null ? item.ProviderID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppID", item.AppID != null ? item.AppID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", item.OperatorID != null ? item.OperatorID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", item.UserID != null ? item.UserID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@FromMode", item.FromMode, MySqlDbType.Int32),
				Database.CreateInParameter("@FromId", item.FromId != null ? item.FromId : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserKind", item.UserKind, MySqlDbType.Int32),
				Database.CreateInParameter("@CountryID", item.CountryID != null ? item.CountryID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", item.CurrencyID != null ? item.CurrencyID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyType", item.CurrencyType, MySqlDbType.Int32),
				Database.CreateInParameter("@IsBonus", item.IsBonus, MySqlDbType.Byte),
				Database.CreateInParameter("@FlowMultip", item.FlowMultip, MySqlDbType.Float),
				Database.CreateInParameter("@Reason", item.Reason != null ? item.Reason : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@PlanAmount", item.PlanAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@Meta", item.Meta != null ? item.Meta : (object)DBNull.Value, MySqlDbType.Text),
				Database.CreateInParameter("@SourceType", item.SourceType, MySqlDbType.Int32),
				Database.CreateInParameter("@SourceTable", item.SourceTable != null ? item.SourceTable : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@SourceId", item.SourceId != null ? item.SourceId : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserIp", item.UserIp != null ? item.UserIp : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Status", item.Status, MySqlDbType.Int32),
				Database.CreateInParameter("@RecDate", item.RecDate, MySqlDbType.DateTime),
				Database.CreateInParameter("@DealTime", item.DealTime.HasValue ? item.DealTime.Value : (object)DBNull.Value, MySqlDbType.DateTime),
				Database.CreateInParameter("@DealStatus", item.DealStatus != null ? item.DealStatus : (object)DBNull.Value, MySqlDbType.Text),
				Database.CreateInParameter("@Amount", item.Amount, MySqlDbType.Int64),
				Database.CreateInParameter("@EndBalance", item.EndBalance, MySqlDbType.Int64),
				Database.CreateInParameter("@AmountBonus", item.AmountBonus, MySqlDbType.Int64),
				Database.CreateInParameter("@EndBonus", item.EndBonus, MySqlDbType.Int64),
				Database.CreateInParameter("@SettlStatus", item.SettlStatus, MySqlDbType.Int32),
				Database.CreateInParameter("@SettlTable", item.SettlTable != null ? item.SettlTable : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@SettlId", item.SettlId != null ? item.SettlId : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@SettlAmount", item.SettlAmount, MySqlDbType.Int64),
			};
		}
		public int AddByBatch(IEnumerable<S_currency_changeEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<S_currency_changeEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<S_currency_changeEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`ChangeID`, `ProviderID`, `AppID`, `OperatorID`, `UserID`, `FromMode`, `FromId`, `UserKind`, `CountryID`, `CurrencyID`, `CurrencyType`, `IsBonus`, `FlowMultip`, `Reason`, `PlanAmount`, `Meta`, `SourceType`, `SourceTable`, `SourceId`, `UserIp`, `Status`, `RecDate`, `DealTime`, `DealStatus`, `Amount`, `EndBalance`, `AmountBonus`, `EndBonus`, `SettlStatus`, `SettlTable`, `SettlId`, `SettlAmount`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"('{item.ChangeID}','{item.ProviderID}','{item.AppID}','{item.OperatorID}','{item.UserID}',{item.FromMode},'{item.FromId}',{item.UserKind},'{item.CountryID}','{item.CurrencyID}',{item.CurrencyType},{item.IsBonus},{item.FlowMultip},'{item.Reason}',{item.PlanAmount},'{item.Meta}',{item.SourceType},'{item.SourceTable}','{item.SourceId}','{item.UserIp}',{item.Status},'{item.RecDate.ToString("yyyy-MM-dd HH:mm:ss")}','{item.DealTime?.ToString("yyyy-MM-dd HH:mm:ss")}','{item.DealStatus}',{item.Amount},{item.EndBalance},{item.AmountBonus},{item.EndBonus},{item.SettlStatus},'{item.SettlTable}','{item.SettlId}',{item.SettlAmount}),");
				if (count == batchCount)
				{
					count = 0;
					sql.Insert(0, insertSql);
					var ret = sql.ToString().TrimEnd(',');
					sql.Clear();
	                yield return ret;
				}
			}
			if (sql.Length > 0)
			{
	            sql.Insert(0, insertSql);
	            yield return sql.ToString().TrimEnd(',');
	        }
	    }
	    #endregion // Add
	    
		#region Remove
		#region RemoveByPK
		/// <summary>
		/// 按主键删除
		/// </summary>
		/// /// <param name = "changeID">货币变化编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(string changeID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(changeID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(string changeID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(changeID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(string changeID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `ChangeID` = @ChangeID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChangeID", changeID, MySqlDbType.VarChar),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(S_currency_changeEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.ChangeID, tm_);
		}
		public async Task<int> RemoveAsync(S_currency_changeEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.ChangeID, tm_);
		}
		#endregion // RemoveByPK
		
		#region RemoveByXXX
		#region RemoveByProviderID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "providerID">应用提供商编码</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByProviderID(string providerID, TransactionManager tm_ = null)
		{
			RepairRemoveByProviderIDData(providerID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByProviderIDAsync(string providerID, TransactionManager tm_ = null)
		{
			RepairRemoveByProviderIDData(providerID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByProviderIDData(string providerID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (providerID != null ? "`ProviderID` = @ProviderID" : "`ProviderID` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (providerID != null)
				paras_.Add(Database.CreateInParameter("@ProviderID", providerID, MySqlDbType.VarChar));
		}
		#endregion // RemoveByProviderID
		#region RemoveByAppID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByAppID(string appID, TransactionManager tm_ = null)
		{
			RepairRemoveByAppIDData(appID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByAppIDAsync(string appID, TransactionManager tm_ = null)
		{
			RepairRemoveByAppIDData(appID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByAppIDData(string appID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (appID != null ? "`AppID` = @AppID" : "`AppID` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (appID != null)
				paras_.Add(Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar));
		}
		#endregion // RemoveByAppID
		#region RemoveByOperatorID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByOperatorID(string operatorID, TransactionManager tm_ = null)
		{
			RepairRemoveByOperatorIDData(operatorID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByOperatorIDAsync(string operatorID, TransactionManager tm_ = null)
		{
			RepairRemoveByOperatorIDData(operatorID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByOperatorIDData(string operatorID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (operatorID != null ? "`OperatorID` = @OperatorID" : "`OperatorID` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (operatorID != null)
				paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
		}
		#endregion // RemoveByOperatorID
		#region RemoveByUserID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByUserID(string userID, TransactionManager tm_ = null)
		{
			RepairRemoveByUserIDData(userID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByUserIDAsync(string userID, TransactionManager tm_ = null)
		{
			RepairRemoveByUserIDData(userID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByUserIDData(string userID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (userID != null ? "`UserID` = @UserID" : "`UserID` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (userID != null)
				paras_.Add(Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar));
		}
		#endregion // RemoveByUserID
		#region RemoveByFromMode
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "fromMode">新用户来源方式</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByFromMode(int fromMode, TransactionManager tm_ = null)
		{
			RepairRemoveByFromModeData(fromMode, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByFromModeAsync(int fromMode, TransactionManager tm_ = null)
		{
			RepairRemoveByFromModeData(fromMode, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByFromModeData(int fromMode, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `FromMode` = @FromMode";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FromMode", fromMode, MySqlDbType.Int32));
		}
		#endregion // RemoveByFromMode
		#region RemoveByFromId
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "fromId">对应的编码（根据FromMode变化）</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByFromId(string fromId, TransactionManager tm_ = null)
		{
			RepairRemoveByFromIdData(fromId, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByFromIdAsync(string fromId, TransactionManager tm_ = null)
		{
			RepairRemoveByFromIdData(fromId, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByFromIdData(string fromId, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (fromId != null ? "`FromId` = @FromId" : "`FromId` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (fromId != null)
				paras_.Add(Database.CreateInParameter("@FromId", fromId, MySqlDbType.VarChar));
		}
		#endregion // RemoveByFromId
		#region RemoveByUserKind
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "userKind">用户类型</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByUserKind(int userKind, TransactionManager tm_ = null)
		{
			RepairRemoveByUserKindData(userKind, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByUserKindAsync(int userKind, TransactionManager tm_ = null)
		{
			RepairRemoveByUserKindData(userKind, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByUserKindData(int userKind, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `UserKind` = @UserKind";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserKind", userKind, MySqlDbType.Int32));
		}
		#endregion // RemoveByUserKind
		#region RemoveByCountryID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByCountryID(string countryID, TransactionManager tm_ = null)
		{
			RepairRemoveByCountryIDData(countryID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByCountryIDAsync(string countryID, TransactionManager tm_ = null)
		{
			RepairRemoveByCountryIDData(countryID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByCountryIDData(string countryID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (countryID != null ? "`CountryID` = @CountryID" : "`CountryID` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (countryID != null)
				paras_.Add(Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar));
		}
		#endregion // RemoveByCountryID
		#region RemoveByCurrencyID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "currencyID">货币类型（货币缩写USD）</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByCurrencyID(string currencyID, TransactionManager tm_ = null)
		{
			RepairRemoveByCurrencyIDData(currencyID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByCurrencyIDAsync(string currencyID, TransactionManager tm_ = null)
		{
			RepairRemoveByCurrencyIDData(currencyID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByCurrencyIDData(string currencyID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (currencyID != null ? "`CurrencyID` = @CurrencyID" : "`CurrencyID` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (currencyID != null)
				paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
		}
		#endregion // RemoveByCurrencyID
		#region RemoveByCurrencyType
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "currencyType">货币类型 1-COIN 2--GOLD 3-POINT 4-SWB 8-虚拟货币 9-CASH</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByCurrencyType(int currencyType, TransactionManager tm_ = null)
		{
			RepairRemoveByCurrencyTypeData(currencyType, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByCurrencyTypeAsync(int currencyType, TransactionManager tm_ = null)
		{
			RepairRemoveByCurrencyTypeData(currencyType, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByCurrencyTypeData(int currencyType, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `CurrencyType` = @CurrencyType";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CurrencyType", currencyType, MySqlDbType.Int32));
		}
		#endregion // RemoveByCurrencyType
		#region RemoveByIsBonus
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "isBonus">是否赠金</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByIsBonus(bool isBonus, TransactionManager tm_ = null)
		{
			RepairRemoveByIsBonusData(isBonus, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByIsBonusAsync(bool isBonus, TransactionManager tm_ = null)
		{
			RepairRemoveByIsBonusData(isBonus, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByIsBonusData(bool isBonus, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `IsBonus` = @IsBonus";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IsBonus", isBonus, MySqlDbType.Byte));
		}
		#endregion // RemoveByIsBonus
		#region RemoveByFlowMultip
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "flowMultip">要求的流水系数</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByFlowMultip(float flowMultip, TransactionManager tm_ = null)
		{
			RepairRemoveByFlowMultipData(flowMultip, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByFlowMultipAsync(float flowMultip, TransactionManager tm_ = null)
		{
			RepairRemoveByFlowMultipData(flowMultip, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByFlowMultipData(float flowMultip, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `FlowMultip` = @FlowMultip";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FlowMultip", flowMultip, MySqlDbType.Float));
		}
		#endregion // RemoveByFlowMultip
		#region RemoveByReason
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "reason">变化原因</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByReason(string reason, TransactionManager tm_ = null)
		{
			RepairRemoveByReasonData(reason, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByReasonAsync(string reason, TransactionManager tm_ = null)
		{
			RepairRemoveByReasonData(reason, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByReasonData(string reason, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (reason != null ? "`Reason` = @Reason" : "`Reason` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (reason != null)
				paras_.Add(Database.CreateInParameter("@Reason", reason, MySqlDbType.VarChar));
		}
		#endregion // RemoveByReason
		#region RemoveByPlanAmount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "planAmount">计划变化金额（正负数）</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPlanAmount(long planAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByPlanAmountData(planAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPlanAmountAsync(long planAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByPlanAmountData(planAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByPlanAmountData(long planAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `PlanAmount` = @PlanAmount";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PlanAmount", planAmount, MySqlDbType.Int64));
		}
		#endregion // RemoveByPlanAmount
		#region RemoveByMeta
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "meta">扩展数据</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByMeta(string meta, TransactionManager tm_ = null)
		{
			RepairRemoveByMetaData(meta, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByMetaAsync(string meta, TransactionManager tm_ = null)
		{
			RepairRemoveByMetaData(meta, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByMetaData(string meta, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (meta != null ? "`Meta` = @Meta" : "`Meta` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (meta != null)
				paras_.Add(Database.CreateInParameter("@Meta", meta, MySqlDbType.Text));
		}
		#endregion // RemoveByMeta
		#region RemoveBySourceType
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "sourceType">0-未知1-运营活动2</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveBySourceType(int sourceType, TransactionManager tm_ = null)
		{
			RepairRemoveBySourceTypeData(sourceType, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveBySourceTypeAsync(int sourceType, TransactionManager tm_ = null)
		{
			RepairRemoveBySourceTypeData(sourceType, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveBySourceTypeData(int sourceType, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `SourceType` = @SourceType";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@SourceType", sourceType, MySqlDbType.Int32));
		}
		#endregion // RemoveBySourceType
		#region RemoveBySourceTable
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "sourceTable">源表名</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveBySourceTable(string sourceTable, TransactionManager tm_ = null)
		{
			RepairRemoveBySourceTableData(sourceTable, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveBySourceTableAsync(string sourceTable, TransactionManager tm_ = null)
		{
			RepairRemoveBySourceTableData(sourceTable, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveBySourceTableData(string sourceTable, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (sourceTable != null ? "`SourceTable` = @SourceTable" : "`SourceTable` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (sourceTable != null)
				paras_.Add(Database.CreateInParameter("@SourceTable", sourceTable, MySqlDbType.VarChar));
		}
		#endregion // RemoveBySourceTable
		#region RemoveBySourceId
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "sourceId">源表编码</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveBySourceId(string sourceId, TransactionManager tm_ = null)
		{
			RepairRemoveBySourceIdData(sourceId, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveBySourceIdAsync(string sourceId, TransactionManager tm_ = null)
		{
			RepairRemoveBySourceIdData(sourceId, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveBySourceIdData(string sourceId, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (sourceId != null ? "`SourceId` = @SourceId" : "`SourceId` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (sourceId != null)
				paras_.Add(Database.CreateInParameter("@SourceId", sourceId, MySqlDbType.VarChar));
		}
		#endregion // RemoveBySourceId
		#region RemoveByUserIp
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "userIp">用户IP</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByUserIp(string userIp, TransactionManager tm_ = null)
		{
			RepairRemoveByUserIpData(userIp, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByUserIpAsync(string userIp, TransactionManager tm_ = null)
		{
			RepairRemoveByUserIpData(userIp, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByUserIpData(string userIp, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (userIp != null ? "`UserIp` = @UserIp" : "`UserIp` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (userIp != null)
				paras_.Add(Database.CreateInParameter("@UserIp", userIp, MySqlDbType.VarChar));
		}
		#endregion // RemoveByUserIp
		#region RemoveByStatus
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "status">状态0-初始1-处理中2-成功3-失败4-已回滚5-异常且需处理6-异常已处理</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByStatus(int status, TransactionManager tm_ = null)
		{
			RepairRemoveByStatusData(status, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByStatusAsync(int status, TransactionManager tm_ = null)
		{
			RepairRemoveByStatusData(status, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByStatusData(int status, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `Status` = @Status";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Status", status, MySqlDbType.Int32));
		}
		#endregion // RemoveByStatus
		#region RemoveByRecDate
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByRecDate(DateTime recDate, TransactionManager tm_ = null)
		{
			RepairRemoveByRecDateData(recDate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByRecDateAsync(DateTime recDate, TransactionManager tm_ = null)
		{
			RepairRemoveByRecDateData(recDate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByRecDateData(DateTime recDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `RecDate` = @RecDate";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
		}
		#endregion // RemoveByRecDate
		#region RemoveByDealTime
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "dealTime">处理时间</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByDealTime(DateTime? dealTime, TransactionManager tm_ = null)
		{
			RepairRemoveByDealTimeData(dealTime.Value, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByDealTimeAsync(DateTime? dealTime, TransactionManager tm_ = null)
		{
			RepairRemoveByDealTimeData(dealTime.Value, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByDealTimeData(DateTime? dealTime, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (dealTime.HasValue ? "`DealTime` = @DealTime" : "`DealTime` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (dealTime.HasValue)
				paras_.Add(Database.CreateInParameter("@DealTime", dealTime.Value, MySqlDbType.DateTime));
		}
		#endregion // RemoveByDealTime
		#region RemoveByDealStatus
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "dealStatus">处理状态数据</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByDealStatus(string dealStatus, TransactionManager tm_ = null)
		{
			RepairRemoveByDealStatusData(dealStatus, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByDealStatusAsync(string dealStatus, TransactionManager tm_ = null)
		{
			RepairRemoveByDealStatusData(dealStatus, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByDealStatusData(string dealStatus, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (dealStatus != null ? "`DealStatus` = @DealStatus" : "`DealStatus` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (dealStatus != null)
				paras_.Add(Database.CreateInParameter("@DealStatus", dealStatus, MySqlDbType.Text));
		}
		#endregion // RemoveByDealStatus
		#region RemoveByAmount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "amount">实际金额（正负数）</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByAmount(long amount, TransactionManager tm_ = null)
		{
			RepairRemoveByAmountData(amount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByAmountAsync(long amount, TransactionManager tm_ = null)
		{
			RepairRemoveByAmountData(amount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByAmountData(long amount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `Amount` = @Amount";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Amount", amount, MySqlDbType.Int64));
		}
		#endregion // RemoveByAmount
		#region RemoveByEndBalance
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "endBalance">处理后余额</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByEndBalance(long endBalance, TransactionManager tm_ = null)
		{
			RepairRemoveByEndBalanceData(endBalance, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByEndBalanceAsync(long endBalance, TransactionManager tm_ = null)
		{
			RepairRemoveByEndBalanceData(endBalance, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByEndBalanceData(long endBalance, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `EndBalance` = @EndBalance";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@EndBalance", endBalance, MySqlDbType.Int64));
		}
		#endregion // RemoveByEndBalance
		#region RemoveByAmountBonus
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "amountBonus">bonus实际变化数量（正负数）</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByAmountBonus(long amountBonus, TransactionManager tm_ = null)
		{
			RepairRemoveByAmountBonusData(amountBonus, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByAmountBonusAsync(long amountBonus, TransactionManager tm_ = null)
		{
			RepairRemoveByAmountBonusData(amountBonus, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByAmountBonusData(long amountBonus, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `AmountBonus` = @AmountBonus";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@AmountBonus", amountBonus, MySqlDbType.Int64));
		}
		#endregion // RemoveByAmountBonus
		#region RemoveByEndBonus
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "endBonus">处理后bonus余额</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByEndBonus(long endBonus, TransactionManager tm_ = null)
		{
			RepairRemoveByEndBonusData(endBonus, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByEndBonusAsync(long endBonus, TransactionManager tm_ = null)
		{
			RepairRemoveByEndBonusData(endBonus, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByEndBonusData(long endBonus, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `EndBonus` = @EndBonus";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@EndBonus", endBonus, MySqlDbType.Int64));
		}
		#endregion // RemoveByEndBonus
		#region RemoveBySettlStatus
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "settlStatus">结算状态（0-未结算1-已结算）</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveBySettlStatus(int settlStatus, TransactionManager tm_ = null)
		{
			RepairRemoveBySettlStatusData(settlStatus, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveBySettlStatusAsync(int settlStatus, TransactionManager tm_ = null)
		{
			RepairRemoveBySettlStatusData(settlStatus, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveBySettlStatusData(int settlStatus, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `SettlStatus` = @SettlStatus";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@SettlStatus", settlStatus, MySqlDbType.Int32));
		}
		#endregion // RemoveBySettlStatus
		#region RemoveBySettlTable
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "settlTable">结算表名</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveBySettlTable(string settlTable, TransactionManager tm_ = null)
		{
			RepairRemoveBySettlTableData(settlTable, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveBySettlTableAsync(string settlTable, TransactionManager tm_ = null)
		{
			RepairRemoveBySettlTableData(settlTable, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveBySettlTableData(string settlTable, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (settlTable != null ? "`SettlTable` = @SettlTable" : "`SettlTable` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (settlTable != null)
				paras_.Add(Database.CreateInParameter("@SettlTable", settlTable, MySqlDbType.VarChar));
		}
		#endregion // RemoveBySettlTable
		#region RemoveBySettlId
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "settlId">结算编码</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveBySettlId(string settlId, TransactionManager tm_ = null)
		{
			RepairRemoveBySettlIdData(settlId, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveBySettlIdAsync(string settlId, TransactionManager tm_ = null)
		{
			RepairRemoveBySettlIdData(settlId, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveBySettlIdData(string settlId, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (settlId != null ? "`SettlId` = @SettlId" : "`SettlId` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (settlId != null)
				paras_.Add(Database.CreateInParameter("@SettlId", settlId, MySqlDbType.VarChar));
		}
		#endregion // RemoveBySettlId
		#region RemoveBySettlAmount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "settlAmount">结算金额(正负数)</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveBySettlAmount(long settlAmount, TransactionManager tm_ = null)
		{
			RepairRemoveBySettlAmountData(settlAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveBySettlAmountAsync(long settlAmount, TransactionManager tm_ = null)
		{
			RepairRemoveBySettlAmountData(settlAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveBySettlAmountData(long settlAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `SettlAmount` = @SettlAmount";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@SettlAmount", settlAmount, MySqlDbType.Int64));
		}
		#endregion // RemoveBySettlAmount
		#endregion // RemoveByXXX
	    
		#region RemoveByFKOrUnique
		#endregion // RemoveByFKOrUnique
		#endregion //Remove
	    
		#region Put
		#region PutItem
		/// <summary>
		/// 更新实体到数据库
		/// </summary>
		/// <param name = "item">要更新的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(S_currency_changeEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(S_currency_changeEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(S_currency_changeEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `ChangeID` = @ChangeID, `ProviderID` = @ProviderID, `AppID` = @AppID, `OperatorID` = @OperatorID, `UserID` = @UserID, `FromMode` = @FromMode, `FromId` = @FromId, `UserKind` = @UserKind, `CountryID` = @CountryID, `CurrencyID` = @CurrencyID, `CurrencyType` = @CurrencyType, `IsBonus` = @IsBonus, `FlowMultip` = @FlowMultip, `Reason` = @Reason, `PlanAmount` = @PlanAmount, `Meta` = @Meta, `SourceType` = @SourceType, `SourceTable` = @SourceTable, `SourceId` = @SourceId, `UserIp` = @UserIp, `Status` = @Status, `DealTime` = @DealTime, `DealStatus` = @DealStatus, `Amount` = @Amount, `EndBalance` = @EndBalance, `AmountBonus` = @AmountBonus, `EndBonus` = @EndBonus, `SettlStatus` = @SettlStatus, `SettlTable` = @SettlTable, `SettlId` = @SettlId, `SettlAmount` = @SettlAmount WHERE `ChangeID` = @ChangeID_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChangeID", item.ChangeID, MySqlDbType.VarChar),
				Database.CreateInParameter("@ProviderID", item.ProviderID != null ? item.ProviderID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppID", item.AppID != null ? item.AppID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", item.OperatorID != null ? item.OperatorID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", item.UserID != null ? item.UserID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@FromMode", item.FromMode, MySqlDbType.Int32),
				Database.CreateInParameter("@FromId", item.FromId != null ? item.FromId : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserKind", item.UserKind, MySqlDbType.Int32),
				Database.CreateInParameter("@CountryID", item.CountryID != null ? item.CountryID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", item.CurrencyID != null ? item.CurrencyID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyType", item.CurrencyType, MySqlDbType.Int32),
				Database.CreateInParameter("@IsBonus", item.IsBonus, MySqlDbType.Byte),
				Database.CreateInParameter("@FlowMultip", item.FlowMultip, MySqlDbType.Float),
				Database.CreateInParameter("@Reason", item.Reason != null ? item.Reason : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@PlanAmount", item.PlanAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@Meta", item.Meta != null ? item.Meta : (object)DBNull.Value, MySqlDbType.Text),
				Database.CreateInParameter("@SourceType", item.SourceType, MySqlDbType.Int32),
				Database.CreateInParameter("@SourceTable", item.SourceTable != null ? item.SourceTable : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@SourceId", item.SourceId != null ? item.SourceId : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserIp", item.UserIp != null ? item.UserIp : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Status", item.Status, MySqlDbType.Int32),
				Database.CreateInParameter("@DealTime", item.DealTime.HasValue ? item.DealTime.Value : (object)DBNull.Value, MySqlDbType.DateTime),
				Database.CreateInParameter("@DealStatus", item.DealStatus != null ? item.DealStatus : (object)DBNull.Value, MySqlDbType.Text),
				Database.CreateInParameter("@Amount", item.Amount, MySqlDbType.Int64),
				Database.CreateInParameter("@EndBalance", item.EndBalance, MySqlDbType.Int64),
				Database.CreateInParameter("@AmountBonus", item.AmountBonus, MySqlDbType.Int64),
				Database.CreateInParameter("@EndBonus", item.EndBonus, MySqlDbType.Int64),
				Database.CreateInParameter("@SettlStatus", item.SettlStatus, MySqlDbType.Int32),
				Database.CreateInParameter("@SettlTable", item.SettlTable != null ? item.SettlTable : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@SettlId", item.SettlId != null ? item.SettlId : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@SettlAmount", item.SettlAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@ChangeID_Original", item.HasOriginal ? item.OriginalChangeID : item.ChangeID, MySqlDbType.VarChar),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<S_currency_changeEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<S_currency_changeEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += await PutAsync(item, tm_);
			}
			return ret;
		}
		#endregion // PutItem
		
		#region PutByPK
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "changeID">货币变化编码(GUID)</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string changeID, string set_, params object[] values_)
		{
			return Put(set_, "`ChangeID` = @ChangeID", ConcatValues(values_, changeID));
		}
		public async Task<int> PutByPKAsync(string changeID, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`ChangeID` = @ChangeID", ConcatValues(values_, changeID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "changeID">货币变化编码(GUID)</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string changeID, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`ChangeID` = @ChangeID", tm_, ConcatValues(values_, changeID));
		}
		public async Task<int> PutByPKAsync(string changeID, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`ChangeID` = @ChangeID", tm_, ConcatValues(values_, changeID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "changeID">货币变化编码(GUID)</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string changeID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@ChangeID", changeID, MySqlDbType.VarChar),
	        };
			return Put(set_, "`ChangeID` = @ChangeID", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(string changeID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@ChangeID", changeID, MySqlDbType.VarChar),
	        };
			return await PutAsync(set_, "`ChangeID` = @ChangeID", ConcatParameters(paras_, newParas_), tm_);
		}
		#endregion // PutByPK
		
		#region PutXXX
		#region PutProviderID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "changeID">货币变化编码(GUID)</param>
		/// /// <param name = "providerID">应用提供商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutProviderIDByPK(string changeID, string providerID, TransactionManager tm_ = null)
		{
			RepairPutProviderIDByPKData(changeID, providerID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutProviderIDByPKAsync(string changeID, string providerID, TransactionManager tm_ = null)
		{
			RepairPutProviderIDByPKData(changeID, providerID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutProviderIDByPKData(string changeID, string providerID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `ProviderID` = @ProviderID  WHERE `ChangeID` = @ChangeID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ProviderID", providerID != null ? providerID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ChangeID", changeID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "providerID">应用提供商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutProviderID(string providerID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ProviderID` = @ProviderID";
			var parameter_ = Database.CreateInParameter("@ProviderID", providerID != null ? providerID : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutProviderIDAsync(string providerID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ProviderID` = @ProviderID";
			var parameter_ = Database.CreateInParameter("@ProviderID", providerID != null ? providerID : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutProviderID
		#region PutAppID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "changeID">货币变化编码(GUID)</param>
		/// /// <param name = "appID">应用编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutAppIDByPK(string changeID, string appID, TransactionManager tm_ = null)
		{
			RepairPutAppIDByPKData(changeID, appID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAppIDByPKAsync(string changeID, string appID, TransactionManager tm_ = null)
		{
			RepairPutAppIDByPKData(changeID, appID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutAppIDByPKData(string changeID, string appID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `AppID` = @AppID  WHERE `ChangeID` = @ChangeID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID != null ? appID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ChangeID", changeID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutAppID(string appID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `AppID` = @AppID";
			var parameter_ = Database.CreateInParameter("@AppID", appID != null ? appID : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutAppIDAsync(string appID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `AppID` = @AppID";
			var parameter_ = Database.CreateInParameter("@AppID", appID != null ? appID : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutAppID
		#region PutOperatorID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "changeID">货币变化编码(GUID)</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOperatorIDByPK(string changeID, string operatorID, TransactionManager tm_ = null)
		{
			RepairPutOperatorIDByPKData(changeID, operatorID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutOperatorIDByPKAsync(string changeID, string operatorID, TransactionManager tm_ = null)
		{
			RepairPutOperatorIDByPKData(changeID, operatorID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutOperatorIDByPKData(string changeID, string operatorID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `OperatorID` = @OperatorID  WHERE `ChangeID` = @ChangeID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID != null ? operatorID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ChangeID", changeID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOperatorID(string operatorID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `OperatorID` = @OperatorID";
			var parameter_ = Database.CreateInParameter("@OperatorID", operatorID != null ? operatorID : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutOperatorIDAsync(string operatorID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `OperatorID` = @OperatorID";
			var parameter_ = Database.CreateInParameter("@OperatorID", operatorID != null ? operatorID : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutOperatorID
		#region PutUserID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "changeID">货币变化编码(GUID)</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutUserIDByPK(string changeID, string userID, TransactionManager tm_ = null)
		{
			RepairPutUserIDByPKData(changeID, userID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutUserIDByPKAsync(string changeID, string userID, TransactionManager tm_ = null)
		{
			RepairPutUserIDByPKData(changeID, userID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutUserIDByPKData(string changeID, string userID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `UserID` = @UserID  WHERE `ChangeID` = @ChangeID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID != null ? userID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ChangeID", changeID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutUserID(string userID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `UserID` = @UserID";
			var parameter_ = Database.CreateInParameter("@UserID", userID != null ? userID : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutUserIDAsync(string userID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `UserID` = @UserID";
			var parameter_ = Database.CreateInParameter("@UserID", userID != null ? userID : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutUserID
		#region PutFromMode
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "changeID">货币变化编码(GUID)</param>
		/// /// <param name = "fromMode">新用户来源方式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutFromModeByPK(string changeID, int fromMode, TransactionManager tm_ = null)
		{
			RepairPutFromModeByPKData(changeID, fromMode, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutFromModeByPKAsync(string changeID, int fromMode, TransactionManager tm_ = null)
		{
			RepairPutFromModeByPKData(changeID, fromMode, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutFromModeByPKData(string changeID, int fromMode, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `FromMode` = @FromMode  WHERE `ChangeID` = @ChangeID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@FromMode", fromMode, MySqlDbType.Int32),
				Database.CreateInParameter("@ChangeID", changeID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "fromMode">新用户来源方式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutFromMode(int fromMode, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `FromMode` = @FromMode";
			var parameter_ = Database.CreateInParameter("@FromMode", fromMode, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutFromModeAsync(int fromMode, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `FromMode` = @FromMode";
			var parameter_ = Database.CreateInParameter("@FromMode", fromMode, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutFromMode
		#region PutFromId
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "changeID">货币变化编码(GUID)</param>
		/// /// <param name = "fromId">对应的编码（根据FromMode变化）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutFromIdByPK(string changeID, string fromId, TransactionManager tm_ = null)
		{
			RepairPutFromIdByPKData(changeID, fromId, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutFromIdByPKAsync(string changeID, string fromId, TransactionManager tm_ = null)
		{
			RepairPutFromIdByPKData(changeID, fromId, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutFromIdByPKData(string changeID, string fromId, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `FromId` = @FromId  WHERE `ChangeID` = @ChangeID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@FromId", fromId != null ? fromId : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ChangeID", changeID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "fromId">对应的编码（根据FromMode变化）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutFromId(string fromId, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `FromId` = @FromId";
			var parameter_ = Database.CreateInParameter("@FromId", fromId != null ? fromId : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutFromIdAsync(string fromId, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `FromId` = @FromId";
			var parameter_ = Database.CreateInParameter("@FromId", fromId != null ? fromId : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutFromId
		#region PutUserKind
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "changeID">货币变化编码(GUID)</param>
		/// /// <param name = "userKind">用户类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutUserKindByPK(string changeID, int userKind, TransactionManager tm_ = null)
		{
			RepairPutUserKindByPKData(changeID, userKind, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutUserKindByPKAsync(string changeID, int userKind, TransactionManager tm_ = null)
		{
			RepairPutUserKindByPKData(changeID, userKind, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutUserKindByPKData(string changeID, int userKind, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `UserKind` = @UserKind  WHERE `ChangeID` = @ChangeID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserKind", userKind, MySqlDbType.Int32),
				Database.CreateInParameter("@ChangeID", changeID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "userKind">用户类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutUserKind(int userKind, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `UserKind` = @UserKind";
			var parameter_ = Database.CreateInParameter("@UserKind", userKind, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutUserKindAsync(int userKind, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `UserKind` = @UserKind";
			var parameter_ = Database.CreateInParameter("@UserKind", userKind, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutUserKind
		#region PutCountryID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "changeID">货币变化编码(GUID)</param>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCountryIDByPK(string changeID, string countryID, TransactionManager tm_ = null)
		{
			RepairPutCountryIDByPKData(changeID, countryID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutCountryIDByPKAsync(string changeID, string countryID, TransactionManager tm_ = null)
		{
			RepairPutCountryIDByPKData(changeID, countryID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutCountryIDByPKData(string changeID, string countryID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `CountryID` = @CountryID  WHERE `ChangeID` = @ChangeID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CountryID", countryID != null ? countryID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ChangeID", changeID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCountryID(string countryID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CountryID` = @CountryID";
			var parameter_ = Database.CreateInParameter("@CountryID", countryID != null ? countryID : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutCountryIDAsync(string countryID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CountryID` = @CountryID";
			var parameter_ = Database.CreateInParameter("@CountryID", countryID != null ? countryID : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutCountryID
		#region PutCurrencyID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "changeID">货币变化编码(GUID)</param>
		/// /// <param name = "currencyID">货币类型（货币缩写USD）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCurrencyIDByPK(string changeID, string currencyID, TransactionManager tm_ = null)
		{
			RepairPutCurrencyIDByPKData(changeID, currencyID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutCurrencyIDByPKAsync(string changeID, string currencyID, TransactionManager tm_ = null)
		{
			RepairPutCurrencyIDByPKData(changeID, currencyID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutCurrencyIDByPKData(string changeID, string currencyID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `CurrencyID` = @CurrencyID  WHERE `ChangeID` = @ChangeID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CurrencyID", currencyID != null ? currencyID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ChangeID", changeID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "currencyID">货币类型（货币缩写USD）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCurrencyID(string currencyID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CurrencyID` = @CurrencyID";
			var parameter_ = Database.CreateInParameter("@CurrencyID", currencyID != null ? currencyID : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutCurrencyIDAsync(string currencyID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CurrencyID` = @CurrencyID";
			var parameter_ = Database.CreateInParameter("@CurrencyID", currencyID != null ? currencyID : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutCurrencyID
		#region PutCurrencyType
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "changeID">货币变化编码(GUID)</param>
		/// /// <param name = "currencyType">货币类型 1-COIN 2--GOLD 3-POINT 4-SWB 8-虚拟货币 9-CASH</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCurrencyTypeByPK(string changeID, int currencyType, TransactionManager tm_ = null)
		{
			RepairPutCurrencyTypeByPKData(changeID, currencyType, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutCurrencyTypeByPKAsync(string changeID, int currencyType, TransactionManager tm_ = null)
		{
			RepairPutCurrencyTypeByPKData(changeID, currencyType, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutCurrencyTypeByPKData(string changeID, int currencyType, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `CurrencyType` = @CurrencyType  WHERE `ChangeID` = @ChangeID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CurrencyType", currencyType, MySqlDbType.Int32),
				Database.CreateInParameter("@ChangeID", changeID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "currencyType">货币类型 1-COIN 2--GOLD 3-POINT 4-SWB 8-虚拟货币 9-CASH</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCurrencyType(int currencyType, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CurrencyType` = @CurrencyType";
			var parameter_ = Database.CreateInParameter("@CurrencyType", currencyType, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutCurrencyTypeAsync(int currencyType, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CurrencyType` = @CurrencyType";
			var parameter_ = Database.CreateInParameter("@CurrencyType", currencyType, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutCurrencyType
		#region PutIsBonus
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "changeID">货币变化编码(GUID)</param>
		/// /// <param name = "isBonus">是否赠金</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutIsBonusByPK(string changeID, bool isBonus, TransactionManager tm_ = null)
		{
			RepairPutIsBonusByPKData(changeID, isBonus, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutIsBonusByPKAsync(string changeID, bool isBonus, TransactionManager tm_ = null)
		{
			RepairPutIsBonusByPKData(changeID, isBonus, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutIsBonusByPKData(string changeID, bool isBonus, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `IsBonus` = @IsBonus  WHERE `ChangeID` = @ChangeID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@IsBonus", isBonus, MySqlDbType.Byte),
				Database.CreateInParameter("@ChangeID", changeID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "isBonus">是否赠金</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutIsBonus(bool isBonus, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `IsBonus` = @IsBonus";
			var parameter_ = Database.CreateInParameter("@IsBonus", isBonus, MySqlDbType.Byte);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutIsBonusAsync(bool isBonus, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `IsBonus` = @IsBonus";
			var parameter_ = Database.CreateInParameter("@IsBonus", isBonus, MySqlDbType.Byte);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutIsBonus
		#region PutFlowMultip
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "changeID">货币变化编码(GUID)</param>
		/// /// <param name = "flowMultip">要求的流水系数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutFlowMultipByPK(string changeID, float flowMultip, TransactionManager tm_ = null)
		{
			RepairPutFlowMultipByPKData(changeID, flowMultip, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutFlowMultipByPKAsync(string changeID, float flowMultip, TransactionManager tm_ = null)
		{
			RepairPutFlowMultipByPKData(changeID, flowMultip, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutFlowMultipByPKData(string changeID, float flowMultip, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `FlowMultip` = @FlowMultip  WHERE `ChangeID` = @ChangeID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@FlowMultip", flowMultip, MySqlDbType.Float),
				Database.CreateInParameter("@ChangeID", changeID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "flowMultip">要求的流水系数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutFlowMultip(float flowMultip, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `FlowMultip` = @FlowMultip";
			var parameter_ = Database.CreateInParameter("@FlowMultip", flowMultip, MySqlDbType.Float);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutFlowMultipAsync(float flowMultip, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `FlowMultip` = @FlowMultip";
			var parameter_ = Database.CreateInParameter("@FlowMultip", flowMultip, MySqlDbType.Float);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutFlowMultip
		#region PutReason
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "changeID">货币变化编码(GUID)</param>
		/// /// <param name = "reason">变化原因</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutReasonByPK(string changeID, string reason, TransactionManager tm_ = null)
		{
			RepairPutReasonByPKData(changeID, reason, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutReasonByPKAsync(string changeID, string reason, TransactionManager tm_ = null)
		{
			RepairPutReasonByPKData(changeID, reason, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutReasonByPKData(string changeID, string reason, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Reason` = @Reason  WHERE `ChangeID` = @ChangeID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Reason", reason != null ? reason : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ChangeID", changeID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "reason">变化原因</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutReason(string reason, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Reason` = @Reason";
			var parameter_ = Database.CreateInParameter("@Reason", reason != null ? reason : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutReasonAsync(string reason, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Reason` = @Reason";
			var parameter_ = Database.CreateInParameter("@Reason", reason != null ? reason : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutReason
		#region PutPlanAmount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "changeID">货币变化编码(GUID)</param>
		/// /// <param name = "planAmount">计划变化金额（正负数）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPlanAmountByPK(string changeID, long planAmount, TransactionManager tm_ = null)
		{
			RepairPutPlanAmountByPKData(changeID, planAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutPlanAmountByPKAsync(string changeID, long planAmount, TransactionManager tm_ = null)
		{
			RepairPutPlanAmountByPKData(changeID, planAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutPlanAmountByPKData(string changeID, long planAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `PlanAmount` = @PlanAmount  WHERE `ChangeID` = @ChangeID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@PlanAmount", planAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@ChangeID", changeID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "planAmount">计划变化金额（正负数）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPlanAmount(long planAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `PlanAmount` = @PlanAmount";
			var parameter_ = Database.CreateInParameter("@PlanAmount", planAmount, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutPlanAmountAsync(long planAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `PlanAmount` = @PlanAmount";
			var parameter_ = Database.CreateInParameter("@PlanAmount", planAmount, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutPlanAmount
		#region PutMeta
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "changeID">货币变化编码(GUID)</param>
		/// /// <param name = "meta">扩展数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutMetaByPK(string changeID, string meta, TransactionManager tm_ = null)
		{
			RepairPutMetaByPKData(changeID, meta, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutMetaByPKAsync(string changeID, string meta, TransactionManager tm_ = null)
		{
			RepairPutMetaByPKData(changeID, meta, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutMetaByPKData(string changeID, string meta, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Meta` = @Meta  WHERE `ChangeID` = @ChangeID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Meta", meta != null ? meta : (object)DBNull.Value, MySqlDbType.Text),
				Database.CreateInParameter("@ChangeID", changeID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "meta">扩展数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutMeta(string meta, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Meta` = @Meta";
			var parameter_ = Database.CreateInParameter("@Meta", meta != null ? meta : (object)DBNull.Value, MySqlDbType.Text);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutMetaAsync(string meta, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Meta` = @Meta";
			var parameter_ = Database.CreateInParameter("@Meta", meta != null ? meta : (object)DBNull.Value, MySqlDbType.Text);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutMeta
		#region PutSourceType
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "changeID">货币变化编码(GUID)</param>
		/// /// <param name = "sourceType">0-未知1-运营活动2</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutSourceTypeByPK(string changeID, int sourceType, TransactionManager tm_ = null)
		{
			RepairPutSourceTypeByPKData(changeID, sourceType, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutSourceTypeByPKAsync(string changeID, int sourceType, TransactionManager tm_ = null)
		{
			RepairPutSourceTypeByPKData(changeID, sourceType, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutSourceTypeByPKData(string changeID, int sourceType, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `SourceType` = @SourceType  WHERE `ChangeID` = @ChangeID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@SourceType", sourceType, MySqlDbType.Int32),
				Database.CreateInParameter("@ChangeID", changeID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "sourceType">0-未知1-运营活动2</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutSourceType(int sourceType, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `SourceType` = @SourceType";
			var parameter_ = Database.CreateInParameter("@SourceType", sourceType, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutSourceTypeAsync(int sourceType, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `SourceType` = @SourceType";
			var parameter_ = Database.CreateInParameter("@SourceType", sourceType, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutSourceType
		#region PutSourceTable
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "changeID">货币变化编码(GUID)</param>
		/// /// <param name = "sourceTable">源表名</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutSourceTableByPK(string changeID, string sourceTable, TransactionManager tm_ = null)
		{
			RepairPutSourceTableByPKData(changeID, sourceTable, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutSourceTableByPKAsync(string changeID, string sourceTable, TransactionManager tm_ = null)
		{
			RepairPutSourceTableByPKData(changeID, sourceTable, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutSourceTableByPKData(string changeID, string sourceTable, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `SourceTable` = @SourceTable  WHERE `ChangeID` = @ChangeID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@SourceTable", sourceTable != null ? sourceTable : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ChangeID", changeID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "sourceTable">源表名</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutSourceTable(string sourceTable, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `SourceTable` = @SourceTable";
			var parameter_ = Database.CreateInParameter("@SourceTable", sourceTable != null ? sourceTable : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutSourceTableAsync(string sourceTable, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `SourceTable` = @SourceTable";
			var parameter_ = Database.CreateInParameter("@SourceTable", sourceTable != null ? sourceTable : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutSourceTable
		#region PutSourceId
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "changeID">货币变化编码(GUID)</param>
		/// /// <param name = "sourceId">源表编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutSourceIdByPK(string changeID, string sourceId, TransactionManager tm_ = null)
		{
			RepairPutSourceIdByPKData(changeID, sourceId, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutSourceIdByPKAsync(string changeID, string sourceId, TransactionManager tm_ = null)
		{
			RepairPutSourceIdByPKData(changeID, sourceId, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutSourceIdByPKData(string changeID, string sourceId, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `SourceId` = @SourceId  WHERE `ChangeID` = @ChangeID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@SourceId", sourceId != null ? sourceId : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ChangeID", changeID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "sourceId">源表编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutSourceId(string sourceId, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `SourceId` = @SourceId";
			var parameter_ = Database.CreateInParameter("@SourceId", sourceId != null ? sourceId : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutSourceIdAsync(string sourceId, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `SourceId` = @SourceId";
			var parameter_ = Database.CreateInParameter("@SourceId", sourceId != null ? sourceId : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutSourceId
		#region PutUserIp
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "changeID">货币变化编码(GUID)</param>
		/// /// <param name = "userIp">用户IP</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutUserIpByPK(string changeID, string userIp, TransactionManager tm_ = null)
		{
			RepairPutUserIpByPKData(changeID, userIp, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutUserIpByPKAsync(string changeID, string userIp, TransactionManager tm_ = null)
		{
			RepairPutUserIpByPKData(changeID, userIp, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutUserIpByPKData(string changeID, string userIp, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `UserIp` = @UserIp  WHERE `ChangeID` = @ChangeID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserIp", userIp != null ? userIp : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ChangeID", changeID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "userIp">用户IP</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutUserIp(string userIp, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `UserIp` = @UserIp";
			var parameter_ = Database.CreateInParameter("@UserIp", userIp != null ? userIp : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutUserIpAsync(string userIp, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `UserIp` = @UserIp";
			var parameter_ = Database.CreateInParameter("@UserIp", userIp != null ? userIp : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutUserIp
		#region PutStatus
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "changeID">货币变化编码(GUID)</param>
		/// /// <param name = "status">状态0-初始1-处理中2-成功3-失败4-已回滚5-异常且需处理6-异常已处理</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutStatusByPK(string changeID, int status, TransactionManager tm_ = null)
		{
			RepairPutStatusByPKData(changeID, status, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutStatusByPKAsync(string changeID, int status, TransactionManager tm_ = null)
		{
			RepairPutStatusByPKData(changeID, status, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutStatusByPKData(string changeID, int status, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Status` = @Status  WHERE `ChangeID` = @ChangeID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Status", status, MySqlDbType.Int32),
				Database.CreateInParameter("@ChangeID", changeID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "status">状态0-初始1-处理中2-成功3-失败4-已回滚5-异常且需处理6-异常已处理</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutStatus(int status, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Status` = @Status";
			var parameter_ = Database.CreateInParameter("@Status", status, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutStatusAsync(int status, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Status` = @Status";
			var parameter_ = Database.CreateInParameter("@Status", status, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutStatus
		#region PutRecDate
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "changeID">货币变化编码(GUID)</param>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRecDateByPK(string changeID, DateTime recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(changeID, recDate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutRecDateByPKAsync(string changeID, DateTime recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(changeID, recDate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutRecDateByPKData(string changeID, DateTime recDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `RecDate` = @RecDate  WHERE `ChangeID` = @ChangeID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime),
				Database.CreateInParameter("@ChangeID", changeID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRecDate(DateTime recDate, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `RecDate` = @RecDate";
			var parameter_ = Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutRecDateAsync(DateTime recDate, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `RecDate` = @RecDate";
			var parameter_ = Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutRecDate
		#region PutDealTime
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "changeID">货币变化编码(GUID)</param>
		/// /// <param name = "dealTime">处理时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutDealTimeByPK(string changeID, DateTime? dealTime, TransactionManager tm_ = null)
		{
			RepairPutDealTimeByPKData(changeID, dealTime, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutDealTimeByPKAsync(string changeID, DateTime? dealTime, TransactionManager tm_ = null)
		{
			RepairPutDealTimeByPKData(changeID, dealTime, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutDealTimeByPKData(string changeID, DateTime? dealTime, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `DealTime` = @DealTime  WHERE `ChangeID` = @ChangeID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DealTime", dealTime.HasValue ? dealTime.Value : (object)DBNull.Value, MySqlDbType.DateTime),
				Database.CreateInParameter("@ChangeID", changeID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "dealTime">处理时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutDealTime(DateTime? dealTime, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `DealTime` = @DealTime";
			var parameter_ = Database.CreateInParameter("@DealTime", dealTime.HasValue ? dealTime.Value : (object)DBNull.Value, MySqlDbType.DateTime);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutDealTimeAsync(DateTime? dealTime, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `DealTime` = @DealTime";
			var parameter_ = Database.CreateInParameter("@DealTime", dealTime.HasValue ? dealTime.Value : (object)DBNull.Value, MySqlDbType.DateTime);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutDealTime
		#region PutDealStatus
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "changeID">货币变化编码(GUID)</param>
		/// /// <param name = "dealStatus">处理状态数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutDealStatusByPK(string changeID, string dealStatus, TransactionManager tm_ = null)
		{
			RepairPutDealStatusByPKData(changeID, dealStatus, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutDealStatusByPKAsync(string changeID, string dealStatus, TransactionManager tm_ = null)
		{
			RepairPutDealStatusByPKData(changeID, dealStatus, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutDealStatusByPKData(string changeID, string dealStatus, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `DealStatus` = @DealStatus  WHERE `ChangeID` = @ChangeID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DealStatus", dealStatus != null ? dealStatus : (object)DBNull.Value, MySqlDbType.Text),
				Database.CreateInParameter("@ChangeID", changeID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "dealStatus">处理状态数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutDealStatus(string dealStatus, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `DealStatus` = @DealStatus";
			var parameter_ = Database.CreateInParameter("@DealStatus", dealStatus != null ? dealStatus : (object)DBNull.Value, MySqlDbType.Text);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutDealStatusAsync(string dealStatus, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `DealStatus` = @DealStatus";
			var parameter_ = Database.CreateInParameter("@DealStatus", dealStatus != null ? dealStatus : (object)DBNull.Value, MySqlDbType.Text);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutDealStatus
		#region PutAmount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "changeID">货币变化编码(GUID)</param>
		/// /// <param name = "amount">实际金额（正负数）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutAmountByPK(string changeID, long amount, TransactionManager tm_ = null)
		{
			RepairPutAmountByPKData(changeID, amount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAmountByPKAsync(string changeID, long amount, TransactionManager tm_ = null)
		{
			RepairPutAmountByPKData(changeID, amount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutAmountByPKData(string changeID, long amount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Amount` = @Amount  WHERE `ChangeID` = @ChangeID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Amount", amount, MySqlDbType.Int64),
				Database.CreateInParameter("@ChangeID", changeID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "amount">实际金额（正负数）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutAmount(long amount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Amount` = @Amount";
			var parameter_ = Database.CreateInParameter("@Amount", amount, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutAmountAsync(long amount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Amount` = @Amount";
			var parameter_ = Database.CreateInParameter("@Amount", amount, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutAmount
		#region PutEndBalance
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "changeID">货币变化编码(GUID)</param>
		/// /// <param name = "endBalance">处理后余额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutEndBalanceByPK(string changeID, long endBalance, TransactionManager tm_ = null)
		{
			RepairPutEndBalanceByPKData(changeID, endBalance, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutEndBalanceByPKAsync(string changeID, long endBalance, TransactionManager tm_ = null)
		{
			RepairPutEndBalanceByPKData(changeID, endBalance, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutEndBalanceByPKData(string changeID, long endBalance, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `EndBalance` = @EndBalance  WHERE `ChangeID` = @ChangeID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@EndBalance", endBalance, MySqlDbType.Int64),
				Database.CreateInParameter("@ChangeID", changeID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "endBalance">处理后余额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutEndBalance(long endBalance, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `EndBalance` = @EndBalance";
			var parameter_ = Database.CreateInParameter("@EndBalance", endBalance, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutEndBalanceAsync(long endBalance, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `EndBalance` = @EndBalance";
			var parameter_ = Database.CreateInParameter("@EndBalance", endBalance, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutEndBalance
		#region PutAmountBonus
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "changeID">货币变化编码(GUID)</param>
		/// /// <param name = "amountBonus">bonus实际变化数量（正负数）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutAmountBonusByPK(string changeID, long amountBonus, TransactionManager tm_ = null)
		{
			RepairPutAmountBonusByPKData(changeID, amountBonus, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAmountBonusByPKAsync(string changeID, long amountBonus, TransactionManager tm_ = null)
		{
			RepairPutAmountBonusByPKData(changeID, amountBonus, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutAmountBonusByPKData(string changeID, long amountBonus, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `AmountBonus` = @AmountBonus  WHERE `ChangeID` = @ChangeID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AmountBonus", amountBonus, MySqlDbType.Int64),
				Database.CreateInParameter("@ChangeID", changeID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "amountBonus">bonus实际变化数量（正负数）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutAmountBonus(long amountBonus, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `AmountBonus` = @AmountBonus";
			var parameter_ = Database.CreateInParameter("@AmountBonus", amountBonus, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutAmountBonusAsync(long amountBonus, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `AmountBonus` = @AmountBonus";
			var parameter_ = Database.CreateInParameter("@AmountBonus", amountBonus, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutAmountBonus
		#region PutEndBonus
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "changeID">货币变化编码(GUID)</param>
		/// /// <param name = "endBonus">处理后bonus余额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutEndBonusByPK(string changeID, long endBonus, TransactionManager tm_ = null)
		{
			RepairPutEndBonusByPKData(changeID, endBonus, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutEndBonusByPKAsync(string changeID, long endBonus, TransactionManager tm_ = null)
		{
			RepairPutEndBonusByPKData(changeID, endBonus, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutEndBonusByPKData(string changeID, long endBonus, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `EndBonus` = @EndBonus  WHERE `ChangeID` = @ChangeID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@EndBonus", endBonus, MySqlDbType.Int64),
				Database.CreateInParameter("@ChangeID", changeID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "endBonus">处理后bonus余额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutEndBonus(long endBonus, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `EndBonus` = @EndBonus";
			var parameter_ = Database.CreateInParameter("@EndBonus", endBonus, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutEndBonusAsync(long endBonus, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `EndBonus` = @EndBonus";
			var parameter_ = Database.CreateInParameter("@EndBonus", endBonus, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutEndBonus
		#region PutSettlStatus
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "changeID">货币变化编码(GUID)</param>
		/// /// <param name = "settlStatus">结算状态（0-未结算1-已结算）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutSettlStatusByPK(string changeID, int settlStatus, TransactionManager tm_ = null)
		{
			RepairPutSettlStatusByPKData(changeID, settlStatus, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutSettlStatusByPKAsync(string changeID, int settlStatus, TransactionManager tm_ = null)
		{
			RepairPutSettlStatusByPKData(changeID, settlStatus, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutSettlStatusByPKData(string changeID, int settlStatus, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `SettlStatus` = @SettlStatus  WHERE `ChangeID` = @ChangeID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@SettlStatus", settlStatus, MySqlDbType.Int32),
				Database.CreateInParameter("@ChangeID", changeID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "settlStatus">结算状态（0-未结算1-已结算）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutSettlStatus(int settlStatus, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `SettlStatus` = @SettlStatus";
			var parameter_ = Database.CreateInParameter("@SettlStatus", settlStatus, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutSettlStatusAsync(int settlStatus, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `SettlStatus` = @SettlStatus";
			var parameter_ = Database.CreateInParameter("@SettlStatus", settlStatus, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutSettlStatus
		#region PutSettlTable
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "changeID">货币变化编码(GUID)</param>
		/// /// <param name = "settlTable">结算表名</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutSettlTableByPK(string changeID, string settlTable, TransactionManager tm_ = null)
		{
			RepairPutSettlTableByPKData(changeID, settlTable, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutSettlTableByPKAsync(string changeID, string settlTable, TransactionManager tm_ = null)
		{
			RepairPutSettlTableByPKData(changeID, settlTable, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutSettlTableByPKData(string changeID, string settlTable, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `SettlTable` = @SettlTable  WHERE `ChangeID` = @ChangeID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@SettlTable", settlTable != null ? settlTable : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ChangeID", changeID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "settlTable">结算表名</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutSettlTable(string settlTable, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `SettlTable` = @SettlTable";
			var parameter_ = Database.CreateInParameter("@SettlTable", settlTable != null ? settlTable : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutSettlTableAsync(string settlTable, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `SettlTable` = @SettlTable";
			var parameter_ = Database.CreateInParameter("@SettlTable", settlTable != null ? settlTable : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutSettlTable
		#region PutSettlId
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "changeID">货币变化编码(GUID)</param>
		/// /// <param name = "settlId">结算编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutSettlIdByPK(string changeID, string settlId, TransactionManager tm_ = null)
		{
			RepairPutSettlIdByPKData(changeID, settlId, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutSettlIdByPKAsync(string changeID, string settlId, TransactionManager tm_ = null)
		{
			RepairPutSettlIdByPKData(changeID, settlId, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutSettlIdByPKData(string changeID, string settlId, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `SettlId` = @SettlId  WHERE `ChangeID` = @ChangeID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@SettlId", settlId != null ? settlId : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ChangeID", changeID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "settlId">结算编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutSettlId(string settlId, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `SettlId` = @SettlId";
			var parameter_ = Database.CreateInParameter("@SettlId", settlId != null ? settlId : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutSettlIdAsync(string settlId, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `SettlId` = @SettlId";
			var parameter_ = Database.CreateInParameter("@SettlId", settlId != null ? settlId : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutSettlId
		#region PutSettlAmount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "changeID">货币变化编码(GUID)</param>
		/// /// <param name = "settlAmount">结算金额(正负数)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutSettlAmountByPK(string changeID, long settlAmount, TransactionManager tm_ = null)
		{
			RepairPutSettlAmountByPKData(changeID, settlAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutSettlAmountByPKAsync(string changeID, long settlAmount, TransactionManager tm_ = null)
		{
			RepairPutSettlAmountByPKData(changeID, settlAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutSettlAmountByPKData(string changeID, long settlAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `SettlAmount` = @SettlAmount  WHERE `ChangeID` = @ChangeID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@SettlAmount", settlAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@ChangeID", changeID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "settlAmount">结算金额(正负数)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutSettlAmount(long settlAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `SettlAmount` = @SettlAmount";
			var parameter_ = Database.CreateInParameter("@SettlAmount", settlAmount, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutSettlAmountAsync(long settlAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `SettlAmount` = @SettlAmount";
			var parameter_ = Database.CreateInParameter("@SettlAmount", settlAmount, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutSettlAmount
		#endregion // PutXXX
		#endregion // Put
	   
		#region Set
		
		/// <summary>
		/// 插入或者更新数据
		/// </summary>
		/// <param name = "item">要更新的实体对象</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>true:插入操作；false:更新操作</return>
		public bool Set(S_currency_changeEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.ChangeID) == null)
			{
				Add(item, tm);
			}
			else
			{
				Put(item, tm);
				ret = false;
			}
			return ret;
		}
		public async Task<bool> SetAsync(S_currency_changeEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.ChangeID) == null)
			{
				await AddAsync(item, tm);
			}
			else
			{
				await PutAsync(item, tm);
				ret = false;
			}
			return ret;
		}
		
		#endregion // Set
		
		#region Get
		#region GetByPK
		/// <summary>
		/// 按 PK（主键） 查询
		/// </summary>
		/// /// <param name = "changeID">货币变化编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public S_currency_changeEO GetByPK(string changeID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(changeID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, S_currency_changeEO.MapDataReader);
		}
		public async Task<S_currency_changeEO> GetByPKAsync(string changeID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(changeID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, S_currency_changeEO.MapDataReader);
		}
		private void RepairGetByPKData(string changeID, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false, TransactionManager tm_ = null)
		{
			sql_ = BuildSelectSQL("`ChangeID` = @ChangeID", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChangeID", changeID, MySqlDbType.VarChar),
			};
		}
		#endregion // GetByPK
		
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 ProviderID（字段）
		/// </summary>
		/// /// <param name = "changeID">货币变化编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetProviderIDByPK(string changeID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChangeID", changeID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`ProviderID`", "`ChangeID` = @ChangeID", paras_, tm_);
		}
		public async Task<string> GetProviderIDByPKAsync(string changeID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChangeID", changeID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`ProviderID`", "`ChangeID` = @ChangeID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 AppID（字段）
		/// </summary>
		/// /// <param name = "changeID">货币变化编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetAppIDByPK(string changeID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChangeID", changeID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`AppID`", "`ChangeID` = @ChangeID", paras_, tm_);
		}
		public async Task<string> GetAppIDByPKAsync(string changeID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChangeID", changeID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`AppID`", "`ChangeID` = @ChangeID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 OperatorID（字段）
		/// </summary>
		/// /// <param name = "changeID">货币变化编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetOperatorIDByPK(string changeID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChangeID", changeID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`OperatorID`", "`ChangeID` = @ChangeID", paras_, tm_);
		}
		public async Task<string> GetOperatorIDByPKAsync(string changeID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChangeID", changeID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`OperatorID`", "`ChangeID` = @ChangeID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 UserID（字段）
		/// </summary>
		/// /// <param name = "changeID">货币变化编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetUserIDByPK(string changeID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChangeID", changeID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`UserID`", "`ChangeID` = @ChangeID", paras_, tm_);
		}
		public async Task<string> GetUserIDByPKAsync(string changeID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChangeID", changeID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`UserID`", "`ChangeID` = @ChangeID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 FromMode（字段）
		/// </summary>
		/// /// <param name = "changeID">货币变化编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetFromModeByPK(string changeID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChangeID", changeID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`FromMode`", "`ChangeID` = @ChangeID", paras_, tm_);
		}
		public async Task<int> GetFromModeByPKAsync(string changeID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChangeID", changeID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`FromMode`", "`ChangeID` = @ChangeID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 FromId（字段）
		/// </summary>
		/// /// <param name = "changeID">货币变化编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetFromIdByPK(string changeID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChangeID", changeID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`FromId`", "`ChangeID` = @ChangeID", paras_, tm_);
		}
		public async Task<string> GetFromIdByPKAsync(string changeID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChangeID", changeID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`FromId`", "`ChangeID` = @ChangeID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 UserKind（字段）
		/// </summary>
		/// /// <param name = "changeID">货币变化编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetUserKindByPK(string changeID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChangeID", changeID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`UserKind`", "`ChangeID` = @ChangeID", paras_, tm_);
		}
		public async Task<int> GetUserKindByPKAsync(string changeID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChangeID", changeID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`UserKind`", "`ChangeID` = @ChangeID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 CountryID（字段）
		/// </summary>
		/// /// <param name = "changeID">货币变化编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetCountryIDByPK(string changeID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChangeID", changeID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`CountryID`", "`ChangeID` = @ChangeID", paras_, tm_);
		}
		public async Task<string> GetCountryIDByPKAsync(string changeID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChangeID", changeID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`CountryID`", "`ChangeID` = @ChangeID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 CurrencyID（字段）
		/// </summary>
		/// /// <param name = "changeID">货币变化编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetCurrencyIDByPK(string changeID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChangeID", changeID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`CurrencyID`", "`ChangeID` = @ChangeID", paras_, tm_);
		}
		public async Task<string> GetCurrencyIDByPKAsync(string changeID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChangeID", changeID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`CurrencyID`", "`ChangeID` = @ChangeID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 CurrencyType（字段）
		/// </summary>
		/// /// <param name = "changeID">货币变化编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetCurrencyTypeByPK(string changeID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChangeID", changeID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`CurrencyType`", "`ChangeID` = @ChangeID", paras_, tm_);
		}
		public async Task<int> GetCurrencyTypeByPKAsync(string changeID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChangeID", changeID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`CurrencyType`", "`ChangeID` = @ChangeID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 IsBonus（字段）
		/// </summary>
		/// /// <param name = "changeID">货币变化编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public bool GetIsBonusByPK(string changeID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChangeID", changeID, MySqlDbType.VarChar),
			};
			return (bool)GetScalar("`IsBonus`", "`ChangeID` = @ChangeID", paras_, tm_);
		}
		public async Task<bool> GetIsBonusByPKAsync(string changeID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChangeID", changeID, MySqlDbType.VarChar),
			};
			return (bool)await GetScalarAsync("`IsBonus`", "`ChangeID` = @ChangeID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 FlowMultip（字段）
		/// </summary>
		/// /// <param name = "changeID">货币变化编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public float GetFlowMultipByPK(string changeID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChangeID", changeID, MySqlDbType.VarChar),
			};
			return (float)GetScalar("`FlowMultip`", "`ChangeID` = @ChangeID", paras_, tm_);
		}
		public async Task<float> GetFlowMultipByPKAsync(string changeID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChangeID", changeID, MySqlDbType.VarChar),
			};
			return (float)await GetScalarAsync("`FlowMultip`", "`ChangeID` = @ChangeID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Reason（字段）
		/// </summary>
		/// /// <param name = "changeID">货币变化编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetReasonByPK(string changeID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChangeID", changeID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`Reason`", "`ChangeID` = @ChangeID", paras_, tm_);
		}
		public async Task<string> GetReasonByPKAsync(string changeID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChangeID", changeID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`Reason`", "`ChangeID` = @ChangeID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 PlanAmount（字段）
		/// </summary>
		/// /// <param name = "changeID">货币变化编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetPlanAmountByPK(string changeID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChangeID", changeID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`PlanAmount`", "`ChangeID` = @ChangeID", paras_, tm_);
		}
		public async Task<long> GetPlanAmountByPKAsync(string changeID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChangeID", changeID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`PlanAmount`", "`ChangeID` = @ChangeID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Meta（字段）
		/// </summary>
		/// /// <param name = "changeID">货币变化编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetMetaByPK(string changeID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChangeID", changeID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`Meta`", "`ChangeID` = @ChangeID", paras_, tm_);
		}
		public async Task<string> GetMetaByPKAsync(string changeID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChangeID", changeID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`Meta`", "`ChangeID` = @ChangeID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 SourceType（字段）
		/// </summary>
		/// /// <param name = "changeID">货币变化编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetSourceTypeByPK(string changeID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChangeID", changeID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`SourceType`", "`ChangeID` = @ChangeID", paras_, tm_);
		}
		public async Task<int> GetSourceTypeByPKAsync(string changeID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChangeID", changeID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`SourceType`", "`ChangeID` = @ChangeID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 SourceTable（字段）
		/// </summary>
		/// /// <param name = "changeID">货币变化编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetSourceTableByPK(string changeID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChangeID", changeID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`SourceTable`", "`ChangeID` = @ChangeID", paras_, tm_);
		}
		public async Task<string> GetSourceTableByPKAsync(string changeID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChangeID", changeID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`SourceTable`", "`ChangeID` = @ChangeID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 SourceId（字段）
		/// </summary>
		/// /// <param name = "changeID">货币变化编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetSourceIdByPK(string changeID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChangeID", changeID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`SourceId`", "`ChangeID` = @ChangeID", paras_, tm_);
		}
		public async Task<string> GetSourceIdByPKAsync(string changeID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChangeID", changeID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`SourceId`", "`ChangeID` = @ChangeID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 UserIp（字段）
		/// </summary>
		/// /// <param name = "changeID">货币变化编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetUserIpByPK(string changeID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChangeID", changeID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`UserIp`", "`ChangeID` = @ChangeID", paras_, tm_);
		}
		public async Task<string> GetUserIpByPKAsync(string changeID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChangeID", changeID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`UserIp`", "`ChangeID` = @ChangeID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Status（字段）
		/// </summary>
		/// /// <param name = "changeID">货币变化编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetStatusByPK(string changeID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChangeID", changeID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`Status`", "`ChangeID` = @ChangeID", paras_, tm_);
		}
		public async Task<int> GetStatusByPKAsync(string changeID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChangeID", changeID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`Status`", "`ChangeID` = @ChangeID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 RecDate（字段）
		/// </summary>
		/// /// <param name = "changeID">货币变化编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime GetRecDateByPK(string changeID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChangeID", changeID, MySqlDbType.VarChar),
			};
			return (DateTime)GetScalar("`RecDate`", "`ChangeID` = @ChangeID", paras_, tm_);
		}
		public async Task<DateTime> GetRecDateByPKAsync(string changeID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChangeID", changeID, MySqlDbType.VarChar),
			};
			return (DateTime)await GetScalarAsync("`RecDate`", "`ChangeID` = @ChangeID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 DealTime（字段）
		/// </summary>
		/// /// <param name = "changeID">货币变化编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime? GetDealTimeByPK(string changeID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChangeID", changeID, MySqlDbType.VarChar),
			};
			return (DateTime?)GetScalar("`DealTime`", "`ChangeID` = @ChangeID", paras_, tm_);
		}
		public async Task<DateTime?> GetDealTimeByPKAsync(string changeID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChangeID", changeID, MySqlDbType.VarChar),
			};
			return (DateTime?)await GetScalarAsync("`DealTime`", "`ChangeID` = @ChangeID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 DealStatus（字段）
		/// </summary>
		/// /// <param name = "changeID">货币变化编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetDealStatusByPK(string changeID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChangeID", changeID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`DealStatus`", "`ChangeID` = @ChangeID", paras_, tm_);
		}
		public async Task<string> GetDealStatusByPKAsync(string changeID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChangeID", changeID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`DealStatus`", "`ChangeID` = @ChangeID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Amount（字段）
		/// </summary>
		/// /// <param name = "changeID">货币变化编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetAmountByPK(string changeID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChangeID", changeID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`Amount`", "`ChangeID` = @ChangeID", paras_, tm_);
		}
		public async Task<long> GetAmountByPKAsync(string changeID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChangeID", changeID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`Amount`", "`ChangeID` = @ChangeID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 EndBalance（字段）
		/// </summary>
		/// /// <param name = "changeID">货币变化编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetEndBalanceByPK(string changeID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChangeID", changeID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`EndBalance`", "`ChangeID` = @ChangeID", paras_, tm_);
		}
		public async Task<long> GetEndBalanceByPKAsync(string changeID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChangeID", changeID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`EndBalance`", "`ChangeID` = @ChangeID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 AmountBonus（字段）
		/// </summary>
		/// /// <param name = "changeID">货币变化编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetAmountBonusByPK(string changeID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChangeID", changeID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`AmountBonus`", "`ChangeID` = @ChangeID", paras_, tm_);
		}
		public async Task<long> GetAmountBonusByPKAsync(string changeID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChangeID", changeID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`AmountBonus`", "`ChangeID` = @ChangeID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 EndBonus（字段）
		/// </summary>
		/// /// <param name = "changeID">货币变化编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetEndBonusByPK(string changeID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChangeID", changeID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`EndBonus`", "`ChangeID` = @ChangeID", paras_, tm_);
		}
		public async Task<long> GetEndBonusByPKAsync(string changeID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChangeID", changeID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`EndBonus`", "`ChangeID` = @ChangeID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 SettlStatus（字段）
		/// </summary>
		/// /// <param name = "changeID">货币变化编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetSettlStatusByPK(string changeID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChangeID", changeID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`SettlStatus`", "`ChangeID` = @ChangeID", paras_, tm_);
		}
		public async Task<int> GetSettlStatusByPKAsync(string changeID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChangeID", changeID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`SettlStatus`", "`ChangeID` = @ChangeID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 SettlTable（字段）
		/// </summary>
		/// /// <param name = "changeID">货币变化编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetSettlTableByPK(string changeID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChangeID", changeID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`SettlTable`", "`ChangeID` = @ChangeID", paras_, tm_);
		}
		public async Task<string> GetSettlTableByPKAsync(string changeID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChangeID", changeID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`SettlTable`", "`ChangeID` = @ChangeID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 SettlId（字段）
		/// </summary>
		/// /// <param name = "changeID">货币变化编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetSettlIdByPK(string changeID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChangeID", changeID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`SettlId`", "`ChangeID` = @ChangeID", paras_, tm_);
		}
		public async Task<string> GetSettlIdByPKAsync(string changeID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChangeID", changeID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`SettlId`", "`ChangeID` = @ChangeID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 SettlAmount（字段）
		/// </summary>
		/// /// <param name = "changeID">货币变化编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetSettlAmountByPK(string changeID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChangeID", changeID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`SettlAmount`", "`ChangeID` = @ChangeID", paras_, tm_);
		}
		public async Task<long> GetSettlAmountByPKAsync(string changeID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChangeID", changeID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`SettlAmount`", "`ChangeID` = @ChangeID", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByProviderID
		
		/// <summary>
		/// 按 ProviderID（字段） 查询
		/// </summary>
		/// /// <param name = "providerID">应用提供商编码</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByProviderID(string providerID)
		{
			return GetByProviderID(providerID, 0, string.Empty, null);
		}
		public async Task<List<S_currency_changeEO>> GetByProviderIDAsync(string providerID)
		{
			return await GetByProviderIDAsync(providerID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ProviderID（字段） 查询
		/// </summary>
		/// /// <param name = "providerID">应用提供商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByProviderID(string providerID, TransactionManager tm_)
		{
			return GetByProviderID(providerID, 0, string.Empty, tm_);
		}
		public async Task<List<S_currency_changeEO>> GetByProviderIDAsync(string providerID, TransactionManager tm_)
		{
			return await GetByProviderIDAsync(providerID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ProviderID（字段） 查询
		/// </summary>
		/// /// <param name = "providerID">应用提供商编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByProviderID(string providerID, int top_)
		{
			return GetByProviderID(providerID, top_, string.Empty, null);
		}
		public async Task<List<S_currency_changeEO>> GetByProviderIDAsync(string providerID, int top_)
		{
			return await GetByProviderIDAsync(providerID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ProviderID（字段） 查询
		/// </summary>
		/// /// <param name = "providerID">应用提供商编码</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByProviderID(string providerID, int top_, TransactionManager tm_)
		{
			return GetByProviderID(providerID, top_, string.Empty, tm_);
		}
		public async Task<List<S_currency_changeEO>> GetByProviderIDAsync(string providerID, int top_, TransactionManager tm_)
		{
			return await GetByProviderIDAsync(providerID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ProviderID（字段） 查询
		/// </summary>
		/// /// <param name = "providerID">应用提供商编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByProviderID(string providerID, string sort_)
		{
			return GetByProviderID(providerID, 0, sort_, null);
		}
		public async Task<List<S_currency_changeEO>> GetByProviderIDAsync(string providerID, string sort_)
		{
			return await GetByProviderIDAsync(providerID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 ProviderID（字段） 查询
		/// </summary>
		/// /// <param name = "providerID">应用提供商编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByProviderID(string providerID, string sort_, TransactionManager tm_)
		{
			return GetByProviderID(providerID, 0, sort_, tm_);
		}
		public async Task<List<S_currency_changeEO>> GetByProviderIDAsync(string providerID, string sort_, TransactionManager tm_)
		{
			return await GetByProviderIDAsync(providerID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 ProviderID（字段） 查询
		/// </summary>
		/// /// <param name = "providerID">应用提供商编码</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByProviderID(string providerID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(providerID != null ? "`ProviderID` = @ProviderID" : "`ProviderID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (providerID != null)
				paras_.Add(Database.CreateInParameter("@ProviderID", providerID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_currency_changeEO.MapDataReader);
		}
		public async Task<List<S_currency_changeEO>> GetByProviderIDAsync(string providerID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(providerID != null ? "`ProviderID` = @ProviderID" : "`ProviderID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (providerID != null)
				paras_.Add(Database.CreateInParameter("@ProviderID", providerID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_currency_changeEO.MapDataReader);
		}
		#endregion // GetByProviderID
		#region GetByAppID
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByAppID(string appID)
		{
			return GetByAppID(appID, 0, string.Empty, null);
		}
		public async Task<List<S_currency_changeEO>> GetByAppIDAsync(string appID)
		{
			return await GetByAppIDAsync(appID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByAppID(string appID, TransactionManager tm_)
		{
			return GetByAppID(appID, 0, string.Empty, tm_);
		}
		public async Task<List<S_currency_changeEO>> GetByAppIDAsync(string appID, TransactionManager tm_)
		{
			return await GetByAppIDAsync(appID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByAppID(string appID, int top_)
		{
			return GetByAppID(appID, top_, string.Empty, null);
		}
		public async Task<List<S_currency_changeEO>> GetByAppIDAsync(string appID, int top_)
		{
			return await GetByAppIDAsync(appID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByAppID(string appID, int top_, TransactionManager tm_)
		{
			return GetByAppID(appID, top_, string.Empty, tm_);
		}
		public async Task<List<S_currency_changeEO>> GetByAppIDAsync(string appID, int top_, TransactionManager tm_)
		{
			return await GetByAppIDAsync(appID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByAppID(string appID, string sort_)
		{
			return GetByAppID(appID, 0, sort_, null);
		}
		public async Task<List<S_currency_changeEO>> GetByAppIDAsync(string appID, string sort_)
		{
			return await GetByAppIDAsync(appID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByAppID(string appID, string sort_, TransactionManager tm_)
		{
			return GetByAppID(appID, 0, sort_, tm_);
		}
		public async Task<List<S_currency_changeEO>> GetByAppIDAsync(string appID, string sort_, TransactionManager tm_)
		{
			return await GetByAppIDAsync(appID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByAppID(string appID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(appID != null ? "`AppID` = @AppID" : "`AppID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (appID != null)
				paras_.Add(Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_currency_changeEO.MapDataReader);
		}
		public async Task<List<S_currency_changeEO>> GetByAppIDAsync(string appID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(appID != null ? "`AppID` = @AppID" : "`AppID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (appID != null)
				paras_.Add(Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_currency_changeEO.MapDataReader);
		}
		#endregion // GetByAppID
		#region GetByOperatorID
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByOperatorID(string operatorID)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, null);
		}
		public async Task<List<S_currency_changeEO>> GetByOperatorIDAsync(string operatorID)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByOperatorID(string operatorID, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, tm_);
		}
		public async Task<List<S_currency_changeEO>> GetByOperatorIDAsync(string operatorID, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByOperatorID(string operatorID, int top_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, null);
		}
		public async Task<List<S_currency_changeEO>> GetByOperatorIDAsync(string operatorID, int top_)
		{
			return await GetByOperatorIDAsync(operatorID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByOperatorID(string operatorID, int top_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, tm_);
		}
		public async Task<List<S_currency_changeEO>> GetByOperatorIDAsync(string operatorID, int top_, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByOperatorID(string operatorID, string sort_)
		{
			return GetByOperatorID(operatorID, 0, sort_, null);
		}
		public async Task<List<S_currency_changeEO>> GetByOperatorIDAsync(string operatorID, string sort_)
		{
			return await GetByOperatorIDAsync(operatorID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByOperatorID(string operatorID, string sort_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, sort_, tm_);
		}
		public async Task<List<S_currency_changeEO>> GetByOperatorIDAsync(string operatorID, string sort_, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByOperatorID(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(operatorID != null ? "`OperatorID` = @OperatorID" : "`OperatorID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (operatorID != null)
				paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_currency_changeEO.MapDataReader);
		}
		public async Task<List<S_currency_changeEO>> GetByOperatorIDAsync(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(operatorID != null ? "`OperatorID` = @OperatorID" : "`OperatorID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (operatorID != null)
				paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_currency_changeEO.MapDataReader);
		}
		#endregion // GetByOperatorID
		#region GetByUserID
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByUserID(string userID)
		{
			return GetByUserID(userID, 0, string.Empty, null);
		}
		public async Task<List<S_currency_changeEO>> GetByUserIDAsync(string userID)
		{
			return await GetByUserIDAsync(userID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByUserID(string userID, TransactionManager tm_)
		{
			return GetByUserID(userID, 0, string.Empty, tm_);
		}
		public async Task<List<S_currency_changeEO>> GetByUserIDAsync(string userID, TransactionManager tm_)
		{
			return await GetByUserIDAsync(userID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByUserID(string userID, int top_)
		{
			return GetByUserID(userID, top_, string.Empty, null);
		}
		public async Task<List<S_currency_changeEO>> GetByUserIDAsync(string userID, int top_)
		{
			return await GetByUserIDAsync(userID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByUserID(string userID, int top_, TransactionManager tm_)
		{
			return GetByUserID(userID, top_, string.Empty, tm_);
		}
		public async Task<List<S_currency_changeEO>> GetByUserIDAsync(string userID, int top_, TransactionManager tm_)
		{
			return await GetByUserIDAsync(userID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByUserID(string userID, string sort_)
		{
			return GetByUserID(userID, 0, sort_, null);
		}
		public async Task<List<S_currency_changeEO>> GetByUserIDAsync(string userID, string sort_)
		{
			return await GetByUserIDAsync(userID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByUserID(string userID, string sort_, TransactionManager tm_)
		{
			return GetByUserID(userID, 0, sort_, tm_);
		}
		public async Task<List<S_currency_changeEO>> GetByUserIDAsync(string userID, string sort_, TransactionManager tm_)
		{
			return await GetByUserIDAsync(userID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByUserID(string userID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(userID != null ? "`UserID` = @UserID" : "`UserID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (userID != null)
				paras_.Add(Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_currency_changeEO.MapDataReader);
		}
		public async Task<List<S_currency_changeEO>> GetByUserIDAsync(string userID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(userID != null ? "`UserID` = @UserID" : "`UserID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (userID != null)
				paras_.Add(Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_currency_changeEO.MapDataReader);
		}
		#endregion // GetByUserID
		#region GetByFromMode
		
		/// <summary>
		/// 按 FromMode（字段） 查询
		/// </summary>
		/// /// <param name = "fromMode">新用户来源方式</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByFromMode(int fromMode)
		{
			return GetByFromMode(fromMode, 0, string.Empty, null);
		}
		public async Task<List<S_currency_changeEO>> GetByFromModeAsync(int fromMode)
		{
			return await GetByFromModeAsync(fromMode, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 FromMode（字段） 查询
		/// </summary>
		/// /// <param name = "fromMode">新用户来源方式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByFromMode(int fromMode, TransactionManager tm_)
		{
			return GetByFromMode(fromMode, 0, string.Empty, tm_);
		}
		public async Task<List<S_currency_changeEO>> GetByFromModeAsync(int fromMode, TransactionManager tm_)
		{
			return await GetByFromModeAsync(fromMode, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FromMode（字段） 查询
		/// </summary>
		/// /// <param name = "fromMode">新用户来源方式</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByFromMode(int fromMode, int top_)
		{
			return GetByFromMode(fromMode, top_, string.Empty, null);
		}
		public async Task<List<S_currency_changeEO>> GetByFromModeAsync(int fromMode, int top_)
		{
			return await GetByFromModeAsync(fromMode, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 FromMode（字段） 查询
		/// </summary>
		/// /// <param name = "fromMode">新用户来源方式</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByFromMode(int fromMode, int top_, TransactionManager tm_)
		{
			return GetByFromMode(fromMode, top_, string.Empty, tm_);
		}
		public async Task<List<S_currency_changeEO>> GetByFromModeAsync(int fromMode, int top_, TransactionManager tm_)
		{
			return await GetByFromModeAsync(fromMode, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FromMode（字段） 查询
		/// </summary>
		/// /// <param name = "fromMode">新用户来源方式</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByFromMode(int fromMode, string sort_)
		{
			return GetByFromMode(fromMode, 0, sort_, null);
		}
		public async Task<List<S_currency_changeEO>> GetByFromModeAsync(int fromMode, string sort_)
		{
			return await GetByFromModeAsync(fromMode, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 FromMode（字段） 查询
		/// </summary>
		/// /// <param name = "fromMode">新用户来源方式</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByFromMode(int fromMode, string sort_, TransactionManager tm_)
		{
			return GetByFromMode(fromMode, 0, sort_, tm_);
		}
		public async Task<List<S_currency_changeEO>> GetByFromModeAsync(int fromMode, string sort_, TransactionManager tm_)
		{
			return await GetByFromModeAsync(fromMode, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 FromMode（字段） 查询
		/// </summary>
		/// /// <param name = "fromMode">新用户来源方式</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByFromMode(int fromMode, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`FromMode` = @FromMode", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FromMode", fromMode, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, S_currency_changeEO.MapDataReader);
		}
		public async Task<List<S_currency_changeEO>> GetByFromModeAsync(int fromMode, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`FromMode` = @FromMode", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FromMode", fromMode, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_currency_changeEO.MapDataReader);
		}
		#endregion // GetByFromMode
		#region GetByFromId
		
		/// <summary>
		/// 按 FromId（字段） 查询
		/// </summary>
		/// /// <param name = "fromId">对应的编码（根据FromMode变化）</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByFromId(string fromId)
		{
			return GetByFromId(fromId, 0, string.Empty, null);
		}
		public async Task<List<S_currency_changeEO>> GetByFromIdAsync(string fromId)
		{
			return await GetByFromIdAsync(fromId, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 FromId（字段） 查询
		/// </summary>
		/// /// <param name = "fromId">对应的编码（根据FromMode变化）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByFromId(string fromId, TransactionManager tm_)
		{
			return GetByFromId(fromId, 0, string.Empty, tm_);
		}
		public async Task<List<S_currency_changeEO>> GetByFromIdAsync(string fromId, TransactionManager tm_)
		{
			return await GetByFromIdAsync(fromId, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FromId（字段） 查询
		/// </summary>
		/// /// <param name = "fromId">对应的编码（根据FromMode变化）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByFromId(string fromId, int top_)
		{
			return GetByFromId(fromId, top_, string.Empty, null);
		}
		public async Task<List<S_currency_changeEO>> GetByFromIdAsync(string fromId, int top_)
		{
			return await GetByFromIdAsync(fromId, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 FromId（字段） 查询
		/// </summary>
		/// /// <param name = "fromId">对应的编码（根据FromMode变化）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByFromId(string fromId, int top_, TransactionManager tm_)
		{
			return GetByFromId(fromId, top_, string.Empty, tm_);
		}
		public async Task<List<S_currency_changeEO>> GetByFromIdAsync(string fromId, int top_, TransactionManager tm_)
		{
			return await GetByFromIdAsync(fromId, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FromId（字段） 查询
		/// </summary>
		/// /// <param name = "fromId">对应的编码（根据FromMode变化）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByFromId(string fromId, string sort_)
		{
			return GetByFromId(fromId, 0, sort_, null);
		}
		public async Task<List<S_currency_changeEO>> GetByFromIdAsync(string fromId, string sort_)
		{
			return await GetByFromIdAsync(fromId, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 FromId（字段） 查询
		/// </summary>
		/// /// <param name = "fromId">对应的编码（根据FromMode变化）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByFromId(string fromId, string sort_, TransactionManager tm_)
		{
			return GetByFromId(fromId, 0, sort_, tm_);
		}
		public async Task<List<S_currency_changeEO>> GetByFromIdAsync(string fromId, string sort_, TransactionManager tm_)
		{
			return await GetByFromIdAsync(fromId, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 FromId（字段） 查询
		/// </summary>
		/// /// <param name = "fromId">对应的编码（根据FromMode变化）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByFromId(string fromId, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(fromId != null ? "`FromId` = @FromId" : "`FromId` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (fromId != null)
				paras_.Add(Database.CreateInParameter("@FromId", fromId, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_currency_changeEO.MapDataReader);
		}
		public async Task<List<S_currency_changeEO>> GetByFromIdAsync(string fromId, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(fromId != null ? "`FromId` = @FromId" : "`FromId` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (fromId != null)
				paras_.Add(Database.CreateInParameter("@FromId", fromId, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_currency_changeEO.MapDataReader);
		}
		#endregion // GetByFromId
		#region GetByUserKind
		
		/// <summary>
		/// 按 UserKind（字段） 查询
		/// </summary>
		/// /// <param name = "userKind">用户类型</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByUserKind(int userKind)
		{
			return GetByUserKind(userKind, 0, string.Empty, null);
		}
		public async Task<List<S_currency_changeEO>> GetByUserKindAsync(int userKind)
		{
			return await GetByUserKindAsync(userKind, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UserKind（字段） 查询
		/// </summary>
		/// /// <param name = "userKind">用户类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByUserKind(int userKind, TransactionManager tm_)
		{
			return GetByUserKind(userKind, 0, string.Empty, tm_);
		}
		public async Task<List<S_currency_changeEO>> GetByUserKindAsync(int userKind, TransactionManager tm_)
		{
			return await GetByUserKindAsync(userKind, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserKind（字段） 查询
		/// </summary>
		/// /// <param name = "userKind">用户类型</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByUserKind(int userKind, int top_)
		{
			return GetByUserKind(userKind, top_, string.Empty, null);
		}
		public async Task<List<S_currency_changeEO>> GetByUserKindAsync(int userKind, int top_)
		{
			return await GetByUserKindAsync(userKind, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UserKind（字段） 查询
		/// </summary>
		/// /// <param name = "userKind">用户类型</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByUserKind(int userKind, int top_, TransactionManager tm_)
		{
			return GetByUserKind(userKind, top_, string.Empty, tm_);
		}
		public async Task<List<S_currency_changeEO>> GetByUserKindAsync(int userKind, int top_, TransactionManager tm_)
		{
			return await GetByUserKindAsync(userKind, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserKind（字段） 查询
		/// </summary>
		/// /// <param name = "userKind">用户类型</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByUserKind(int userKind, string sort_)
		{
			return GetByUserKind(userKind, 0, sort_, null);
		}
		public async Task<List<S_currency_changeEO>> GetByUserKindAsync(int userKind, string sort_)
		{
			return await GetByUserKindAsync(userKind, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 UserKind（字段） 查询
		/// </summary>
		/// /// <param name = "userKind">用户类型</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByUserKind(int userKind, string sort_, TransactionManager tm_)
		{
			return GetByUserKind(userKind, 0, sort_, tm_);
		}
		public async Task<List<S_currency_changeEO>> GetByUserKindAsync(int userKind, string sort_, TransactionManager tm_)
		{
			return await GetByUserKindAsync(userKind, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 UserKind（字段） 查询
		/// </summary>
		/// /// <param name = "userKind">用户类型</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByUserKind(int userKind, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UserKind` = @UserKind", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserKind", userKind, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, S_currency_changeEO.MapDataReader);
		}
		public async Task<List<S_currency_changeEO>> GetByUserKindAsync(int userKind, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UserKind` = @UserKind", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserKind", userKind, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_currency_changeEO.MapDataReader);
		}
		#endregion // GetByUserKind
		#region GetByCountryID
		
		/// <summary>
		/// 按 CountryID（字段） 查询
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByCountryID(string countryID)
		{
			return GetByCountryID(countryID, 0, string.Empty, null);
		}
		public async Task<List<S_currency_changeEO>> GetByCountryIDAsync(string countryID)
		{
			return await GetByCountryIDAsync(countryID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CountryID（字段） 查询
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByCountryID(string countryID, TransactionManager tm_)
		{
			return GetByCountryID(countryID, 0, string.Empty, tm_);
		}
		public async Task<List<S_currency_changeEO>> GetByCountryIDAsync(string countryID, TransactionManager tm_)
		{
			return await GetByCountryIDAsync(countryID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CountryID（字段） 查询
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByCountryID(string countryID, int top_)
		{
			return GetByCountryID(countryID, top_, string.Empty, null);
		}
		public async Task<List<S_currency_changeEO>> GetByCountryIDAsync(string countryID, int top_)
		{
			return await GetByCountryIDAsync(countryID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CountryID（字段） 查询
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByCountryID(string countryID, int top_, TransactionManager tm_)
		{
			return GetByCountryID(countryID, top_, string.Empty, tm_);
		}
		public async Task<List<S_currency_changeEO>> GetByCountryIDAsync(string countryID, int top_, TransactionManager tm_)
		{
			return await GetByCountryIDAsync(countryID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CountryID（字段） 查询
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByCountryID(string countryID, string sort_)
		{
			return GetByCountryID(countryID, 0, sort_, null);
		}
		public async Task<List<S_currency_changeEO>> GetByCountryIDAsync(string countryID, string sort_)
		{
			return await GetByCountryIDAsync(countryID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 CountryID（字段） 查询
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByCountryID(string countryID, string sort_, TransactionManager tm_)
		{
			return GetByCountryID(countryID, 0, sort_, tm_);
		}
		public async Task<List<S_currency_changeEO>> GetByCountryIDAsync(string countryID, string sort_, TransactionManager tm_)
		{
			return await GetByCountryIDAsync(countryID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 CountryID（字段） 查询
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByCountryID(string countryID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(countryID != null ? "`CountryID` = @CountryID" : "`CountryID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (countryID != null)
				paras_.Add(Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_currency_changeEO.MapDataReader);
		}
		public async Task<List<S_currency_changeEO>> GetByCountryIDAsync(string countryID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(countryID != null ? "`CountryID` = @CountryID" : "`CountryID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (countryID != null)
				paras_.Add(Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_currency_changeEO.MapDataReader);
		}
		#endregion // GetByCountryID
		#region GetByCurrencyID
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型（货币缩写USD）</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByCurrencyID(string currencyID)
		{
			return GetByCurrencyID(currencyID, 0, string.Empty, null);
		}
		public async Task<List<S_currency_changeEO>> GetByCurrencyIDAsync(string currencyID)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型（货币缩写USD）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByCurrencyID(string currencyID, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, 0, string.Empty, tm_);
		}
		public async Task<List<S_currency_changeEO>> GetByCurrencyIDAsync(string currencyID, TransactionManager tm_)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型（货币缩写USD）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByCurrencyID(string currencyID, int top_)
		{
			return GetByCurrencyID(currencyID, top_, string.Empty, null);
		}
		public async Task<List<S_currency_changeEO>> GetByCurrencyIDAsync(string currencyID, int top_)
		{
			return await GetByCurrencyIDAsync(currencyID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型（货币缩写USD）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByCurrencyID(string currencyID, int top_, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, top_, string.Empty, tm_);
		}
		public async Task<List<S_currency_changeEO>> GetByCurrencyIDAsync(string currencyID, int top_, TransactionManager tm_)
		{
			return await GetByCurrencyIDAsync(currencyID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型（货币缩写USD）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByCurrencyID(string currencyID, string sort_)
		{
			return GetByCurrencyID(currencyID, 0, sort_, null);
		}
		public async Task<List<S_currency_changeEO>> GetByCurrencyIDAsync(string currencyID, string sort_)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型（货币缩写USD）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByCurrencyID(string currencyID, string sort_, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, 0, sort_, tm_);
		}
		public async Task<List<S_currency_changeEO>> GetByCurrencyIDAsync(string currencyID, string sort_, TransactionManager tm_)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型（货币缩写USD）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByCurrencyID(string currencyID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(currencyID != null ? "`CurrencyID` = @CurrencyID" : "`CurrencyID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (currencyID != null)
				paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_currency_changeEO.MapDataReader);
		}
		public async Task<List<S_currency_changeEO>> GetByCurrencyIDAsync(string currencyID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(currencyID != null ? "`CurrencyID` = @CurrencyID" : "`CurrencyID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (currencyID != null)
				paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_currency_changeEO.MapDataReader);
		}
		#endregion // GetByCurrencyID
		#region GetByCurrencyType
		
		/// <summary>
		/// 按 CurrencyType（字段） 查询
		/// </summary>
		/// /// <param name = "currencyType">货币类型 1-COIN 2--GOLD 3-POINT 4-SWB 8-虚拟货币 9-CASH</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByCurrencyType(int currencyType)
		{
			return GetByCurrencyType(currencyType, 0, string.Empty, null);
		}
		public async Task<List<S_currency_changeEO>> GetByCurrencyTypeAsync(int currencyType)
		{
			return await GetByCurrencyTypeAsync(currencyType, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CurrencyType（字段） 查询
		/// </summary>
		/// /// <param name = "currencyType">货币类型 1-COIN 2--GOLD 3-POINT 4-SWB 8-虚拟货币 9-CASH</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByCurrencyType(int currencyType, TransactionManager tm_)
		{
			return GetByCurrencyType(currencyType, 0, string.Empty, tm_);
		}
		public async Task<List<S_currency_changeEO>> GetByCurrencyTypeAsync(int currencyType, TransactionManager tm_)
		{
			return await GetByCurrencyTypeAsync(currencyType, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyType（字段） 查询
		/// </summary>
		/// /// <param name = "currencyType">货币类型 1-COIN 2--GOLD 3-POINT 4-SWB 8-虚拟货币 9-CASH</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByCurrencyType(int currencyType, int top_)
		{
			return GetByCurrencyType(currencyType, top_, string.Empty, null);
		}
		public async Task<List<S_currency_changeEO>> GetByCurrencyTypeAsync(int currencyType, int top_)
		{
			return await GetByCurrencyTypeAsync(currencyType, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CurrencyType（字段） 查询
		/// </summary>
		/// /// <param name = "currencyType">货币类型 1-COIN 2--GOLD 3-POINT 4-SWB 8-虚拟货币 9-CASH</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByCurrencyType(int currencyType, int top_, TransactionManager tm_)
		{
			return GetByCurrencyType(currencyType, top_, string.Empty, tm_);
		}
		public async Task<List<S_currency_changeEO>> GetByCurrencyTypeAsync(int currencyType, int top_, TransactionManager tm_)
		{
			return await GetByCurrencyTypeAsync(currencyType, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyType（字段） 查询
		/// </summary>
		/// /// <param name = "currencyType">货币类型 1-COIN 2--GOLD 3-POINT 4-SWB 8-虚拟货币 9-CASH</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByCurrencyType(int currencyType, string sort_)
		{
			return GetByCurrencyType(currencyType, 0, sort_, null);
		}
		public async Task<List<S_currency_changeEO>> GetByCurrencyTypeAsync(int currencyType, string sort_)
		{
			return await GetByCurrencyTypeAsync(currencyType, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 CurrencyType（字段） 查询
		/// </summary>
		/// /// <param name = "currencyType">货币类型 1-COIN 2--GOLD 3-POINT 4-SWB 8-虚拟货币 9-CASH</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByCurrencyType(int currencyType, string sort_, TransactionManager tm_)
		{
			return GetByCurrencyType(currencyType, 0, sort_, tm_);
		}
		public async Task<List<S_currency_changeEO>> GetByCurrencyTypeAsync(int currencyType, string sort_, TransactionManager tm_)
		{
			return await GetByCurrencyTypeAsync(currencyType, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyType（字段） 查询
		/// </summary>
		/// /// <param name = "currencyType">货币类型 1-COIN 2--GOLD 3-POINT 4-SWB 8-虚拟货币 9-CASH</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByCurrencyType(int currencyType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CurrencyType` = @CurrencyType", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CurrencyType", currencyType, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, S_currency_changeEO.MapDataReader);
		}
		public async Task<List<S_currency_changeEO>> GetByCurrencyTypeAsync(int currencyType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CurrencyType` = @CurrencyType", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CurrencyType", currencyType, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_currency_changeEO.MapDataReader);
		}
		#endregion // GetByCurrencyType
		#region GetByIsBonus
		
		/// <summary>
		/// 按 IsBonus（字段） 查询
		/// </summary>
		/// /// <param name = "isBonus">是否赠金</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByIsBonus(bool isBonus)
		{
			return GetByIsBonus(isBonus, 0, string.Empty, null);
		}
		public async Task<List<S_currency_changeEO>> GetByIsBonusAsync(bool isBonus)
		{
			return await GetByIsBonusAsync(isBonus, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 IsBonus（字段） 查询
		/// </summary>
		/// /// <param name = "isBonus">是否赠金</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByIsBonus(bool isBonus, TransactionManager tm_)
		{
			return GetByIsBonus(isBonus, 0, string.Empty, tm_);
		}
		public async Task<List<S_currency_changeEO>> GetByIsBonusAsync(bool isBonus, TransactionManager tm_)
		{
			return await GetByIsBonusAsync(isBonus, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IsBonus（字段） 查询
		/// </summary>
		/// /// <param name = "isBonus">是否赠金</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByIsBonus(bool isBonus, int top_)
		{
			return GetByIsBonus(isBonus, top_, string.Empty, null);
		}
		public async Task<List<S_currency_changeEO>> GetByIsBonusAsync(bool isBonus, int top_)
		{
			return await GetByIsBonusAsync(isBonus, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 IsBonus（字段） 查询
		/// </summary>
		/// /// <param name = "isBonus">是否赠金</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByIsBonus(bool isBonus, int top_, TransactionManager tm_)
		{
			return GetByIsBonus(isBonus, top_, string.Empty, tm_);
		}
		public async Task<List<S_currency_changeEO>> GetByIsBonusAsync(bool isBonus, int top_, TransactionManager tm_)
		{
			return await GetByIsBonusAsync(isBonus, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IsBonus（字段） 查询
		/// </summary>
		/// /// <param name = "isBonus">是否赠金</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByIsBonus(bool isBonus, string sort_)
		{
			return GetByIsBonus(isBonus, 0, sort_, null);
		}
		public async Task<List<S_currency_changeEO>> GetByIsBonusAsync(bool isBonus, string sort_)
		{
			return await GetByIsBonusAsync(isBonus, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 IsBonus（字段） 查询
		/// </summary>
		/// /// <param name = "isBonus">是否赠金</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByIsBonus(bool isBonus, string sort_, TransactionManager tm_)
		{
			return GetByIsBonus(isBonus, 0, sort_, tm_);
		}
		public async Task<List<S_currency_changeEO>> GetByIsBonusAsync(bool isBonus, string sort_, TransactionManager tm_)
		{
			return await GetByIsBonusAsync(isBonus, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 IsBonus（字段） 查询
		/// </summary>
		/// /// <param name = "isBonus">是否赠金</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByIsBonus(bool isBonus, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`IsBonus` = @IsBonus", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IsBonus", isBonus, MySqlDbType.Byte));
			return Database.ExecSqlList(sql_, paras_, tm_, S_currency_changeEO.MapDataReader);
		}
		public async Task<List<S_currency_changeEO>> GetByIsBonusAsync(bool isBonus, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`IsBonus` = @IsBonus", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IsBonus", isBonus, MySqlDbType.Byte));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_currency_changeEO.MapDataReader);
		}
		#endregion // GetByIsBonus
		#region GetByFlowMultip
		
		/// <summary>
		/// 按 FlowMultip（字段） 查询
		/// </summary>
		/// /// <param name = "flowMultip">要求的流水系数</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByFlowMultip(float flowMultip)
		{
			return GetByFlowMultip(flowMultip, 0, string.Empty, null);
		}
		public async Task<List<S_currency_changeEO>> GetByFlowMultipAsync(float flowMultip)
		{
			return await GetByFlowMultipAsync(flowMultip, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 FlowMultip（字段） 查询
		/// </summary>
		/// /// <param name = "flowMultip">要求的流水系数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByFlowMultip(float flowMultip, TransactionManager tm_)
		{
			return GetByFlowMultip(flowMultip, 0, string.Empty, tm_);
		}
		public async Task<List<S_currency_changeEO>> GetByFlowMultipAsync(float flowMultip, TransactionManager tm_)
		{
			return await GetByFlowMultipAsync(flowMultip, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FlowMultip（字段） 查询
		/// </summary>
		/// /// <param name = "flowMultip">要求的流水系数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByFlowMultip(float flowMultip, int top_)
		{
			return GetByFlowMultip(flowMultip, top_, string.Empty, null);
		}
		public async Task<List<S_currency_changeEO>> GetByFlowMultipAsync(float flowMultip, int top_)
		{
			return await GetByFlowMultipAsync(flowMultip, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 FlowMultip（字段） 查询
		/// </summary>
		/// /// <param name = "flowMultip">要求的流水系数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByFlowMultip(float flowMultip, int top_, TransactionManager tm_)
		{
			return GetByFlowMultip(flowMultip, top_, string.Empty, tm_);
		}
		public async Task<List<S_currency_changeEO>> GetByFlowMultipAsync(float flowMultip, int top_, TransactionManager tm_)
		{
			return await GetByFlowMultipAsync(flowMultip, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FlowMultip（字段） 查询
		/// </summary>
		/// /// <param name = "flowMultip">要求的流水系数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByFlowMultip(float flowMultip, string sort_)
		{
			return GetByFlowMultip(flowMultip, 0, sort_, null);
		}
		public async Task<List<S_currency_changeEO>> GetByFlowMultipAsync(float flowMultip, string sort_)
		{
			return await GetByFlowMultipAsync(flowMultip, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 FlowMultip（字段） 查询
		/// </summary>
		/// /// <param name = "flowMultip">要求的流水系数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByFlowMultip(float flowMultip, string sort_, TransactionManager tm_)
		{
			return GetByFlowMultip(flowMultip, 0, sort_, tm_);
		}
		public async Task<List<S_currency_changeEO>> GetByFlowMultipAsync(float flowMultip, string sort_, TransactionManager tm_)
		{
			return await GetByFlowMultipAsync(flowMultip, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 FlowMultip（字段） 查询
		/// </summary>
		/// /// <param name = "flowMultip">要求的流水系数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByFlowMultip(float flowMultip, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`FlowMultip` = @FlowMultip", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FlowMultip", flowMultip, MySqlDbType.Float));
			return Database.ExecSqlList(sql_, paras_, tm_, S_currency_changeEO.MapDataReader);
		}
		public async Task<List<S_currency_changeEO>> GetByFlowMultipAsync(float flowMultip, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`FlowMultip` = @FlowMultip", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FlowMultip", flowMultip, MySqlDbType.Float));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_currency_changeEO.MapDataReader);
		}
		#endregion // GetByFlowMultip
		#region GetByReason
		
		/// <summary>
		/// 按 Reason（字段） 查询
		/// </summary>
		/// /// <param name = "reason">变化原因</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByReason(string reason)
		{
			return GetByReason(reason, 0, string.Empty, null);
		}
		public async Task<List<S_currency_changeEO>> GetByReasonAsync(string reason)
		{
			return await GetByReasonAsync(reason, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Reason（字段） 查询
		/// </summary>
		/// /// <param name = "reason">变化原因</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByReason(string reason, TransactionManager tm_)
		{
			return GetByReason(reason, 0, string.Empty, tm_);
		}
		public async Task<List<S_currency_changeEO>> GetByReasonAsync(string reason, TransactionManager tm_)
		{
			return await GetByReasonAsync(reason, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Reason（字段） 查询
		/// </summary>
		/// /// <param name = "reason">变化原因</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByReason(string reason, int top_)
		{
			return GetByReason(reason, top_, string.Empty, null);
		}
		public async Task<List<S_currency_changeEO>> GetByReasonAsync(string reason, int top_)
		{
			return await GetByReasonAsync(reason, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Reason（字段） 查询
		/// </summary>
		/// /// <param name = "reason">变化原因</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByReason(string reason, int top_, TransactionManager tm_)
		{
			return GetByReason(reason, top_, string.Empty, tm_);
		}
		public async Task<List<S_currency_changeEO>> GetByReasonAsync(string reason, int top_, TransactionManager tm_)
		{
			return await GetByReasonAsync(reason, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Reason（字段） 查询
		/// </summary>
		/// /// <param name = "reason">变化原因</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByReason(string reason, string sort_)
		{
			return GetByReason(reason, 0, sort_, null);
		}
		public async Task<List<S_currency_changeEO>> GetByReasonAsync(string reason, string sort_)
		{
			return await GetByReasonAsync(reason, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Reason（字段） 查询
		/// </summary>
		/// /// <param name = "reason">变化原因</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByReason(string reason, string sort_, TransactionManager tm_)
		{
			return GetByReason(reason, 0, sort_, tm_);
		}
		public async Task<List<S_currency_changeEO>> GetByReasonAsync(string reason, string sort_, TransactionManager tm_)
		{
			return await GetByReasonAsync(reason, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Reason（字段） 查询
		/// </summary>
		/// /// <param name = "reason">变化原因</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByReason(string reason, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(reason != null ? "`Reason` = @Reason" : "`Reason` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (reason != null)
				paras_.Add(Database.CreateInParameter("@Reason", reason, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_currency_changeEO.MapDataReader);
		}
		public async Task<List<S_currency_changeEO>> GetByReasonAsync(string reason, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(reason != null ? "`Reason` = @Reason" : "`Reason` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (reason != null)
				paras_.Add(Database.CreateInParameter("@Reason", reason, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_currency_changeEO.MapDataReader);
		}
		#endregion // GetByReason
		#region GetByPlanAmount
		
		/// <summary>
		/// 按 PlanAmount（字段） 查询
		/// </summary>
		/// /// <param name = "planAmount">计划变化金额（正负数）</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByPlanAmount(long planAmount)
		{
			return GetByPlanAmount(planAmount, 0, string.Empty, null);
		}
		public async Task<List<S_currency_changeEO>> GetByPlanAmountAsync(long planAmount)
		{
			return await GetByPlanAmountAsync(planAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PlanAmount（字段） 查询
		/// </summary>
		/// /// <param name = "planAmount">计划变化金额（正负数）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByPlanAmount(long planAmount, TransactionManager tm_)
		{
			return GetByPlanAmount(planAmount, 0, string.Empty, tm_);
		}
		public async Task<List<S_currency_changeEO>> GetByPlanAmountAsync(long planAmount, TransactionManager tm_)
		{
			return await GetByPlanAmountAsync(planAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PlanAmount（字段） 查询
		/// </summary>
		/// /// <param name = "planAmount">计划变化金额（正负数）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByPlanAmount(long planAmount, int top_)
		{
			return GetByPlanAmount(planAmount, top_, string.Empty, null);
		}
		public async Task<List<S_currency_changeEO>> GetByPlanAmountAsync(long planAmount, int top_)
		{
			return await GetByPlanAmountAsync(planAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PlanAmount（字段） 查询
		/// </summary>
		/// /// <param name = "planAmount">计划变化金额（正负数）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByPlanAmount(long planAmount, int top_, TransactionManager tm_)
		{
			return GetByPlanAmount(planAmount, top_, string.Empty, tm_);
		}
		public async Task<List<S_currency_changeEO>> GetByPlanAmountAsync(long planAmount, int top_, TransactionManager tm_)
		{
			return await GetByPlanAmountAsync(planAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PlanAmount（字段） 查询
		/// </summary>
		/// /// <param name = "planAmount">计划变化金额（正负数）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByPlanAmount(long planAmount, string sort_)
		{
			return GetByPlanAmount(planAmount, 0, sort_, null);
		}
		public async Task<List<S_currency_changeEO>> GetByPlanAmountAsync(long planAmount, string sort_)
		{
			return await GetByPlanAmountAsync(planAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 PlanAmount（字段） 查询
		/// </summary>
		/// /// <param name = "planAmount">计划变化金额（正负数）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByPlanAmount(long planAmount, string sort_, TransactionManager tm_)
		{
			return GetByPlanAmount(planAmount, 0, sort_, tm_);
		}
		public async Task<List<S_currency_changeEO>> GetByPlanAmountAsync(long planAmount, string sort_, TransactionManager tm_)
		{
			return await GetByPlanAmountAsync(planAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 PlanAmount（字段） 查询
		/// </summary>
		/// /// <param name = "planAmount">计划变化金额（正负数）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByPlanAmount(long planAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`PlanAmount` = @PlanAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PlanAmount", planAmount, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, S_currency_changeEO.MapDataReader);
		}
		public async Task<List<S_currency_changeEO>> GetByPlanAmountAsync(long planAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`PlanAmount` = @PlanAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PlanAmount", planAmount, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_currency_changeEO.MapDataReader);
		}
		#endregion // GetByPlanAmount
		#region GetByMeta
		
		/// <summary>
		/// 按 Meta（字段） 查询
		/// </summary>
		/// /// <param name = "meta">扩展数据</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByMeta(string meta)
		{
			return GetByMeta(meta, 0, string.Empty, null);
		}
		public async Task<List<S_currency_changeEO>> GetByMetaAsync(string meta)
		{
			return await GetByMetaAsync(meta, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Meta（字段） 查询
		/// </summary>
		/// /// <param name = "meta">扩展数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByMeta(string meta, TransactionManager tm_)
		{
			return GetByMeta(meta, 0, string.Empty, tm_);
		}
		public async Task<List<S_currency_changeEO>> GetByMetaAsync(string meta, TransactionManager tm_)
		{
			return await GetByMetaAsync(meta, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Meta（字段） 查询
		/// </summary>
		/// /// <param name = "meta">扩展数据</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByMeta(string meta, int top_)
		{
			return GetByMeta(meta, top_, string.Empty, null);
		}
		public async Task<List<S_currency_changeEO>> GetByMetaAsync(string meta, int top_)
		{
			return await GetByMetaAsync(meta, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Meta（字段） 查询
		/// </summary>
		/// /// <param name = "meta">扩展数据</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByMeta(string meta, int top_, TransactionManager tm_)
		{
			return GetByMeta(meta, top_, string.Empty, tm_);
		}
		public async Task<List<S_currency_changeEO>> GetByMetaAsync(string meta, int top_, TransactionManager tm_)
		{
			return await GetByMetaAsync(meta, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Meta（字段） 查询
		/// </summary>
		/// /// <param name = "meta">扩展数据</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByMeta(string meta, string sort_)
		{
			return GetByMeta(meta, 0, sort_, null);
		}
		public async Task<List<S_currency_changeEO>> GetByMetaAsync(string meta, string sort_)
		{
			return await GetByMetaAsync(meta, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Meta（字段） 查询
		/// </summary>
		/// /// <param name = "meta">扩展数据</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByMeta(string meta, string sort_, TransactionManager tm_)
		{
			return GetByMeta(meta, 0, sort_, tm_);
		}
		public async Task<List<S_currency_changeEO>> GetByMetaAsync(string meta, string sort_, TransactionManager tm_)
		{
			return await GetByMetaAsync(meta, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Meta（字段） 查询
		/// </summary>
		/// /// <param name = "meta">扩展数据</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByMeta(string meta, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(meta != null ? "`Meta` = @Meta" : "`Meta` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (meta != null)
				paras_.Add(Database.CreateInParameter("@Meta", meta, MySqlDbType.Text));
			return Database.ExecSqlList(sql_, paras_, tm_, S_currency_changeEO.MapDataReader);
		}
		public async Task<List<S_currency_changeEO>> GetByMetaAsync(string meta, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(meta != null ? "`Meta` = @Meta" : "`Meta` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (meta != null)
				paras_.Add(Database.CreateInParameter("@Meta", meta, MySqlDbType.Text));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_currency_changeEO.MapDataReader);
		}
		#endregion // GetByMeta
		#region GetBySourceType
		
		/// <summary>
		/// 按 SourceType（字段） 查询
		/// </summary>
		/// /// <param name = "sourceType">0-未知1-运营活动2</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetBySourceType(int sourceType)
		{
			return GetBySourceType(sourceType, 0, string.Empty, null);
		}
		public async Task<List<S_currency_changeEO>> GetBySourceTypeAsync(int sourceType)
		{
			return await GetBySourceTypeAsync(sourceType, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 SourceType（字段） 查询
		/// </summary>
		/// /// <param name = "sourceType">0-未知1-运营活动2</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetBySourceType(int sourceType, TransactionManager tm_)
		{
			return GetBySourceType(sourceType, 0, string.Empty, tm_);
		}
		public async Task<List<S_currency_changeEO>> GetBySourceTypeAsync(int sourceType, TransactionManager tm_)
		{
			return await GetBySourceTypeAsync(sourceType, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SourceType（字段） 查询
		/// </summary>
		/// /// <param name = "sourceType">0-未知1-运营活动2</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetBySourceType(int sourceType, int top_)
		{
			return GetBySourceType(sourceType, top_, string.Empty, null);
		}
		public async Task<List<S_currency_changeEO>> GetBySourceTypeAsync(int sourceType, int top_)
		{
			return await GetBySourceTypeAsync(sourceType, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 SourceType（字段） 查询
		/// </summary>
		/// /// <param name = "sourceType">0-未知1-运营活动2</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetBySourceType(int sourceType, int top_, TransactionManager tm_)
		{
			return GetBySourceType(sourceType, top_, string.Empty, tm_);
		}
		public async Task<List<S_currency_changeEO>> GetBySourceTypeAsync(int sourceType, int top_, TransactionManager tm_)
		{
			return await GetBySourceTypeAsync(sourceType, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SourceType（字段） 查询
		/// </summary>
		/// /// <param name = "sourceType">0-未知1-运营活动2</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetBySourceType(int sourceType, string sort_)
		{
			return GetBySourceType(sourceType, 0, sort_, null);
		}
		public async Task<List<S_currency_changeEO>> GetBySourceTypeAsync(int sourceType, string sort_)
		{
			return await GetBySourceTypeAsync(sourceType, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 SourceType（字段） 查询
		/// </summary>
		/// /// <param name = "sourceType">0-未知1-运营活动2</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetBySourceType(int sourceType, string sort_, TransactionManager tm_)
		{
			return GetBySourceType(sourceType, 0, sort_, tm_);
		}
		public async Task<List<S_currency_changeEO>> GetBySourceTypeAsync(int sourceType, string sort_, TransactionManager tm_)
		{
			return await GetBySourceTypeAsync(sourceType, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 SourceType（字段） 查询
		/// </summary>
		/// /// <param name = "sourceType">0-未知1-运营活动2</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetBySourceType(int sourceType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`SourceType` = @SourceType", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@SourceType", sourceType, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, S_currency_changeEO.MapDataReader);
		}
		public async Task<List<S_currency_changeEO>> GetBySourceTypeAsync(int sourceType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`SourceType` = @SourceType", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@SourceType", sourceType, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_currency_changeEO.MapDataReader);
		}
		#endregion // GetBySourceType
		#region GetBySourceTable
		
		/// <summary>
		/// 按 SourceTable（字段） 查询
		/// </summary>
		/// /// <param name = "sourceTable">源表名</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetBySourceTable(string sourceTable)
		{
			return GetBySourceTable(sourceTable, 0, string.Empty, null);
		}
		public async Task<List<S_currency_changeEO>> GetBySourceTableAsync(string sourceTable)
		{
			return await GetBySourceTableAsync(sourceTable, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 SourceTable（字段） 查询
		/// </summary>
		/// /// <param name = "sourceTable">源表名</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetBySourceTable(string sourceTable, TransactionManager tm_)
		{
			return GetBySourceTable(sourceTable, 0, string.Empty, tm_);
		}
		public async Task<List<S_currency_changeEO>> GetBySourceTableAsync(string sourceTable, TransactionManager tm_)
		{
			return await GetBySourceTableAsync(sourceTable, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SourceTable（字段） 查询
		/// </summary>
		/// /// <param name = "sourceTable">源表名</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetBySourceTable(string sourceTable, int top_)
		{
			return GetBySourceTable(sourceTable, top_, string.Empty, null);
		}
		public async Task<List<S_currency_changeEO>> GetBySourceTableAsync(string sourceTable, int top_)
		{
			return await GetBySourceTableAsync(sourceTable, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 SourceTable（字段） 查询
		/// </summary>
		/// /// <param name = "sourceTable">源表名</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetBySourceTable(string sourceTable, int top_, TransactionManager tm_)
		{
			return GetBySourceTable(sourceTable, top_, string.Empty, tm_);
		}
		public async Task<List<S_currency_changeEO>> GetBySourceTableAsync(string sourceTable, int top_, TransactionManager tm_)
		{
			return await GetBySourceTableAsync(sourceTable, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SourceTable（字段） 查询
		/// </summary>
		/// /// <param name = "sourceTable">源表名</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetBySourceTable(string sourceTable, string sort_)
		{
			return GetBySourceTable(sourceTable, 0, sort_, null);
		}
		public async Task<List<S_currency_changeEO>> GetBySourceTableAsync(string sourceTable, string sort_)
		{
			return await GetBySourceTableAsync(sourceTable, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 SourceTable（字段） 查询
		/// </summary>
		/// /// <param name = "sourceTable">源表名</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetBySourceTable(string sourceTable, string sort_, TransactionManager tm_)
		{
			return GetBySourceTable(sourceTable, 0, sort_, tm_);
		}
		public async Task<List<S_currency_changeEO>> GetBySourceTableAsync(string sourceTable, string sort_, TransactionManager tm_)
		{
			return await GetBySourceTableAsync(sourceTable, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 SourceTable（字段） 查询
		/// </summary>
		/// /// <param name = "sourceTable">源表名</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetBySourceTable(string sourceTable, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(sourceTable != null ? "`SourceTable` = @SourceTable" : "`SourceTable` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (sourceTable != null)
				paras_.Add(Database.CreateInParameter("@SourceTable", sourceTable, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_currency_changeEO.MapDataReader);
		}
		public async Task<List<S_currency_changeEO>> GetBySourceTableAsync(string sourceTable, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(sourceTable != null ? "`SourceTable` = @SourceTable" : "`SourceTable` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (sourceTable != null)
				paras_.Add(Database.CreateInParameter("@SourceTable", sourceTable, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_currency_changeEO.MapDataReader);
		}
		#endregion // GetBySourceTable
		#region GetBySourceId
		
		/// <summary>
		/// 按 SourceId（字段） 查询
		/// </summary>
		/// /// <param name = "sourceId">源表编码</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetBySourceId(string sourceId)
		{
			return GetBySourceId(sourceId, 0, string.Empty, null);
		}
		public async Task<List<S_currency_changeEO>> GetBySourceIdAsync(string sourceId)
		{
			return await GetBySourceIdAsync(sourceId, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 SourceId（字段） 查询
		/// </summary>
		/// /// <param name = "sourceId">源表编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetBySourceId(string sourceId, TransactionManager tm_)
		{
			return GetBySourceId(sourceId, 0, string.Empty, tm_);
		}
		public async Task<List<S_currency_changeEO>> GetBySourceIdAsync(string sourceId, TransactionManager tm_)
		{
			return await GetBySourceIdAsync(sourceId, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SourceId（字段） 查询
		/// </summary>
		/// /// <param name = "sourceId">源表编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetBySourceId(string sourceId, int top_)
		{
			return GetBySourceId(sourceId, top_, string.Empty, null);
		}
		public async Task<List<S_currency_changeEO>> GetBySourceIdAsync(string sourceId, int top_)
		{
			return await GetBySourceIdAsync(sourceId, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 SourceId（字段） 查询
		/// </summary>
		/// /// <param name = "sourceId">源表编码</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetBySourceId(string sourceId, int top_, TransactionManager tm_)
		{
			return GetBySourceId(sourceId, top_, string.Empty, tm_);
		}
		public async Task<List<S_currency_changeEO>> GetBySourceIdAsync(string sourceId, int top_, TransactionManager tm_)
		{
			return await GetBySourceIdAsync(sourceId, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SourceId（字段） 查询
		/// </summary>
		/// /// <param name = "sourceId">源表编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetBySourceId(string sourceId, string sort_)
		{
			return GetBySourceId(sourceId, 0, sort_, null);
		}
		public async Task<List<S_currency_changeEO>> GetBySourceIdAsync(string sourceId, string sort_)
		{
			return await GetBySourceIdAsync(sourceId, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 SourceId（字段） 查询
		/// </summary>
		/// /// <param name = "sourceId">源表编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetBySourceId(string sourceId, string sort_, TransactionManager tm_)
		{
			return GetBySourceId(sourceId, 0, sort_, tm_);
		}
		public async Task<List<S_currency_changeEO>> GetBySourceIdAsync(string sourceId, string sort_, TransactionManager tm_)
		{
			return await GetBySourceIdAsync(sourceId, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 SourceId（字段） 查询
		/// </summary>
		/// /// <param name = "sourceId">源表编码</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetBySourceId(string sourceId, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(sourceId != null ? "`SourceId` = @SourceId" : "`SourceId` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (sourceId != null)
				paras_.Add(Database.CreateInParameter("@SourceId", sourceId, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_currency_changeEO.MapDataReader);
		}
		public async Task<List<S_currency_changeEO>> GetBySourceIdAsync(string sourceId, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(sourceId != null ? "`SourceId` = @SourceId" : "`SourceId` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (sourceId != null)
				paras_.Add(Database.CreateInParameter("@SourceId", sourceId, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_currency_changeEO.MapDataReader);
		}
		#endregion // GetBySourceId
		#region GetByUserIp
		
		/// <summary>
		/// 按 UserIp（字段） 查询
		/// </summary>
		/// /// <param name = "userIp">用户IP</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByUserIp(string userIp)
		{
			return GetByUserIp(userIp, 0, string.Empty, null);
		}
		public async Task<List<S_currency_changeEO>> GetByUserIpAsync(string userIp)
		{
			return await GetByUserIpAsync(userIp, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UserIp（字段） 查询
		/// </summary>
		/// /// <param name = "userIp">用户IP</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByUserIp(string userIp, TransactionManager tm_)
		{
			return GetByUserIp(userIp, 0, string.Empty, tm_);
		}
		public async Task<List<S_currency_changeEO>> GetByUserIpAsync(string userIp, TransactionManager tm_)
		{
			return await GetByUserIpAsync(userIp, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserIp（字段） 查询
		/// </summary>
		/// /// <param name = "userIp">用户IP</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByUserIp(string userIp, int top_)
		{
			return GetByUserIp(userIp, top_, string.Empty, null);
		}
		public async Task<List<S_currency_changeEO>> GetByUserIpAsync(string userIp, int top_)
		{
			return await GetByUserIpAsync(userIp, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UserIp（字段） 查询
		/// </summary>
		/// /// <param name = "userIp">用户IP</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByUserIp(string userIp, int top_, TransactionManager tm_)
		{
			return GetByUserIp(userIp, top_, string.Empty, tm_);
		}
		public async Task<List<S_currency_changeEO>> GetByUserIpAsync(string userIp, int top_, TransactionManager tm_)
		{
			return await GetByUserIpAsync(userIp, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserIp（字段） 查询
		/// </summary>
		/// /// <param name = "userIp">用户IP</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByUserIp(string userIp, string sort_)
		{
			return GetByUserIp(userIp, 0, sort_, null);
		}
		public async Task<List<S_currency_changeEO>> GetByUserIpAsync(string userIp, string sort_)
		{
			return await GetByUserIpAsync(userIp, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 UserIp（字段） 查询
		/// </summary>
		/// /// <param name = "userIp">用户IP</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByUserIp(string userIp, string sort_, TransactionManager tm_)
		{
			return GetByUserIp(userIp, 0, sort_, tm_);
		}
		public async Task<List<S_currency_changeEO>> GetByUserIpAsync(string userIp, string sort_, TransactionManager tm_)
		{
			return await GetByUserIpAsync(userIp, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 UserIp（字段） 查询
		/// </summary>
		/// /// <param name = "userIp">用户IP</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByUserIp(string userIp, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(userIp != null ? "`UserIp` = @UserIp" : "`UserIp` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (userIp != null)
				paras_.Add(Database.CreateInParameter("@UserIp", userIp, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_currency_changeEO.MapDataReader);
		}
		public async Task<List<S_currency_changeEO>> GetByUserIpAsync(string userIp, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(userIp != null ? "`UserIp` = @UserIp" : "`UserIp` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (userIp != null)
				paras_.Add(Database.CreateInParameter("@UserIp", userIp, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_currency_changeEO.MapDataReader);
		}
		#endregion // GetByUserIp
		#region GetByStatus
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态0-初始1-处理中2-成功3-失败4-已回滚5-异常且需处理6-异常已处理</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByStatus(int status)
		{
			return GetByStatus(status, 0, string.Empty, null);
		}
		public async Task<List<S_currency_changeEO>> GetByStatusAsync(int status)
		{
			return await GetByStatusAsync(status, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态0-初始1-处理中2-成功3-失败4-已回滚5-异常且需处理6-异常已处理</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByStatus(int status, TransactionManager tm_)
		{
			return GetByStatus(status, 0, string.Empty, tm_);
		}
		public async Task<List<S_currency_changeEO>> GetByStatusAsync(int status, TransactionManager tm_)
		{
			return await GetByStatusAsync(status, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态0-初始1-处理中2-成功3-失败4-已回滚5-异常且需处理6-异常已处理</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByStatus(int status, int top_)
		{
			return GetByStatus(status, top_, string.Empty, null);
		}
		public async Task<List<S_currency_changeEO>> GetByStatusAsync(int status, int top_)
		{
			return await GetByStatusAsync(status, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态0-初始1-处理中2-成功3-失败4-已回滚5-异常且需处理6-异常已处理</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByStatus(int status, int top_, TransactionManager tm_)
		{
			return GetByStatus(status, top_, string.Empty, tm_);
		}
		public async Task<List<S_currency_changeEO>> GetByStatusAsync(int status, int top_, TransactionManager tm_)
		{
			return await GetByStatusAsync(status, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态0-初始1-处理中2-成功3-失败4-已回滚5-异常且需处理6-异常已处理</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByStatus(int status, string sort_)
		{
			return GetByStatus(status, 0, sort_, null);
		}
		public async Task<List<S_currency_changeEO>> GetByStatusAsync(int status, string sort_)
		{
			return await GetByStatusAsync(status, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态0-初始1-处理中2-成功3-失败4-已回滚5-异常且需处理6-异常已处理</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByStatus(int status, string sort_, TransactionManager tm_)
		{
			return GetByStatus(status, 0, sort_, tm_);
		}
		public async Task<List<S_currency_changeEO>> GetByStatusAsync(int status, string sort_, TransactionManager tm_)
		{
			return await GetByStatusAsync(status, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态0-初始1-处理中2-成功3-失败4-已回滚5-异常且需处理6-异常已处理</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByStatus(int status, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Status` = @Status", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Status", status, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, S_currency_changeEO.MapDataReader);
		}
		public async Task<List<S_currency_changeEO>> GetByStatusAsync(int status, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Status` = @Status", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Status", status, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_currency_changeEO.MapDataReader);
		}
		#endregion // GetByStatus
		#region GetByRecDate
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByRecDate(DateTime recDate)
		{
			return GetByRecDate(recDate, 0, string.Empty, null);
		}
		public async Task<List<S_currency_changeEO>> GetByRecDateAsync(DateTime recDate)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByRecDate(DateTime recDate, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, string.Empty, tm_);
		}
		public async Task<List<S_currency_changeEO>> GetByRecDateAsync(DateTime recDate, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByRecDate(DateTime recDate, int top_)
		{
			return GetByRecDate(recDate, top_, string.Empty, null);
		}
		public async Task<List<S_currency_changeEO>> GetByRecDateAsync(DateTime recDate, int top_)
		{
			return await GetByRecDateAsync(recDate, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByRecDate(DateTime recDate, int top_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, top_, string.Empty, tm_);
		}
		public async Task<List<S_currency_changeEO>> GetByRecDateAsync(DateTime recDate, int top_, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByRecDate(DateTime recDate, string sort_)
		{
			return GetByRecDate(recDate, 0, sort_, null);
		}
		public async Task<List<S_currency_changeEO>> GetByRecDateAsync(DateTime recDate, string sort_)
		{
			return await GetByRecDateAsync(recDate, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByRecDate(DateTime recDate, string sort_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, sort_, tm_);
		}
		public async Task<List<S_currency_changeEO>> GetByRecDateAsync(DateTime recDate, string sort_, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByRecDate(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return Database.ExecSqlList(sql_, paras_, tm_, S_currency_changeEO.MapDataReader);
		}
		public async Task<List<S_currency_changeEO>> GetByRecDateAsync(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_currency_changeEO.MapDataReader);
		}
		#endregion // GetByRecDate
		#region GetByDealTime
		
		/// <summary>
		/// 按 DealTime（字段） 查询
		/// </summary>
		/// /// <param name = "dealTime">处理时间</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByDealTime(DateTime? dealTime)
		{
			return GetByDealTime(dealTime, 0, string.Empty, null);
		}
		public async Task<List<S_currency_changeEO>> GetByDealTimeAsync(DateTime? dealTime)
		{
			return await GetByDealTimeAsync(dealTime, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DealTime（字段） 查询
		/// </summary>
		/// /// <param name = "dealTime">处理时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByDealTime(DateTime? dealTime, TransactionManager tm_)
		{
			return GetByDealTime(dealTime, 0, string.Empty, tm_);
		}
		public async Task<List<S_currency_changeEO>> GetByDealTimeAsync(DateTime? dealTime, TransactionManager tm_)
		{
			return await GetByDealTimeAsync(dealTime, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DealTime（字段） 查询
		/// </summary>
		/// /// <param name = "dealTime">处理时间</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByDealTime(DateTime? dealTime, int top_)
		{
			return GetByDealTime(dealTime, top_, string.Empty, null);
		}
		public async Task<List<S_currency_changeEO>> GetByDealTimeAsync(DateTime? dealTime, int top_)
		{
			return await GetByDealTimeAsync(dealTime, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DealTime（字段） 查询
		/// </summary>
		/// /// <param name = "dealTime">处理时间</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByDealTime(DateTime? dealTime, int top_, TransactionManager tm_)
		{
			return GetByDealTime(dealTime, top_, string.Empty, tm_);
		}
		public async Task<List<S_currency_changeEO>> GetByDealTimeAsync(DateTime? dealTime, int top_, TransactionManager tm_)
		{
			return await GetByDealTimeAsync(dealTime, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DealTime（字段） 查询
		/// </summary>
		/// /// <param name = "dealTime">处理时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByDealTime(DateTime? dealTime, string sort_)
		{
			return GetByDealTime(dealTime, 0, sort_, null);
		}
		public async Task<List<S_currency_changeEO>> GetByDealTimeAsync(DateTime? dealTime, string sort_)
		{
			return await GetByDealTimeAsync(dealTime, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 DealTime（字段） 查询
		/// </summary>
		/// /// <param name = "dealTime">处理时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByDealTime(DateTime? dealTime, string sort_, TransactionManager tm_)
		{
			return GetByDealTime(dealTime, 0, sort_, tm_);
		}
		public async Task<List<S_currency_changeEO>> GetByDealTimeAsync(DateTime? dealTime, string sort_, TransactionManager tm_)
		{
			return await GetByDealTimeAsync(dealTime, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 DealTime（字段） 查询
		/// </summary>
		/// /// <param name = "dealTime">处理时间</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByDealTime(DateTime? dealTime, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(dealTime.HasValue ? "`DealTime` = @DealTime" : "`DealTime` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (dealTime.HasValue)
				paras_.Add(Database.CreateInParameter("@DealTime", dealTime.Value, MySqlDbType.DateTime));
			return Database.ExecSqlList(sql_, paras_, tm_, S_currency_changeEO.MapDataReader);
		}
		public async Task<List<S_currency_changeEO>> GetByDealTimeAsync(DateTime? dealTime, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(dealTime.HasValue ? "`DealTime` = @DealTime" : "`DealTime` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (dealTime.HasValue)
				paras_.Add(Database.CreateInParameter("@DealTime", dealTime.Value, MySqlDbType.DateTime));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_currency_changeEO.MapDataReader);
		}
		#endregion // GetByDealTime
		#region GetByDealStatus
		
		/// <summary>
		/// 按 DealStatus（字段） 查询
		/// </summary>
		/// /// <param name = "dealStatus">处理状态数据</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByDealStatus(string dealStatus)
		{
			return GetByDealStatus(dealStatus, 0, string.Empty, null);
		}
		public async Task<List<S_currency_changeEO>> GetByDealStatusAsync(string dealStatus)
		{
			return await GetByDealStatusAsync(dealStatus, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DealStatus（字段） 查询
		/// </summary>
		/// /// <param name = "dealStatus">处理状态数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByDealStatus(string dealStatus, TransactionManager tm_)
		{
			return GetByDealStatus(dealStatus, 0, string.Empty, tm_);
		}
		public async Task<List<S_currency_changeEO>> GetByDealStatusAsync(string dealStatus, TransactionManager tm_)
		{
			return await GetByDealStatusAsync(dealStatus, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DealStatus（字段） 查询
		/// </summary>
		/// /// <param name = "dealStatus">处理状态数据</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByDealStatus(string dealStatus, int top_)
		{
			return GetByDealStatus(dealStatus, top_, string.Empty, null);
		}
		public async Task<List<S_currency_changeEO>> GetByDealStatusAsync(string dealStatus, int top_)
		{
			return await GetByDealStatusAsync(dealStatus, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DealStatus（字段） 查询
		/// </summary>
		/// /// <param name = "dealStatus">处理状态数据</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByDealStatus(string dealStatus, int top_, TransactionManager tm_)
		{
			return GetByDealStatus(dealStatus, top_, string.Empty, tm_);
		}
		public async Task<List<S_currency_changeEO>> GetByDealStatusAsync(string dealStatus, int top_, TransactionManager tm_)
		{
			return await GetByDealStatusAsync(dealStatus, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DealStatus（字段） 查询
		/// </summary>
		/// /// <param name = "dealStatus">处理状态数据</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByDealStatus(string dealStatus, string sort_)
		{
			return GetByDealStatus(dealStatus, 0, sort_, null);
		}
		public async Task<List<S_currency_changeEO>> GetByDealStatusAsync(string dealStatus, string sort_)
		{
			return await GetByDealStatusAsync(dealStatus, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 DealStatus（字段） 查询
		/// </summary>
		/// /// <param name = "dealStatus">处理状态数据</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByDealStatus(string dealStatus, string sort_, TransactionManager tm_)
		{
			return GetByDealStatus(dealStatus, 0, sort_, tm_);
		}
		public async Task<List<S_currency_changeEO>> GetByDealStatusAsync(string dealStatus, string sort_, TransactionManager tm_)
		{
			return await GetByDealStatusAsync(dealStatus, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 DealStatus（字段） 查询
		/// </summary>
		/// /// <param name = "dealStatus">处理状态数据</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByDealStatus(string dealStatus, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(dealStatus != null ? "`DealStatus` = @DealStatus" : "`DealStatus` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (dealStatus != null)
				paras_.Add(Database.CreateInParameter("@DealStatus", dealStatus, MySqlDbType.Text));
			return Database.ExecSqlList(sql_, paras_, tm_, S_currency_changeEO.MapDataReader);
		}
		public async Task<List<S_currency_changeEO>> GetByDealStatusAsync(string dealStatus, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(dealStatus != null ? "`DealStatus` = @DealStatus" : "`DealStatus` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (dealStatus != null)
				paras_.Add(Database.CreateInParameter("@DealStatus", dealStatus, MySqlDbType.Text));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_currency_changeEO.MapDataReader);
		}
		#endregion // GetByDealStatus
		#region GetByAmount
		
		/// <summary>
		/// 按 Amount（字段） 查询
		/// </summary>
		/// /// <param name = "amount">实际金额（正负数）</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByAmount(long amount)
		{
			return GetByAmount(amount, 0, string.Empty, null);
		}
		public async Task<List<S_currency_changeEO>> GetByAmountAsync(long amount)
		{
			return await GetByAmountAsync(amount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Amount（字段） 查询
		/// </summary>
		/// /// <param name = "amount">实际金额（正负数）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByAmount(long amount, TransactionManager tm_)
		{
			return GetByAmount(amount, 0, string.Empty, tm_);
		}
		public async Task<List<S_currency_changeEO>> GetByAmountAsync(long amount, TransactionManager tm_)
		{
			return await GetByAmountAsync(amount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Amount（字段） 查询
		/// </summary>
		/// /// <param name = "amount">实际金额（正负数）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByAmount(long amount, int top_)
		{
			return GetByAmount(amount, top_, string.Empty, null);
		}
		public async Task<List<S_currency_changeEO>> GetByAmountAsync(long amount, int top_)
		{
			return await GetByAmountAsync(amount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Amount（字段） 查询
		/// </summary>
		/// /// <param name = "amount">实际金额（正负数）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByAmount(long amount, int top_, TransactionManager tm_)
		{
			return GetByAmount(amount, top_, string.Empty, tm_);
		}
		public async Task<List<S_currency_changeEO>> GetByAmountAsync(long amount, int top_, TransactionManager tm_)
		{
			return await GetByAmountAsync(amount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Amount（字段） 查询
		/// </summary>
		/// /// <param name = "amount">实际金额（正负数）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByAmount(long amount, string sort_)
		{
			return GetByAmount(amount, 0, sort_, null);
		}
		public async Task<List<S_currency_changeEO>> GetByAmountAsync(long amount, string sort_)
		{
			return await GetByAmountAsync(amount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Amount（字段） 查询
		/// </summary>
		/// /// <param name = "amount">实际金额（正负数）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByAmount(long amount, string sort_, TransactionManager tm_)
		{
			return GetByAmount(amount, 0, sort_, tm_);
		}
		public async Task<List<S_currency_changeEO>> GetByAmountAsync(long amount, string sort_, TransactionManager tm_)
		{
			return await GetByAmountAsync(amount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Amount（字段） 查询
		/// </summary>
		/// /// <param name = "amount">实际金额（正负数）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByAmount(long amount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Amount` = @Amount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Amount", amount, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, S_currency_changeEO.MapDataReader);
		}
		public async Task<List<S_currency_changeEO>> GetByAmountAsync(long amount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Amount` = @Amount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Amount", amount, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_currency_changeEO.MapDataReader);
		}
		#endregion // GetByAmount
		#region GetByEndBalance
		
		/// <summary>
		/// 按 EndBalance（字段） 查询
		/// </summary>
		/// /// <param name = "endBalance">处理后余额</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByEndBalance(long endBalance)
		{
			return GetByEndBalance(endBalance, 0, string.Empty, null);
		}
		public async Task<List<S_currency_changeEO>> GetByEndBalanceAsync(long endBalance)
		{
			return await GetByEndBalanceAsync(endBalance, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 EndBalance（字段） 查询
		/// </summary>
		/// /// <param name = "endBalance">处理后余额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByEndBalance(long endBalance, TransactionManager tm_)
		{
			return GetByEndBalance(endBalance, 0, string.Empty, tm_);
		}
		public async Task<List<S_currency_changeEO>> GetByEndBalanceAsync(long endBalance, TransactionManager tm_)
		{
			return await GetByEndBalanceAsync(endBalance, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 EndBalance（字段） 查询
		/// </summary>
		/// /// <param name = "endBalance">处理后余额</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByEndBalance(long endBalance, int top_)
		{
			return GetByEndBalance(endBalance, top_, string.Empty, null);
		}
		public async Task<List<S_currency_changeEO>> GetByEndBalanceAsync(long endBalance, int top_)
		{
			return await GetByEndBalanceAsync(endBalance, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 EndBalance（字段） 查询
		/// </summary>
		/// /// <param name = "endBalance">处理后余额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByEndBalance(long endBalance, int top_, TransactionManager tm_)
		{
			return GetByEndBalance(endBalance, top_, string.Empty, tm_);
		}
		public async Task<List<S_currency_changeEO>> GetByEndBalanceAsync(long endBalance, int top_, TransactionManager tm_)
		{
			return await GetByEndBalanceAsync(endBalance, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 EndBalance（字段） 查询
		/// </summary>
		/// /// <param name = "endBalance">处理后余额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByEndBalance(long endBalance, string sort_)
		{
			return GetByEndBalance(endBalance, 0, sort_, null);
		}
		public async Task<List<S_currency_changeEO>> GetByEndBalanceAsync(long endBalance, string sort_)
		{
			return await GetByEndBalanceAsync(endBalance, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 EndBalance（字段） 查询
		/// </summary>
		/// /// <param name = "endBalance">处理后余额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByEndBalance(long endBalance, string sort_, TransactionManager tm_)
		{
			return GetByEndBalance(endBalance, 0, sort_, tm_);
		}
		public async Task<List<S_currency_changeEO>> GetByEndBalanceAsync(long endBalance, string sort_, TransactionManager tm_)
		{
			return await GetByEndBalanceAsync(endBalance, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 EndBalance（字段） 查询
		/// </summary>
		/// /// <param name = "endBalance">处理后余额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByEndBalance(long endBalance, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`EndBalance` = @EndBalance", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@EndBalance", endBalance, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, S_currency_changeEO.MapDataReader);
		}
		public async Task<List<S_currency_changeEO>> GetByEndBalanceAsync(long endBalance, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`EndBalance` = @EndBalance", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@EndBalance", endBalance, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_currency_changeEO.MapDataReader);
		}
		#endregion // GetByEndBalance
		#region GetByAmountBonus
		
		/// <summary>
		/// 按 AmountBonus（字段） 查询
		/// </summary>
		/// /// <param name = "amountBonus">bonus实际变化数量（正负数）</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByAmountBonus(long amountBonus)
		{
			return GetByAmountBonus(amountBonus, 0, string.Empty, null);
		}
		public async Task<List<S_currency_changeEO>> GetByAmountBonusAsync(long amountBonus)
		{
			return await GetByAmountBonusAsync(amountBonus, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 AmountBonus（字段） 查询
		/// </summary>
		/// /// <param name = "amountBonus">bonus实际变化数量（正负数）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByAmountBonus(long amountBonus, TransactionManager tm_)
		{
			return GetByAmountBonus(amountBonus, 0, string.Empty, tm_);
		}
		public async Task<List<S_currency_changeEO>> GetByAmountBonusAsync(long amountBonus, TransactionManager tm_)
		{
			return await GetByAmountBonusAsync(amountBonus, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 AmountBonus（字段） 查询
		/// </summary>
		/// /// <param name = "amountBonus">bonus实际变化数量（正负数）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByAmountBonus(long amountBonus, int top_)
		{
			return GetByAmountBonus(amountBonus, top_, string.Empty, null);
		}
		public async Task<List<S_currency_changeEO>> GetByAmountBonusAsync(long amountBonus, int top_)
		{
			return await GetByAmountBonusAsync(amountBonus, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 AmountBonus（字段） 查询
		/// </summary>
		/// /// <param name = "amountBonus">bonus实际变化数量（正负数）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByAmountBonus(long amountBonus, int top_, TransactionManager tm_)
		{
			return GetByAmountBonus(amountBonus, top_, string.Empty, tm_);
		}
		public async Task<List<S_currency_changeEO>> GetByAmountBonusAsync(long amountBonus, int top_, TransactionManager tm_)
		{
			return await GetByAmountBonusAsync(amountBonus, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 AmountBonus（字段） 查询
		/// </summary>
		/// /// <param name = "amountBonus">bonus实际变化数量（正负数）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByAmountBonus(long amountBonus, string sort_)
		{
			return GetByAmountBonus(amountBonus, 0, sort_, null);
		}
		public async Task<List<S_currency_changeEO>> GetByAmountBonusAsync(long amountBonus, string sort_)
		{
			return await GetByAmountBonusAsync(amountBonus, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 AmountBonus（字段） 查询
		/// </summary>
		/// /// <param name = "amountBonus">bonus实际变化数量（正负数）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByAmountBonus(long amountBonus, string sort_, TransactionManager tm_)
		{
			return GetByAmountBonus(amountBonus, 0, sort_, tm_);
		}
		public async Task<List<S_currency_changeEO>> GetByAmountBonusAsync(long amountBonus, string sort_, TransactionManager tm_)
		{
			return await GetByAmountBonusAsync(amountBonus, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 AmountBonus（字段） 查询
		/// </summary>
		/// /// <param name = "amountBonus">bonus实际变化数量（正负数）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByAmountBonus(long amountBonus, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`AmountBonus` = @AmountBonus", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@AmountBonus", amountBonus, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, S_currency_changeEO.MapDataReader);
		}
		public async Task<List<S_currency_changeEO>> GetByAmountBonusAsync(long amountBonus, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`AmountBonus` = @AmountBonus", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@AmountBonus", amountBonus, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_currency_changeEO.MapDataReader);
		}
		#endregion // GetByAmountBonus
		#region GetByEndBonus
		
		/// <summary>
		/// 按 EndBonus（字段） 查询
		/// </summary>
		/// /// <param name = "endBonus">处理后bonus余额</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByEndBonus(long endBonus)
		{
			return GetByEndBonus(endBonus, 0, string.Empty, null);
		}
		public async Task<List<S_currency_changeEO>> GetByEndBonusAsync(long endBonus)
		{
			return await GetByEndBonusAsync(endBonus, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 EndBonus（字段） 查询
		/// </summary>
		/// /// <param name = "endBonus">处理后bonus余额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByEndBonus(long endBonus, TransactionManager tm_)
		{
			return GetByEndBonus(endBonus, 0, string.Empty, tm_);
		}
		public async Task<List<S_currency_changeEO>> GetByEndBonusAsync(long endBonus, TransactionManager tm_)
		{
			return await GetByEndBonusAsync(endBonus, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 EndBonus（字段） 查询
		/// </summary>
		/// /// <param name = "endBonus">处理后bonus余额</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByEndBonus(long endBonus, int top_)
		{
			return GetByEndBonus(endBonus, top_, string.Empty, null);
		}
		public async Task<List<S_currency_changeEO>> GetByEndBonusAsync(long endBonus, int top_)
		{
			return await GetByEndBonusAsync(endBonus, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 EndBonus（字段） 查询
		/// </summary>
		/// /// <param name = "endBonus">处理后bonus余额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByEndBonus(long endBonus, int top_, TransactionManager tm_)
		{
			return GetByEndBonus(endBonus, top_, string.Empty, tm_);
		}
		public async Task<List<S_currency_changeEO>> GetByEndBonusAsync(long endBonus, int top_, TransactionManager tm_)
		{
			return await GetByEndBonusAsync(endBonus, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 EndBonus（字段） 查询
		/// </summary>
		/// /// <param name = "endBonus">处理后bonus余额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByEndBonus(long endBonus, string sort_)
		{
			return GetByEndBonus(endBonus, 0, sort_, null);
		}
		public async Task<List<S_currency_changeEO>> GetByEndBonusAsync(long endBonus, string sort_)
		{
			return await GetByEndBonusAsync(endBonus, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 EndBonus（字段） 查询
		/// </summary>
		/// /// <param name = "endBonus">处理后bonus余额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByEndBonus(long endBonus, string sort_, TransactionManager tm_)
		{
			return GetByEndBonus(endBonus, 0, sort_, tm_);
		}
		public async Task<List<S_currency_changeEO>> GetByEndBonusAsync(long endBonus, string sort_, TransactionManager tm_)
		{
			return await GetByEndBonusAsync(endBonus, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 EndBonus（字段） 查询
		/// </summary>
		/// /// <param name = "endBonus">处理后bonus余额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetByEndBonus(long endBonus, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`EndBonus` = @EndBonus", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@EndBonus", endBonus, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, S_currency_changeEO.MapDataReader);
		}
		public async Task<List<S_currency_changeEO>> GetByEndBonusAsync(long endBonus, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`EndBonus` = @EndBonus", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@EndBonus", endBonus, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_currency_changeEO.MapDataReader);
		}
		#endregion // GetByEndBonus
		#region GetBySettlStatus
		
		/// <summary>
		/// 按 SettlStatus（字段） 查询
		/// </summary>
		/// /// <param name = "settlStatus">结算状态（0-未结算1-已结算）</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetBySettlStatus(int settlStatus)
		{
			return GetBySettlStatus(settlStatus, 0, string.Empty, null);
		}
		public async Task<List<S_currency_changeEO>> GetBySettlStatusAsync(int settlStatus)
		{
			return await GetBySettlStatusAsync(settlStatus, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 SettlStatus（字段） 查询
		/// </summary>
		/// /// <param name = "settlStatus">结算状态（0-未结算1-已结算）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetBySettlStatus(int settlStatus, TransactionManager tm_)
		{
			return GetBySettlStatus(settlStatus, 0, string.Empty, tm_);
		}
		public async Task<List<S_currency_changeEO>> GetBySettlStatusAsync(int settlStatus, TransactionManager tm_)
		{
			return await GetBySettlStatusAsync(settlStatus, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SettlStatus（字段） 查询
		/// </summary>
		/// /// <param name = "settlStatus">结算状态（0-未结算1-已结算）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetBySettlStatus(int settlStatus, int top_)
		{
			return GetBySettlStatus(settlStatus, top_, string.Empty, null);
		}
		public async Task<List<S_currency_changeEO>> GetBySettlStatusAsync(int settlStatus, int top_)
		{
			return await GetBySettlStatusAsync(settlStatus, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 SettlStatus（字段） 查询
		/// </summary>
		/// /// <param name = "settlStatus">结算状态（0-未结算1-已结算）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetBySettlStatus(int settlStatus, int top_, TransactionManager tm_)
		{
			return GetBySettlStatus(settlStatus, top_, string.Empty, tm_);
		}
		public async Task<List<S_currency_changeEO>> GetBySettlStatusAsync(int settlStatus, int top_, TransactionManager tm_)
		{
			return await GetBySettlStatusAsync(settlStatus, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SettlStatus（字段） 查询
		/// </summary>
		/// /// <param name = "settlStatus">结算状态（0-未结算1-已结算）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetBySettlStatus(int settlStatus, string sort_)
		{
			return GetBySettlStatus(settlStatus, 0, sort_, null);
		}
		public async Task<List<S_currency_changeEO>> GetBySettlStatusAsync(int settlStatus, string sort_)
		{
			return await GetBySettlStatusAsync(settlStatus, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 SettlStatus（字段） 查询
		/// </summary>
		/// /// <param name = "settlStatus">结算状态（0-未结算1-已结算）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetBySettlStatus(int settlStatus, string sort_, TransactionManager tm_)
		{
			return GetBySettlStatus(settlStatus, 0, sort_, tm_);
		}
		public async Task<List<S_currency_changeEO>> GetBySettlStatusAsync(int settlStatus, string sort_, TransactionManager tm_)
		{
			return await GetBySettlStatusAsync(settlStatus, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 SettlStatus（字段） 查询
		/// </summary>
		/// /// <param name = "settlStatus">结算状态（0-未结算1-已结算）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetBySettlStatus(int settlStatus, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`SettlStatus` = @SettlStatus", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@SettlStatus", settlStatus, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, S_currency_changeEO.MapDataReader);
		}
		public async Task<List<S_currency_changeEO>> GetBySettlStatusAsync(int settlStatus, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`SettlStatus` = @SettlStatus", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@SettlStatus", settlStatus, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_currency_changeEO.MapDataReader);
		}
		#endregion // GetBySettlStatus
		#region GetBySettlTable
		
		/// <summary>
		/// 按 SettlTable（字段） 查询
		/// </summary>
		/// /// <param name = "settlTable">结算表名</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetBySettlTable(string settlTable)
		{
			return GetBySettlTable(settlTable, 0, string.Empty, null);
		}
		public async Task<List<S_currency_changeEO>> GetBySettlTableAsync(string settlTable)
		{
			return await GetBySettlTableAsync(settlTable, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 SettlTable（字段） 查询
		/// </summary>
		/// /// <param name = "settlTable">结算表名</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetBySettlTable(string settlTable, TransactionManager tm_)
		{
			return GetBySettlTable(settlTable, 0, string.Empty, tm_);
		}
		public async Task<List<S_currency_changeEO>> GetBySettlTableAsync(string settlTable, TransactionManager tm_)
		{
			return await GetBySettlTableAsync(settlTable, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SettlTable（字段） 查询
		/// </summary>
		/// /// <param name = "settlTable">结算表名</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetBySettlTable(string settlTable, int top_)
		{
			return GetBySettlTable(settlTable, top_, string.Empty, null);
		}
		public async Task<List<S_currency_changeEO>> GetBySettlTableAsync(string settlTable, int top_)
		{
			return await GetBySettlTableAsync(settlTable, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 SettlTable（字段） 查询
		/// </summary>
		/// /// <param name = "settlTable">结算表名</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetBySettlTable(string settlTable, int top_, TransactionManager tm_)
		{
			return GetBySettlTable(settlTable, top_, string.Empty, tm_);
		}
		public async Task<List<S_currency_changeEO>> GetBySettlTableAsync(string settlTable, int top_, TransactionManager tm_)
		{
			return await GetBySettlTableAsync(settlTable, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SettlTable（字段） 查询
		/// </summary>
		/// /// <param name = "settlTable">结算表名</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetBySettlTable(string settlTable, string sort_)
		{
			return GetBySettlTable(settlTable, 0, sort_, null);
		}
		public async Task<List<S_currency_changeEO>> GetBySettlTableAsync(string settlTable, string sort_)
		{
			return await GetBySettlTableAsync(settlTable, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 SettlTable（字段） 查询
		/// </summary>
		/// /// <param name = "settlTable">结算表名</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetBySettlTable(string settlTable, string sort_, TransactionManager tm_)
		{
			return GetBySettlTable(settlTable, 0, sort_, tm_);
		}
		public async Task<List<S_currency_changeEO>> GetBySettlTableAsync(string settlTable, string sort_, TransactionManager tm_)
		{
			return await GetBySettlTableAsync(settlTable, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 SettlTable（字段） 查询
		/// </summary>
		/// /// <param name = "settlTable">结算表名</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetBySettlTable(string settlTable, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(settlTable != null ? "`SettlTable` = @SettlTable" : "`SettlTable` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (settlTable != null)
				paras_.Add(Database.CreateInParameter("@SettlTable", settlTable, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_currency_changeEO.MapDataReader);
		}
		public async Task<List<S_currency_changeEO>> GetBySettlTableAsync(string settlTable, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(settlTable != null ? "`SettlTable` = @SettlTable" : "`SettlTable` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (settlTable != null)
				paras_.Add(Database.CreateInParameter("@SettlTable", settlTable, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_currency_changeEO.MapDataReader);
		}
		#endregion // GetBySettlTable
		#region GetBySettlId
		
		/// <summary>
		/// 按 SettlId（字段） 查询
		/// </summary>
		/// /// <param name = "settlId">结算编码</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetBySettlId(string settlId)
		{
			return GetBySettlId(settlId, 0, string.Empty, null);
		}
		public async Task<List<S_currency_changeEO>> GetBySettlIdAsync(string settlId)
		{
			return await GetBySettlIdAsync(settlId, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 SettlId（字段） 查询
		/// </summary>
		/// /// <param name = "settlId">结算编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetBySettlId(string settlId, TransactionManager tm_)
		{
			return GetBySettlId(settlId, 0, string.Empty, tm_);
		}
		public async Task<List<S_currency_changeEO>> GetBySettlIdAsync(string settlId, TransactionManager tm_)
		{
			return await GetBySettlIdAsync(settlId, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SettlId（字段） 查询
		/// </summary>
		/// /// <param name = "settlId">结算编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetBySettlId(string settlId, int top_)
		{
			return GetBySettlId(settlId, top_, string.Empty, null);
		}
		public async Task<List<S_currency_changeEO>> GetBySettlIdAsync(string settlId, int top_)
		{
			return await GetBySettlIdAsync(settlId, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 SettlId（字段） 查询
		/// </summary>
		/// /// <param name = "settlId">结算编码</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetBySettlId(string settlId, int top_, TransactionManager tm_)
		{
			return GetBySettlId(settlId, top_, string.Empty, tm_);
		}
		public async Task<List<S_currency_changeEO>> GetBySettlIdAsync(string settlId, int top_, TransactionManager tm_)
		{
			return await GetBySettlIdAsync(settlId, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SettlId（字段） 查询
		/// </summary>
		/// /// <param name = "settlId">结算编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetBySettlId(string settlId, string sort_)
		{
			return GetBySettlId(settlId, 0, sort_, null);
		}
		public async Task<List<S_currency_changeEO>> GetBySettlIdAsync(string settlId, string sort_)
		{
			return await GetBySettlIdAsync(settlId, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 SettlId（字段） 查询
		/// </summary>
		/// /// <param name = "settlId">结算编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetBySettlId(string settlId, string sort_, TransactionManager tm_)
		{
			return GetBySettlId(settlId, 0, sort_, tm_);
		}
		public async Task<List<S_currency_changeEO>> GetBySettlIdAsync(string settlId, string sort_, TransactionManager tm_)
		{
			return await GetBySettlIdAsync(settlId, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 SettlId（字段） 查询
		/// </summary>
		/// /// <param name = "settlId">结算编码</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetBySettlId(string settlId, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(settlId != null ? "`SettlId` = @SettlId" : "`SettlId` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (settlId != null)
				paras_.Add(Database.CreateInParameter("@SettlId", settlId, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_currency_changeEO.MapDataReader);
		}
		public async Task<List<S_currency_changeEO>> GetBySettlIdAsync(string settlId, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(settlId != null ? "`SettlId` = @SettlId" : "`SettlId` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (settlId != null)
				paras_.Add(Database.CreateInParameter("@SettlId", settlId, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_currency_changeEO.MapDataReader);
		}
		#endregion // GetBySettlId
		#region GetBySettlAmount
		
		/// <summary>
		/// 按 SettlAmount（字段） 查询
		/// </summary>
		/// /// <param name = "settlAmount">结算金额(正负数)</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetBySettlAmount(long settlAmount)
		{
			return GetBySettlAmount(settlAmount, 0, string.Empty, null);
		}
		public async Task<List<S_currency_changeEO>> GetBySettlAmountAsync(long settlAmount)
		{
			return await GetBySettlAmountAsync(settlAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 SettlAmount（字段） 查询
		/// </summary>
		/// /// <param name = "settlAmount">结算金额(正负数)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetBySettlAmount(long settlAmount, TransactionManager tm_)
		{
			return GetBySettlAmount(settlAmount, 0, string.Empty, tm_);
		}
		public async Task<List<S_currency_changeEO>> GetBySettlAmountAsync(long settlAmount, TransactionManager tm_)
		{
			return await GetBySettlAmountAsync(settlAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SettlAmount（字段） 查询
		/// </summary>
		/// /// <param name = "settlAmount">结算金额(正负数)</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetBySettlAmount(long settlAmount, int top_)
		{
			return GetBySettlAmount(settlAmount, top_, string.Empty, null);
		}
		public async Task<List<S_currency_changeEO>> GetBySettlAmountAsync(long settlAmount, int top_)
		{
			return await GetBySettlAmountAsync(settlAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 SettlAmount（字段） 查询
		/// </summary>
		/// /// <param name = "settlAmount">结算金额(正负数)</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetBySettlAmount(long settlAmount, int top_, TransactionManager tm_)
		{
			return GetBySettlAmount(settlAmount, top_, string.Empty, tm_);
		}
		public async Task<List<S_currency_changeEO>> GetBySettlAmountAsync(long settlAmount, int top_, TransactionManager tm_)
		{
			return await GetBySettlAmountAsync(settlAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SettlAmount（字段） 查询
		/// </summary>
		/// /// <param name = "settlAmount">结算金额(正负数)</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetBySettlAmount(long settlAmount, string sort_)
		{
			return GetBySettlAmount(settlAmount, 0, sort_, null);
		}
		public async Task<List<S_currency_changeEO>> GetBySettlAmountAsync(long settlAmount, string sort_)
		{
			return await GetBySettlAmountAsync(settlAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 SettlAmount（字段） 查询
		/// </summary>
		/// /// <param name = "settlAmount">结算金额(正负数)</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetBySettlAmount(long settlAmount, string sort_, TransactionManager tm_)
		{
			return GetBySettlAmount(settlAmount, 0, sort_, tm_);
		}
		public async Task<List<S_currency_changeEO>> GetBySettlAmountAsync(long settlAmount, string sort_, TransactionManager tm_)
		{
			return await GetBySettlAmountAsync(settlAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 SettlAmount（字段） 查询
		/// </summary>
		/// /// <param name = "settlAmount">结算金额(正负数)</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currency_changeEO> GetBySettlAmount(long settlAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`SettlAmount` = @SettlAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@SettlAmount", settlAmount, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, S_currency_changeEO.MapDataReader);
		}
		public async Task<List<S_currency_changeEO>> GetBySettlAmountAsync(long settlAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`SettlAmount` = @SettlAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@SettlAmount", settlAmount, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_currency_changeEO.MapDataReader);
		}
		#endregion // GetBySettlAmount
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}

/******************************************************
 * 此代码由代码生成器工具自动生成，请不要修改
 * TinyFx代码生成器核心库版本号：1.0.0.0
 * git: https://github.com/jh98net/TinyFx
 * 文档生成时间：2023-12-29 15: 09:49
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
	/// 应用提供商调用我方接口订单
	/// 【表 s_provider_order 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class S_provider_orderEO : IRowMapper<S_provider_orderEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public S_provider_orderEO()
		{
			this.FromMode = 0;
			this.UserKind = 0;
			this.CurrencyType = 0;
			this.PromoterType = 2;
			this.ReqMark = 0;
			this.RoundClosed = true;
			this.IsFree = false;
			this.PlanBet = 0;
			this.PlanWin = 0;
			this.PlanAmount = 0;
			this.Status = 0;
			this.RecDate = DateTime.Now;
			this.Amount = 0;
			this.EndBalance = 0;
			this.BetBonus = 0;
			this.WinBonus = 0;
			this.EndBonus = 0;
			this.AmountBonus = 0;
			this.SettlAmount = 0;
			this.SettlStatus = 0;
		}
		#region 主键原始值 & 主键集合
	    
		/// <summary>
		/// 当前对象是否保存原始主键值，当修改了主键值时为 true
		/// </summary>
		public bool HasOriginal { get; protected set; }
		
		private string _originalOrderID;
		/// <summary>
		/// 【数据库中的原始主键 OrderID 值的副本，用于主键值更新】
		/// </summary>
		public string OriginalOrderID
		{
			get { return _originalOrderID; }
			set { HasOriginal = true; _originalOrderID = value; }
		}
	    /// <summary>
	    /// 获取主键集合。key: 数据库字段名称, value: 主键值
	    /// </summary>
	    /// <returns></returns>
	    public Dictionary<string, object> GetPrimaryKeys()
	    {
	        return new Dictionary<string, object>() { { "OrderID", OrderID }, };
	    }
	    /// <summary>
	    /// 获取主键集合JSON格式
	    /// </summary>
	    /// <returns></returns>
	    public string GetPrimaryKeysJson() => SerializerUtil.SerializeJson(GetPrimaryKeys());
		#endregion // 主键原始值
		#region 所有字段
		/// <summary>
		/// 供应商请求生成的订单编码 GUID
		/// 【主键 varchar(38)】
		/// </summary>
		[DataMember(Order = 1)]
		public string OrderID { get; set; }
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
		/// 货币类型（货币缩写RMB,USD）
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
		/// 推广类型1-棋牌2-电子3-捕鱼4-真人5-彩票6-体育
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 12)]
		public int PromoterType { get; set; }
		/// <summary>
		/// 请求接口类型（0-balance1-Bet 2-Win 3-BetWin4-Rollback）
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 13)]
		public int ReqMark { get; set; }
		/// <summary>
		/// 请求唯一号
		/// 【字段 varchar(38)】
		/// </summary>
		[DataMember(Order = 14)]
		public string RequestUUID { get; set; }
		/// <summary>
		/// 应用提供商订单编码(TransactionUUID)
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 15)]
		public string ProviderOrderId { get; set; }
		/// <summary>
		/// 应用提供商原始订单编码(ReferenceTransactionUUID)
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 16)]
		public string ReferProviderOrderId { get; set; }
		/// <summary>
		/// 回合是否关闭
		/// 【字段 tinyint(1)】
		/// </summary>
		[DataMember(Order = 17)]
		public bool RoundClosed { get; set; }
		/// <summary>
		/// 回合标识
		/// 【字段 varchar(100)】
		/// </summary>
		[DataMember(Order = 18)]
		public string RoundId { get; set; }
		/// <summary>
		/// 我方提供的奖励id
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 19)]
		public string RewardUUID { get; set; }
		/// <summary>
		/// 是否促销产生的交易
		/// 【字段 tinyint(1)】
		/// </summary>
		[DataMember(Order = 20)]
		public bool IsFree { get; set; }
		/// <summary>
		/// 计划下注数量（正数）
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 21)]
		public long PlanBet { get; set; }
		/// <summary>
		/// 计划返奖数量（正数）
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 22)]
		public long PlanWin { get; set; }
		/// <summary>
		/// 计划账户变化数量（正负数）
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 23)]
		public long PlanAmount { get; set; }
		/// <summary>
		/// 扩展数据
		/// 【字段 text】
		/// </summary>
		[DataMember(Order = 24)]
		public string Meta { get; set; }
		/// <summary>
		/// 用户IP
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 25)]
		public string UserIp { get; set; }
		/// <summary>
		/// 状态0-初始1-处理中2-成功3-失败4-已回滚5-异常且需处理6-异常已处理
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 26)]
		public int Status { get; set; }
		/// <summary>
		/// 订单时间
		/// 【字段 datetime】
		/// </summary>
		[DataMember(Order = 27)]
		public DateTime RecDate { get; set; }
		/// <summary>
		/// 返回时间
		/// 【字段 datetime】
		/// </summary>
		[DataMember(Order = 28)]
		public DateTime? ResponseTime { get; set; }
		/// <summary>
		/// 返回状态
		/// 【字段 varchar(255)】
		/// </summary>
		[DataMember(Order = 29)]
		public string ResponseStatus { get; set; }
		/// <summary>
		/// 实际账户变化数量（正负数）
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 30)]
		public long Amount { get; set; }
		/// <summary>
		/// 处理后余额
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 31)]
		public long EndBalance { get; set; }
		/// <summary>
		/// 下注时扣除的bonus
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 32)]
		public long BetBonus { get; set; }
		/// <summary>
		/// 返奖时增加的bonus
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 33)]
		public long WinBonus { get; set; }
		/// <summary>
		/// 处理后bonus余额
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 34)]
		public long EndBonus { get; set; }
		/// <summary>
		/// bonus实际变化数量（正负数）
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 35)]
		public long AmountBonus { get; set; }
		/// <summary>
		/// 结算表名
		/// 【字段 varchar(100)】
		/// </summary>
		[DataMember(Order = 36)]
		public string SettlTable { get; set; }
		/// <summary>
		/// 结算编码
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 37)]
		public string SettlId { get; set; }
		/// <summary>
		/// 结算金额(正负数)
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 38)]
		public long SettlAmount { get; set; }
		/// <summary>
		/// 结算状态（0-未结算1-已结算）
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 39)]
		public int SettlStatus { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public S_provider_orderEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static S_provider_orderEO MapDataReader(IDataReader reader)
		{
		    S_provider_orderEO ret = new S_provider_orderEO();
			ret.OrderID = reader.ToString("OrderID");
			ret.OriginalOrderID = ret.OrderID;
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
			ret.PromoterType = reader.ToInt32("PromoterType");
			ret.ReqMark = reader.ToInt32("ReqMark");
			ret.RequestUUID = reader.ToString("RequestUUID");
			ret.ProviderOrderId = reader.ToString("ProviderOrderId");
			ret.ReferProviderOrderId = reader.ToString("ReferProviderOrderId");
			ret.RoundClosed = reader.ToBoolean("RoundClosed");
			ret.RoundId = reader.ToString("RoundId");
			ret.RewardUUID = reader.ToString("RewardUUID");
			ret.IsFree = reader.ToBoolean("IsFree");
			ret.PlanBet = reader.ToInt64("PlanBet");
			ret.PlanWin = reader.ToInt64("PlanWin");
			ret.PlanAmount = reader.ToInt64("PlanAmount");
			ret.Meta = reader.ToString("Meta");
			ret.UserIp = reader.ToString("UserIp");
			ret.Status = reader.ToInt32("Status");
			ret.RecDate = reader.ToDateTime("RecDate");
			ret.ResponseTime = reader.ToDateTimeN("ResponseTime");
			ret.ResponseStatus = reader.ToString("ResponseStatus");
			ret.Amount = reader.ToInt64("Amount");
			ret.EndBalance = reader.ToInt64("EndBalance");
			ret.BetBonus = reader.ToInt64("BetBonus");
			ret.WinBonus = reader.ToInt64("WinBonus");
			ret.EndBonus = reader.ToInt64("EndBonus");
			ret.AmountBonus = reader.ToInt64("AmountBonus");
			ret.SettlTable = reader.ToString("SettlTable");
			ret.SettlId = reader.ToString("SettlId");
			ret.SettlAmount = reader.ToInt64("SettlAmount");
			ret.SettlStatus = reader.ToInt32("SettlStatus");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 应用提供商调用我方接口订单
	/// 【表 s_provider_order 的操作类】
	/// </summary>
	[Obsolete]
	public class S_provider_orderMO : MySqlTableMO<S_provider_orderEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`s_provider_order`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public S_provider_orderMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public S_provider_orderMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public S_provider_orderMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(S_provider_orderEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(S_provider_orderEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(S_provider_orderEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`OrderID`, `ProviderID`, `AppID`, `OperatorID`, `UserID`, `FromMode`, `FromId`, `UserKind`, `CountryID`, `CurrencyID`, `CurrencyType`, `PromoterType`, `ReqMark`, `RequestUUID`, `ProviderOrderId`, `ReferProviderOrderId`, `RoundClosed`, `RoundId`, `RewardUUID`, `IsFree`, `PlanBet`, `PlanWin`, `PlanAmount`, `Meta`, `UserIp`, `Status`, `RecDate`, `ResponseTime`, `ResponseStatus`, `Amount`, `EndBalance`, `BetBonus`, `WinBonus`, `EndBonus`, `AmountBonus`, `SettlTable`, `SettlId`, `SettlAmount`, `SettlStatus`) VALUE (@OrderID, @ProviderID, @AppID, @OperatorID, @UserID, @FromMode, @FromId, @UserKind, @CountryID, @CurrencyID, @CurrencyType, @PromoterType, @ReqMark, @RequestUUID, @ProviderOrderId, @ReferProviderOrderId, @RoundClosed, @RoundId, @RewardUUID, @IsFree, @PlanBet, @PlanWin, @PlanAmount, @Meta, @UserIp, @Status, @RecDate, @ResponseTime, @ResponseStatus, @Amount, @EndBalance, @BetBonus, @WinBonus, @EndBonus, @AmountBonus, @SettlTable, @SettlId, @SettlAmount, @SettlStatus);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OrderID", item.OrderID, MySqlDbType.VarChar),
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
				Database.CreateInParameter("@PromoterType", item.PromoterType, MySqlDbType.Int32),
				Database.CreateInParameter("@ReqMark", item.ReqMark, MySqlDbType.Int32),
				Database.CreateInParameter("@RequestUUID", item.RequestUUID != null ? item.RequestUUID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ProviderOrderId", item.ProviderOrderId != null ? item.ProviderOrderId : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ReferProviderOrderId", item.ReferProviderOrderId != null ? item.ReferProviderOrderId : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@RoundClosed", item.RoundClosed, MySqlDbType.Byte),
				Database.CreateInParameter("@RoundId", item.RoundId != null ? item.RoundId : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@RewardUUID", item.RewardUUID != null ? item.RewardUUID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@IsFree", item.IsFree, MySqlDbType.Byte),
				Database.CreateInParameter("@PlanBet", item.PlanBet, MySqlDbType.Int64),
				Database.CreateInParameter("@PlanWin", item.PlanWin, MySqlDbType.Int64),
				Database.CreateInParameter("@PlanAmount", item.PlanAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@Meta", item.Meta != null ? item.Meta : (object)DBNull.Value, MySqlDbType.Text),
				Database.CreateInParameter("@UserIp", item.UserIp != null ? item.UserIp : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Status", item.Status, MySqlDbType.Int32),
				Database.CreateInParameter("@RecDate", item.RecDate, MySqlDbType.DateTime),
				Database.CreateInParameter("@ResponseTime", item.ResponseTime.HasValue ? item.ResponseTime.Value : (object)DBNull.Value, MySqlDbType.DateTime),
				Database.CreateInParameter("@ResponseStatus", item.ResponseStatus != null ? item.ResponseStatus : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Amount", item.Amount, MySqlDbType.Int64),
				Database.CreateInParameter("@EndBalance", item.EndBalance, MySqlDbType.Int64),
				Database.CreateInParameter("@BetBonus", item.BetBonus, MySqlDbType.Int64),
				Database.CreateInParameter("@WinBonus", item.WinBonus, MySqlDbType.Int64),
				Database.CreateInParameter("@EndBonus", item.EndBonus, MySqlDbType.Int64),
				Database.CreateInParameter("@AmountBonus", item.AmountBonus, MySqlDbType.Int64),
				Database.CreateInParameter("@SettlTable", item.SettlTable != null ? item.SettlTable : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@SettlId", item.SettlId != null ? item.SettlId : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@SettlAmount", item.SettlAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@SettlStatus", item.SettlStatus, MySqlDbType.Int32),
			};
		}
		public int AddByBatch(IEnumerable<S_provider_orderEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<S_provider_orderEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<S_provider_orderEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`OrderID`, `ProviderID`, `AppID`, `OperatorID`, `UserID`, `FromMode`, `FromId`, `UserKind`, `CountryID`, `CurrencyID`, `CurrencyType`, `PromoterType`, `ReqMark`, `RequestUUID`, `ProviderOrderId`, `ReferProviderOrderId`, `RoundClosed`, `RoundId`, `RewardUUID`, `IsFree`, `PlanBet`, `PlanWin`, `PlanAmount`, `Meta`, `UserIp`, `Status`, `RecDate`, `ResponseTime`, `ResponseStatus`, `Amount`, `EndBalance`, `BetBonus`, `WinBonus`, `EndBonus`, `AmountBonus`, `SettlTable`, `SettlId`, `SettlAmount`, `SettlStatus`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"('{item.OrderID}','{item.ProviderID}','{item.AppID}','{item.OperatorID}','{item.UserID}',{item.FromMode},'{item.FromId}',{item.UserKind},'{item.CountryID}','{item.CurrencyID}',{item.CurrencyType},{item.PromoterType},{item.ReqMark},'{item.RequestUUID}','{item.ProviderOrderId}','{item.ReferProviderOrderId}',{item.RoundClosed},'{item.RoundId}','{item.RewardUUID}',{item.IsFree},{item.PlanBet},{item.PlanWin},{item.PlanAmount},'{item.Meta}','{item.UserIp}',{item.Status},'{item.RecDate.ToString("yyyy-MM-dd HH:mm:ss")}','{item.ResponseTime?.ToString("yyyy-MM-dd HH:mm:ss")}','{item.ResponseStatus}',{item.Amount},{item.EndBalance},{item.BetBonus},{item.WinBonus},{item.EndBonus},{item.AmountBonus},'{item.SettlTable}','{item.SettlId}',{item.SettlAmount},{item.SettlStatus}),");
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
		/// /// <param name = "orderID">供应商请求生成的订单编码 GUID</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(string orderID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(orderID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(string orderID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(orderID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(string orderID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `OrderID` = @OrderID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(S_provider_orderEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.OrderID, tm_);
		}
		public async Task<int> RemoveAsync(S_provider_orderEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.OrderID, tm_);
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
		/// /// <param name = "currencyID">货币类型（货币缩写RMB,USD）</param>
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
		#region RemoveByPromoterType
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "promoterType">推广类型1-棋牌2-电子3-捕鱼4-真人5-彩票6-体育</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPromoterType(int promoterType, TransactionManager tm_ = null)
		{
			RepairRemoveByPromoterTypeData(promoterType, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPromoterTypeAsync(int promoterType, TransactionManager tm_ = null)
		{
			RepairRemoveByPromoterTypeData(promoterType, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByPromoterTypeData(int promoterType, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `PromoterType` = @PromoterType";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PromoterType", promoterType, MySqlDbType.Int32));
		}
		#endregion // RemoveByPromoterType
		#region RemoveByReqMark
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "reqMark">请求接口类型（0-balance1-Bet 2-Win 3-BetWin4-Rollback）</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByReqMark(int reqMark, TransactionManager tm_ = null)
		{
			RepairRemoveByReqMarkData(reqMark, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByReqMarkAsync(int reqMark, TransactionManager tm_ = null)
		{
			RepairRemoveByReqMarkData(reqMark, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByReqMarkData(int reqMark, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `ReqMark` = @ReqMark";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ReqMark", reqMark, MySqlDbType.Int32));
		}
		#endregion // RemoveByReqMark
		#region RemoveByRequestUUID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "requestUUID">请求唯一号</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByRequestUUID(string requestUUID, TransactionManager tm_ = null)
		{
			RepairRemoveByRequestUUIDData(requestUUID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByRequestUUIDAsync(string requestUUID, TransactionManager tm_ = null)
		{
			RepairRemoveByRequestUUIDData(requestUUID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByRequestUUIDData(string requestUUID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (requestUUID != null ? "`RequestUUID` = @RequestUUID" : "`RequestUUID` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (requestUUID != null)
				paras_.Add(Database.CreateInParameter("@RequestUUID", requestUUID, MySqlDbType.VarChar));
		}
		#endregion // RemoveByRequestUUID
		#region RemoveByProviderOrderId
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "providerOrderId">应用提供商订单编码(TransactionUUID)</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByProviderOrderId(string providerOrderId, TransactionManager tm_ = null)
		{
			RepairRemoveByProviderOrderIdData(providerOrderId, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByProviderOrderIdAsync(string providerOrderId, TransactionManager tm_ = null)
		{
			RepairRemoveByProviderOrderIdData(providerOrderId, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByProviderOrderIdData(string providerOrderId, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (providerOrderId != null ? "`ProviderOrderId` = @ProviderOrderId" : "`ProviderOrderId` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (providerOrderId != null)
				paras_.Add(Database.CreateInParameter("@ProviderOrderId", providerOrderId, MySqlDbType.VarChar));
		}
		#endregion // RemoveByProviderOrderId
		#region RemoveByReferProviderOrderId
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "referProviderOrderId">应用提供商原始订单编码(ReferenceTransactionUUID)</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByReferProviderOrderId(string referProviderOrderId, TransactionManager tm_ = null)
		{
			RepairRemoveByReferProviderOrderIdData(referProviderOrderId, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByReferProviderOrderIdAsync(string referProviderOrderId, TransactionManager tm_ = null)
		{
			RepairRemoveByReferProviderOrderIdData(referProviderOrderId, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByReferProviderOrderIdData(string referProviderOrderId, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (referProviderOrderId != null ? "`ReferProviderOrderId` = @ReferProviderOrderId" : "`ReferProviderOrderId` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (referProviderOrderId != null)
				paras_.Add(Database.CreateInParameter("@ReferProviderOrderId", referProviderOrderId, MySqlDbType.VarChar));
		}
		#endregion // RemoveByReferProviderOrderId
		#region RemoveByRoundClosed
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "roundClosed">回合是否关闭</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByRoundClosed(bool roundClosed, TransactionManager tm_ = null)
		{
			RepairRemoveByRoundClosedData(roundClosed, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByRoundClosedAsync(bool roundClosed, TransactionManager tm_ = null)
		{
			RepairRemoveByRoundClosedData(roundClosed, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByRoundClosedData(bool roundClosed, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `RoundClosed` = @RoundClosed";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RoundClosed", roundClosed, MySqlDbType.Byte));
		}
		#endregion // RemoveByRoundClosed
		#region RemoveByRoundId
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "roundId">回合标识</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByRoundId(string roundId, TransactionManager tm_ = null)
		{
			RepairRemoveByRoundIdData(roundId, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByRoundIdAsync(string roundId, TransactionManager tm_ = null)
		{
			RepairRemoveByRoundIdData(roundId, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByRoundIdData(string roundId, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (roundId != null ? "`RoundId` = @RoundId" : "`RoundId` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (roundId != null)
				paras_.Add(Database.CreateInParameter("@RoundId", roundId, MySqlDbType.VarChar));
		}
		#endregion // RemoveByRoundId
		#region RemoveByRewardUUID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "rewardUUID">我方提供的奖励id</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByRewardUUID(string rewardUUID, TransactionManager tm_ = null)
		{
			RepairRemoveByRewardUUIDData(rewardUUID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByRewardUUIDAsync(string rewardUUID, TransactionManager tm_ = null)
		{
			RepairRemoveByRewardUUIDData(rewardUUID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByRewardUUIDData(string rewardUUID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (rewardUUID != null ? "`RewardUUID` = @RewardUUID" : "`RewardUUID` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (rewardUUID != null)
				paras_.Add(Database.CreateInParameter("@RewardUUID", rewardUUID, MySqlDbType.VarChar));
		}
		#endregion // RemoveByRewardUUID
		#region RemoveByIsFree
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "isFree">是否促销产生的交易</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByIsFree(bool isFree, TransactionManager tm_ = null)
		{
			RepairRemoveByIsFreeData(isFree, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByIsFreeAsync(bool isFree, TransactionManager tm_ = null)
		{
			RepairRemoveByIsFreeData(isFree, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByIsFreeData(bool isFree, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `IsFree` = @IsFree";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IsFree", isFree, MySqlDbType.Byte));
		}
		#endregion // RemoveByIsFree
		#region RemoveByPlanBet
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "planBet">计划下注数量（正数）</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPlanBet(long planBet, TransactionManager tm_ = null)
		{
			RepairRemoveByPlanBetData(planBet, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPlanBetAsync(long planBet, TransactionManager tm_ = null)
		{
			RepairRemoveByPlanBetData(planBet, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByPlanBetData(long planBet, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `PlanBet` = @PlanBet";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PlanBet", planBet, MySqlDbType.Int64));
		}
		#endregion // RemoveByPlanBet
		#region RemoveByPlanWin
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "planWin">计划返奖数量（正数）</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPlanWin(long planWin, TransactionManager tm_ = null)
		{
			RepairRemoveByPlanWinData(planWin, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPlanWinAsync(long planWin, TransactionManager tm_ = null)
		{
			RepairRemoveByPlanWinData(planWin, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByPlanWinData(long planWin, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `PlanWin` = @PlanWin";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PlanWin", planWin, MySqlDbType.Int64));
		}
		#endregion // RemoveByPlanWin
		#region RemoveByPlanAmount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "planAmount">计划账户变化数量（正负数）</param>
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
		/// /// <param name = "recDate">订单时间</param>
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
		#region RemoveByResponseTime
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "responseTime">返回时间</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByResponseTime(DateTime? responseTime, TransactionManager tm_ = null)
		{
			RepairRemoveByResponseTimeData(responseTime.Value, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByResponseTimeAsync(DateTime? responseTime, TransactionManager tm_ = null)
		{
			RepairRemoveByResponseTimeData(responseTime.Value, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByResponseTimeData(DateTime? responseTime, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (responseTime.HasValue ? "`ResponseTime` = @ResponseTime" : "`ResponseTime` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (responseTime.HasValue)
				paras_.Add(Database.CreateInParameter("@ResponseTime", responseTime.Value, MySqlDbType.DateTime));
		}
		#endregion // RemoveByResponseTime
		#region RemoveByResponseStatus
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "responseStatus">返回状态</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByResponseStatus(string responseStatus, TransactionManager tm_ = null)
		{
			RepairRemoveByResponseStatusData(responseStatus, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByResponseStatusAsync(string responseStatus, TransactionManager tm_ = null)
		{
			RepairRemoveByResponseStatusData(responseStatus, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByResponseStatusData(string responseStatus, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (responseStatus != null ? "`ResponseStatus` = @ResponseStatus" : "`ResponseStatus` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (responseStatus != null)
				paras_.Add(Database.CreateInParameter("@ResponseStatus", responseStatus, MySqlDbType.VarChar));
		}
		#endregion // RemoveByResponseStatus
		#region RemoveByAmount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "amount">实际账户变化数量（正负数）</param>
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
		#region RemoveByBetBonus
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "betBonus">下注时扣除的bonus</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByBetBonus(long betBonus, TransactionManager tm_ = null)
		{
			RepairRemoveByBetBonusData(betBonus, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByBetBonusAsync(long betBonus, TransactionManager tm_ = null)
		{
			RepairRemoveByBetBonusData(betBonus, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByBetBonusData(long betBonus, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `BetBonus` = @BetBonus";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BetBonus", betBonus, MySqlDbType.Int64));
		}
		#endregion // RemoveByBetBonus
		#region RemoveByWinBonus
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "winBonus">返奖时增加的bonus</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByWinBonus(long winBonus, TransactionManager tm_ = null)
		{
			RepairRemoveByWinBonusData(winBonus, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByWinBonusAsync(long winBonus, TransactionManager tm_ = null)
		{
			RepairRemoveByWinBonusData(winBonus, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByWinBonusData(long winBonus, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `WinBonus` = @WinBonus";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@WinBonus", winBonus, MySqlDbType.Int64));
		}
		#endregion // RemoveByWinBonus
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
		public int Put(S_provider_orderEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(S_provider_orderEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(S_provider_orderEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `OrderID` = @OrderID, `ProviderID` = @ProviderID, `AppID` = @AppID, `OperatorID` = @OperatorID, `UserID` = @UserID, `FromMode` = @FromMode, `FromId` = @FromId, `UserKind` = @UserKind, `CountryID` = @CountryID, `CurrencyID` = @CurrencyID, `CurrencyType` = @CurrencyType, `PromoterType` = @PromoterType, `ReqMark` = @ReqMark, `RequestUUID` = @RequestUUID, `ProviderOrderId` = @ProviderOrderId, `ReferProviderOrderId` = @ReferProviderOrderId, `RoundClosed` = @RoundClosed, `RoundId` = @RoundId, `RewardUUID` = @RewardUUID, `IsFree` = @IsFree, `PlanBet` = @PlanBet, `PlanWin` = @PlanWin, `PlanAmount` = @PlanAmount, `Meta` = @Meta, `UserIp` = @UserIp, `Status` = @Status, `ResponseTime` = @ResponseTime, `ResponseStatus` = @ResponseStatus, `Amount` = @Amount, `EndBalance` = @EndBalance, `BetBonus` = @BetBonus, `WinBonus` = @WinBonus, `EndBonus` = @EndBonus, `AmountBonus` = @AmountBonus, `SettlTable` = @SettlTable, `SettlId` = @SettlId, `SettlAmount` = @SettlAmount, `SettlStatus` = @SettlStatus WHERE `OrderID` = @OrderID_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OrderID", item.OrderID, MySqlDbType.VarChar),
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
				Database.CreateInParameter("@PromoterType", item.PromoterType, MySqlDbType.Int32),
				Database.CreateInParameter("@ReqMark", item.ReqMark, MySqlDbType.Int32),
				Database.CreateInParameter("@RequestUUID", item.RequestUUID != null ? item.RequestUUID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ProviderOrderId", item.ProviderOrderId != null ? item.ProviderOrderId : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ReferProviderOrderId", item.ReferProviderOrderId != null ? item.ReferProviderOrderId : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@RoundClosed", item.RoundClosed, MySqlDbType.Byte),
				Database.CreateInParameter("@RoundId", item.RoundId != null ? item.RoundId : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@RewardUUID", item.RewardUUID != null ? item.RewardUUID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@IsFree", item.IsFree, MySqlDbType.Byte),
				Database.CreateInParameter("@PlanBet", item.PlanBet, MySqlDbType.Int64),
				Database.CreateInParameter("@PlanWin", item.PlanWin, MySqlDbType.Int64),
				Database.CreateInParameter("@PlanAmount", item.PlanAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@Meta", item.Meta != null ? item.Meta : (object)DBNull.Value, MySqlDbType.Text),
				Database.CreateInParameter("@UserIp", item.UserIp != null ? item.UserIp : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Status", item.Status, MySqlDbType.Int32),
				Database.CreateInParameter("@ResponseTime", item.ResponseTime.HasValue ? item.ResponseTime.Value : (object)DBNull.Value, MySqlDbType.DateTime),
				Database.CreateInParameter("@ResponseStatus", item.ResponseStatus != null ? item.ResponseStatus : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Amount", item.Amount, MySqlDbType.Int64),
				Database.CreateInParameter("@EndBalance", item.EndBalance, MySqlDbType.Int64),
				Database.CreateInParameter("@BetBonus", item.BetBonus, MySqlDbType.Int64),
				Database.CreateInParameter("@WinBonus", item.WinBonus, MySqlDbType.Int64),
				Database.CreateInParameter("@EndBonus", item.EndBonus, MySqlDbType.Int64),
				Database.CreateInParameter("@AmountBonus", item.AmountBonus, MySqlDbType.Int64),
				Database.CreateInParameter("@SettlTable", item.SettlTable != null ? item.SettlTable : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@SettlId", item.SettlId != null ? item.SettlId : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@SettlAmount", item.SettlAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@SettlStatus", item.SettlStatus, MySqlDbType.Int32),
				Database.CreateInParameter("@OrderID_Original", item.HasOriginal ? item.OriginalOrderID : item.OrderID, MySqlDbType.VarChar),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<S_provider_orderEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<S_provider_orderEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "orderID">供应商请求生成的订单编码 GUID</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string orderID, string set_, params object[] values_)
		{
			return Put(set_, "`OrderID` = @OrderID", ConcatValues(values_, orderID));
		}
		public async Task<int> PutByPKAsync(string orderID, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`OrderID` = @OrderID", ConcatValues(values_, orderID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "orderID">供应商请求生成的订单编码 GUID</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string orderID, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`OrderID` = @OrderID", tm_, ConcatValues(values_, orderID));
		}
		public async Task<int> PutByPKAsync(string orderID, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`OrderID` = @OrderID", tm_, ConcatValues(values_, orderID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "orderID">供应商请求生成的订单编码 GUID</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string orderID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
	        };
			return Put(set_, "`OrderID` = @OrderID", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(string orderID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
	        };
			return await PutAsync(set_, "`OrderID` = @OrderID", ConcatParameters(paras_, newParas_), tm_);
		}
		#endregion // PutByPK
		
		#region PutXXX
		#region PutProviderID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "orderID">供应商请求生成的订单编码 GUID</param>
		/// /// <param name = "providerID">应用提供商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutProviderIDByPK(string orderID, string providerID, TransactionManager tm_ = null)
		{
			RepairPutProviderIDByPKData(orderID, providerID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutProviderIDByPKAsync(string orderID, string providerID, TransactionManager tm_ = null)
		{
			RepairPutProviderIDByPKData(orderID, providerID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutProviderIDByPKData(string orderID, string providerID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `ProviderID` = @ProviderID  WHERE `OrderID` = @OrderID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ProviderID", providerID != null ? providerID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
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
		/// /// <param name = "orderID">供应商请求生成的订单编码 GUID</param>
		/// /// <param name = "appID">应用编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutAppIDByPK(string orderID, string appID, TransactionManager tm_ = null)
		{
			RepairPutAppIDByPKData(orderID, appID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAppIDByPKAsync(string orderID, string appID, TransactionManager tm_ = null)
		{
			RepairPutAppIDByPKData(orderID, appID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutAppIDByPKData(string orderID, string appID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `AppID` = @AppID  WHERE `OrderID` = @OrderID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID != null ? appID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
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
		/// /// <param name = "orderID">供应商请求生成的订单编码 GUID</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOperatorIDByPK(string orderID, string operatorID, TransactionManager tm_ = null)
		{
			RepairPutOperatorIDByPKData(orderID, operatorID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutOperatorIDByPKAsync(string orderID, string operatorID, TransactionManager tm_ = null)
		{
			RepairPutOperatorIDByPKData(orderID, operatorID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutOperatorIDByPKData(string orderID, string operatorID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `OperatorID` = @OperatorID  WHERE `OrderID` = @OrderID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID != null ? operatorID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
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
		/// /// <param name = "orderID">供应商请求生成的订单编码 GUID</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutUserIDByPK(string orderID, string userID, TransactionManager tm_ = null)
		{
			RepairPutUserIDByPKData(orderID, userID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutUserIDByPKAsync(string orderID, string userID, TransactionManager tm_ = null)
		{
			RepairPutUserIDByPKData(orderID, userID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutUserIDByPKData(string orderID, string userID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `UserID` = @UserID  WHERE `OrderID` = @OrderID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID != null ? userID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
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
		/// /// <param name = "orderID">供应商请求生成的订单编码 GUID</param>
		/// /// <param name = "fromMode">新用户来源方式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutFromModeByPK(string orderID, int fromMode, TransactionManager tm_ = null)
		{
			RepairPutFromModeByPKData(orderID, fromMode, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutFromModeByPKAsync(string orderID, int fromMode, TransactionManager tm_ = null)
		{
			RepairPutFromModeByPKData(orderID, fromMode, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutFromModeByPKData(string orderID, int fromMode, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `FromMode` = @FromMode  WHERE `OrderID` = @OrderID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@FromMode", fromMode, MySqlDbType.Int32),
				Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
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
		/// /// <param name = "orderID">供应商请求生成的订单编码 GUID</param>
		/// /// <param name = "fromId">对应的编码（根据FromMode变化）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutFromIdByPK(string orderID, string fromId, TransactionManager tm_ = null)
		{
			RepairPutFromIdByPKData(orderID, fromId, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutFromIdByPKAsync(string orderID, string fromId, TransactionManager tm_ = null)
		{
			RepairPutFromIdByPKData(orderID, fromId, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutFromIdByPKData(string orderID, string fromId, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `FromId` = @FromId  WHERE `OrderID` = @OrderID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@FromId", fromId != null ? fromId : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
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
		/// /// <param name = "orderID">供应商请求生成的订单编码 GUID</param>
		/// /// <param name = "userKind">用户类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutUserKindByPK(string orderID, int userKind, TransactionManager tm_ = null)
		{
			RepairPutUserKindByPKData(orderID, userKind, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutUserKindByPKAsync(string orderID, int userKind, TransactionManager tm_ = null)
		{
			RepairPutUserKindByPKData(orderID, userKind, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutUserKindByPKData(string orderID, int userKind, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `UserKind` = @UserKind  WHERE `OrderID` = @OrderID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserKind", userKind, MySqlDbType.Int32),
				Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
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
		/// /// <param name = "orderID">供应商请求生成的订单编码 GUID</param>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCountryIDByPK(string orderID, string countryID, TransactionManager tm_ = null)
		{
			RepairPutCountryIDByPKData(orderID, countryID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutCountryIDByPKAsync(string orderID, string countryID, TransactionManager tm_ = null)
		{
			RepairPutCountryIDByPKData(orderID, countryID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutCountryIDByPKData(string orderID, string countryID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `CountryID` = @CountryID  WHERE `OrderID` = @OrderID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CountryID", countryID != null ? countryID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
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
		/// /// <param name = "orderID">供应商请求生成的订单编码 GUID</param>
		/// /// <param name = "currencyID">货币类型（货币缩写RMB,USD）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCurrencyIDByPK(string orderID, string currencyID, TransactionManager tm_ = null)
		{
			RepairPutCurrencyIDByPKData(orderID, currencyID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutCurrencyIDByPKAsync(string orderID, string currencyID, TransactionManager tm_ = null)
		{
			RepairPutCurrencyIDByPKData(orderID, currencyID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutCurrencyIDByPKData(string orderID, string currencyID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `CurrencyID` = @CurrencyID  WHERE `OrderID` = @OrderID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CurrencyID", currencyID != null ? currencyID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "currencyID">货币类型（货币缩写RMB,USD）</param>
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
		/// /// <param name = "orderID">供应商请求生成的订单编码 GUID</param>
		/// /// <param name = "currencyType">货币类型 1-COIN 2--GOLD 3-POINT 4-SWB 8-虚拟货币 9-CASH</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCurrencyTypeByPK(string orderID, int currencyType, TransactionManager tm_ = null)
		{
			RepairPutCurrencyTypeByPKData(orderID, currencyType, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutCurrencyTypeByPKAsync(string orderID, int currencyType, TransactionManager tm_ = null)
		{
			RepairPutCurrencyTypeByPKData(orderID, currencyType, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutCurrencyTypeByPKData(string orderID, int currencyType, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `CurrencyType` = @CurrencyType  WHERE `OrderID` = @OrderID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CurrencyType", currencyType, MySqlDbType.Int32),
				Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
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
		#region PutPromoterType
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "orderID">供应商请求生成的订单编码 GUID</param>
		/// /// <param name = "promoterType">推广类型1-棋牌2-电子3-捕鱼4-真人5-彩票6-体育</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPromoterTypeByPK(string orderID, int promoterType, TransactionManager tm_ = null)
		{
			RepairPutPromoterTypeByPKData(orderID, promoterType, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutPromoterTypeByPKAsync(string orderID, int promoterType, TransactionManager tm_ = null)
		{
			RepairPutPromoterTypeByPKData(orderID, promoterType, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutPromoterTypeByPKData(string orderID, int promoterType, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `PromoterType` = @PromoterType  WHERE `OrderID` = @OrderID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@PromoterType", promoterType, MySqlDbType.Int32),
				Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "promoterType">推广类型1-棋牌2-电子3-捕鱼4-真人5-彩票6-体育</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPromoterType(int promoterType, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `PromoterType` = @PromoterType";
			var parameter_ = Database.CreateInParameter("@PromoterType", promoterType, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutPromoterTypeAsync(int promoterType, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `PromoterType` = @PromoterType";
			var parameter_ = Database.CreateInParameter("@PromoterType", promoterType, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutPromoterType
		#region PutReqMark
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "orderID">供应商请求生成的订单编码 GUID</param>
		/// /// <param name = "reqMark">请求接口类型（0-balance1-Bet 2-Win 3-BetWin4-Rollback）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutReqMarkByPK(string orderID, int reqMark, TransactionManager tm_ = null)
		{
			RepairPutReqMarkByPKData(orderID, reqMark, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutReqMarkByPKAsync(string orderID, int reqMark, TransactionManager tm_ = null)
		{
			RepairPutReqMarkByPKData(orderID, reqMark, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutReqMarkByPKData(string orderID, int reqMark, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `ReqMark` = @ReqMark  WHERE `OrderID` = @OrderID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ReqMark", reqMark, MySqlDbType.Int32),
				Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "reqMark">请求接口类型（0-balance1-Bet 2-Win 3-BetWin4-Rollback）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutReqMark(int reqMark, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ReqMark` = @ReqMark";
			var parameter_ = Database.CreateInParameter("@ReqMark", reqMark, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutReqMarkAsync(int reqMark, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ReqMark` = @ReqMark";
			var parameter_ = Database.CreateInParameter("@ReqMark", reqMark, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutReqMark
		#region PutRequestUUID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "orderID">供应商请求生成的订单编码 GUID</param>
		/// /// <param name = "requestUUID">请求唯一号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRequestUUIDByPK(string orderID, string requestUUID, TransactionManager tm_ = null)
		{
			RepairPutRequestUUIDByPKData(orderID, requestUUID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutRequestUUIDByPKAsync(string orderID, string requestUUID, TransactionManager tm_ = null)
		{
			RepairPutRequestUUIDByPKData(orderID, requestUUID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutRequestUUIDByPKData(string orderID, string requestUUID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `RequestUUID` = @RequestUUID  WHERE `OrderID` = @OrderID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RequestUUID", requestUUID != null ? requestUUID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "requestUUID">请求唯一号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRequestUUID(string requestUUID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `RequestUUID` = @RequestUUID";
			var parameter_ = Database.CreateInParameter("@RequestUUID", requestUUID != null ? requestUUID : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutRequestUUIDAsync(string requestUUID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `RequestUUID` = @RequestUUID";
			var parameter_ = Database.CreateInParameter("@RequestUUID", requestUUID != null ? requestUUID : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutRequestUUID
		#region PutProviderOrderId
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "orderID">供应商请求生成的订单编码 GUID</param>
		/// /// <param name = "providerOrderId">应用提供商订单编码(TransactionUUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutProviderOrderIdByPK(string orderID, string providerOrderId, TransactionManager tm_ = null)
		{
			RepairPutProviderOrderIdByPKData(orderID, providerOrderId, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutProviderOrderIdByPKAsync(string orderID, string providerOrderId, TransactionManager tm_ = null)
		{
			RepairPutProviderOrderIdByPKData(orderID, providerOrderId, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutProviderOrderIdByPKData(string orderID, string providerOrderId, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `ProviderOrderId` = @ProviderOrderId  WHERE `OrderID` = @OrderID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ProviderOrderId", providerOrderId != null ? providerOrderId : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "providerOrderId">应用提供商订单编码(TransactionUUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutProviderOrderId(string providerOrderId, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ProviderOrderId` = @ProviderOrderId";
			var parameter_ = Database.CreateInParameter("@ProviderOrderId", providerOrderId != null ? providerOrderId : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutProviderOrderIdAsync(string providerOrderId, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ProviderOrderId` = @ProviderOrderId";
			var parameter_ = Database.CreateInParameter("@ProviderOrderId", providerOrderId != null ? providerOrderId : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutProviderOrderId
		#region PutReferProviderOrderId
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "orderID">供应商请求生成的订单编码 GUID</param>
		/// /// <param name = "referProviderOrderId">应用提供商原始订单编码(ReferenceTransactionUUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutReferProviderOrderIdByPK(string orderID, string referProviderOrderId, TransactionManager tm_ = null)
		{
			RepairPutReferProviderOrderIdByPKData(orderID, referProviderOrderId, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutReferProviderOrderIdByPKAsync(string orderID, string referProviderOrderId, TransactionManager tm_ = null)
		{
			RepairPutReferProviderOrderIdByPKData(orderID, referProviderOrderId, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutReferProviderOrderIdByPKData(string orderID, string referProviderOrderId, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `ReferProviderOrderId` = @ReferProviderOrderId  WHERE `OrderID` = @OrderID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ReferProviderOrderId", referProviderOrderId != null ? referProviderOrderId : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "referProviderOrderId">应用提供商原始订单编码(ReferenceTransactionUUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutReferProviderOrderId(string referProviderOrderId, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ReferProviderOrderId` = @ReferProviderOrderId";
			var parameter_ = Database.CreateInParameter("@ReferProviderOrderId", referProviderOrderId != null ? referProviderOrderId : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutReferProviderOrderIdAsync(string referProviderOrderId, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ReferProviderOrderId` = @ReferProviderOrderId";
			var parameter_ = Database.CreateInParameter("@ReferProviderOrderId", referProviderOrderId != null ? referProviderOrderId : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutReferProviderOrderId
		#region PutRoundClosed
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "orderID">供应商请求生成的订单编码 GUID</param>
		/// /// <param name = "roundClosed">回合是否关闭</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRoundClosedByPK(string orderID, bool roundClosed, TransactionManager tm_ = null)
		{
			RepairPutRoundClosedByPKData(orderID, roundClosed, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutRoundClosedByPKAsync(string orderID, bool roundClosed, TransactionManager tm_ = null)
		{
			RepairPutRoundClosedByPKData(orderID, roundClosed, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutRoundClosedByPKData(string orderID, bool roundClosed, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `RoundClosed` = @RoundClosed  WHERE `OrderID` = @OrderID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RoundClosed", roundClosed, MySqlDbType.Byte),
				Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "roundClosed">回合是否关闭</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRoundClosed(bool roundClosed, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `RoundClosed` = @RoundClosed";
			var parameter_ = Database.CreateInParameter("@RoundClosed", roundClosed, MySqlDbType.Byte);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutRoundClosedAsync(bool roundClosed, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `RoundClosed` = @RoundClosed";
			var parameter_ = Database.CreateInParameter("@RoundClosed", roundClosed, MySqlDbType.Byte);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutRoundClosed
		#region PutRoundId
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "orderID">供应商请求生成的订单编码 GUID</param>
		/// /// <param name = "roundId">回合标识</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRoundIdByPK(string orderID, string roundId, TransactionManager tm_ = null)
		{
			RepairPutRoundIdByPKData(orderID, roundId, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutRoundIdByPKAsync(string orderID, string roundId, TransactionManager tm_ = null)
		{
			RepairPutRoundIdByPKData(orderID, roundId, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutRoundIdByPKData(string orderID, string roundId, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `RoundId` = @RoundId  WHERE `OrderID` = @OrderID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RoundId", roundId != null ? roundId : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "roundId">回合标识</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRoundId(string roundId, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `RoundId` = @RoundId";
			var parameter_ = Database.CreateInParameter("@RoundId", roundId != null ? roundId : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutRoundIdAsync(string roundId, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `RoundId` = @RoundId";
			var parameter_ = Database.CreateInParameter("@RoundId", roundId != null ? roundId : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutRoundId
		#region PutRewardUUID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "orderID">供应商请求生成的订单编码 GUID</param>
		/// /// <param name = "rewardUUID">我方提供的奖励id</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRewardUUIDByPK(string orderID, string rewardUUID, TransactionManager tm_ = null)
		{
			RepairPutRewardUUIDByPKData(orderID, rewardUUID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutRewardUUIDByPKAsync(string orderID, string rewardUUID, TransactionManager tm_ = null)
		{
			RepairPutRewardUUIDByPKData(orderID, rewardUUID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutRewardUUIDByPKData(string orderID, string rewardUUID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `RewardUUID` = @RewardUUID  WHERE `OrderID` = @OrderID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RewardUUID", rewardUUID != null ? rewardUUID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "rewardUUID">我方提供的奖励id</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRewardUUID(string rewardUUID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `RewardUUID` = @RewardUUID";
			var parameter_ = Database.CreateInParameter("@RewardUUID", rewardUUID != null ? rewardUUID : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutRewardUUIDAsync(string rewardUUID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `RewardUUID` = @RewardUUID";
			var parameter_ = Database.CreateInParameter("@RewardUUID", rewardUUID != null ? rewardUUID : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutRewardUUID
		#region PutIsFree
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "orderID">供应商请求生成的订单编码 GUID</param>
		/// /// <param name = "isFree">是否促销产生的交易</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutIsFreeByPK(string orderID, bool isFree, TransactionManager tm_ = null)
		{
			RepairPutIsFreeByPKData(orderID, isFree, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutIsFreeByPKAsync(string orderID, bool isFree, TransactionManager tm_ = null)
		{
			RepairPutIsFreeByPKData(orderID, isFree, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutIsFreeByPKData(string orderID, bool isFree, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `IsFree` = @IsFree  WHERE `OrderID` = @OrderID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@IsFree", isFree, MySqlDbType.Byte),
				Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "isFree">是否促销产生的交易</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutIsFree(bool isFree, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `IsFree` = @IsFree";
			var parameter_ = Database.CreateInParameter("@IsFree", isFree, MySqlDbType.Byte);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutIsFreeAsync(bool isFree, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `IsFree` = @IsFree";
			var parameter_ = Database.CreateInParameter("@IsFree", isFree, MySqlDbType.Byte);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutIsFree
		#region PutPlanBet
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "orderID">供应商请求生成的订单编码 GUID</param>
		/// /// <param name = "planBet">计划下注数量（正数）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPlanBetByPK(string orderID, long planBet, TransactionManager tm_ = null)
		{
			RepairPutPlanBetByPKData(orderID, planBet, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutPlanBetByPKAsync(string orderID, long planBet, TransactionManager tm_ = null)
		{
			RepairPutPlanBetByPKData(orderID, planBet, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutPlanBetByPKData(string orderID, long planBet, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `PlanBet` = @PlanBet  WHERE `OrderID` = @OrderID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@PlanBet", planBet, MySqlDbType.Int64),
				Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "planBet">计划下注数量（正数）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPlanBet(long planBet, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `PlanBet` = @PlanBet";
			var parameter_ = Database.CreateInParameter("@PlanBet", planBet, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutPlanBetAsync(long planBet, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `PlanBet` = @PlanBet";
			var parameter_ = Database.CreateInParameter("@PlanBet", planBet, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutPlanBet
		#region PutPlanWin
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "orderID">供应商请求生成的订单编码 GUID</param>
		/// /// <param name = "planWin">计划返奖数量（正数）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPlanWinByPK(string orderID, long planWin, TransactionManager tm_ = null)
		{
			RepairPutPlanWinByPKData(orderID, planWin, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutPlanWinByPKAsync(string orderID, long planWin, TransactionManager tm_ = null)
		{
			RepairPutPlanWinByPKData(orderID, planWin, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutPlanWinByPKData(string orderID, long planWin, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `PlanWin` = @PlanWin  WHERE `OrderID` = @OrderID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@PlanWin", planWin, MySqlDbType.Int64),
				Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "planWin">计划返奖数量（正数）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPlanWin(long planWin, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `PlanWin` = @PlanWin";
			var parameter_ = Database.CreateInParameter("@PlanWin", planWin, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutPlanWinAsync(long planWin, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `PlanWin` = @PlanWin";
			var parameter_ = Database.CreateInParameter("@PlanWin", planWin, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutPlanWin
		#region PutPlanAmount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "orderID">供应商请求生成的订单编码 GUID</param>
		/// /// <param name = "planAmount">计划账户变化数量（正负数）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPlanAmountByPK(string orderID, long planAmount, TransactionManager tm_ = null)
		{
			RepairPutPlanAmountByPKData(orderID, planAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutPlanAmountByPKAsync(string orderID, long planAmount, TransactionManager tm_ = null)
		{
			RepairPutPlanAmountByPKData(orderID, planAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutPlanAmountByPKData(string orderID, long planAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `PlanAmount` = @PlanAmount  WHERE `OrderID` = @OrderID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@PlanAmount", planAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "planAmount">计划账户变化数量（正负数）</param>
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
		/// /// <param name = "orderID">供应商请求生成的订单编码 GUID</param>
		/// /// <param name = "meta">扩展数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutMetaByPK(string orderID, string meta, TransactionManager tm_ = null)
		{
			RepairPutMetaByPKData(orderID, meta, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutMetaByPKAsync(string orderID, string meta, TransactionManager tm_ = null)
		{
			RepairPutMetaByPKData(orderID, meta, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutMetaByPKData(string orderID, string meta, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Meta` = @Meta  WHERE `OrderID` = @OrderID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Meta", meta != null ? meta : (object)DBNull.Value, MySqlDbType.Text),
				Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
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
		#region PutUserIp
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "orderID">供应商请求生成的订单编码 GUID</param>
		/// /// <param name = "userIp">用户IP</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutUserIpByPK(string orderID, string userIp, TransactionManager tm_ = null)
		{
			RepairPutUserIpByPKData(orderID, userIp, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutUserIpByPKAsync(string orderID, string userIp, TransactionManager tm_ = null)
		{
			RepairPutUserIpByPKData(orderID, userIp, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutUserIpByPKData(string orderID, string userIp, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `UserIp` = @UserIp  WHERE `OrderID` = @OrderID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserIp", userIp != null ? userIp : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
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
		/// /// <param name = "orderID">供应商请求生成的订单编码 GUID</param>
		/// /// <param name = "status">状态0-初始1-处理中2-成功3-失败4-已回滚5-异常且需处理6-异常已处理</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutStatusByPK(string orderID, int status, TransactionManager tm_ = null)
		{
			RepairPutStatusByPKData(orderID, status, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutStatusByPKAsync(string orderID, int status, TransactionManager tm_ = null)
		{
			RepairPutStatusByPKData(orderID, status, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutStatusByPKData(string orderID, int status, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Status` = @Status  WHERE `OrderID` = @OrderID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Status", status, MySqlDbType.Int32),
				Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
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
		/// /// <param name = "orderID">供应商请求生成的订单编码 GUID</param>
		/// /// <param name = "recDate">订单时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRecDateByPK(string orderID, DateTime recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(orderID, recDate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutRecDateByPKAsync(string orderID, DateTime recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(orderID, recDate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutRecDateByPKData(string orderID, DateTime recDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `RecDate` = @RecDate  WHERE `OrderID` = @OrderID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime),
				Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "recDate">订单时间</param>
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
		#region PutResponseTime
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "orderID">供应商请求生成的订单编码 GUID</param>
		/// /// <param name = "responseTime">返回时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutResponseTimeByPK(string orderID, DateTime? responseTime, TransactionManager tm_ = null)
		{
			RepairPutResponseTimeByPKData(orderID, responseTime, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutResponseTimeByPKAsync(string orderID, DateTime? responseTime, TransactionManager tm_ = null)
		{
			RepairPutResponseTimeByPKData(orderID, responseTime, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutResponseTimeByPKData(string orderID, DateTime? responseTime, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `ResponseTime` = @ResponseTime  WHERE `OrderID` = @OrderID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ResponseTime", responseTime.HasValue ? responseTime.Value : (object)DBNull.Value, MySqlDbType.DateTime),
				Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "responseTime">返回时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutResponseTime(DateTime? responseTime, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ResponseTime` = @ResponseTime";
			var parameter_ = Database.CreateInParameter("@ResponseTime", responseTime.HasValue ? responseTime.Value : (object)DBNull.Value, MySqlDbType.DateTime);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutResponseTimeAsync(DateTime? responseTime, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ResponseTime` = @ResponseTime";
			var parameter_ = Database.CreateInParameter("@ResponseTime", responseTime.HasValue ? responseTime.Value : (object)DBNull.Value, MySqlDbType.DateTime);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutResponseTime
		#region PutResponseStatus
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "orderID">供应商请求生成的订单编码 GUID</param>
		/// /// <param name = "responseStatus">返回状态</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutResponseStatusByPK(string orderID, string responseStatus, TransactionManager tm_ = null)
		{
			RepairPutResponseStatusByPKData(orderID, responseStatus, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutResponseStatusByPKAsync(string orderID, string responseStatus, TransactionManager tm_ = null)
		{
			RepairPutResponseStatusByPKData(orderID, responseStatus, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutResponseStatusByPKData(string orderID, string responseStatus, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `ResponseStatus` = @ResponseStatus  WHERE `OrderID` = @OrderID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ResponseStatus", responseStatus != null ? responseStatus : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "responseStatus">返回状态</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutResponseStatus(string responseStatus, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ResponseStatus` = @ResponseStatus";
			var parameter_ = Database.CreateInParameter("@ResponseStatus", responseStatus != null ? responseStatus : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutResponseStatusAsync(string responseStatus, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ResponseStatus` = @ResponseStatus";
			var parameter_ = Database.CreateInParameter("@ResponseStatus", responseStatus != null ? responseStatus : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutResponseStatus
		#region PutAmount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "orderID">供应商请求生成的订单编码 GUID</param>
		/// /// <param name = "amount">实际账户变化数量（正负数）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutAmountByPK(string orderID, long amount, TransactionManager tm_ = null)
		{
			RepairPutAmountByPKData(orderID, amount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAmountByPKAsync(string orderID, long amount, TransactionManager tm_ = null)
		{
			RepairPutAmountByPKData(orderID, amount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutAmountByPKData(string orderID, long amount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Amount` = @Amount  WHERE `OrderID` = @OrderID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Amount", amount, MySqlDbType.Int64),
				Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "amount">实际账户变化数量（正负数）</param>
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
		/// /// <param name = "orderID">供应商请求生成的订单编码 GUID</param>
		/// /// <param name = "endBalance">处理后余额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutEndBalanceByPK(string orderID, long endBalance, TransactionManager tm_ = null)
		{
			RepairPutEndBalanceByPKData(orderID, endBalance, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutEndBalanceByPKAsync(string orderID, long endBalance, TransactionManager tm_ = null)
		{
			RepairPutEndBalanceByPKData(orderID, endBalance, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutEndBalanceByPKData(string orderID, long endBalance, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `EndBalance` = @EndBalance  WHERE `OrderID` = @OrderID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@EndBalance", endBalance, MySqlDbType.Int64),
				Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
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
		#region PutBetBonus
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "orderID">供应商请求生成的订单编码 GUID</param>
		/// /// <param name = "betBonus">下注时扣除的bonus</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBetBonusByPK(string orderID, long betBonus, TransactionManager tm_ = null)
		{
			RepairPutBetBonusByPKData(orderID, betBonus, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutBetBonusByPKAsync(string orderID, long betBonus, TransactionManager tm_ = null)
		{
			RepairPutBetBonusByPKData(orderID, betBonus, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutBetBonusByPKData(string orderID, long betBonus, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `BetBonus` = @BetBonus  WHERE `OrderID` = @OrderID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetBonus", betBonus, MySqlDbType.Int64),
				Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "betBonus">下注时扣除的bonus</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBetBonus(long betBonus, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `BetBonus` = @BetBonus";
			var parameter_ = Database.CreateInParameter("@BetBonus", betBonus, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutBetBonusAsync(long betBonus, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `BetBonus` = @BetBonus";
			var parameter_ = Database.CreateInParameter("@BetBonus", betBonus, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutBetBonus
		#region PutWinBonus
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "orderID">供应商请求生成的订单编码 GUID</param>
		/// /// <param name = "winBonus">返奖时增加的bonus</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutWinBonusByPK(string orderID, long winBonus, TransactionManager tm_ = null)
		{
			RepairPutWinBonusByPKData(orderID, winBonus, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutWinBonusByPKAsync(string orderID, long winBonus, TransactionManager tm_ = null)
		{
			RepairPutWinBonusByPKData(orderID, winBonus, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutWinBonusByPKData(string orderID, long winBonus, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `WinBonus` = @WinBonus  WHERE `OrderID` = @OrderID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@WinBonus", winBonus, MySqlDbType.Int64),
				Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "winBonus">返奖时增加的bonus</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutWinBonus(long winBonus, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `WinBonus` = @WinBonus";
			var parameter_ = Database.CreateInParameter("@WinBonus", winBonus, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutWinBonusAsync(long winBonus, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `WinBonus` = @WinBonus";
			var parameter_ = Database.CreateInParameter("@WinBonus", winBonus, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutWinBonus
		#region PutEndBonus
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "orderID">供应商请求生成的订单编码 GUID</param>
		/// /// <param name = "endBonus">处理后bonus余额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutEndBonusByPK(string orderID, long endBonus, TransactionManager tm_ = null)
		{
			RepairPutEndBonusByPKData(orderID, endBonus, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutEndBonusByPKAsync(string orderID, long endBonus, TransactionManager tm_ = null)
		{
			RepairPutEndBonusByPKData(orderID, endBonus, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutEndBonusByPKData(string orderID, long endBonus, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `EndBonus` = @EndBonus  WHERE `OrderID` = @OrderID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@EndBonus", endBonus, MySqlDbType.Int64),
				Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
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
		#region PutAmountBonus
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "orderID">供应商请求生成的订单编码 GUID</param>
		/// /// <param name = "amountBonus">bonus实际变化数量（正负数）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutAmountBonusByPK(string orderID, long amountBonus, TransactionManager tm_ = null)
		{
			RepairPutAmountBonusByPKData(orderID, amountBonus, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAmountBonusByPKAsync(string orderID, long amountBonus, TransactionManager tm_ = null)
		{
			RepairPutAmountBonusByPKData(orderID, amountBonus, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutAmountBonusByPKData(string orderID, long amountBonus, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `AmountBonus` = @AmountBonus  WHERE `OrderID` = @OrderID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AmountBonus", amountBonus, MySqlDbType.Int64),
				Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
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
		#region PutSettlTable
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "orderID">供应商请求生成的订单编码 GUID</param>
		/// /// <param name = "settlTable">结算表名</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutSettlTableByPK(string orderID, string settlTable, TransactionManager tm_ = null)
		{
			RepairPutSettlTableByPKData(orderID, settlTable, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutSettlTableByPKAsync(string orderID, string settlTable, TransactionManager tm_ = null)
		{
			RepairPutSettlTableByPKData(orderID, settlTable, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutSettlTableByPKData(string orderID, string settlTable, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `SettlTable` = @SettlTable  WHERE `OrderID` = @OrderID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@SettlTable", settlTable != null ? settlTable : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
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
		/// /// <param name = "orderID">供应商请求生成的订单编码 GUID</param>
		/// /// <param name = "settlId">结算编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutSettlIdByPK(string orderID, string settlId, TransactionManager tm_ = null)
		{
			RepairPutSettlIdByPKData(orderID, settlId, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutSettlIdByPKAsync(string orderID, string settlId, TransactionManager tm_ = null)
		{
			RepairPutSettlIdByPKData(orderID, settlId, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutSettlIdByPKData(string orderID, string settlId, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `SettlId` = @SettlId  WHERE `OrderID` = @OrderID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@SettlId", settlId != null ? settlId : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
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
		/// /// <param name = "orderID">供应商请求生成的订单编码 GUID</param>
		/// /// <param name = "settlAmount">结算金额(正负数)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutSettlAmountByPK(string orderID, long settlAmount, TransactionManager tm_ = null)
		{
			RepairPutSettlAmountByPKData(orderID, settlAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutSettlAmountByPKAsync(string orderID, long settlAmount, TransactionManager tm_ = null)
		{
			RepairPutSettlAmountByPKData(orderID, settlAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutSettlAmountByPKData(string orderID, long settlAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `SettlAmount` = @SettlAmount  WHERE `OrderID` = @OrderID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@SettlAmount", settlAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
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
		#region PutSettlStatus
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "orderID">供应商请求生成的订单编码 GUID</param>
		/// /// <param name = "settlStatus">结算状态（0-未结算1-已结算）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutSettlStatusByPK(string orderID, int settlStatus, TransactionManager tm_ = null)
		{
			RepairPutSettlStatusByPKData(orderID, settlStatus, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutSettlStatusByPKAsync(string orderID, int settlStatus, TransactionManager tm_ = null)
		{
			RepairPutSettlStatusByPKData(orderID, settlStatus, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutSettlStatusByPKData(string orderID, int settlStatus, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `SettlStatus` = @SettlStatus  WHERE `OrderID` = @OrderID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@SettlStatus", settlStatus, MySqlDbType.Int32),
				Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
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
		#endregion // PutXXX
		#endregion // Put
	   
		#region Set
		
		/// <summary>
		/// 插入或者更新数据
		/// </summary>
		/// <param name = "item">要更新的实体对象</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>true:插入操作；false:更新操作</return>
		public bool Set(S_provider_orderEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.OrderID) == null)
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
		public async Task<bool> SetAsync(S_provider_orderEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.OrderID) == null)
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
		/// /// <param name = "orderID">供应商请求生成的订单编码 GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public S_provider_orderEO GetByPK(string orderID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(orderID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, S_provider_orderEO.MapDataReader);
		}
		public async Task<S_provider_orderEO> GetByPKAsync(string orderID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(orderID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, S_provider_orderEO.MapDataReader);
		}
		private void RepairGetByPKData(string orderID, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false, TransactionManager tm_ = null)
		{
			sql_ = BuildSelectSQL("`OrderID` = @OrderID", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
			};
		}
		#endregion // GetByPK
		
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 ProviderID（字段）
		/// </summary>
		/// /// <param name = "orderID">供应商请求生成的订单编码 GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetProviderIDByPK(string orderID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`ProviderID`", "`OrderID` = @OrderID", paras_, tm_);
		}
		public async Task<string> GetProviderIDByPKAsync(string orderID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`ProviderID`", "`OrderID` = @OrderID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 AppID（字段）
		/// </summary>
		/// /// <param name = "orderID">供应商请求生成的订单编码 GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetAppIDByPK(string orderID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`AppID`", "`OrderID` = @OrderID", paras_, tm_);
		}
		public async Task<string> GetAppIDByPKAsync(string orderID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`AppID`", "`OrderID` = @OrderID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 OperatorID（字段）
		/// </summary>
		/// /// <param name = "orderID">供应商请求生成的订单编码 GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetOperatorIDByPK(string orderID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`OperatorID`", "`OrderID` = @OrderID", paras_, tm_);
		}
		public async Task<string> GetOperatorIDByPKAsync(string orderID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`OperatorID`", "`OrderID` = @OrderID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 UserID（字段）
		/// </summary>
		/// /// <param name = "orderID">供应商请求生成的订单编码 GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetUserIDByPK(string orderID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`UserID`", "`OrderID` = @OrderID", paras_, tm_);
		}
		public async Task<string> GetUserIDByPKAsync(string orderID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`UserID`", "`OrderID` = @OrderID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 FromMode（字段）
		/// </summary>
		/// /// <param name = "orderID">供应商请求生成的订单编码 GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetFromModeByPK(string orderID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`FromMode`", "`OrderID` = @OrderID", paras_, tm_);
		}
		public async Task<int> GetFromModeByPKAsync(string orderID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`FromMode`", "`OrderID` = @OrderID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 FromId（字段）
		/// </summary>
		/// /// <param name = "orderID">供应商请求生成的订单编码 GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetFromIdByPK(string orderID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`FromId`", "`OrderID` = @OrderID", paras_, tm_);
		}
		public async Task<string> GetFromIdByPKAsync(string orderID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`FromId`", "`OrderID` = @OrderID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 UserKind（字段）
		/// </summary>
		/// /// <param name = "orderID">供应商请求生成的订单编码 GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetUserKindByPK(string orderID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`UserKind`", "`OrderID` = @OrderID", paras_, tm_);
		}
		public async Task<int> GetUserKindByPKAsync(string orderID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`UserKind`", "`OrderID` = @OrderID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 CountryID（字段）
		/// </summary>
		/// /// <param name = "orderID">供应商请求生成的订单编码 GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetCountryIDByPK(string orderID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`CountryID`", "`OrderID` = @OrderID", paras_, tm_);
		}
		public async Task<string> GetCountryIDByPKAsync(string orderID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`CountryID`", "`OrderID` = @OrderID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 CurrencyID（字段）
		/// </summary>
		/// /// <param name = "orderID">供应商请求生成的订单编码 GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetCurrencyIDByPK(string orderID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`CurrencyID`", "`OrderID` = @OrderID", paras_, tm_);
		}
		public async Task<string> GetCurrencyIDByPKAsync(string orderID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`CurrencyID`", "`OrderID` = @OrderID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 CurrencyType（字段）
		/// </summary>
		/// /// <param name = "orderID">供应商请求生成的订单编码 GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetCurrencyTypeByPK(string orderID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`CurrencyType`", "`OrderID` = @OrderID", paras_, tm_);
		}
		public async Task<int> GetCurrencyTypeByPKAsync(string orderID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`CurrencyType`", "`OrderID` = @OrderID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 PromoterType（字段）
		/// </summary>
		/// /// <param name = "orderID">供应商请求生成的订单编码 GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetPromoterTypeByPK(string orderID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`PromoterType`", "`OrderID` = @OrderID", paras_, tm_);
		}
		public async Task<int> GetPromoterTypeByPKAsync(string orderID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`PromoterType`", "`OrderID` = @OrderID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 ReqMark（字段）
		/// </summary>
		/// /// <param name = "orderID">供应商请求生成的订单编码 GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetReqMarkByPK(string orderID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`ReqMark`", "`OrderID` = @OrderID", paras_, tm_);
		}
		public async Task<int> GetReqMarkByPKAsync(string orderID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`ReqMark`", "`OrderID` = @OrderID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 RequestUUID（字段）
		/// </summary>
		/// /// <param name = "orderID">供应商请求生成的订单编码 GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetRequestUUIDByPK(string orderID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`RequestUUID`", "`OrderID` = @OrderID", paras_, tm_);
		}
		public async Task<string> GetRequestUUIDByPKAsync(string orderID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`RequestUUID`", "`OrderID` = @OrderID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 ProviderOrderId（字段）
		/// </summary>
		/// /// <param name = "orderID">供应商请求生成的订单编码 GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetProviderOrderIdByPK(string orderID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`ProviderOrderId`", "`OrderID` = @OrderID", paras_, tm_);
		}
		public async Task<string> GetProviderOrderIdByPKAsync(string orderID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`ProviderOrderId`", "`OrderID` = @OrderID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 ReferProviderOrderId（字段）
		/// </summary>
		/// /// <param name = "orderID">供应商请求生成的订单编码 GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetReferProviderOrderIdByPK(string orderID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`ReferProviderOrderId`", "`OrderID` = @OrderID", paras_, tm_);
		}
		public async Task<string> GetReferProviderOrderIdByPKAsync(string orderID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`ReferProviderOrderId`", "`OrderID` = @OrderID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 RoundClosed（字段）
		/// </summary>
		/// /// <param name = "orderID">供应商请求生成的订单编码 GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public bool GetRoundClosedByPK(string orderID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
			};
			return (bool)GetScalar("`RoundClosed`", "`OrderID` = @OrderID", paras_, tm_);
		}
		public async Task<bool> GetRoundClosedByPKAsync(string orderID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
			};
			return (bool)await GetScalarAsync("`RoundClosed`", "`OrderID` = @OrderID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 RoundId（字段）
		/// </summary>
		/// /// <param name = "orderID">供应商请求生成的订单编码 GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetRoundIdByPK(string orderID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`RoundId`", "`OrderID` = @OrderID", paras_, tm_);
		}
		public async Task<string> GetRoundIdByPKAsync(string orderID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`RoundId`", "`OrderID` = @OrderID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 RewardUUID（字段）
		/// </summary>
		/// /// <param name = "orderID">供应商请求生成的订单编码 GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetRewardUUIDByPK(string orderID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`RewardUUID`", "`OrderID` = @OrderID", paras_, tm_);
		}
		public async Task<string> GetRewardUUIDByPKAsync(string orderID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`RewardUUID`", "`OrderID` = @OrderID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 IsFree（字段）
		/// </summary>
		/// /// <param name = "orderID">供应商请求生成的订单编码 GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public bool GetIsFreeByPK(string orderID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
			};
			return (bool)GetScalar("`IsFree`", "`OrderID` = @OrderID", paras_, tm_);
		}
		public async Task<bool> GetIsFreeByPKAsync(string orderID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
			};
			return (bool)await GetScalarAsync("`IsFree`", "`OrderID` = @OrderID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 PlanBet（字段）
		/// </summary>
		/// /// <param name = "orderID">供应商请求生成的订单编码 GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetPlanBetByPK(string orderID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`PlanBet`", "`OrderID` = @OrderID", paras_, tm_);
		}
		public async Task<long> GetPlanBetByPKAsync(string orderID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`PlanBet`", "`OrderID` = @OrderID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 PlanWin（字段）
		/// </summary>
		/// /// <param name = "orderID">供应商请求生成的订单编码 GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetPlanWinByPK(string orderID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`PlanWin`", "`OrderID` = @OrderID", paras_, tm_);
		}
		public async Task<long> GetPlanWinByPKAsync(string orderID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`PlanWin`", "`OrderID` = @OrderID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 PlanAmount（字段）
		/// </summary>
		/// /// <param name = "orderID">供应商请求生成的订单编码 GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetPlanAmountByPK(string orderID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`PlanAmount`", "`OrderID` = @OrderID", paras_, tm_);
		}
		public async Task<long> GetPlanAmountByPKAsync(string orderID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`PlanAmount`", "`OrderID` = @OrderID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Meta（字段）
		/// </summary>
		/// /// <param name = "orderID">供应商请求生成的订单编码 GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetMetaByPK(string orderID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`Meta`", "`OrderID` = @OrderID", paras_, tm_);
		}
		public async Task<string> GetMetaByPKAsync(string orderID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`Meta`", "`OrderID` = @OrderID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 UserIp（字段）
		/// </summary>
		/// /// <param name = "orderID">供应商请求生成的订单编码 GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetUserIpByPK(string orderID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`UserIp`", "`OrderID` = @OrderID", paras_, tm_);
		}
		public async Task<string> GetUserIpByPKAsync(string orderID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`UserIp`", "`OrderID` = @OrderID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Status（字段）
		/// </summary>
		/// /// <param name = "orderID">供应商请求生成的订单编码 GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetStatusByPK(string orderID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`Status`", "`OrderID` = @OrderID", paras_, tm_);
		}
		public async Task<int> GetStatusByPKAsync(string orderID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`Status`", "`OrderID` = @OrderID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 RecDate（字段）
		/// </summary>
		/// /// <param name = "orderID">供应商请求生成的订单编码 GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime GetRecDateByPK(string orderID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
			};
			return (DateTime)GetScalar("`RecDate`", "`OrderID` = @OrderID", paras_, tm_);
		}
		public async Task<DateTime> GetRecDateByPKAsync(string orderID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
			};
			return (DateTime)await GetScalarAsync("`RecDate`", "`OrderID` = @OrderID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 ResponseTime（字段）
		/// </summary>
		/// /// <param name = "orderID">供应商请求生成的订单编码 GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime? GetResponseTimeByPK(string orderID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
			};
			return (DateTime?)GetScalar("`ResponseTime`", "`OrderID` = @OrderID", paras_, tm_);
		}
		public async Task<DateTime?> GetResponseTimeByPKAsync(string orderID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
			};
			return (DateTime?)await GetScalarAsync("`ResponseTime`", "`OrderID` = @OrderID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 ResponseStatus（字段）
		/// </summary>
		/// /// <param name = "orderID">供应商请求生成的订单编码 GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetResponseStatusByPK(string orderID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`ResponseStatus`", "`OrderID` = @OrderID", paras_, tm_);
		}
		public async Task<string> GetResponseStatusByPKAsync(string orderID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`ResponseStatus`", "`OrderID` = @OrderID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Amount（字段）
		/// </summary>
		/// /// <param name = "orderID">供应商请求生成的订单编码 GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetAmountByPK(string orderID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`Amount`", "`OrderID` = @OrderID", paras_, tm_);
		}
		public async Task<long> GetAmountByPKAsync(string orderID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`Amount`", "`OrderID` = @OrderID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 EndBalance（字段）
		/// </summary>
		/// /// <param name = "orderID">供应商请求生成的订单编码 GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetEndBalanceByPK(string orderID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`EndBalance`", "`OrderID` = @OrderID", paras_, tm_);
		}
		public async Task<long> GetEndBalanceByPKAsync(string orderID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`EndBalance`", "`OrderID` = @OrderID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 BetBonus（字段）
		/// </summary>
		/// /// <param name = "orderID">供应商请求生成的订单编码 GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetBetBonusByPK(string orderID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`BetBonus`", "`OrderID` = @OrderID", paras_, tm_);
		}
		public async Task<long> GetBetBonusByPKAsync(string orderID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`BetBonus`", "`OrderID` = @OrderID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 WinBonus（字段）
		/// </summary>
		/// /// <param name = "orderID">供应商请求生成的订单编码 GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetWinBonusByPK(string orderID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`WinBonus`", "`OrderID` = @OrderID", paras_, tm_);
		}
		public async Task<long> GetWinBonusByPKAsync(string orderID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`WinBonus`", "`OrderID` = @OrderID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 EndBonus（字段）
		/// </summary>
		/// /// <param name = "orderID">供应商请求生成的订单编码 GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetEndBonusByPK(string orderID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`EndBonus`", "`OrderID` = @OrderID", paras_, tm_);
		}
		public async Task<long> GetEndBonusByPKAsync(string orderID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`EndBonus`", "`OrderID` = @OrderID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 AmountBonus（字段）
		/// </summary>
		/// /// <param name = "orderID">供应商请求生成的订单编码 GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetAmountBonusByPK(string orderID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`AmountBonus`", "`OrderID` = @OrderID", paras_, tm_);
		}
		public async Task<long> GetAmountBonusByPKAsync(string orderID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`AmountBonus`", "`OrderID` = @OrderID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 SettlTable（字段）
		/// </summary>
		/// /// <param name = "orderID">供应商请求生成的订单编码 GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetSettlTableByPK(string orderID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`SettlTable`", "`OrderID` = @OrderID", paras_, tm_);
		}
		public async Task<string> GetSettlTableByPKAsync(string orderID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`SettlTable`", "`OrderID` = @OrderID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 SettlId（字段）
		/// </summary>
		/// /// <param name = "orderID">供应商请求生成的订单编码 GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetSettlIdByPK(string orderID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`SettlId`", "`OrderID` = @OrderID", paras_, tm_);
		}
		public async Task<string> GetSettlIdByPKAsync(string orderID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`SettlId`", "`OrderID` = @OrderID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 SettlAmount（字段）
		/// </summary>
		/// /// <param name = "orderID">供应商请求生成的订单编码 GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetSettlAmountByPK(string orderID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`SettlAmount`", "`OrderID` = @OrderID", paras_, tm_);
		}
		public async Task<long> GetSettlAmountByPKAsync(string orderID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`SettlAmount`", "`OrderID` = @OrderID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 SettlStatus（字段）
		/// </summary>
		/// /// <param name = "orderID">供应商请求生成的订单编码 GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetSettlStatusByPK(string orderID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`SettlStatus`", "`OrderID` = @OrderID", paras_, tm_);
		}
		public async Task<int> GetSettlStatusByPKAsync(string orderID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`SettlStatus`", "`OrderID` = @OrderID", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByProviderID
		
		/// <summary>
		/// 按 ProviderID（字段） 查询
		/// </summary>
		/// /// <param name = "providerID">应用提供商编码</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByProviderID(string providerID)
		{
			return GetByProviderID(providerID, 0, string.Empty, null);
		}
		public async Task<List<S_provider_orderEO>> GetByProviderIDAsync(string providerID)
		{
			return await GetByProviderIDAsync(providerID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ProviderID（字段） 查询
		/// </summary>
		/// /// <param name = "providerID">应用提供商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByProviderID(string providerID, TransactionManager tm_)
		{
			return GetByProviderID(providerID, 0, string.Empty, tm_);
		}
		public async Task<List<S_provider_orderEO>> GetByProviderIDAsync(string providerID, TransactionManager tm_)
		{
			return await GetByProviderIDAsync(providerID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ProviderID（字段） 查询
		/// </summary>
		/// /// <param name = "providerID">应用提供商编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByProviderID(string providerID, int top_)
		{
			return GetByProviderID(providerID, top_, string.Empty, null);
		}
		public async Task<List<S_provider_orderEO>> GetByProviderIDAsync(string providerID, int top_)
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
		public List<S_provider_orderEO> GetByProviderID(string providerID, int top_, TransactionManager tm_)
		{
			return GetByProviderID(providerID, top_, string.Empty, tm_);
		}
		public async Task<List<S_provider_orderEO>> GetByProviderIDAsync(string providerID, int top_, TransactionManager tm_)
		{
			return await GetByProviderIDAsync(providerID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ProviderID（字段） 查询
		/// </summary>
		/// /// <param name = "providerID">应用提供商编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByProviderID(string providerID, string sort_)
		{
			return GetByProviderID(providerID, 0, sort_, null);
		}
		public async Task<List<S_provider_orderEO>> GetByProviderIDAsync(string providerID, string sort_)
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
		public List<S_provider_orderEO> GetByProviderID(string providerID, string sort_, TransactionManager tm_)
		{
			return GetByProviderID(providerID, 0, sort_, tm_);
		}
		public async Task<List<S_provider_orderEO>> GetByProviderIDAsync(string providerID, string sort_, TransactionManager tm_)
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
		public List<S_provider_orderEO> GetByProviderID(string providerID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(providerID != null ? "`ProviderID` = @ProviderID" : "`ProviderID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (providerID != null)
				paras_.Add(Database.CreateInParameter("@ProviderID", providerID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_provider_orderEO.MapDataReader);
		}
		public async Task<List<S_provider_orderEO>> GetByProviderIDAsync(string providerID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(providerID != null ? "`ProviderID` = @ProviderID" : "`ProviderID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (providerID != null)
				paras_.Add(Database.CreateInParameter("@ProviderID", providerID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_provider_orderEO.MapDataReader);
		}
		#endregion // GetByProviderID
		#region GetByAppID
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByAppID(string appID)
		{
			return GetByAppID(appID, 0, string.Empty, null);
		}
		public async Task<List<S_provider_orderEO>> GetByAppIDAsync(string appID)
		{
			return await GetByAppIDAsync(appID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByAppID(string appID, TransactionManager tm_)
		{
			return GetByAppID(appID, 0, string.Empty, tm_);
		}
		public async Task<List<S_provider_orderEO>> GetByAppIDAsync(string appID, TransactionManager tm_)
		{
			return await GetByAppIDAsync(appID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByAppID(string appID, int top_)
		{
			return GetByAppID(appID, top_, string.Empty, null);
		}
		public async Task<List<S_provider_orderEO>> GetByAppIDAsync(string appID, int top_)
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
		public List<S_provider_orderEO> GetByAppID(string appID, int top_, TransactionManager tm_)
		{
			return GetByAppID(appID, top_, string.Empty, tm_);
		}
		public async Task<List<S_provider_orderEO>> GetByAppIDAsync(string appID, int top_, TransactionManager tm_)
		{
			return await GetByAppIDAsync(appID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByAppID(string appID, string sort_)
		{
			return GetByAppID(appID, 0, sort_, null);
		}
		public async Task<List<S_provider_orderEO>> GetByAppIDAsync(string appID, string sort_)
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
		public List<S_provider_orderEO> GetByAppID(string appID, string sort_, TransactionManager tm_)
		{
			return GetByAppID(appID, 0, sort_, tm_);
		}
		public async Task<List<S_provider_orderEO>> GetByAppIDAsync(string appID, string sort_, TransactionManager tm_)
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
		public List<S_provider_orderEO> GetByAppID(string appID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(appID != null ? "`AppID` = @AppID" : "`AppID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (appID != null)
				paras_.Add(Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_provider_orderEO.MapDataReader);
		}
		public async Task<List<S_provider_orderEO>> GetByAppIDAsync(string appID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(appID != null ? "`AppID` = @AppID" : "`AppID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (appID != null)
				paras_.Add(Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_provider_orderEO.MapDataReader);
		}
		#endregion // GetByAppID
		#region GetByOperatorID
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByOperatorID(string operatorID)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, null);
		}
		public async Task<List<S_provider_orderEO>> GetByOperatorIDAsync(string operatorID)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByOperatorID(string operatorID, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, tm_);
		}
		public async Task<List<S_provider_orderEO>> GetByOperatorIDAsync(string operatorID, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByOperatorID(string operatorID, int top_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, null);
		}
		public async Task<List<S_provider_orderEO>> GetByOperatorIDAsync(string operatorID, int top_)
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
		public List<S_provider_orderEO> GetByOperatorID(string operatorID, int top_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, tm_);
		}
		public async Task<List<S_provider_orderEO>> GetByOperatorIDAsync(string operatorID, int top_, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByOperatorID(string operatorID, string sort_)
		{
			return GetByOperatorID(operatorID, 0, sort_, null);
		}
		public async Task<List<S_provider_orderEO>> GetByOperatorIDAsync(string operatorID, string sort_)
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
		public List<S_provider_orderEO> GetByOperatorID(string operatorID, string sort_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, sort_, tm_);
		}
		public async Task<List<S_provider_orderEO>> GetByOperatorIDAsync(string operatorID, string sort_, TransactionManager tm_)
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
		public List<S_provider_orderEO> GetByOperatorID(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(operatorID != null ? "`OperatorID` = @OperatorID" : "`OperatorID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (operatorID != null)
				paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_provider_orderEO.MapDataReader);
		}
		public async Task<List<S_provider_orderEO>> GetByOperatorIDAsync(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(operatorID != null ? "`OperatorID` = @OperatorID" : "`OperatorID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (operatorID != null)
				paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_provider_orderEO.MapDataReader);
		}
		#endregion // GetByOperatorID
		#region GetByUserID
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByUserID(string userID)
		{
			return GetByUserID(userID, 0, string.Empty, null);
		}
		public async Task<List<S_provider_orderEO>> GetByUserIDAsync(string userID)
		{
			return await GetByUserIDAsync(userID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByUserID(string userID, TransactionManager tm_)
		{
			return GetByUserID(userID, 0, string.Empty, tm_);
		}
		public async Task<List<S_provider_orderEO>> GetByUserIDAsync(string userID, TransactionManager tm_)
		{
			return await GetByUserIDAsync(userID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByUserID(string userID, int top_)
		{
			return GetByUserID(userID, top_, string.Empty, null);
		}
		public async Task<List<S_provider_orderEO>> GetByUserIDAsync(string userID, int top_)
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
		public List<S_provider_orderEO> GetByUserID(string userID, int top_, TransactionManager tm_)
		{
			return GetByUserID(userID, top_, string.Empty, tm_);
		}
		public async Task<List<S_provider_orderEO>> GetByUserIDAsync(string userID, int top_, TransactionManager tm_)
		{
			return await GetByUserIDAsync(userID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByUserID(string userID, string sort_)
		{
			return GetByUserID(userID, 0, sort_, null);
		}
		public async Task<List<S_provider_orderEO>> GetByUserIDAsync(string userID, string sort_)
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
		public List<S_provider_orderEO> GetByUserID(string userID, string sort_, TransactionManager tm_)
		{
			return GetByUserID(userID, 0, sort_, tm_);
		}
		public async Task<List<S_provider_orderEO>> GetByUserIDAsync(string userID, string sort_, TransactionManager tm_)
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
		public List<S_provider_orderEO> GetByUserID(string userID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(userID != null ? "`UserID` = @UserID" : "`UserID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (userID != null)
				paras_.Add(Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_provider_orderEO.MapDataReader);
		}
		public async Task<List<S_provider_orderEO>> GetByUserIDAsync(string userID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(userID != null ? "`UserID` = @UserID" : "`UserID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (userID != null)
				paras_.Add(Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_provider_orderEO.MapDataReader);
		}
		#endregion // GetByUserID
		#region GetByFromMode
		
		/// <summary>
		/// 按 FromMode（字段） 查询
		/// </summary>
		/// /// <param name = "fromMode">新用户来源方式</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByFromMode(int fromMode)
		{
			return GetByFromMode(fromMode, 0, string.Empty, null);
		}
		public async Task<List<S_provider_orderEO>> GetByFromModeAsync(int fromMode)
		{
			return await GetByFromModeAsync(fromMode, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 FromMode（字段） 查询
		/// </summary>
		/// /// <param name = "fromMode">新用户来源方式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByFromMode(int fromMode, TransactionManager tm_)
		{
			return GetByFromMode(fromMode, 0, string.Empty, tm_);
		}
		public async Task<List<S_provider_orderEO>> GetByFromModeAsync(int fromMode, TransactionManager tm_)
		{
			return await GetByFromModeAsync(fromMode, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FromMode（字段） 查询
		/// </summary>
		/// /// <param name = "fromMode">新用户来源方式</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByFromMode(int fromMode, int top_)
		{
			return GetByFromMode(fromMode, top_, string.Empty, null);
		}
		public async Task<List<S_provider_orderEO>> GetByFromModeAsync(int fromMode, int top_)
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
		public List<S_provider_orderEO> GetByFromMode(int fromMode, int top_, TransactionManager tm_)
		{
			return GetByFromMode(fromMode, top_, string.Empty, tm_);
		}
		public async Task<List<S_provider_orderEO>> GetByFromModeAsync(int fromMode, int top_, TransactionManager tm_)
		{
			return await GetByFromModeAsync(fromMode, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FromMode（字段） 查询
		/// </summary>
		/// /// <param name = "fromMode">新用户来源方式</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByFromMode(int fromMode, string sort_)
		{
			return GetByFromMode(fromMode, 0, sort_, null);
		}
		public async Task<List<S_provider_orderEO>> GetByFromModeAsync(int fromMode, string sort_)
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
		public List<S_provider_orderEO> GetByFromMode(int fromMode, string sort_, TransactionManager tm_)
		{
			return GetByFromMode(fromMode, 0, sort_, tm_);
		}
		public async Task<List<S_provider_orderEO>> GetByFromModeAsync(int fromMode, string sort_, TransactionManager tm_)
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
		public List<S_provider_orderEO> GetByFromMode(int fromMode, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`FromMode` = @FromMode", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FromMode", fromMode, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, S_provider_orderEO.MapDataReader);
		}
		public async Task<List<S_provider_orderEO>> GetByFromModeAsync(int fromMode, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`FromMode` = @FromMode", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FromMode", fromMode, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_provider_orderEO.MapDataReader);
		}
		#endregion // GetByFromMode
		#region GetByFromId
		
		/// <summary>
		/// 按 FromId（字段） 查询
		/// </summary>
		/// /// <param name = "fromId">对应的编码（根据FromMode变化）</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByFromId(string fromId)
		{
			return GetByFromId(fromId, 0, string.Empty, null);
		}
		public async Task<List<S_provider_orderEO>> GetByFromIdAsync(string fromId)
		{
			return await GetByFromIdAsync(fromId, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 FromId（字段） 查询
		/// </summary>
		/// /// <param name = "fromId">对应的编码（根据FromMode变化）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByFromId(string fromId, TransactionManager tm_)
		{
			return GetByFromId(fromId, 0, string.Empty, tm_);
		}
		public async Task<List<S_provider_orderEO>> GetByFromIdAsync(string fromId, TransactionManager tm_)
		{
			return await GetByFromIdAsync(fromId, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FromId（字段） 查询
		/// </summary>
		/// /// <param name = "fromId">对应的编码（根据FromMode变化）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByFromId(string fromId, int top_)
		{
			return GetByFromId(fromId, top_, string.Empty, null);
		}
		public async Task<List<S_provider_orderEO>> GetByFromIdAsync(string fromId, int top_)
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
		public List<S_provider_orderEO> GetByFromId(string fromId, int top_, TransactionManager tm_)
		{
			return GetByFromId(fromId, top_, string.Empty, tm_);
		}
		public async Task<List<S_provider_orderEO>> GetByFromIdAsync(string fromId, int top_, TransactionManager tm_)
		{
			return await GetByFromIdAsync(fromId, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FromId（字段） 查询
		/// </summary>
		/// /// <param name = "fromId">对应的编码（根据FromMode变化）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByFromId(string fromId, string sort_)
		{
			return GetByFromId(fromId, 0, sort_, null);
		}
		public async Task<List<S_provider_orderEO>> GetByFromIdAsync(string fromId, string sort_)
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
		public List<S_provider_orderEO> GetByFromId(string fromId, string sort_, TransactionManager tm_)
		{
			return GetByFromId(fromId, 0, sort_, tm_);
		}
		public async Task<List<S_provider_orderEO>> GetByFromIdAsync(string fromId, string sort_, TransactionManager tm_)
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
		public List<S_provider_orderEO> GetByFromId(string fromId, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(fromId != null ? "`FromId` = @FromId" : "`FromId` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (fromId != null)
				paras_.Add(Database.CreateInParameter("@FromId", fromId, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_provider_orderEO.MapDataReader);
		}
		public async Task<List<S_provider_orderEO>> GetByFromIdAsync(string fromId, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(fromId != null ? "`FromId` = @FromId" : "`FromId` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (fromId != null)
				paras_.Add(Database.CreateInParameter("@FromId", fromId, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_provider_orderEO.MapDataReader);
		}
		#endregion // GetByFromId
		#region GetByUserKind
		
		/// <summary>
		/// 按 UserKind（字段） 查询
		/// </summary>
		/// /// <param name = "userKind">用户类型</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByUserKind(int userKind)
		{
			return GetByUserKind(userKind, 0, string.Empty, null);
		}
		public async Task<List<S_provider_orderEO>> GetByUserKindAsync(int userKind)
		{
			return await GetByUserKindAsync(userKind, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UserKind（字段） 查询
		/// </summary>
		/// /// <param name = "userKind">用户类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByUserKind(int userKind, TransactionManager tm_)
		{
			return GetByUserKind(userKind, 0, string.Empty, tm_);
		}
		public async Task<List<S_provider_orderEO>> GetByUserKindAsync(int userKind, TransactionManager tm_)
		{
			return await GetByUserKindAsync(userKind, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserKind（字段） 查询
		/// </summary>
		/// /// <param name = "userKind">用户类型</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByUserKind(int userKind, int top_)
		{
			return GetByUserKind(userKind, top_, string.Empty, null);
		}
		public async Task<List<S_provider_orderEO>> GetByUserKindAsync(int userKind, int top_)
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
		public List<S_provider_orderEO> GetByUserKind(int userKind, int top_, TransactionManager tm_)
		{
			return GetByUserKind(userKind, top_, string.Empty, tm_);
		}
		public async Task<List<S_provider_orderEO>> GetByUserKindAsync(int userKind, int top_, TransactionManager tm_)
		{
			return await GetByUserKindAsync(userKind, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserKind（字段） 查询
		/// </summary>
		/// /// <param name = "userKind">用户类型</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByUserKind(int userKind, string sort_)
		{
			return GetByUserKind(userKind, 0, sort_, null);
		}
		public async Task<List<S_provider_orderEO>> GetByUserKindAsync(int userKind, string sort_)
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
		public List<S_provider_orderEO> GetByUserKind(int userKind, string sort_, TransactionManager tm_)
		{
			return GetByUserKind(userKind, 0, sort_, tm_);
		}
		public async Task<List<S_provider_orderEO>> GetByUserKindAsync(int userKind, string sort_, TransactionManager tm_)
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
		public List<S_provider_orderEO> GetByUserKind(int userKind, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UserKind` = @UserKind", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserKind", userKind, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, S_provider_orderEO.MapDataReader);
		}
		public async Task<List<S_provider_orderEO>> GetByUserKindAsync(int userKind, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UserKind` = @UserKind", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserKind", userKind, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_provider_orderEO.MapDataReader);
		}
		#endregion // GetByUserKind
		#region GetByCountryID
		
		/// <summary>
		/// 按 CountryID（字段） 查询
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByCountryID(string countryID)
		{
			return GetByCountryID(countryID, 0, string.Empty, null);
		}
		public async Task<List<S_provider_orderEO>> GetByCountryIDAsync(string countryID)
		{
			return await GetByCountryIDAsync(countryID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CountryID（字段） 查询
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByCountryID(string countryID, TransactionManager tm_)
		{
			return GetByCountryID(countryID, 0, string.Empty, tm_);
		}
		public async Task<List<S_provider_orderEO>> GetByCountryIDAsync(string countryID, TransactionManager tm_)
		{
			return await GetByCountryIDAsync(countryID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CountryID（字段） 查询
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByCountryID(string countryID, int top_)
		{
			return GetByCountryID(countryID, top_, string.Empty, null);
		}
		public async Task<List<S_provider_orderEO>> GetByCountryIDAsync(string countryID, int top_)
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
		public List<S_provider_orderEO> GetByCountryID(string countryID, int top_, TransactionManager tm_)
		{
			return GetByCountryID(countryID, top_, string.Empty, tm_);
		}
		public async Task<List<S_provider_orderEO>> GetByCountryIDAsync(string countryID, int top_, TransactionManager tm_)
		{
			return await GetByCountryIDAsync(countryID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CountryID（字段） 查询
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByCountryID(string countryID, string sort_)
		{
			return GetByCountryID(countryID, 0, sort_, null);
		}
		public async Task<List<S_provider_orderEO>> GetByCountryIDAsync(string countryID, string sort_)
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
		public List<S_provider_orderEO> GetByCountryID(string countryID, string sort_, TransactionManager tm_)
		{
			return GetByCountryID(countryID, 0, sort_, tm_);
		}
		public async Task<List<S_provider_orderEO>> GetByCountryIDAsync(string countryID, string sort_, TransactionManager tm_)
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
		public List<S_provider_orderEO> GetByCountryID(string countryID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(countryID != null ? "`CountryID` = @CountryID" : "`CountryID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (countryID != null)
				paras_.Add(Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_provider_orderEO.MapDataReader);
		}
		public async Task<List<S_provider_orderEO>> GetByCountryIDAsync(string countryID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(countryID != null ? "`CountryID` = @CountryID" : "`CountryID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (countryID != null)
				paras_.Add(Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_provider_orderEO.MapDataReader);
		}
		#endregion // GetByCountryID
		#region GetByCurrencyID
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型（货币缩写RMB,USD）</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByCurrencyID(string currencyID)
		{
			return GetByCurrencyID(currencyID, 0, string.Empty, null);
		}
		public async Task<List<S_provider_orderEO>> GetByCurrencyIDAsync(string currencyID)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型（货币缩写RMB,USD）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByCurrencyID(string currencyID, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, 0, string.Empty, tm_);
		}
		public async Task<List<S_provider_orderEO>> GetByCurrencyIDAsync(string currencyID, TransactionManager tm_)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型（货币缩写RMB,USD）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByCurrencyID(string currencyID, int top_)
		{
			return GetByCurrencyID(currencyID, top_, string.Empty, null);
		}
		public async Task<List<S_provider_orderEO>> GetByCurrencyIDAsync(string currencyID, int top_)
		{
			return await GetByCurrencyIDAsync(currencyID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型（货币缩写RMB,USD）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByCurrencyID(string currencyID, int top_, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, top_, string.Empty, tm_);
		}
		public async Task<List<S_provider_orderEO>> GetByCurrencyIDAsync(string currencyID, int top_, TransactionManager tm_)
		{
			return await GetByCurrencyIDAsync(currencyID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型（货币缩写RMB,USD）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByCurrencyID(string currencyID, string sort_)
		{
			return GetByCurrencyID(currencyID, 0, sort_, null);
		}
		public async Task<List<S_provider_orderEO>> GetByCurrencyIDAsync(string currencyID, string sort_)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型（货币缩写RMB,USD）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByCurrencyID(string currencyID, string sort_, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, 0, sort_, tm_);
		}
		public async Task<List<S_provider_orderEO>> GetByCurrencyIDAsync(string currencyID, string sort_, TransactionManager tm_)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型（货币缩写RMB,USD）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByCurrencyID(string currencyID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(currencyID != null ? "`CurrencyID` = @CurrencyID" : "`CurrencyID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (currencyID != null)
				paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_provider_orderEO.MapDataReader);
		}
		public async Task<List<S_provider_orderEO>> GetByCurrencyIDAsync(string currencyID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(currencyID != null ? "`CurrencyID` = @CurrencyID" : "`CurrencyID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (currencyID != null)
				paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_provider_orderEO.MapDataReader);
		}
		#endregion // GetByCurrencyID
		#region GetByCurrencyType
		
		/// <summary>
		/// 按 CurrencyType（字段） 查询
		/// </summary>
		/// /// <param name = "currencyType">货币类型 1-COIN 2--GOLD 3-POINT 4-SWB 8-虚拟货币 9-CASH</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByCurrencyType(int currencyType)
		{
			return GetByCurrencyType(currencyType, 0, string.Empty, null);
		}
		public async Task<List<S_provider_orderEO>> GetByCurrencyTypeAsync(int currencyType)
		{
			return await GetByCurrencyTypeAsync(currencyType, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CurrencyType（字段） 查询
		/// </summary>
		/// /// <param name = "currencyType">货币类型 1-COIN 2--GOLD 3-POINT 4-SWB 8-虚拟货币 9-CASH</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByCurrencyType(int currencyType, TransactionManager tm_)
		{
			return GetByCurrencyType(currencyType, 0, string.Empty, tm_);
		}
		public async Task<List<S_provider_orderEO>> GetByCurrencyTypeAsync(int currencyType, TransactionManager tm_)
		{
			return await GetByCurrencyTypeAsync(currencyType, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyType（字段） 查询
		/// </summary>
		/// /// <param name = "currencyType">货币类型 1-COIN 2--GOLD 3-POINT 4-SWB 8-虚拟货币 9-CASH</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByCurrencyType(int currencyType, int top_)
		{
			return GetByCurrencyType(currencyType, top_, string.Empty, null);
		}
		public async Task<List<S_provider_orderEO>> GetByCurrencyTypeAsync(int currencyType, int top_)
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
		public List<S_provider_orderEO> GetByCurrencyType(int currencyType, int top_, TransactionManager tm_)
		{
			return GetByCurrencyType(currencyType, top_, string.Empty, tm_);
		}
		public async Task<List<S_provider_orderEO>> GetByCurrencyTypeAsync(int currencyType, int top_, TransactionManager tm_)
		{
			return await GetByCurrencyTypeAsync(currencyType, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyType（字段） 查询
		/// </summary>
		/// /// <param name = "currencyType">货币类型 1-COIN 2--GOLD 3-POINT 4-SWB 8-虚拟货币 9-CASH</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByCurrencyType(int currencyType, string sort_)
		{
			return GetByCurrencyType(currencyType, 0, sort_, null);
		}
		public async Task<List<S_provider_orderEO>> GetByCurrencyTypeAsync(int currencyType, string sort_)
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
		public List<S_provider_orderEO> GetByCurrencyType(int currencyType, string sort_, TransactionManager tm_)
		{
			return GetByCurrencyType(currencyType, 0, sort_, tm_);
		}
		public async Task<List<S_provider_orderEO>> GetByCurrencyTypeAsync(int currencyType, string sort_, TransactionManager tm_)
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
		public List<S_provider_orderEO> GetByCurrencyType(int currencyType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CurrencyType` = @CurrencyType", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CurrencyType", currencyType, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, S_provider_orderEO.MapDataReader);
		}
		public async Task<List<S_provider_orderEO>> GetByCurrencyTypeAsync(int currencyType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CurrencyType` = @CurrencyType", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CurrencyType", currencyType, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_provider_orderEO.MapDataReader);
		}
		#endregion // GetByCurrencyType
		#region GetByPromoterType
		
		/// <summary>
		/// 按 PromoterType（字段） 查询
		/// </summary>
		/// /// <param name = "promoterType">推广类型1-棋牌2-电子3-捕鱼4-真人5-彩票6-体育</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByPromoterType(int promoterType)
		{
			return GetByPromoterType(promoterType, 0, string.Empty, null);
		}
		public async Task<List<S_provider_orderEO>> GetByPromoterTypeAsync(int promoterType)
		{
			return await GetByPromoterTypeAsync(promoterType, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PromoterType（字段） 查询
		/// </summary>
		/// /// <param name = "promoterType">推广类型1-棋牌2-电子3-捕鱼4-真人5-彩票6-体育</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByPromoterType(int promoterType, TransactionManager tm_)
		{
			return GetByPromoterType(promoterType, 0, string.Empty, tm_);
		}
		public async Task<List<S_provider_orderEO>> GetByPromoterTypeAsync(int promoterType, TransactionManager tm_)
		{
			return await GetByPromoterTypeAsync(promoterType, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PromoterType（字段） 查询
		/// </summary>
		/// /// <param name = "promoterType">推广类型1-棋牌2-电子3-捕鱼4-真人5-彩票6-体育</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByPromoterType(int promoterType, int top_)
		{
			return GetByPromoterType(promoterType, top_, string.Empty, null);
		}
		public async Task<List<S_provider_orderEO>> GetByPromoterTypeAsync(int promoterType, int top_)
		{
			return await GetByPromoterTypeAsync(promoterType, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PromoterType（字段） 查询
		/// </summary>
		/// /// <param name = "promoterType">推广类型1-棋牌2-电子3-捕鱼4-真人5-彩票6-体育</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByPromoterType(int promoterType, int top_, TransactionManager tm_)
		{
			return GetByPromoterType(promoterType, top_, string.Empty, tm_);
		}
		public async Task<List<S_provider_orderEO>> GetByPromoterTypeAsync(int promoterType, int top_, TransactionManager tm_)
		{
			return await GetByPromoterTypeAsync(promoterType, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PromoterType（字段） 查询
		/// </summary>
		/// /// <param name = "promoterType">推广类型1-棋牌2-电子3-捕鱼4-真人5-彩票6-体育</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByPromoterType(int promoterType, string sort_)
		{
			return GetByPromoterType(promoterType, 0, sort_, null);
		}
		public async Task<List<S_provider_orderEO>> GetByPromoterTypeAsync(int promoterType, string sort_)
		{
			return await GetByPromoterTypeAsync(promoterType, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 PromoterType（字段） 查询
		/// </summary>
		/// /// <param name = "promoterType">推广类型1-棋牌2-电子3-捕鱼4-真人5-彩票6-体育</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByPromoterType(int promoterType, string sort_, TransactionManager tm_)
		{
			return GetByPromoterType(promoterType, 0, sort_, tm_);
		}
		public async Task<List<S_provider_orderEO>> GetByPromoterTypeAsync(int promoterType, string sort_, TransactionManager tm_)
		{
			return await GetByPromoterTypeAsync(promoterType, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 PromoterType（字段） 查询
		/// </summary>
		/// /// <param name = "promoterType">推广类型1-棋牌2-电子3-捕鱼4-真人5-彩票6-体育</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByPromoterType(int promoterType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`PromoterType` = @PromoterType", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PromoterType", promoterType, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, S_provider_orderEO.MapDataReader);
		}
		public async Task<List<S_provider_orderEO>> GetByPromoterTypeAsync(int promoterType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`PromoterType` = @PromoterType", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PromoterType", promoterType, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_provider_orderEO.MapDataReader);
		}
		#endregion // GetByPromoterType
		#region GetByReqMark
		
		/// <summary>
		/// 按 ReqMark（字段） 查询
		/// </summary>
		/// /// <param name = "reqMark">请求接口类型（0-balance1-Bet 2-Win 3-BetWin4-Rollback）</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByReqMark(int reqMark)
		{
			return GetByReqMark(reqMark, 0, string.Empty, null);
		}
		public async Task<List<S_provider_orderEO>> GetByReqMarkAsync(int reqMark)
		{
			return await GetByReqMarkAsync(reqMark, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ReqMark（字段） 查询
		/// </summary>
		/// /// <param name = "reqMark">请求接口类型（0-balance1-Bet 2-Win 3-BetWin4-Rollback）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByReqMark(int reqMark, TransactionManager tm_)
		{
			return GetByReqMark(reqMark, 0, string.Empty, tm_);
		}
		public async Task<List<S_provider_orderEO>> GetByReqMarkAsync(int reqMark, TransactionManager tm_)
		{
			return await GetByReqMarkAsync(reqMark, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ReqMark（字段） 查询
		/// </summary>
		/// /// <param name = "reqMark">请求接口类型（0-balance1-Bet 2-Win 3-BetWin4-Rollback）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByReqMark(int reqMark, int top_)
		{
			return GetByReqMark(reqMark, top_, string.Empty, null);
		}
		public async Task<List<S_provider_orderEO>> GetByReqMarkAsync(int reqMark, int top_)
		{
			return await GetByReqMarkAsync(reqMark, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ReqMark（字段） 查询
		/// </summary>
		/// /// <param name = "reqMark">请求接口类型（0-balance1-Bet 2-Win 3-BetWin4-Rollback）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByReqMark(int reqMark, int top_, TransactionManager tm_)
		{
			return GetByReqMark(reqMark, top_, string.Empty, tm_);
		}
		public async Task<List<S_provider_orderEO>> GetByReqMarkAsync(int reqMark, int top_, TransactionManager tm_)
		{
			return await GetByReqMarkAsync(reqMark, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ReqMark（字段） 查询
		/// </summary>
		/// /// <param name = "reqMark">请求接口类型（0-balance1-Bet 2-Win 3-BetWin4-Rollback）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByReqMark(int reqMark, string sort_)
		{
			return GetByReqMark(reqMark, 0, sort_, null);
		}
		public async Task<List<S_provider_orderEO>> GetByReqMarkAsync(int reqMark, string sort_)
		{
			return await GetByReqMarkAsync(reqMark, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 ReqMark（字段） 查询
		/// </summary>
		/// /// <param name = "reqMark">请求接口类型（0-balance1-Bet 2-Win 3-BetWin4-Rollback）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByReqMark(int reqMark, string sort_, TransactionManager tm_)
		{
			return GetByReqMark(reqMark, 0, sort_, tm_);
		}
		public async Task<List<S_provider_orderEO>> GetByReqMarkAsync(int reqMark, string sort_, TransactionManager tm_)
		{
			return await GetByReqMarkAsync(reqMark, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 ReqMark（字段） 查询
		/// </summary>
		/// /// <param name = "reqMark">请求接口类型（0-balance1-Bet 2-Win 3-BetWin4-Rollback）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByReqMark(int reqMark, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ReqMark` = @ReqMark", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ReqMark", reqMark, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, S_provider_orderEO.MapDataReader);
		}
		public async Task<List<S_provider_orderEO>> GetByReqMarkAsync(int reqMark, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ReqMark` = @ReqMark", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ReqMark", reqMark, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_provider_orderEO.MapDataReader);
		}
		#endregion // GetByReqMark
		#region GetByRequestUUID
		
		/// <summary>
		/// 按 RequestUUID（字段） 查询
		/// </summary>
		/// /// <param name = "requestUUID">请求唯一号</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByRequestUUID(string requestUUID)
		{
			return GetByRequestUUID(requestUUID, 0, string.Empty, null);
		}
		public async Task<List<S_provider_orderEO>> GetByRequestUUIDAsync(string requestUUID)
		{
			return await GetByRequestUUIDAsync(requestUUID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RequestUUID（字段） 查询
		/// </summary>
		/// /// <param name = "requestUUID">请求唯一号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByRequestUUID(string requestUUID, TransactionManager tm_)
		{
			return GetByRequestUUID(requestUUID, 0, string.Empty, tm_);
		}
		public async Task<List<S_provider_orderEO>> GetByRequestUUIDAsync(string requestUUID, TransactionManager tm_)
		{
			return await GetByRequestUUIDAsync(requestUUID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RequestUUID（字段） 查询
		/// </summary>
		/// /// <param name = "requestUUID">请求唯一号</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByRequestUUID(string requestUUID, int top_)
		{
			return GetByRequestUUID(requestUUID, top_, string.Empty, null);
		}
		public async Task<List<S_provider_orderEO>> GetByRequestUUIDAsync(string requestUUID, int top_)
		{
			return await GetByRequestUUIDAsync(requestUUID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RequestUUID（字段） 查询
		/// </summary>
		/// /// <param name = "requestUUID">请求唯一号</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByRequestUUID(string requestUUID, int top_, TransactionManager tm_)
		{
			return GetByRequestUUID(requestUUID, top_, string.Empty, tm_);
		}
		public async Task<List<S_provider_orderEO>> GetByRequestUUIDAsync(string requestUUID, int top_, TransactionManager tm_)
		{
			return await GetByRequestUUIDAsync(requestUUID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RequestUUID（字段） 查询
		/// </summary>
		/// /// <param name = "requestUUID">请求唯一号</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByRequestUUID(string requestUUID, string sort_)
		{
			return GetByRequestUUID(requestUUID, 0, sort_, null);
		}
		public async Task<List<S_provider_orderEO>> GetByRequestUUIDAsync(string requestUUID, string sort_)
		{
			return await GetByRequestUUIDAsync(requestUUID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 RequestUUID（字段） 查询
		/// </summary>
		/// /// <param name = "requestUUID">请求唯一号</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByRequestUUID(string requestUUID, string sort_, TransactionManager tm_)
		{
			return GetByRequestUUID(requestUUID, 0, sort_, tm_);
		}
		public async Task<List<S_provider_orderEO>> GetByRequestUUIDAsync(string requestUUID, string sort_, TransactionManager tm_)
		{
			return await GetByRequestUUIDAsync(requestUUID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 RequestUUID（字段） 查询
		/// </summary>
		/// /// <param name = "requestUUID">请求唯一号</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByRequestUUID(string requestUUID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(requestUUID != null ? "`RequestUUID` = @RequestUUID" : "`RequestUUID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (requestUUID != null)
				paras_.Add(Database.CreateInParameter("@RequestUUID", requestUUID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_provider_orderEO.MapDataReader);
		}
		public async Task<List<S_provider_orderEO>> GetByRequestUUIDAsync(string requestUUID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(requestUUID != null ? "`RequestUUID` = @RequestUUID" : "`RequestUUID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (requestUUID != null)
				paras_.Add(Database.CreateInParameter("@RequestUUID", requestUUID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_provider_orderEO.MapDataReader);
		}
		#endregion // GetByRequestUUID
		#region GetByProviderOrderId
		
		/// <summary>
		/// 按 ProviderOrderId（字段） 查询
		/// </summary>
		/// /// <param name = "providerOrderId">应用提供商订单编码(TransactionUUID)</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByProviderOrderId(string providerOrderId)
		{
			return GetByProviderOrderId(providerOrderId, 0, string.Empty, null);
		}
		public async Task<List<S_provider_orderEO>> GetByProviderOrderIdAsync(string providerOrderId)
		{
			return await GetByProviderOrderIdAsync(providerOrderId, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ProviderOrderId（字段） 查询
		/// </summary>
		/// /// <param name = "providerOrderId">应用提供商订单编码(TransactionUUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByProviderOrderId(string providerOrderId, TransactionManager tm_)
		{
			return GetByProviderOrderId(providerOrderId, 0, string.Empty, tm_);
		}
		public async Task<List<S_provider_orderEO>> GetByProviderOrderIdAsync(string providerOrderId, TransactionManager tm_)
		{
			return await GetByProviderOrderIdAsync(providerOrderId, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ProviderOrderId（字段） 查询
		/// </summary>
		/// /// <param name = "providerOrderId">应用提供商订单编码(TransactionUUID)</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByProviderOrderId(string providerOrderId, int top_)
		{
			return GetByProviderOrderId(providerOrderId, top_, string.Empty, null);
		}
		public async Task<List<S_provider_orderEO>> GetByProviderOrderIdAsync(string providerOrderId, int top_)
		{
			return await GetByProviderOrderIdAsync(providerOrderId, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ProviderOrderId（字段） 查询
		/// </summary>
		/// /// <param name = "providerOrderId">应用提供商订单编码(TransactionUUID)</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByProviderOrderId(string providerOrderId, int top_, TransactionManager tm_)
		{
			return GetByProviderOrderId(providerOrderId, top_, string.Empty, tm_);
		}
		public async Task<List<S_provider_orderEO>> GetByProviderOrderIdAsync(string providerOrderId, int top_, TransactionManager tm_)
		{
			return await GetByProviderOrderIdAsync(providerOrderId, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ProviderOrderId（字段） 查询
		/// </summary>
		/// /// <param name = "providerOrderId">应用提供商订单编码(TransactionUUID)</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByProviderOrderId(string providerOrderId, string sort_)
		{
			return GetByProviderOrderId(providerOrderId, 0, sort_, null);
		}
		public async Task<List<S_provider_orderEO>> GetByProviderOrderIdAsync(string providerOrderId, string sort_)
		{
			return await GetByProviderOrderIdAsync(providerOrderId, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 ProviderOrderId（字段） 查询
		/// </summary>
		/// /// <param name = "providerOrderId">应用提供商订单编码(TransactionUUID)</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByProviderOrderId(string providerOrderId, string sort_, TransactionManager tm_)
		{
			return GetByProviderOrderId(providerOrderId, 0, sort_, tm_);
		}
		public async Task<List<S_provider_orderEO>> GetByProviderOrderIdAsync(string providerOrderId, string sort_, TransactionManager tm_)
		{
			return await GetByProviderOrderIdAsync(providerOrderId, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 ProviderOrderId（字段） 查询
		/// </summary>
		/// /// <param name = "providerOrderId">应用提供商订单编码(TransactionUUID)</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByProviderOrderId(string providerOrderId, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(providerOrderId != null ? "`ProviderOrderId` = @ProviderOrderId" : "`ProviderOrderId` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (providerOrderId != null)
				paras_.Add(Database.CreateInParameter("@ProviderOrderId", providerOrderId, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_provider_orderEO.MapDataReader);
		}
		public async Task<List<S_provider_orderEO>> GetByProviderOrderIdAsync(string providerOrderId, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(providerOrderId != null ? "`ProviderOrderId` = @ProviderOrderId" : "`ProviderOrderId` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (providerOrderId != null)
				paras_.Add(Database.CreateInParameter("@ProviderOrderId", providerOrderId, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_provider_orderEO.MapDataReader);
		}
		#endregion // GetByProviderOrderId
		#region GetByReferProviderOrderId
		
		/// <summary>
		/// 按 ReferProviderOrderId（字段） 查询
		/// </summary>
		/// /// <param name = "referProviderOrderId">应用提供商原始订单编码(ReferenceTransactionUUID)</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByReferProviderOrderId(string referProviderOrderId)
		{
			return GetByReferProviderOrderId(referProviderOrderId, 0, string.Empty, null);
		}
		public async Task<List<S_provider_orderEO>> GetByReferProviderOrderIdAsync(string referProviderOrderId)
		{
			return await GetByReferProviderOrderIdAsync(referProviderOrderId, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ReferProviderOrderId（字段） 查询
		/// </summary>
		/// /// <param name = "referProviderOrderId">应用提供商原始订单编码(ReferenceTransactionUUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByReferProviderOrderId(string referProviderOrderId, TransactionManager tm_)
		{
			return GetByReferProviderOrderId(referProviderOrderId, 0, string.Empty, tm_);
		}
		public async Task<List<S_provider_orderEO>> GetByReferProviderOrderIdAsync(string referProviderOrderId, TransactionManager tm_)
		{
			return await GetByReferProviderOrderIdAsync(referProviderOrderId, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ReferProviderOrderId（字段） 查询
		/// </summary>
		/// /// <param name = "referProviderOrderId">应用提供商原始订单编码(ReferenceTransactionUUID)</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByReferProviderOrderId(string referProviderOrderId, int top_)
		{
			return GetByReferProviderOrderId(referProviderOrderId, top_, string.Empty, null);
		}
		public async Task<List<S_provider_orderEO>> GetByReferProviderOrderIdAsync(string referProviderOrderId, int top_)
		{
			return await GetByReferProviderOrderIdAsync(referProviderOrderId, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ReferProviderOrderId（字段） 查询
		/// </summary>
		/// /// <param name = "referProviderOrderId">应用提供商原始订单编码(ReferenceTransactionUUID)</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByReferProviderOrderId(string referProviderOrderId, int top_, TransactionManager tm_)
		{
			return GetByReferProviderOrderId(referProviderOrderId, top_, string.Empty, tm_);
		}
		public async Task<List<S_provider_orderEO>> GetByReferProviderOrderIdAsync(string referProviderOrderId, int top_, TransactionManager tm_)
		{
			return await GetByReferProviderOrderIdAsync(referProviderOrderId, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ReferProviderOrderId（字段） 查询
		/// </summary>
		/// /// <param name = "referProviderOrderId">应用提供商原始订单编码(ReferenceTransactionUUID)</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByReferProviderOrderId(string referProviderOrderId, string sort_)
		{
			return GetByReferProviderOrderId(referProviderOrderId, 0, sort_, null);
		}
		public async Task<List<S_provider_orderEO>> GetByReferProviderOrderIdAsync(string referProviderOrderId, string sort_)
		{
			return await GetByReferProviderOrderIdAsync(referProviderOrderId, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 ReferProviderOrderId（字段） 查询
		/// </summary>
		/// /// <param name = "referProviderOrderId">应用提供商原始订单编码(ReferenceTransactionUUID)</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByReferProviderOrderId(string referProviderOrderId, string sort_, TransactionManager tm_)
		{
			return GetByReferProviderOrderId(referProviderOrderId, 0, sort_, tm_);
		}
		public async Task<List<S_provider_orderEO>> GetByReferProviderOrderIdAsync(string referProviderOrderId, string sort_, TransactionManager tm_)
		{
			return await GetByReferProviderOrderIdAsync(referProviderOrderId, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 ReferProviderOrderId（字段） 查询
		/// </summary>
		/// /// <param name = "referProviderOrderId">应用提供商原始订单编码(ReferenceTransactionUUID)</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByReferProviderOrderId(string referProviderOrderId, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(referProviderOrderId != null ? "`ReferProviderOrderId` = @ReferProviderOrderId" : "`ReferProviderOrderId` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (referProviderOrderId != null)
				paras_.Add(Database.CreateInParameter("@ReferProviderOrderId", referProviderOrderId, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_provider_orderEO.MapDataReader);
		}
		public async Task<List<S_provider_orderEO>> GetByReferProviderOrderIdAsync(string referProviderOrderId, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(referProviderOrderId != null ? "`ReferProviderOrderId` = @ReferProviderOrderId" : "`ReferProviderOrderId` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (referProviderOrderId != null)
				paras_.Add(Database.CreateInParameter("@ReferProviderOrderId", referProviderOrderId, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_provider_orderEO.MapDataReader);
		}
		#endregion // GetByReferProviderOrderId
		#region GetByRoundClosed
		
		/// <summary>
		/// 按 RoundClosed（字段） 查询
		/// </summary>
		/// /// <param name = "roundClosed">回合是否关闭</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByRoundClosed(bool roundClosed)
		{
			return GetByRoundClosed(roundClosed, 0, string.Empty, null);
		}
		public async Task<List<S_provider_orderEO>> GetByRoundClosedAsync(bool roundClosed)
		{
			return await GetByRoundClosedAsync(roundClosed, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RoundClosed（字段） 查询
		/// </summary>
		/// /// <param name = "roundClosed">回合是否关闭</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByRoundClosed(bool roundClosed, TransactionManager tm_)
		{
			return GetByRoundClosed(roundClosed, 0, string.Empty, tm_);
		}
		public async Task<List<S_provider_orderEO>> GetByRoundClosedAsync(bool roundClosed, TransactionManager tm_)
		{
			return await GetByRoundClosedAsync(roundClosed, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RoundClosed（字段） 查询
		/// </summary>
		/// /// <param name = "roundClosed">回合是否关闭</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByRoundClosed(bool roundClosed, int top_)
		{
			return GetByRoundClosed(roundClosed, top_, string.Empty, null);
		}
		public async Task<List<S_provider_orderEO>> GetByRoundClosedAsync(bool roundClosed, int top_)
		{
			return await GetByRoundClosedAsync(roundClosed, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RoundClosed（字段） 查询
		/// </summary>
		/// /// <param name = "roundClosed">回合是否关闭</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByRoundClosed(bool roundClosed, int top_, TransactionManager tm_)
		{
			return GetByRoundClosed(roundClosed, top_, string.Empty, tm_);
		}
		public async Task<List<S_provider_orderEO>> GetByRoundClosedAsync(bool roundClosed, int top_, TransactionManager tm_)
		{
			return await GetByRoundClosedAsync(roundClosed, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RoundClosed（字段） 查询
		/// </summary>
		/// /// <param name = "roundClosed">回合是否关闭</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByRoundClosed(bool roundClosed, string sort_)
		{
			return GetByRoundClosed(roundClosed, 0, sort_, null);
		}
		public async Task<List<S_provider_orderEO>> GetByRoundClosedAsync(bool roundClosed, string sort_)
		{
			return await GetByRoundClosedAsync(roundClosed, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 RoundClosed（字段） 查询
		/// </summary>
		/// /// <param name = "roundClosed">回合是否关闭</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByRoundClosed(bool roundClosed, string sort_, TransactionManager tm_)
		{
			return GetByRoundClosed(roundClosed, 0, sort_, tm_);
		}
		public async Task<List<S_provider_orderEO>> GetByRoundClosedAsync(bool roundClosed, string sort_, TransactionManager tm_)
		{
			return await GetByRoundClosedAsync(roundClosed, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 RoundClosed（字段） 查询
		/// </summary>
		/// /// <param name = "roundClosed">回合是否关闭</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByRoundClosed(bool roundClosed, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RoundClosed` = @RoundClosed", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RoundClosed", roundClosed, MySqlDbType.Byte));
			return Database.ExecSqlList(sql_, paras_, tm_, S_provider_orderEO.MapDataReader);
		}
		public async Task<List<S_provider_orderEO>> GetByRoundClosedAsync(bool roundClosed, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RoundClosed` = @RoundClosed", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RoundClosed", roundClosed, MySqlDbType.Byte));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_provider_orderEO.MapDataReader);
		}
		#endregion // GetByRoundClosed
		#region GetByRoundId
		
		/// <summary>
		/// 按 RoundId（字段） 查询
		/// </summary>
		/// /// <param name = "roundId">回合标识</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByRoundId(string roundId)
		{
			return GetByRoundId(roundId, 0, string.Empty, null);
		}
		public async Task<List<S_provider_orderEO>> GetByRoundIdAsync(string roundId)
		{
			return await GetByRoundIdAsync(roundId, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RoundId（字段） 查询
		/// </summary>
		/// /// <param name = "roundId">回合标识</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByRoundId(string roundId, TransactionManager tm_)
		{
			return GetByRoundId(roundId, 0, string.Empty, tm_);
		}
		public async Task<List<S_provider_orderEO>> GetByRoundIdAsync(string roundId, TransactionManager tm_)
		{
			return await GetByRoundIdAsync(roundId, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RoundId（字段） 查询
		/// </summary>
		/// /// <param name = "roundId">回合标识</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByRoundId(string roundId, int top_)
		{
			return GetByRoundId(roundId, top_, string.Empty, null);
		}
		public async Task<List<S_provider_orderEO>> GetByRoundIdAsync(string roundId, int top_)
		{
			return await GetByRoundIdAsync(roundId, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RoundId（字段） 查询
		/// </summary>
		/// /// <param name = "roundId">回合标识</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByRoundId(string roundId, int top_, TransactionManager tm_)
		{
			return GetByRoundId(roundId, top_, string.Empty, tm_);
		}
		public async Task<List<S_provider_orderEO>> GetByRoundIdAsync(string roundId, int top_, TransactionManager tm_)
		{
			return await GetByRoundIdAsync(roundId, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RoundId（字段） 查询
		/// </summary>
		/// /// <param name = "roundId">回合标识</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByRoundId(string roundId, string sort_)
		{
			return GetByRoundId(roundId, 0, sort_, null);
		}
		public async Task<List<S_provider_orderEO>> GetByRoundIdAsync(string roundId, string sort_)
		{
			return await GetByRoundIdAsync(roundId, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 RoundId（字段） 查询
		/// </summary>
		/// /// <param name = "roundId">回合标识</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByRoundId(string roundId, string sort_, TransactionManager tm_)
		{
			return GetByRoundId(roundId, 0, sort_, tm_);
		}
		public async Task<List<S_provider_orderEO>> GetByRoundIdAsync(string roundId, string sort_, TransactionManager tm_)
		{
			return await GetByRoundIdAsync(roundId, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 RoundId（字段） 查询
		/// </summary>
		/// /// <param name = "roundId">回合标识</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByRoundId(string roundId, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(roundId != null ? "`RoundId` = @RoundId" : "`RoundId` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (roundId != null)
				paras_.Add(Database.CreateInParameter("@RoundId", roundId, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_provider_orderEO.MapDataReader);
		}
		public async Task<List<S_provider_orderEO>> GetByRoundIdAsync(string roundId, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(roundId != null ? "`RoundId` = @RoundId" : "`RoundId` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (roundId != null)
				paras_.Add(Database.CreateInParameter("@RoundId", roundId, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_provider_orderEO.MapDataReader);
		}
		#endregion // GetByRoundId
		#region GetByRewardUUID
		
		/// <summary>
		/// 按 RewardUUID（字段） 查询
		/// </summary>
		/// /// <param name = "rewardUUID">我方提供的奖励id</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByRewardUUID(string rewardUUID)
		{
			return GetByRewardUUID(rewardUUID, 0, string.Empty, null);
		}
		public async Task<List<S_provider_orderEO>> GetByRewardUUIDAsync(string rewardUUID)
		{
			return await GetByRewardUUIDAsync(rewardUUID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RewardUUID（字段） 查询
		/// </summary>
		/// /// <param name = "rewardUUID">我方提供的奖励id</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByRewardUUID(string rewardUUID, TransactionManager tm_)
		{
			return GetByRewardUUID(rewardUUID, 0, string.Empty, tm_);
		}
		public async Task<List<S_provider_orderEO>> GetByRewardUUIDAsync(string rewardUUID, TransactionManager tm_)
		{
			return await GetByRewardUUIDAsync(rewardUUID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RewardUUID（字段） 查询
		/// </summary>
		/// /// <param name = "rewardUUID">我方提供的奖励id</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByRewardUUID(string rewardUUID, int top_)
		{
			return GetByRewardUUID(rewardUUID, top_, string.Empty, null);
		}
		public async Task<List<S_provider_orderEO>> GetByRewardUUIDAsync(string rewardUUID, int top_)
		{
			return await GetByRewardUUIDAsync(rewardUUID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RewardUUID（字段） 查询
		/// </summary>
		/// /// <param name = "rewardUUID">我方提供的奖励id</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByRewardUUID(string rewardUUID, int top_, TransactionManager tm_)
		{
			return GetByRewardUUID(rewardUUID, top_, string.Empty, tm_);
		}
		public async Task<List<S_provider_orderEO>> GetByRewardUUIDAsync(string rewardUUID, int top_, TransactionManager tm_)
		{
			return await GetByRewardUUIDAsync(rewardUUID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RewardUUID（字段） 查询
		/// </summary>
		/// /// <param name = "rewardUUID">我方提供的奖励id</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByRewardUUID(string rewardUUID, string sort_)
		{
			return GetByRewardUUID(rewardUUID, 0, sort_, null);
		}
		public async Task<List<S_provider_orderEO>> GetByRewardUUIDAsync(string rewardUUID, string sort_)
		{
			return await GetByRewardUUIDAsync(rewardUUID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 RewardUUID（字段） 查询
		/// </summary>
		/// /// <param name = "rewardUUID">我方提供的奖励id</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByRewardUUID(string rewardUUID, string sort_, TransactionManager tm_)
		{
			return GetByRewardUUID(rewardUUID, 0, sort_, tm_);
		}
		public async Task<List<S_provider_orderEO>> GetByRewardUUIDAsync(string rewardUUID, string sort_, TransactionManager tm_)
		{
			return await GetByRewardUUIDAsync(rewardUUID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 RewardUUID（字段） 查询
		/// </summary>
		/// /// <param name = "rewardUUID">我方提供的奖励id</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByRewardUUID(string rewardUUID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(rewardUUID != null ? "`RewardUUID` = @RewardUUID" : "`RewardUUID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (rewardUUID != null)
				paras_.Add(Database.CreateInParameter("@RewardUUID", rewardUUID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_provider_orderEO.MapDataReader);
		}
		public async Task<List<S_provider_orderEO>> GetByRewardUUIDAsync(string rewardUUID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(rewardUUID != null ? "`RewardUUID` = @RewardUUID" : "`RewardUUID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (rewardUUID != null)
				paras_.Add(Database.CreateInParameter("@RewardUUID", rewardUUID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_provider_orderEO.MapDataReader);
		}
		#endregion // GetByRewardUUID
		#region GetByIsFree
		
		/// <summary>
		/// 按 IsFree（字段） 查询
		/// </summary>
		/// /// <param name = "isFree">是否促销产生的交易</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByIsFree(bool isFree)
		{
			return GetByIsFree(isFree, 0, string.Empty, null);
		}
		public async Task<List<S_provider_orderEO>> GetByIsFreeAsync(bool isFree)
		{
			return await GetByIsFreeAsync(isFree, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 IsFree（字段） 查询
		/// </summary>
		/// /// <param name = "isFree">是否促销产生的交易</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByIsFree(bool isFree, TransactionManager tm_)
		{
			return GetByIsFree(isFree, 0, string.Empty, tm_);
		}
		public async Task<List<S_provider_orderEO>> GetByIsFreeAsync(bool isFree, TransactionManager tm_)
		{
			return await GetByIsFreeAsync(isFree, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IsFree（字段） 查询
		/// </summary>
		/// /// <param name = "isFree">是否促销产生的交易</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByIsFree(bool isFree, int top_)
		{
			return GetByIsFree(isFree, top_, string.Empty, null);
		}
		public async Task<List<S_provider_orderEO>> GetByIsFreeAsync(bool isFree, int top_)
		{
			return await GetByIsFreeAsync(isFree, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 IsFree（字段） 查询
		/// </summary>
		/// /// <param name = "isFree">是否促销产生的交易</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByIsFree(bool isFree, int top_, TransactionManager tm_)
		{
			return GetByIsFree(isFree, top_, string.Empty, tm_);
		}
		public async Task<List<S_provider_orderEO>> GetByIsFreeAsync(bool isFree, int top_, TransactionManager tm_)
		{
			return await GetByIsFreeAsync(isFree, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IsFree（字段） 查询
		/// </summary>
		/// /// <param name = "isFree">是否促销产生的交易</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByIsFree(bool isFree, string sort_)
		{
			return GetByIsFree(isFree, 0, sort_, null);
		}
		public async Task<List<S_provider_orderEO>> GetByIsFreeAsync(bool isFree, string sort_)
		{
			return await GetByIsFreeAsync(isFree, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 IsFree（字段） 查询
		/// </summary>
		/// /// <param name = "isFree">是否促销产生的交易</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByIsFree(bool isFree, string sort_, TransactionManager tm_)
		{
			return GetByIsFree(isFree, 0, sort_, tm_);
		}
		public async Task<List<S_provider_orderEO>> GetByIsFreeAsync(bool isFree, string sort_, TransactionManager tm_)
		{
			return await GetByIsFreeAsync(isFree, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 IsFree（字段） 查询
		/// </summary>
		/// /// <param name = "isFree">是否促销产生的交易</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByIsFree(bool isFree, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`IsFree` = @IsFree", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IsFree", isFree, MySqlDbType.Byte));
			return Database.ExecSqlList(sql_, paras_, tm_, S_provider_orderEO.MapDataReader);
		}
		public async Task<List<S_provider_orderEO>> GetByIsFreeAsync(bool isFree, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`IsFree` = @IsFree", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IsFree", isFree, MySqlDbType.Byte));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_provider_orderEO.MapDataReader);
		}
		#endregion // GetByIsFree
		#region GetByPlanBet
		
		/// <summary>
		/// 按 PlanBet（字段） 查询
		/// </summary>
		/// /// <param name = "planBet">计划下注数量（正数）</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByPlanBet(long planBet)
		{
			return GetByPlanBet(planBet, 0, string.Empty, null);
		}
		public async Task<List<S_provider_orderEO>> GetByPlanBetAsync(long planBet)
		{
			return await GetByPlanBetAsync(planBet, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PlanBet（字段） 查询
		/// </summary>
		/// /// <param name = "planBet">计划下注数量（正数）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByPlanBet(long planBet, TransactionManager tm_)
		{
			return GetByPlanBet(planBet, 0, string.Empty, tm_);
		}
		public async Task<List<S_provider_orderEO>> GetByPlanBetAsync(long planBet, TransactionManager tm_)
		{
			return await GetByPlanBetAsync(planBet, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PlanBet（字段） 查询
		/// </summary>
		/// /// <param name = "planBet">计划下注数量（正数）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByPlanBet(long planBet, int top_)
		{
			return GetByPlanBet(planBet, top_, string.Empty, null);
		}
		public async Task<List<S_provider_orderEO>> GetByPlanBetAsync(long planBet, int top_)
		{
			return await GetByPlanBetAsync(planBet, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PlanBet（字段） 查询
		/// </summary>
		/// /// <param name = "planBet">计划下注数量（正数）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByPlanBet(long planBet, int top_, TransactionManager tm_)
		{
			return GetByPlanBet(planBet, top_, string.Empty, tm_);
		}
		public async Task<List<S_provider_orderEO>> GetByPlanBetAsync(long planBet, int top_, TransactionManager tm_)
		{
			return await GetByPlanBetAsync(planBet, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PlanBet（字段） 查询
		/// </summary>
		/// /// <param name = "planBet">计划下注数量（正数）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByPlanBet(long planBet, string sort_)
		{
			return GetByPlanBet(planBet, 0, sort_, null);
		}
		public async Task<List<S_provider_orderEO>> GetByPlanBetAsync(long planBet, string sort_)
		{
			return await GetByPlanBetAsync(planBet, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 PlanBet（字段） 查询
		/// </summary>
		/// /// <param name = "planBet">计划下注数量（正数）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByPlanBet(long planBet, string sort_, TransactionManager tm_)
		{
			return GetByPlanBet(planBet, 0, sort_, tm_);
		}
		public async Task<List<S_provider_orderEO>> GetByPlanBetAsync(long planBet, string sort_, TransactionManager tm_)
		{
			return await GetByPlanBetAsync(planBet, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 PlanBet（字段） 查询
		/// </summary>
		/// /// <param name = "planBet">计划下注数量（正数）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByPlanBet(long planBet, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`PlanBet` = @PlanBet", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PlanBet", planBet, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, S_provider_orderEO.MapDataReader);
		}
		public async Task<List<S_provider_orderEO>> GetByPlanBetAsync(long planBet, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`PlanBet` = @PlanBet", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PlanBet", planBet, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_provider_orderEO.MapDataReader);
		}
		#endregion // GetByPlanBet
		#region GetByPlanWin
		
		/// <summary>
		/// 按 PlanWin（字段） 查询
		/// </summary>
		/// /// <param name = "planWin">计划返奖数量（正数）</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByPlanWin(long planWin)
		{
			return GetByPlanWin(planWin, 0, string.Empty, null);
		}
		public async Task<List<S_provider_orderEO>> GetByPlanWinAsync(long planWin)
		{
			return await GetByPlanWinAsync(planWin, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PlanWin（字段） 查询
		/// </summary>
		/// /// <param name = "planWin">计划返奖数量（正数）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByPlanWin(long planWin, TransactionManager tm_)
		{
			return GetByPlanWin(planWin, 0, string.Empty, tm_);
		}
		public async Task<List<S_provider_orderEO>> GetByPlanWinAsync(long planWin, TransactionManager tm_)
		{
			return await GetByPlanWinAsync(planWin, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PlanWin（字段） 查询
		/// </summary>
		/// /// <param name = "planWin">计划返奖数量（正数）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByPlanWin(long planWin, int top_)
		{
			return GetByPlanWin(planWin, top_, string.Empty, null);
		}
		public async Task<List<S_provider_orderEO>> GetByPlanWinAsync(long planWin, int top_)
		{
			return await GetByPlanWinAsync(planWin, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PlanWin（字段） 查询
		/// </summary>
		/// /// <param name = "planWin">计划返奖数量（正数）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByPlanWin(long planWin, int top_, TransactionManager tm_)
		{
			return GetByPlanWin(planWin, top_, string.Empty, tm_);
		}
		public async Task<List<S_provider_orderEO>> GetByPlanWinAsync(long planWin, int top_, TransactionManager tm_)
		{
			return await GetByPlanWinAsync(planWin, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PlanWin（字段） 查询
		/// </summary>
		/// /// <param name = "planWin">计划返奖数量（正数）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByPlanWin(long planWin, string sort_)
		{
			return GetByPlanWin(planWin, 0, sort_, null);
		}
		public async Task<List<S_provider_orderEO>> GetByPlanWinAsync(long planWin, string sort_)
		{
			return await GetByPlanWinAsync(planWin, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 PlanWin（字段） 查询
		/// </summary>
		/// /// <param name = "planWin">计划返奖数量（正数）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByPlanWin(long planWin, string sort_, TransactionManager tm_)
		{
			return GetByPlanWin(planWin, 0, sort_, tm_);
		}
		public async Task<List<S_provider_orderEO>> GetByPlanWinAsync(long planWin, string sort_, TransactionManager tm_)
		{
			return await GetByPlanWinAsync(planWin, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 PlanWin（字段） 查询
		/// </summary>
		/// /// <param name = "planWin">计划返奖数量（正数）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByPlanWin(long planWin, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`PlanWin` = @PlanWin", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PlanWin", planWin, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, S_provider_orderEO.MapDataReader);
		}
		public async Task<List<S_provider_orderEO>> GetByPlanWinAsync(long planWin, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`PlanWin` = @PlanWin", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PlanWin", planWin, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_provider_orderEO.MapDataReader);
		}
		#endregion // GetByPlanWin
		#region GetByPlanAmount
		
		/// <summary>
		/// 按 PlanAmount（字段） 查询
		/// </summary>
		/// /// <param name = "planAmount">计划账户变化数量（正负数）</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByPlanAmount(long planAmount)
		{
			return GetByPlanAmount(planAmount, 0, string.Empty, null);
		}
		public async Task<List<S_provider_orderEO>> GetByPlanAmountAsync(long planAmount)
		{
			return await GetByPlanAmountAsync(planAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PlanAmount（字段） 查询
		/// </summary>
		/// /// <param name = "planAmount">计划账户变化数量（正负数）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByPlanAmount(long planAmount, TransactionManager tm_)
		{
			return GetByPlanAmount(planAmount, 0, string.Empty, tm_);
		}
		public async Task<List<S_provider_orderEO>> GetByPlanAmountAsync(long planAmount, TransactionManager tm_)
		{
			return await GetByPlanAmountAsync(planAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PlanAmount（字段） 查询
		/// </summary>
		/// /// <param name = "planAmount">计划账户变化数量（正负数）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByPlanAmount(long planAmount, int top_)
		{
			return GetByPlanAmount(planAmount, top_, string.Empty, null);
		}
		public async Task<List<S_provider_orderEO>> GetByPlanAmountAsync(long planAmount, int top_)
		{
			return await GetByPlanAmountAsync(planAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PlanAmount（字段） 查询
		/// </summary>
		/// /// <param name = "planAmount">计划账户变化数量（正负数）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByPlanAmount(long planAmount, int top_, TransactionManager tm_)
		{
			return GetByPlanAmount(planAmount, top_, string.Empty, tm_);
		}
		public async Task<List<S_provider_orderEO>> GetByPlanAmountAsync(long planAmount, int top_, TransactionManager tm_)
		{
			return await GetByPlanAmountAsync(planAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PlanAmount（字段） 查询
		/// </summary>
		/// /// <param name = "planAmount">计划账户变化数量（正负数）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByPlanAmount(long planAmount, string sort_)
		{
			return GetByPlanAmount(planAmount, 0, sort_, null);
		}
		public async Task<List<S_provider_orderEO>> GetByPlanAmountAsync(long planAmount, string sort_)
		{
			return await GetByPlanAmountAsync(planAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 PlanAmount（字段） 查询
		/// </summary>
		/// /// <param name = "planAmount">计划账户变化数量（正负数）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByPlanAmount(long planAmount, string sort_, TransactionManager tm_)
		{
			return GetByPlanAmount(planAmount, 0, sort_, tm_);
		}
		public async Task<List<S_provider_orderEO>> GetByPlanAmountAsync(long planAmount, string sort_, TransactionManager tm_)
		{
			return await GetByPlanAmountAsync(planAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 PlanAmount（字段） 查询
		/// </summary>
		/// /// <param name = "planAmount">计划账户变化数量（正负数）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByPlanAmount(long planAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`PlanAmount` = @PlanAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PlanAmount", planAmount, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, S_provider_orderEO.MapDataReader);
		}
		public async Task<List<S_provider_orderEO>> GetByPlanAmountAsync(long planAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`PlanAmount` = @PlanAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PlanAmount", planAmount, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_provider_orderEO.MapDataReader);
		}
		#endregion // GetByPlanAmount
		#region GetByMeta
		
		/// <summary>
		/// 按 Meta（字段） 查询
		/// </summary>
		/// /// <param name = "meta">扩展数据</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByMeta(string meta)
		{
			return GetByMeta(meta, 0, string.Empty, null);
		}
		public async Task<List<S_provider_orderEO>> GetByMetaAsync(string meta)
		{
			return await GetByMetaAsync(meta, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Meta（字段） 查询
		/// </summary>
		/// /// <param name = "meta">扩展数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByMeta(string meta, TransactionManager tm_)
		{
			return GetByMeta(meta, 0, string.Empty, tm_);
		}
		public async Task<List<S_provider_orderEO>> GetByMetaAsync(string meta, TransactionManager tm_)
		{
			return await GetByMetaAsync(meta, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Meta（字段） 查询
		/// </summary>
		/// /// <param name = "meta">扩展数据</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByMeta(string meta, int top_)
		{
			return GetByMeta(meta, top_, string.Empty, null);
		}
		public async Task<List<S_provider_orderEO>> GetByMetaAsync(string meta, int top_)
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
		public List<S_provider_orderEO> GetByMeta(string meta, int top_, TransactionManager tm_)
		{
			return GetByMeta(meta, top_, string.Empty, tm_);
		}
		public async Task<List<S_provider_orderEO>> GetByMetaAsync(string meta, int top_, TransactionManager tm_)
		{
			return await GetByMetaAsync(meta, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Meta（字段） 查询
		/// </summary>
		/// /// <param name = "meta">扩展数据</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByMeta(string meta, string sort_)
		{
			return GetByMeta(meta, 0, sort_, null);
		}
		public async Task<List<S_provider_orderEO>> GetByMetaAsync(string meta, string sort_)
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
		public List<S_provider_orderEO> GetByMeta(string meta, string sort_, TransactionManager tm_)
		{
			return GetByMeta(meta, 0, sort_, tm_);
		}
		public async Task<List<S_provider_orderEO>> GetByMetaAsync(string meta, string sort_, TransactionManager tm_)
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
		public List<S_provider_orderEO> GetByMeta(string meta, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(meta != null ? "`Meta` = @Meta" : "`Meta` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (meta != null)
				paras_.Add(Database.CreateInParameter("@Meta", meta, MySqlDbType.Text));
			return Database.ExecSqlList(sql_, paras_, tm_, S_provider_orderEO.MapDataReader);
		}
		public async Task<List<S_provider_orderEO>> GetByMetaAsync(string meta, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(meta != null ? "`Meta` = @Meta" : "`Meta` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (meta != null)
				paras_.Add(Database.CreateInParameter("@Meta", meta, MySqlDbType.Text));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_provider_orderEO.MapDataReader);
		}
		#endregion // GetByMeta
		#region GetByUserIp
		
		/// <summary>
		/// 按 UserIp（字段） 查询
		/// </summary>
		/// /// <param name = "userIp">用户IP</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByUserIp(string userIp)
		{
			return GetByUserIp(userIp, 0, string.Empty, null);
		}
		public async Task<List<S_provider_orderEO>> GetByUserIpAsync(string userIp)
		{
			return await GetByUserIpAsync(userIp, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UserIp（字段） 查询
		/// </summary>
		/// /// <param name = "userIp">用户IP</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByUserIp(string userIp, TransactionManager tm_)
		{
			return GetByUserIp(userIp, 0, string.Empty, tm_);
		}
		public async Task<List<S_provider_orderEO>> GetByUserIpAsync(string userIp, TransactionManager tm_)
		{
			return await GetByUserIpAsync(userIp, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserIp（字段） 查询
		/// </summary>
		/// /// <param name = "userIp">用户IP</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByUserIp(string userIp, int top_)
		{
			return GetByUserIp(userIp, top_, string.Empty, null);
		}
		public async Task<List<S_provider_orderEO>> GetByUserIpAsync(string userIp, int top_)
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
		public List<S_provider_orderEO> GetByUserIp(string userIp, int top_, TransactionManager tm_)
		{
			return GetByUserIp(userIp, top_, string.Empty, tm_);
		}
		public async Task<List<S_provider_orderEO>> GetByUserIpAsync(string userIp, int top_, TransactionManager tm_)
		{
			return await GetByUserIpAsync(userIp, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserIp（字段） 查询
		/// </summary>
		/// /// <param name = "userIp">用户IP</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByUserIp(string userIp, string sort_)
		{
			return GetByUserIp(userIp, 0, sort_, null);
		}
		public async Task<List<S_provider_orderEO>> GetByUserIpAsync(string userIp, string sort_)
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
		public List<S_provider_orderEO> GetByUserIp(string userIp, string sort_, TransactionManager tm_)
		{
			return GetByUserIp(userIp, 0, sort_, tm_);
		}
		public async Task<List<S_provider_orderEO>> GetByUserIpAsync(string userIp, string sort_, TransactionManager tm_)
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
		public List<S_provider_orderEO> GetByUserIp(string userIp, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(userIp != null ? "`UserIp` = @UserIp" : "`UserIp` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (userIp != null)
				paras_.Add(Database.CreateInParameter("@UserIp", userIp, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_provider_orderEO.MapDataReader);
		}
		public async Task<List<S_provider_orderEO>> GetByUserIpAsync(string userIp, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(userIp != null ? "`UserIp` = @UserIp" : "`UserIp` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (userIp != null)
				paras_.Add(Database.CreateInParameter("@UserIp", userIp, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_provider_orderEO.MapDataReader);
		}
		#endregion // GetByUserIp
		#region GetByStatus
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态0-初始1-处理中2-成功3-失败4-已回滚5-异常且需处理6-异常已处理</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByStatus(int status)
		{
			return GetByStatus(status, 0, string.Empty, null);
		}
		public async Task<List<S_provider_orderEO>> GetByStatusAsync(int status)
		{
			return await GetByStatusAsync(status, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态0-初始1-处理中2-成功3-失败4-已回滚5-异常且需处理6-异常已处理</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByStatus(int status, TransactionManager tm_)
		{
			return GetByStatus(status, 0, string.Empty, tm_);
		}
		public async Task<List<S_provider_orderEO>> GetByStatusAsync(int status, TransactionManager tm_)
		{
			return await GetByStatusAsync(status, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态0-初始1-处理中2-成功3-失败4-已回滚5-异常且需处理6-异常已处理</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByStatus(int status, int top_)
		{
			return GetByStatus(status, top_, string.Empty, null);
		}
		public async Task<List<S_provider_orderEO>> GetByStatusAsync(int status, int top_)
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
		public List<S_provider_orderEO> GetByStatus(int status, int top_, TransactionManager tm_)
		{
			return GetByStatus(status, top_, string.Empty, tm_);
		}
		public async Task<List<S_provider_orderEO>> GetByStatusAsync(int status, int top_, TransactionManager tm_)
		{
			return await GetByStatusAsync(status, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态0-初始1-处理中2-成功3-失败4-已回滚5-异常且需处理6-异常已处理</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByStatus(int status, string sort_)
		{
			return GetByStatus(status, 0, sort_, null);
		}
		public async Task<List<S_provider_orderEO>> GetByStatusAsync(int status, string sort_)
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
		public List<S_provider_orderEO> GetByStatus(int status, string sort_, TransactionManager tm_)
		{
			return GetByStatus(status, 0, sort_, tm_);
		}
		public async Task<List<S_provider_orderEO>> GetByStatusAsync(int status, string sort_, TransactionManager tm_)
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
		public List<S_provider_orderEO> GetByStatus(int status, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Status` = @Status", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Status", status, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, S_provider_orderEO.MapDataReader);
		}
		public async Task<List<S_provider_orderEO>> GetByStatusAsync(int status, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Status` = @Status", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Status", status, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_provider_orderEO.MapDataReader);
		}
		#endregion // GetByStatus
		#region GetByRecDate
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">订单时间</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByRecDate(DateTime recDate)
		{
			return GetByRecDate(recDate, 0, string.Empty, null);
		}
		public async Task<List<S_provider_orderEO>> GetByRecDateAsync(DateTime recDate)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">订单时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByRecDate(DateTime recDate, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, string.Empty, tm_);
		}
		public async Task<List<S_provider_orderEO>> GetByRecDateAsync(DateTime recDate, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">订单时间</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByRecDate(DateTime recDate, int top_)
		{
			return GetByRecDate(recDate, top_, string.Empty, null);
		}
		public async Task<List<S_provider_orderEO>> GetByRecDateAsync(DateTime recDate, int top_)
		{
			return await GetByRecDateAsync(recDate, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">订单时间</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByRecDate(DateTime recDate, int top_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, top_, string.Empty, tm_);
		}
		public async Task<List<S_provider_orderEO>> GetByRecDateAsync(DateTime recDate, int top_, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">订单时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByRecDate(DateTime recDate, string sort_)
		{
			return GetByRecDate(recDate, 0, sort_, null);
		}
		public async Task<List<S_provider_orderEO>> GetByRecDateAsync(DateTime recDate, string sort_)
		{
			return await GetByRecDateAsync(recDate, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">订单时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByRecDate(DateTime recDate, string sort_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, sort_, tm_);
		}
		public async Task<List<S_provider_orderEO>> GetByRecDateAsync(DateTime recDate, string sort_, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">订单时间</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByRecDate(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return Database.ExecSqlList(sql_, paras_, tm_, S_provider_orderEO.MapDataReader);
		}
		public async Task<List<S_provider_orderEO>> GetByRecDateAsync(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_provider_orderEO.MapDataReader);
		}
		#endregion // GetByRecDate
		#region GetByResponseTime
		
		/// <summary>
		/// 按 ResponseTime（字段） 查询
		/// </summary>
		/// /// <param name = "responseTime">返回时间</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByResponseTime(DateTime? responseTime)
		{
			return GetByResponseTime(responseTime, 0, string.Empty, null);
		}
		public async Task<List<S_provider_orderEO>> GetByResponseTimeAsync(DateTime? responseTime)
		{
			return await GetByResponseTimeAsync(responseTime, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ResponseTime（字段） 查询
		/// </summary>
		/// /// <param name = "responseTime">返回时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByResponseTime(DateTime? responseTime, TransactionManager tm_)
		{
			return GetByResponseTime(responseTime, 0, string.Empty, tm_);
		}
		public async Task<List<S_provider_orderEO>> GetByResponseTimeAsync(DateTime? responseTime, TransactionManager tm_)
		{
			return await GetByResponseTimeAsync(responseTime, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ResponseTime（字段） 查询
		/// </summary>
		/// /// <param name = "responseTime">返回时间</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByResponseTime(DateTime? responseTime, int top_)
		{
			return GetByResponseTime(responseTime, top_, string.Empty, null);
		}
		public async Task<List<S_provider_orderEO>> GetByResponseTimeAsync(DateTime? responseTime, int top_)
		{
			return await GetByResponseTimeAsync(responseTime, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ResponseTime（字段） 查询
		/// </summary>
		/// /// <param name = "responseTime">返回时间</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByResponseTime(DateTime? responseTime, int top_, TransactionManager tm_)
		{
			return GetByResponseTime(responseTime, top_, string.Empty, tm_);
		}
		public async Task<List<S_provider_orderEO>> GetByResponseTimeAsync(DateTime? responseTime, int top_, TransactionManager tm_)
		{
			return await GetByResponseTimeAsync(responseTime, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ResponseTime（字段） 查询
		/// </summary>
		/// /// <param name = "responseTime">返回时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByResponseTime(DateTime? responseTime, string sort_)
		{
			return GetByResponseTime(responseTime, 0, sort_, null);
		}
		public async Task<List<S_provider_orderEO>> GetByResponseTimeAsync(DateTime? responseTime, string sort_)
		{
			return await GetByResponseTimeAsync(responseTime, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 ResponseTime（字段） 查询
		/// </summary>
		/// /// <param name = "responseTime">返回时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByResponseTime(DateTime? responseTime, string sort_, TransactionManager tm_)
		{
			return GetByResponseTime(responseTime, 0, sort_, tm_);
		}
		public async Task<List<S_provider_orderEO>> GetByResponseTimeAsync(DateTime? responseTime, string sort_, TransactionManager tm_)
		{
			return await GetByResponseTimeAsync(responseTime, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 ResponseTime（字段） 查询
		/// </summary>
		/// /// <param name = "responseTime">返回时间</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByResponseTime(DateTime? responseTime, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(responseTime.HasValue ? "`ResponseTime` = @ResponseTime" : "`ResponseTime` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (responseTime.HasValue)
				paras_.Add(Database.CreateInParameter("@ResponseTime", responseTime.Value, MySqlDbType.DateTime));
			return Database.ExecSqlList(sql_, paras_, tm_, S_provider_orderEO.MapDataReader);
		}
		public async Task<List<S_provider_orderEO>> GetByResponseTimeAsync(DateTime? responseTime, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(responseTime.HasValue ? "`ResponseTime` = @ResponseTime" : "`ResponseTime` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (responseTime.HasValue)
				paras_.Add(Database.CreateInParameter("@ResponseTime", responseTime.Value, MySqlDbType.DateTime));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_provider_orderEO.MapDataReader);
		}
		#endregion // GetByResponseTime
		#region GetByResponseStatus
		
		/// <summary>
		/// 按 ResponseStatus（字段） 查询
		/// </summary>
		/// /// <param name = "responseStatus">返回状态</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByResponseStatus(string responseStatus)
		{
			return GetByResponseStatus(responseStatus, 0, string.Empty, null);
		}
		public async Task<List<S_provider_orderEO>> GetByResponseStatusAsync(string responseStatus)
		{
			return await GetByResponseStatusAsync(responseStatus, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ResponseStatus（字段） 查询
		/// </summary>
		/// /// <param name = "responseStatus">返回状态</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByResponseStatus(string responseStatus, TransactionManager tm_)
		{
			return GetByResponseStatus(responseStatus, 0, string.Empty, tm_);
		}
		public async Task<List<S_provider_orderEO>> GetByResponseStatusAsync(string responseStatus, TransactionManager tm_)
		{
			return await GetByResponseStatusAsync(responseStatus, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ResponseStatus（字段） 查询
		/// </summary>
		/// /// <param name = "responseStatus">返回状态</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByResponseStatus(string responseStatus, int top_)
		{
			return GetByResponseStatus(responseStatus, top_, string.Empty, null);
		}
		public async Task<List<S_provider_orderEO>> GetByResponseStatusAsync(string responseStatus, int top_)
		{
			return await GetByResponseStatusAsync(responseStatus, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ResponseStatus（字段） 查询
		/// </summary>
		/// /// <param name = "responseStatus">返回状态</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByResponseStatus(string responseStatus, int top_, TransactionManager tm_)
		{
			return GetByResponseStatus(responseStatus, top_, string.Empty, tm_);
		}
		public async Task<List<S_provider_orderEO>> GetByResponseStatusAsync(string responseStatus, int top_, TransactionManager tm_)
		{
			return await GetByResponseStatusAsync(responseStatus, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ResponseStatus（字段） 查询
		/// </summary>
		/// /// <param name = "responseStatus">返回状态</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByResponseStatus(string responseStatus, string sort_)
		{
			return GetByResponseStatus(responseStatus, 0, sort_, null);
		}
		public async Task<List<S_provider_orderEO>> GetByResponseStatusAsync(string responseStatus, string sort_)
		{
			return await GetByResponseStatusAsync(responseStatus, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 ResponseStatus（字段） 查询
		/// </summary>
		/// /// <param name = "responseStatus">返回状态</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByResponseStatus(string responseStatus, string sort_, TransactionManager tm_)
		{
			return GetByResponseStatus(responseStatus, 0, sort_, tm_);
		}
		public async Task<List<S_provider_orderEO>> GetByResponseStatusAsync(string responseStatus, string sort_, TransactionManager tm_)
		{
			return await GetByResponseStatusAsync(responseStatus, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 ResponseStatus（字段） 查询
		/// </summary>
		/// /// <param name = "responseStatus">返回状态</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByResponseStatus(string responseStatus, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(responseStatus != null ? "`ResponseStatus` = @ResponseStatus" : "`ResponseStatus` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (responseStatus != null)
				paras_.Add(Database.CreateInParameter("@ResponseStatus", responseStatus, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_provider_orderEO.MapDataReader);
		}
		public async Task<List<S_provider_orderEO>> GetByResponseStatusAsync(string responseStatus, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(responseStatus != null ? "`ResponseStatus` = @ResponseStatus" : "`ResponseStatus` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (responseStatus != null)
				paras_.Add(Database.CreateInParameter("@ResponseStatus", responseStatus, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_provider_orderEO.MapDataReader);
		}
		#endregion // GetByResponseStatus
		#region GetByAmount
		
		/// <summary>
		/// 按 Amount（字段） 查询
		/// </summary>
		/// /// <param name = "amount">实际账户变化数量（正负数）</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByAmount(long amount)
		{
			return GetByAmount(amount, 0, string.Empty, null);
		}
		public async Task<List<S_provider_orderEO>> GetByAmountAsync(long amount)
		{
			return await GetByAmountAsync(amount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Amount（字段） 查询
		/// </summary>
		/// /// <param name = "amount">实际账户变化数量（正负数）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByAmount(long amount, TransactionManager tm_)
		{
			return GetByAmount(amount, 0, string.Empty, tm_);
		}
		public async Task<List<S_provider_orderEO>> GetByAmountAsync(long amount, TransactionManager tm_)
		{
			return await GetByAmountAsync(amount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Amount（字段） 查询
		/// </summary>
		/// /// <param name = "amount">实际账户变化数量（正负数）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByAmount(long amount, int top_)
		{
			return GetByAmount(amount, top_, string.Empty, null);
		}
		public async Task<List<S_provider_orderEO>> GetByAmountAsync(long amount, int top_)
		{
			return await GetByAmountAsync(amount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Amount（字段） 查询
		/// </summary>
		/// /// <param name = "amount">实际账户变化数量（正负数）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByAmount(long amount, int top_, TransactionManager tm_)
		{
			return GetByAmount(amount, top_, string.Empty, tm_);
		}
		public async Task<List<S_provider_orderEO>> GetByAmountAsync(long amount, int top_, TransactionManager tm_)
		{
			return await GetByAmountAsync(amount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Amount（字段） 查询
		/// </summary>
		/// /// <param name = "amount">实际账户变化数量（正负数）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByAmount(long amount, string sort_)
		{
			return GetByAmount(amount, 0, sort_, null);
		}
		public async Task<List<S_provider_orderEO>> GetByAmountAsync(long amount, string sort_)
		{
			return await GetByAmountAsync(amount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Amount（字段） 查询
		/// </summary>
		/// /// <param name = "amount">实际账户变化数量（正负数）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByAmount(long amount, string sort_, TransactionManager tm_)
		{
			return GetByAmount(amount, 0, sort_, tm_);
		}
		public async Task<List<S_provider_orderEO>> GetByAmountAsync(long amount, string sort_, TransactionManager tm_)
		{
			return await GetByAmountAsync(amount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Amount（字段） 查询
		/// </summary>
		/// /// <param name = "amount">实际账户变化数量（正负数）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByAmount(long amount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Amount` = @Amount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Amount", amount, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, S_provider_orderEO.MapDataReader);
		}
		public async Task<List<S_provider_orderEO>> GetByAmountAsync(long amount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Amount` = @Amount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Amount", amount, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_provider_orderEO.MapDataReader);
		}
		#endregion // GetByAmount
		#region GetByEndBalance
		
		/// <summary>
		/// 按 EndBalance（字段） 查询
		/// </summary>
		/// /// <param name = "endBalance">处理后余额</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByEndBalance(long endBalance)
		{
			return GetByEndBalance(endBalance, 0, string.Empty, null);
		}
		public async Task<List<S_provider_orderEO>> GetByEndBalanceAsync(long endBalance)
		{
			return await GetByEndBalanceAsync(endBalance, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 EndBalance（字段） 查询
		/// </summary>
		/// /// <param name = "endBalance">处理后余额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByEndBalance(long endBalance, TransactionManager tm_)
		{
			return GetByEndBalance(endBalance, 0, string.Empty, tm_);
		}
		public async Task<List<S_provider_orderEO>> GetByEndBalanceAsync(long endBalance, TransactionManager tm_)
		{
			return await GetByEndBalanceAsync(endBalance, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 EndBalance（字段） 查询
		/// </summary>
		/// /// <param name = "endBalance">处理后余额</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByEndBalance(long endBalance, int top_)
		{
			return GetByEndBalance(endBalance, top_, string.Empty, null);
		}
		public async Task<List<S_provider_orderEO>> GetByEndBalanceAsync(long endBalance, int top_)
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
		public List<S_provider_orderEO> GetByEndBalance(long endBalance, int top_, TransactionManager tm_)
		{
			return GetByEndBalance(endBalance, top_, string.Empty, tm_);
		}
		public async Task<List<S_provider_orderEO>> GetByEndBalanceAsync(long endBalance, int top_, TransactionManager tm_)
		{
			return await GetByEndBalanceAsync(endBalance, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 EndBalance（字段） 查询
		/// </summary>
		/// /// <param name = "endBalance">处理后余额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByEndBalance(long endBalance, string sort_)
		{
			return GetByEndBalance(endBalance, 0, sort_, null);
		}
		public async Task<List<S_provider_orderEO>> GetByEndBalanceAsync(long endBalance, string sort_)
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
		public List<S_provider_orderEO> GetByEndBalance(long endBalance, string sort_, TransactionManager tm_)
		{
			return GetByEndBalance(endBalance, 0, sort_, tm_);
		}
		public async Task<List<S_provider_orderEO>> GetByEndBalanceAsync(long endBalance, string sort_, TransactionManager tm_)
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
		public List<S_provider_orderEO> GetByEndBalance(long endBalance, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`EndBalance` = @EndBalance", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@EndBalance", endBalance, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, S_provider_orderEO.MapDataReader);
		}
		public async Task<List<S_provider_orderEO>> GetByEndBalanceAsync(long endBalance, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`EndBalance` = @EndBalance", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@EndBalance", endBalance, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_provider_orderEO.MapDataReader);
		}
		#endregion // GetByEndBalance
		#region GetByBetBonus
		
		/// <summary>
		/// 按 BetBonus（字段） 查询
		/// </summary>
		/// /// <param name = "betBonus">下注时扣除的bonus</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByBetBonus(long betBonus)
		{
			return GetByBetBonus(betBonus, 0, string.Empty, null);
		}
		public async Task<List<S_provider_orderEO>> GetByBetBonusAsync(long betBonus)
		{
			return await GetByBetBonusAsync(betBonus, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BetBonus（字段） 查询
		/// </summary>
		/// /// <param name = "betBonus">下注时扣除的bonus</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByBetBonus(long betBonus, TransactionManager tm_)
		{
			return GetByBetBonus(betBonus, 0, string.Empty, tm_);
		}
		public async Task<List<S_provider_orderEO>> GetByBetBonusAsync(long betBonus, TransactionManager tm_)
		{
			return await GetByBetBonusAsync(betBonus, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BetBonus（字段） 查询
		/// </summary>
		/// /// <param name = "betBonus">下注时扣除的bonus</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByBetBonus(long betBonus, int top_)
		{
			return GetByBetBonus(betBonus, top_, string.Empty, null);
		}
		public async Task<List<S_provider_orderEO>> GetByBetBonusAsync(long betBonus, int top_)
		{
			return await GetByBetBonusAsync(betBonus, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BetBonus（字段） 查询
		/// </summary>
		/// /// <param name = "betBonus">下注时扣除的bonus</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByBetBonus(long betBonus, int top_, TransactionManager tm_)
		{
			return GetByBetBonus(betBonus, top_, string.Empty, tm_);
		}
		public async Task<List<S_provider_orderEO>> GetByBetBonusAsync(long betBonus, int top_, TransactionManager tm_)
		{
			return await GetByBetBonusAsync(betBonus, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BetBonus（字段） 查询
		/// </summary>
		/// /// <param name = "betBonus">下注时扣除的bonus</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByBetBonus(long betBonus, string sort_)
		{
			return GetByBetBonus(betBonus, 0, sort_, null);
		}
		public async Task<List<S_provider_orderEO>> GetByBetBonusAsync(long betBonus, string sort_)
		{
			return await GetByBetBonusAsync(betBonus, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 BetBonus（字段） 查询
		/// </summary>
		/// /// <param name = "betBonus">下注时扣除的bonus</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByBetBonus(long betBonus, string sort_, TransactionManager tm_)
		{
			return GetByBetBonus(betBonus, 0, sort_, tm_);
		}
		public async Task<List<S_provider_orderEO>> GetByBetBonusAsync(long betBonus, string sort_, TransactionManager tm_)
		{
			return await GetByBetBonusAsync(betBonus, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 BetBonus（字段） 查询
		/// </summary>
		/// /// <param name = "betBonus">下注时扣除的bonus</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByBetBonus(long betBonus, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BetBonus` = @BetBonus", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BetBonus", betBonus, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, S_provider_orderEO.MapDataReader);
		}
		public async Task<List<S_provider_orderEO>> GetByBetBonusAsync(long betBonus, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BetBonus` = @BetBonus", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BetBonus", betBonus, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_provider_orderEO.MapDataReader);
		}
		#endregion // GetByBetBonus
		#region GetByWinBonus
		
		/// <summary>
		/// 按 WinBonus（字段） 查询
		/// </summary>
		/// /// <param name = "winBonus">返奖时增加的bonus</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByWinBonus(long winBonus)
		{
			return GetByWinBonus(winBonus, 0, string.Empty, null);
		}
		public async Task<List<S_provider_orderEO>> GetByWinBonusAsync(long winBonus)
		{
			return await GetByWinBonusAsync(winBonus, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 WinBonus（字段） 查询
		/// </summary>
		/// /// <param name = "winBonus">返奖时增加的bonus</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByWinBonus(long winBonus, TransactionManager tm_)
		{
			return GetByWinBonus(winBonus, 0, string.Empty, tm_);
		}
		public async Task<List<S_provider_orderEO>> GetByWinBonusAsync(long winBonus, TransactionManager tm_)
		{
			return await GetByWinBonusAsync(winBonus, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 WinBonus（字段） 查询
		/// </summary>
		/// /// <param name = "winBonus">返奖时增加的bonus</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByWinBonus(long winBonus, int top_)
		{
			return GetByWinBonus(winBonus, top_, string.Empty, null);
		}
		public async Task<List<S_provider_orderEO>> GetByWinBonusAsync(long winBonus, int top_)
		{
			return await GetByWinBonusAsync(winBonus, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 WinBonus（字段） 查询
		/// </summary>
		/// /// <param name = "winBonus">返奖时增加的bonus</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByWinBonus(long winBonus, int top_, TransactionManager tm_)
		{
			return GetByWinBonus(winBonus, top_, string.Empty, tm_);
		}
		public async Task<List<S_provider_orderEO>> GetByWinBonusAsync(long winBonus, int top_, TransactionManager tm_)
		{
			return await GetByWinBonusAsync(winBonus, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 WinBonus（字段） 查询
		/// </summary>
		/// /// <param name = "winBonus">返奖时增加的bonus</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByWinBonus(long winBonus, string sort_)
		{
			return GetByWinBonus(winBonus, 0, sort_, null);
		}
		public async Task<List<S_provider_orderEO>> GetByWinBonusAsync(long winBonus, string sort_)
		{
			return await GetByWinBonusAsync(winBonus, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 WinBonus（字段） 查询
		/// </summary>
		/// /// <param name = "winBonus">返奖时增加的bonus</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByWinBonus(long winBonus, string sort_, TransactionManager tm_)
		{
			return GetByWinBonus(winBonus, 0, sort_, tm_);
		}
		public async Task<List<S_provider_orderEO>> GetByWinBonusAsync(long winBonus, string sort_, TransactionManager tm_)
		{
			return await GetByWinBonusAsync(winBonus, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 WinBonus（字段） 查询
		/// </summary>
		/// /// <param name = "winBonus">返奖时增加的bonus</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByWinBonus(long winBonus, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`WinBonus` = @WinBonus", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@WinBonus", winBonus, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, S_provider_orderEO.MapDataReader);
		}
		public async Task<List<S_provider_orderEO>> GetByWinBonusAsync(long winBonus, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`WinBonus` = @WinBonus", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@WinBonus", winBonus, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_provider_orderEO.MapDataReader);
		}
		#endregion // GetByWinBonus
		#region GetByEndBonus
		
		/// <summary>
		/// 按 EndBonus（字段） 查询
		/// </summary>
		/// /// <param name = "endBonus">处理后bonus余额</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByEndBonus(long endBonus)
		{
			return GetByEndBonus(endBonus, 0, string.Empty, null);
		}
		public async Task<List<S_provider_orderEO>> GetByEndBonusAsync(long endBonus)
		{
			return await GetByEndBonusAsync(endBonus, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 EndBonus（字段） 查询
		/// </summary>
		/// /// <param name = "endBonus">处理后bonus余额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByEndBonus(long endBonus, TransactionManager tm_)
		{
			return GetByEndBonus(endBonus, 0, string.Empty, tm_);
		}
		public async Task<List<S_provider_orderEO>> GetByEndBonusAsync(long endBonus, TransactionManager tm_)
		{
			return await GetByEndBonusAsync(endBonus, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 EndBonus（字段） 查询
		/// </summary>
		/// /// <param name = "endBonus">处理后bonus余额</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByEndBonus(long endBonus, int top_)
		{
			return GetByEndBonus(endBonus, top_, string.Empty, null);
		}
		public async Task<List<S_provider_orderEO>> GetByEndBonusAsync(long endBonus, int top_)
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
		public List<S_provider_orderEO> GetByEndBonus(long endBonus, int top_, TransactionManager tm_)
		{
			return GetByEndBonus(endBonus, top_, string.Empty, tm_);
		}
		public async Task<List<S_provider_orderEO>> GetByEndBonusAsync(long endBonus, int top_, TransactionManager tm_)
		{
			return await GetByEndBonusAsync(endBonus, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 EndBonus（字段） 查询
		/// </summary>
		/// /// <param name = "endBonus">处理后bonus余额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByEndBonus(long endBonus, string sort_)
		{
			return GetByEndBonus(endBonus, 0, sort_, null);
		}
		public async Task<List<S_provider_orderEO>> GetByEndBonusAsync(long endBonus, string sort_)
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
		public List<S_provider_orderEO> GetByEndBonus(long endBonus, string sort_, TransactionManager tm_)
		{
			return GetByEndBonus(endBonus, 0, sort_, tm_);
		}
		public async Task<List<S_provider_orderEO>> GetByEndBonusAsync(long endBonus, string sort_, TransactionManager tm_)
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
		public List<S_provider_orderEO> GetByEndBonus(long endBonus, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`EndBonus` = @EndBonus", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@EndBonus", endBonus, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, S_provider_orderEO.MapDataReader);
		}
		public async Task<List<S_provider_orderEO>> GetByEndBonusAsync(long endBonus, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`EndBonus` = @EndBonus", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@EndBonus", endBonus, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_provider_orderEO.MapDataReader);
		}
		#endregion // GetByEndBonus
		#region GetByAmountBonus
		
		/// <summary>
		/// 按 AmountBonus（字段） 查询
		/// </summary>
		/// /// <param name = "amountBonus">bonus实际变化数量（正负数）</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByAmountBonus(long amountBonus)
		{
			return GetByAmountBonus(amountBonus, 0, string.Empty, null);
		}
		public async Task<List<S_provider_orderEO>> GetByAmountBonusAsync(long amountBonus)
		{
			return await GetByAmountBonusAsync(amountBonus, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 AmountBonus（字段） 查询
		/// </summary>
		/// /// <param name = "amountBonus">bonus实际变化数量（正负数）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByAmountBonus(long amountBonus, TransactionManager tm_)
		{
			return GetByAmountBonus(amountBonus, 0, string.Empty, tm_);
		}
		public async Task<List<S_provider_orderEO>> GetByAmountBonusAsync(long amountBonus, TransactionManager tm_)
		{
			return await GetByAmountBonusAsync(amountBonus, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 AmountBonus（字段） 查询
		/// </summary>
		/// /// <param name = "amountBonus">bonus实际变化数量（正负数）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByAmountBonus(long amountBonus, int top_)
		{
			return GetByAmountBonus(amountBonus, top_, string.Empty, null);
		}
		public async Task<List<S_provider_orderEO>> GetByAmountBonusAsync(long amountBonus, int top_)
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
		public List<S_provider_orderEO> GetByAmountBonus(long amountBonus, int top_, TransactionManager tm_)
		{
			return GetByAmountBonus(amountBonus, top_, string.Empty, tm_);
		}
		public async Task<List<S_provider_orderEO>> GetByAmountBonusAsync(long amountBonus, int top_, TransactionManager tm_)
		{
			return await GetByAmountBonusAsync(amountBonus, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 AmountBonus（字段） 查询
		/// </summary>
		/// /// <param name = "amountBonus">bonus实际变化数量（正负数）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetByAmountBonus(long amountBonus, string sort_)
		{
			return GetByAmountBonus(amountBonus, 0, sort_, null);
		}
		public async Task<List<S_provider_orderEO>> GetByAmountBonusAsync(long amountBonus, string sort_)
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
		public List<S_provider_orderEO> GetByAmountBonus(long amountBonus, string sort_, TransactionManager tm_)
		{
			return GetByAmountBonus(amountBonus, 0, sort_, tm_);
		}
		public async Task<List<S_provider_orderEO>> GetByAmountBonusAsync(long amountBonus, string sort_, TransactionManager tm_)
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
		public List<S_provider_orderEO> GetByAmountBonus(long amountBonus, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`AmountBonus` = @AmountBonus", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@AmountBonus", amountBonus, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, S_provider_orderEO.MapDataReader);
		}
		public async Task<List<S_provider_orderEO>> GetByAmountBonusAsync(long amountBonus, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`AmountBonus` = @AmountBonus", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@AmountBonus", amountBonus, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_provider_orderEO.MapDataReader);
		}
		#endregion // GetByAmountBonus
		#region GetBySettlTable
		
		/// <summary>
		/// 按 SettlTable（字段） 查询
		/// </summary>
		/// /// <param name = "settlTable">结算表名</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetBySettlTable(string settlTable)
		{
			return GetBySettlTable(settlTable, 0, string.Empty, null);
		}
		public async Task<List<S_provider_orderEO>> GetBySettlTableAsync(string settlTable)
		{
			return await GetBySettlTableAsync(settlTable, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 SettlTable（字段） 查询
		/// </summary>
		/// /// <param name = "settlTable">结算表名</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetBySettlTable(string settlTable, TransactionManager tm_)
		{
			return GetBySettlTable(settlTable, 0, string.Empty, tm_);
		}
		public async Task<List<S_provider_orderEO>> GetBySettlTableAsync(string settlTable, TransactionManager tm_)
		{
			return await GetBySettlTableAsync(settlTable, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SettlTable（字段） 查询
		/// </summary>
		/// /// <param name = "settlTable">结算表名</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetBySettlTable(string settlTable, int top_)
		{
			return GetBySettlTable(settlTable, top_, string.Empty, null);
		}
		public async Task<List<S_provider_orderEO>> GetBySettlTableAsync(string settlTable, int top_)
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
		public List<S_provider_orderEO> GetBySettlTable(string settlTable, int top_, TransactionManager tm_)
		{
			return GetBySettlTable(settlTable, top_, string.Empty, tm_);
		}
		public async Task<List<S_provider_orderEO>> GetBySettlTableAsync(string settlTable, int top_, TransactionManager tm_)
		{
			return await GetBySettlTableAsync(settlTable, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SettlTable（字段） 查询
		/// </summary>
		/// /// <param name = "settlTable">结算表名</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetBySettlTable(string settlTable, string sort_)
		{
			return GetBySettlTable(settlTable, 0, sort_, null);
		}
		public async Task<List<S_provider_orderEO>> GetBySettlTableAsync(string settlTable, string sort_)
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
		public List<S_provider_orderEO> GetBySettlTable(string settlTable, string sort_, TransactionManager tm_)
		{
			return GetBySettlTable(settlTable, 0, sort_, tm_);
		}
		public async Task<List<S_provider_orderEO>> GetBySettlTableAsync(string settlTable, string sort_, TransactionManager tm_)
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
		public List<S_provider_orderEO> GetBySettlTable(string settlTable, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(settlTable != null ? "`SettlTable` = @SettlTable" : "`SettlTable` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (settlTable != null)
				paras_.Add(Database.CreateInParameter("@SettlTable", settlTable, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_provider_orderEO.MapDataReader);
		}
		public async Task<List<S_provider_orderEO>> GetBySettlTableAsync(string settlTable, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(settlTable != null ? "`SettlTable` = @SettlTable" : "`SettlTable` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (settlTable != null)
				paras_.Add(Database.CreateInParameter("@SettlTable", settlTable, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_provider_orderEO.MapDataReader);
		}
		#endregion // GetBySettlTable
		#region GetBySettlId
		
		/// <summary>
		/// 按 SettlId（字段） 查询
		/// </summary>
		/// /// <param name = "settlId">结算编码</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetBySettlId(string settlId)
		{
			return GetBySettlId(settlId, 0, string.Empty, null);
		}
		public async Task<List<S_provider_orderEO>> GetBySettlIdAsync(string settlId)
		{
			return await GetBySettlIdAsync(settlId, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 SettlId（字段） 查询
		/// </summary>
		/// /// <param name = "settlId">结算编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetBySettlId(string settlId, TransactionManager tm_)
		{
			return GetBySettlId(settlId, 0, string.Empty, tm_);
		}
		public async Task<List<S_provider_orderEO>> GetBySettlIdAsync(string settlId, TransactionManager tm_)
		{
			return await GetBySettlIdAsync(settlId, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SettlId（字段） 查询
		/// </summary>
		/// /// <param name = "settlId">结算编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetBySettlId(string settlId, int top_)
		{
			return GetBySettlId(settlId, top_, string.Empty, null);
		}
		public async Task<List<S_provider_orderEO>> GetBySettlIdAsync(string settlId, int top_)
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
		public List<S_provider_orderEO> GetBySettlId(string settlId, int top_, TransactionManager tm_)
		{
			return GetBySettlId(settlId, top_, string.Empty, tm_);
		}
		public async Task<List<S_provider_orderEO>> GetBySettlIdAsync(string settlId, int top_, TransactionManager tm_)
		{
			return await GetBySettlIdAsync(settlId, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SettlId（字段） 查询
		/// </summary>
		/// /// <param name = "settlId">结算编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetBySettlId(string settlId, string sort_)
		{
			return GetBySettlId(settlId, 0, sort_, null);
		}
		public async Task<List<S_provider_orderEO>> GetBySettlIdAsync(string settlId, string sort_)
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
		public List<S_provider_orderEO> GetBySettlId(string settlId, string sort_, TransactionManager tm_)
		{
			return GetBySettlId(settlId, 0, sort_, tm_);
		}
		public async Task<List<S_provider_orderEO>> GetBySettlIdAsync(string settlId, string sort_, TransactionManager tm_)
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
		public List<S_provider_orderEO> GetBySettlId(string settlId, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(settlId != null ? "`SettlId` = @SettlId" : "`SettlId` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (settlId != null)
				paras_.Add(Database.CreateInParameter("@SettlId", settlId, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_provider_orderEO.MapDataReader);
		}
		public async Task<List<S_provider_orderEO>> GetBySettlIdAsync(string settlId, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(settlId != null ? "`SettlId` = @SettlId" : "`SettlId` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (settlId != null)
				paras_.Add(Database.CreateInParameter("@SettlId", settlId, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_provider_orderEO.MapDataReader);
		}
		#endregion // GetBySettlId
		#region GetBySettlAmount
		
		/// <summary>
		/// 按 SettlAmount（字段） 查询
		/// </summary>
		/// /// <param name = "settlAmount">结算金额(正负数)</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetBySettlAmount(long settlAmount)
		{
			return GetBySettlAmount(settlAmount, 0, string.Empty, null);
		}
		public async Task<List<S_provider_orderEO>> GetBySettlAmountAsync(long settlAmount)
		{
			return await GetBySettlAmountAsync(settlAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 SettlAmount（字段） 查询
		/// </summary>
		/// /// <param name = "settlAmount">结算金额(正负数)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetBySettlAmount(long settlAmount, TransactionManager tm_)
		{
			return GetBySettlAmount(settlAmount, 0, string.Empty, tm_);
		}
		public async Task<List<S_provider_orderEO>> GetBySettlAmountAsync(long settlAmount, TransactionManager tm_)
		{
			return await GetBySettlAmountAsync(settlAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SettlAmount（字段） 查询
		/// </summary>
		/// /// <param name = "settlAmount">结算金额(正负数)</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetBySettlAmount(long settlAmount, int top_)
		{
			return GetBySettlAmount(settlAmount, top_, string.Empty, null);
		}
		public async Task<List<S_provider_orderEO>> GetBySettlAmountAsync(long settlAmount, int top_)
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
		public List<S_provider_orderEO> GetBySettlAmount(long settlAmount, int top_, TransactionManager tm_)
		{
			return GetBySettlAmount(settlAmount, top_, string.Empty, tm_);
		}
		public async Task<List<S_provider_orderEO>> GetBySettlAmountAsync(long settlAmount, int top_, TransactionManager tm_)
		{
			return await GetBySettlAmountAsync(settlAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SettlAmount（字段） 查询
		/// </summary>
		/// /// <param name = "settlAmount">结算金额(正负数)</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetBySettlAmount(long settlAmount, string sort_)
		{
			return GetBySettlAmount(settlAmount, 0, sort_, null);
		}
		public async Task<List<S_provider_orderEO>> GetBySettlAmountAsync(long settlAmount, string sort_)
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
		public List<S_provider_orderEO> GetBySettlAmount(long settlAmount, string sort_, TransactionManager tm_)
		{
			return GetBySettlAmount(settlAmount, 0, sort_, tm_);
		}
		public async Task<List<S_provider_orderEO>> GetBySettlAmountAsync(long settlAmount, string sort_, TransactionManager tm_)
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
		public List<S_provider_orderEO> GetBySettlAmount(long settlAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`SettlAmount` = @SettlAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@SettlAmount", settlAmount, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, S_provider_orderEO.MapDataReader);
		}
		public async Task<List<S_provider_orderEO>> GetBySettlAmountAsync(long settlAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`SettlAmount` = @SettlAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@SettlAmount", settlAmount, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_provider_orderEO.MapDataReader);
		}
		#endregion // GetBySettlAmount
		#region GetBySettlStatus
		
		/// <summary>
		/// 按 SettlStatus（字段） 查询
		/// </summary>
		/// /// <param name = "settlStatus">结算状态（0-未结算1-已结算）</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetBySettlStatus(int settlStatus)
		{
			return GetBySettlStatus(settlStatus, 0, string.Empty, null);
		}
		public async Task<List<S_provider_orderEO>> GetBySettlStatusAsync(int settlStatus)
		{
			return await GetBySettlStatusAsync(settlStatus, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 SettlStatus（字段） 查询
		/// </summary>
		/// /// <param name = "settlStatus">结算状态（0-未结算1-已结算）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetBySettlStatus(int settlStatus, TransactionManager tm_)
		{
			return GetBySettlStatus(settlStatus, 0, string.Empty, tm_);
		}
		public async Task<List<S_provider_orderEO>> GetBySettlStatusAsync(int settlStatus, TransactionManager tm_)
		{
			return await GetBySettlStatusAsync(settlStatus, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SettlStatus（字段） 查询
		/// </summary>
		/// /// <param name = "settlStatus">结算状态（0-未结算1-已结算）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetBySettlStatus(int settlStatus, int top_)
		{
			return GetBySettlStatus(settlStatus, top_, string.Empty, null);
		}
		public async Task<List<S_provider_orderEO>> GetBySettlStatusAsync(int settlStatus, int top_)
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
		public List<S_provider_orderEO> GetBySettlStatus(int settlStatus, int top_, TransactionManager tm_)
		{
			return GetBySettlStatus(settlStatus, top_, string.Empty, tm_);
		}
		public async Task<List<S_provider_orderEO>> GetBySettlStatusAsync(int settlStatus, int top_, TransactionManager tm_)
		{
			return await GetBySettlStatusAsync(settlStatus, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SettlStatus（字段） 查询
		/// </summary>
		/// /// <param name = "settlStatus">结算状态（0-未结算1-已结算）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_provider_orderEO> GetBySettlStatus(int settlStatus, string sort_)
		{
			return GetBySettlStatus(settlStatus, 0, sort_, null);
		}
		public async Task<List<S_provider_orderEO>> GetBySettlStatusAsync(int settlStatus, string sort_)
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
		public List<S_provider_orderEO> GetBySettlStatus(int settlStatus, string sort_, TransactionManager tm_)
		{
			return GetBySettlStatus(settlStatus, 0, sort_, tm_);
		}
		public async Task<List<S_provider_orderEO>> GetBySettlStatusAsync(int settlStatus, string sort_, TransactionManager tm_)
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
		public List<S_provider_orderEO> GetBySettlStatus(int settlStatus, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`SettlStatus` = @SettlStatus", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@SettlStatus", settlStatus, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, S_provider_orderEO.MapDataReader);
		}
		public async Task<List<S_provider_orderEO>> GetBySettlStatusAsync(int settlStatus, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`SettlStatus` = @SettlStatus", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@SettlStatus", settlStatus, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_provider_orderEO.MapDataReader);
		}
		#endregion // GetBySettlStatus
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}

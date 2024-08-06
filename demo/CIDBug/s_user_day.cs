/******************************************************
 * 此代码由代码生成器工具自动生成，请不要修改
 * TinyFx代码生成器核心库版本号：1.0.0.0
 * git: https://github.com/jh98net/TinyFx
 * 文档生成时间：2023-12-29 15: 09:50
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
	/// 用户每天统计
	/// 【表 s_user_day 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class S_user_dayEO : IRowMapper<S_user_dayEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public S_user_dayEO()
		{
			this.FromMode = 0;
			this.UserKind = 0;
			this.IsNew = false;
			this.IsLogin = false;
			this.IsRegister = false;
			this.IsNewBet = false;
			this.HasBet = false;
			this.IsNewPay = false;
			this.HasPay = false;
			this.IsNewCash = false;
			this.HasCash = false;
			this.TotalBonus = 0;
			this.TotalBonusCount = 0;
			this.TotalBetBonus = 0;
			this.TotalWinBonus = 0;
			this.TotalChangeAmount = 0;
			this.TotalChangeCount = 0;
			this.TotalBetAmount = 0;
			this.TotalBetCount = 0;
			this.TotalWinAmount = 0;
			this.TotalWinCount = 0;
			this.TotalPayAmount = 0;
			this.TotalPayCount = 0;
			this.TotalCashAmount = 0;
			this.TotalCashCount = 0;
			this.RecDate = DateTime.Now;
		}
		#region 主键原始值 & 主键集合
	    
		/// <summary>
		/// 当前对象是否保存原始主键值，当修改了主键值时为 true
		/// </summary>
		public bool HasOriginal { get; protected set; }
		
		private DateTime _originalDayID;
		/// <summary>
		/// 【数据库中的原始主键 DayID 值的副本，用于主键值更新】
		/// </summary>
		public DateTime OriginalDayID
		{
			get { return _originalDayID; }
			set { HasOriginal = true; _originalDayID = value; }
		}
		
		private string _originalUserID;
		/// <summary>
		/// 【数据库中的原始主键 UserID 值的副本，用于主键值更新】
		/// </summary>
		public string OriginalUserID
		{
			get { return _originalUserID; }
			set { HasOriginal = true; _originalUserID = value; }
		}
	    /// <summary>
	    /// 获取主键集合。key: 数据库字段名称, value: 主键值
	    /// </summary>
	    /// <returns></returns>
	    public Dictionary<string, object> GetPrimaryKeys()
	    {
	        return new Dictionary<string, object>() { { "DayID", DayID },  { "UserID", UserID }, };
	    }
	    /// <summary>
	    /// 获取主键集合JSON格式
	    /// </summary>
	    /// <returns></returns>
	    public string GetPrimaryKeysJson() => SerializerUtil.SerializeJson(GetPrimaryKeys());
		#endregion // 主键原始值
		#region 所有字段
		/// <summary>
		/// 统计日
		/// 【主键 date】
		/// </summary>
		[DataMember(Order = 1)]
		public DateTime DayID { get; set; }
		/// <summary>
		/// 用户编码(GUID)
		/// 【主键 varchar(38)】
		/// </summary>
		[DataMember(Order = 2)]
		public string UserID { get; set; }
		/// <summary>
		/// 新用户来源方式
		///              0-获得运营商的新用户(s_operator)
		///              1-推广员获得的新用户（userid）
		///              2-推广渠道通过url获得的新用户（s_channel_url)
		///              3-推广渠道通过code获得的新用户（s_channel_code)
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 3)]
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
		[DataMember(Order = 4)]
		public string FromId { get; set; }
		/// <summary>
		/// 用户类型
		///              0-未知
		///              1-普通用户
		///              2-开发用户
		///              3-线上测试用户（调用第三方扣减）
		///              4-线上测试用户（不调用第三方扣减）
		///              5-仿真用户
		///              6-接口联调用户
		///              9-管理员
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 5)]
		public int UserKind { get; set; }
		/// <summary>
		/// 运营商编码
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 6)]
		public string OperatorID { get; set; }
		/// <summary>
		/// 国家编码ISO 3166-1三位字母
		/// 【字段 varchar(5)】
		/// </summary>
		[DataMember(Order = 7)]
		public string CountryID { get; set; }
		/// <summary>
		/// 货币类型
		/// 【字段 varchar(5)】
		/// </summary>
		[DataMember(Order = 8)]
		public string CurrencyID { get; set; }
		/// <summary>
		/// 是否新用户
		/// 【字段 tinyint(1)】
		/// </summary>
		[DataMember(Order = 9)]
		public bool IsNew { get; set; }
		/// <summary>
		/// 当天是否登录
		/// 【字段 tinyint(1)】
		/// </summary>
		[DataMember(Order = 10)]
		public bool IsLogin { get; set; }
		/// <summary>
		/// 连续登录天数
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 11)]
		public int LoginDays { get; set; }
		/// <summary>
		/// 上次登录时间
		/// 【字段 datetime】
		/// </summary>
		[DataMember(Order = 12)]
		public DateTime? LastLoginTime { get; set; }
		/// <summary>
		/// 当天是否进行了注册
		/// 【字段 tinyint(1)】
		/// </summary>
		[DataMember(Order = 13)]
		public bool IsRegister { get; set; }
		/// <summary>
		/// 注册时间
		/// 【字段 datetime】
		/// </summary>
		[DataMember(Order = 14)]
		public DateTime? RegistDate { get; set; }
		/// <summary>
		/// 是否是第一次下注用户
		/// 【字段 tinyint(1)】
		/// </summary>
		[DataMember(Order = 15)]
		public bool IsNewBet { get; set; }
		/// <summary>
		/// 当天是否下注
		/// 【字段 tinyint(1)】
		/// </summary>
		[DataMember(Order = 16)]
		public bool HasBet { get; set; }
		/// <summary>
		/// 是否是第一次充值用户
		/// 【字段 tinyint(1)】
		/// </summary>
		[DataMember(Order = 17)]
		public bool IsNewPay { get; set; }
		/// <summary>
		/// 当天是否充值
		/// 【字段 tinyint(1)】
		/// </summary>
		[DataMember(Order = 18)]
		public bool HasPay { get; set; }
		/// <summary>
		/// 是否第一次体现用户
		/// 【字段 tinyint(1)】
		/// </summary>
		[DataMember(Order = 19)]
		public bool IsNewCash { get; set; }
		/// <summary>
		/// 当天是否有提现行为
		/// 【字段 tinyint(1)】
		/// </summary>
		[DataMember(Order = 20)]
		public bool HasCash { get; set; }
		/// <summary>
		/// 赠金总额
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 21)]
		public long TotalBonus { get; set; }
		/// <summary>
		/// 赠金次数
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 22)]
		public int TotalBonusCount { get; set; }
		/// <summary>
		/// 下注时扣除的bonus总额
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 23)]
		public long TotalBetBonus { get; set; }
		/// <summary>
		/// 返奖时增加的bonus总额
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 24)]
		public long TotalWinBonus { get; set; }
		/// <summary>
		/// 变化总额
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 25)]
		public long TotalChangeAmount { get; set; }
		/// <summary>
		/// 变化次数
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 26)]
		public int TotalChangeCount { get; set; }
		/// <summary>
		/// 下注总额
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 27)]
		public long TotalBetAmount { get; set; }
		/// <summary>
		/// 下注次数
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 28)]
		public int TotalBetCount { get; set; }
		/// <summary>
		/// 返奖总额
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 29)]
		public long TotalWinAmount { get; set; }
		/// <summary>
		/// 返奖次数
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 30)]
		public int TotalWinCount { get; set; }
		/// <summary>
		/// 充值总额
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 31)]
		public long TotalPayAmount { get; set; }
		/// <summary>
		/// 充值次数
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 32)]
		public int TotalPayCount { get; set; }
		/// <summary>
		/// 提现总额
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 33)]
		public long TotalCashAmount { get; set; }
		/// <summary>
		/// 提现次数
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 34)]
		public int TotalCashCount { get; set; }
		/// <summary>
		/// 用户IP
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 35)]
		public string UserIp { get; set; }
		/// <summary>
		/// 记录时间
		/// 【字段 datetime】
		/// </summary>
		[DataMember(Order = 36)]
		public DateTime RecDate { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public S_user_dayEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static S_user_dayEO MapDataReader(IDataReader reader)
		{
		    S_user_dayEO ret = new S_user_dayEO();
			ret.DayID = reader.ToDateTime("DayID");
			ret.OriginalDayID = ret.DayID;
			ret.UserID = reader.ToString("UserID");
			ret.OriginalUserID = ret.UserID;
			ret.FromMode = reader.ToInt32("FromMode");
			ret.FromId = reader.ToString("FromId");
			ret.UserKind = reader.ToInt32("UserKind");
			ret.OperatorID = reader.ToString("OperatorID");
			ret.CountryID = reader.ToString("CountryID");
			ret.CurrencyID = reader.ToString("CurrencyID");
			ret.IsNew = reader.ToBoolean("IsNew");
			ret.IsLogin = reader.ToBoolean("IsLogin");
			ret.LoginDays = reader.ToInt32("LoginDays");
			ret.LastLoginTime = reader.ToDateTimeN("LastLoginTime");
			ret.IsRegister = reader.ToBoolean("IsRegister");
			ret.RegistDate = reader.ToDateTimeN("RegistDate");
			ret.IsNewBet = reader.ToBoolean("IsNewBet");
			ret.HasBet = reader.ToBoolean("HasBet");
			ret.IsNewPay = reader.ToBoolean("IsNewPay");
			ret.HasPay = reader.ToBoolean("HasPay");
			ret.IsNewCash = reader.ToBoolean("IsNewCash");
			ret.HasCash = reader.ToBoolean("HasCash");
			ret.TotalBonus = reader.ToInt64("TotalBonus");
			ret.TotalBonusCount = reader.ToInt32("TotalBonusCount");
			ret.TotalBetBonus = reader.ToInt64("TotalBetBonus");
			ret.TotalWinBonus = reader.ToInt64("TotalWinBonus");
			ret.TotalChangeAmount = reader.ToInt64("TotalChangeAmount");
			ret.TotalChangeCount = reader.ToInt32("TotalChangeCount");
			ret.TotalBetAmount = reader.ToInt64("TotalBetAmount");
			ret.TotalBetCount = reader.ToInt32("TotalBetCount");
			ret.TotalWinAmount = reader.ToInt64("TotalWinAmount");
			ret.TotalWinCount = reader.ToInt32("TotalWinCount");
			ret.TotalPayAmount = reader.ToInt64("TotalPayAmount");
			ret.TotalPayCount = reader.ToInt32("TotalPayCount");
			ret.TotalCashAmount = reader.ToInt64("TotalCashAmount");
			ret.TotalCashCount = reader.ToInt32("TotalCashCount");
			ret.UserIp = reader.ToString("UserIp");
			ret.RecDate = reader.ToDateTime("RecDate");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 用户每天统计
	/// 【表 s_user_day 的操作类】
	/// </summary>
	[Obsolete]
	public class S_user_dayMO : MySqlTableMO<S_user_dayEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`s_user_day`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public S_user_dayMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public S_user_dayMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public S_user_dayMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(S_user_dayEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(S_user_dayEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(S_user_dayEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`DayID`, `UserID`, `FromMode`, `FromId`, `UserKind`, `OperatorID`, `CountryID`, `CurrencyID`, `IsNew`, `IsLogin`, `LoginDays`, `LastLoginTime`, `IsRegister`, `RegistDate`, `IsNewBet`, `HasBet`, `IsNewPay`, `HasPay`, `IsNewCash`, `HasCash`, `TotalBonus`, `TotalBonusCount`, `TotalBetBonus`, `TotalWinBonus`, `TotalChangeAmount`, `TotalChangeCount`, `TotalBetAmount`, `TotalBetCount`, `TotalWinAmount`, `TotalWinCount`, `TotalPayAmount`, `TotalPayCount`, `TotalCashAmount`, `TotalCashCount`, `UserIp`, `RecDate`) VALUE (@DayID, @UserID, @FromMode, @FromId, @UserKind, @OperatorID, @CountryID, @CurrencyID, @IsNew, @IsLogin, @LoginDays, @LastLoginTime, @IsRegister, @RegistDate, @IsNewBet, @HasBet, @IsNewPay, @HasPay, @IsNewCash, @HasCash, @TotalBonus, @TotalBonusCount, @TotalBetBonus, @TotalWinBonus, @TotalChangeAmount, @TotalChangeCount, @TotalBetAmount, @TotalBetCount, @TotalWinAmount, @TotalWinCount, @TotalPayAmount, @TotalPayCount, @TotalCashAmount, @TotalCashCount, @UserIp, @RecDate);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", item.DayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", item.UserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@FromMode", item.FromMode, MySqlDbType.Int32),
				Database.CreateInParameter("@FromId", item.FromId != null ? item.FromId : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserKind", item.UserKind, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", item.OperatorID != null ? item.OperatorID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryID", item.CountryID != null ? item.CountryID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", item.CurrencyID != null ? item.CurrencyID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@IsNew", item.IsNew, MySqlDbType.Byte),
				Database.CreateInParameter("@IsLogin", item.IsLogin, MySqlDbType.Byte),
				Database.CreateInParameter("@LoginDays", item.LoginDays, MySqlDbType.Int32),
				Database.CreateInParameter("@LastLoginTime", item.LastLoginTime.HasValue ? item.LastLoginTime.Value : (object)DBNull.Value, MySqlDbType.DateTime),
				Database.CreateInParameter("@IsRegister", item.IsRegister, MySqlDbType.Byte),
				Database.CreateInParameter("@RegistDate", item.RegistDate.HasValue ? item.RegistDate.Value : (object)DBNull.Value, MySqlDbType.DateTime),
				Database.CreateInParameter("@IsNewBet", item.IsNewBet, MySqlDbType.Byte),
				Database.CreateInParameter("@HasBet", item.HasBet, MySqlDbType.Byte),
				Database.CreateInParameter("@IsNewPay", item.IsNewPay, MySqlDbType.Byte),
				Database.CreateInParameter("@HasPay", item.HasPay, MySqlDbType.Byte),
				Database.CreateInParameter("@IsNewCash", item.IsNewCash, MySqlDbType.Byte),
				Database.CreateInParameter("@HasCash", item.HasCash, MySqlDbType.Byte),
				Database.CreateInParameter("@TotalBonus", item.TotalBonus, MySqlDbType.Int64),
				Database.CreateInParameter("@TotalBonusCount", item.TotalBonusCount, MySqlDbType.Int32),
				Database.CreateInParameter("@TotalBetBonus", item.TotalBetBonus, MySqlDbType.Int64),
				Database.CreateInParameter("@TotalWinBonus", item.TotalWinBonus, MySqlDbType.Int64),
				Database.CreateInParameter("@TotalChangeAmount", item.TotalChangeAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@TotalChangeCount", item.TotalChangeCount, MySqlDbType.Int32),
				Database.CreateInParameter("@TotalBetAmount", item.TotalBetAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@TotalBetCount", item.TotalBetCount, MySqlDbType.Int32),
				Database.CreateInParameter("@TotalWinAmount", item.TotalWinAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@TotalWinCount", item.TotalWinCount, MySqlDbType.Int32),
				Database.CreateInParameter("@TotalPayAmount", item.TotalPayAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@TotalPayCount", item.TotalPayCount, MySqlDbType.Int32),
				Database.CreateInParameter("@TotalCashAmount", item.TotalCashAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@TotalCashCount", item.TotalCashCount, MySqlDbType.Int32),
				Database.CreateInParameter("@UserIp", item.UserIp != null ? item.UserIp : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@RecDate", item.RecDate, MySqlDbType.DateTime),
			};
		}
		public int AddByBatch(IEnumerable<S_user_dayEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<S_user_dayEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<S_user_dayEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`DayID`, `UserID`, `FromMode`, `FromId`, `UserKind`, `OperatorID`, `CountryID`, `CurrencyID`, `IsNew`, `IsLogin`, `LoginDays`, `LastLoginTime`, `IsRegister`, `RegistDate`, `IsNewBet`, `HasBet`, `IsNewPay`, `HasPay`, `IsNewCash`, `HasCash`, `TotalBonus`, `TotalBonusCount`, `TotalBetBonus`, `TotalWinBonus`, `TotalChangeAmount`, `TotalChangeCount`, `TotalBetAmount`, `TotalBetCount`, `TotalWinAmount`, `TotalWinCount`, `TotalPayAmount`, `TotalPayCount`, `TotalCashAmount`, `TotalCashCount`, `UserIp`, `RecDate`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"('{item.DayID.ToString("yyyy-MM-dd HH:mm:ss")}','{item.UserID}',{item.FromMode},'{item.FromId}',{item.UserKind},'{item.OperatorID}','{item.CountryID}','{item.CurrencyID}',{item.IsNew},{item.IsLogin},{item.LoginDays},'{item.LastLoginTime?.ToString("yyyy-MM-dd HH:mm:ss")}',{item.IsRegister},'{item.RegistDate?.ToString("yyyy-MM-dd HH:mm:ss")}',{item.IsNewBet},{item.HasBet},{item.IsNewPay},{item.HasPay},{item.IsNewCash},{item.HasCash},{item.TotalBonus},{item.TotalBonusCount},{item.TotalBetBonus},{item.TotalWinBonus},{item.TotalChangeAmount},{item.TotalChangeCount},{item.TotalBetAmount},{item.TotalBetCount},{item.TotalWinAmount},{item.TotalWinCount},{item.TotalPayAmount},{item.TotalPayCount},{item.TotalCashAmount},{item.TotalCashCount},'{item.UserIp}','{item.RecDate.ToString("yyyy-MM-dd HH:mm:ss")}'),");
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
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(dayID, userID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(dayID, userID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(DateTime dayID, string userID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `DayID` = @DayID AND `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(S_user_dayEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.DayID, item.UserID, tm_);
		}
		public async Task<int> RemoveAsync(S_user_dayEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.DayID, item.UserID, tm_);
		}
		#endregion // RemoveByPK
		
		#region RemoveByXXX
		#region RemoveByDayID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByDayID(DateTime dayID, TransactionManager tm_ = null)
		{
			RepairRemoveByDayIDData(dayID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByDayIDAsync(DateTime dayID, TransactionManager tm_ = null)
		{
			RepairRemoveByDayIDData(dayID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByDayIDData(DateTime dayID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `DayID` = @DayID";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date));
		}
		#endregion // RemoveByDayID
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
			sql_ = $"DELETE FROM {TableName} WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>();
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
		/// /// <param name = "currencyID">货币类型</param>
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
		#region RemoveByIsNew
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "isNew">是否新用户</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByIsNew(bool isNew, TransactionManager tm_ = null)
		{
			RepairRemoveByIsNewData(isNew, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByIsNewAsync(bool isNew, TransactionManager tm_ = null)
		{
			RepairRemoveByIsNewData(isNew, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByIsNewData(bool isNew, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `IsNew` = @IsNew";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IsNew", isNew, MySqlDbType.Byte));
		}
		#endregion // RemoveByIsNew
		#region RemoveByIsLogin
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "isLogin">当天是否登录</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByIsLogin(bool isLogin, TransactionManager tm_ = null)
		{
			RepairRemoveByIsLoginData(isLogin, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByIsLoginAsync(bool isLogin, TransactionManager tm_ = null)
		{
			RepairRemoveByIsLoginData(isLogin, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByIsLoginData(bool isLogin, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `IsLogin` = @IsLogin";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IsLogin", isLogin, MySqlDbType.Byte));
		}
		#endregion // RemoveByIsLogin
		#region RemoveByLoginDays
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "loginDays">连续登录天数</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByLoginDays(int loginDays, TransactionManager tm_ = null)
		{
			RepairRemoveByLoginDaysData(loginDays, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByLoginDaysAsync(int loginDays, TransactionManager tm_ = null)
		{
			RepairRemoveByLoginDaysData(loginDays, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByLoginDaysData(int loginDays, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `LoginDays` = @LoginDays";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@LoginDays", loginDays, MySqlDbType.Int32));
		}
		#endregion // RemoveByLoginDays
		#region RemoveByLastLoginTime
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "lastLoginTime">上次登录时间</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByLastLoginTime(DateTime? lastLoginTime, TransactionManager tm_ = null)
		{
			RepairRemoveByLastLoginTimeData(lastLoginTime.Value, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByLastLoginTimeAsync(DateTime? lastLoginTime, TransactionManager tm_ = null)
		{
			RepairRemoveByLastLoginTimeData(lastLoginTime.Value, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByLastLoginTimeData(DateTime? lastLoginTime, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (lastLoginTime.HasValue ? "`LastLoginTime` = @LastLoginTime" : "`LastLoginTime` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (lastLoginTime.HasValue)
				paras_.Add(Database.CreateInParameter("@LastLoginTime", lastLoginTime.Value, MySqlDbType.DateTime));
		}
		#endregion // RemoveByLastLoginTime
		#region RemoveByIsRegister
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "isRegister">当天是否进行了注册</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByIsRegister(bool isRegister, TransactionManager tm_ = null)
		{
			RepairRemoveByIsRegisterData(isRegister, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByIsRegisterAsync(bool isRegister, TransactionManager tm_ = null)
		{
			RepairRemoveByIsRegisterData(isRegister, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByIsRegisterData(bool isRegister, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `IsRegister` = @IsRegister";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IsRegister", isRegister, MySqlDbType.Byte));
		}
		#endregion // RemoveByIsRegister
		#region RemoveByRegistDate
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "registDate">注册时间</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByRegistDate(DateTime? registDate, TransactionManager tm_ = null)
		{
			RepairRemoveByRegistDateData(registDate.Value, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByRegistDateAsync(DateTime? registDate, TransactionManager tm_ = null)
		{
			RepairRemoveByRegistDateData(registDate.Value, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByRegistDateData(DateTime? registDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (registDate.HasValue ? "`RegistDate` = @RegistDate" : "`RegistDate` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (registDate.HasValue)
				paras_.Add(Database.CreateInParameter("@RegistDate", registDate.Value, MySqlDbType.DateTime));
		}
		#endregion // RemoveByRegistDate
		#region RemoveByIsNewBet
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "isNewBet">是否是第一次下注用户</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByIsNewBet(bool isNewBet, TransactionManager tm_ = null)
		{
			RepairRemoveByIsNewBetData(isNewBet, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByIsNewBetAsync(bool isNewBet, TransactionManager tm_ = null)
		{
			RepairRemoveByIsNewBetData(isNewBet, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByIsNewBetData(bool isNewBet, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `IsNewBet` = @IsNewBet";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IsNewBet", isNewBet, MySqlDbType.Byte));
		}
		#endregion // RemoveByIsNewBet
		#region RemoveByHasBet
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "hasBet">当天是否下注</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByHasBet(bool hasBet, TransactionManager tm_ = null)
		{
			RepairRemoveByHasBetData(hasBet, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByHasBetAsync(bool hasBet, TransactionManager tm_ = null)
		{
			RepairRemoveByHasBetData(hasBet, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByHasBetData(bool hasBet, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `HasBet` = @HasBet";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@HasBet", hasBet, MySqlDbType.Byte));
		}
		#endregion // RemoveByHasBet
		#region RemoveByIsNewPay
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "isNewPay">是否是第一次充值用户</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByIsNewPay(bool isNewPay, TransactionManager tm_ = null)
		{
			RepairRemoveByIsNewPayData(isNewPay, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByIsNewPayAsync(bool isNewPay, TransactionManager tm_ = null)
		{
			RepairRemoveByIsNewPayData(isNewPay, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByIsNewPayData(bool isNewPay, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `IsNewPay` = @IsNewPay";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IsNewPay", isNewPay, MySqlDbType.Byte));
		}
		#endregion // RemoveByIsNewPay
		#region RemoveByHasPay
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "hasPay">当天是否充值</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByHasPay(bool hasPay, TransactionManager tm_ = null)
		{
			RepairRemoveByHasPayData(hasPay, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByHasPayAsync(bool hasPay, TransactionManager tm_ = null)
		{
			RepairRemoveByHasPayData(hasPay, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByHasPayData(bool hasPay, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `HasPay` = @HasPay";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@HasPay", hasPay, MySqlDbType.Byte));
		}
		#endregion // RemoveByHasPay
		#region RemoveByIsNewCash
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "isNewCash">是否第一次体现用户</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByIsNewCash(bool isNewCash, TransactionManager tm_ = null)
		{
			RepairRemoveByIsNewCashData(isNewCash, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByIsNewCashAsync(bool isNewCash, TransactionManager tm_ = null)
		{
			RepairRemoveByIsNewCashData(isNewCash, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByIsNewCashData(bool isNewCash, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `IsNewCash` = @IsNewCash";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IsNewCash", isNewCash, MySqlDbType.Byte));
		}
		#endregion // RemoveByIsNewCash
		#region RemoveByHasCash
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "hasCash">当天是否有提现行为</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByHasCash(bool hasCash, TransactionManager tm_ = null)
		{
			RepairRemoveByHasCashData(hasCash, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByHasCashAsync(bool hasCash, TransactionManager tm_ = null)
		{
			RepairRemoveByHasCashData(hasCash, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByHasCashData(bool hasCash, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `HasCash` = @HasCash";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@HasCash", hasCash, MySqlDbType.Byte));
		}
		#endregion // RemoveByHasCash
		#region RemoveByTotalBonus
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "totalBonus">赠金总额</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByTotalBonus(long totalBonus, TransactionManager tm_ = null)
		{
			RepairRemoveByTotalBonusData(totalBonus, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByTotalBonusAsync(long totalBonus, TransactionManager tm_ = null)
		{
			RepairRemoveByTotalBonusData(totalBonus, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByTotalBonusData(long totalBonus, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `TotalBonus` = @TotalBonus";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TotalBonus", totalBonus, MySqlDbType.Int64));
		}
		#endregion // RemoveByTotalBonus
		#region RemoveByTotalBonusCount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "totalBonusCount">赠金次数</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByTotalBonusCount(int totalBonusCount, TransactionManager tm_ = null)
		{
			RepairRemoveByTotalBonusCountData(totalBonusCount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByTotalBonusCountAsync(int totalBonusCount, TransactionManager tm_ = null)
		{
			RepairRemoveByTotalBonusCountData(totalBonusCount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByTotalBonusCountData(int totalBonusCount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `TotalBonusCount` = @TotalBonusCount";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TotalBonusCount", totalBonusCount, MySqlDbType.Int32));
		}
		#endregion // RemoveByTotalBonusCount
		#region RemoveByTotalBetBonus
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "totalBetBonus">下注时扣除的bonus总额</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByTotalBetBonus(long totalBetBonus, TransactionManager tm_ = null)
		{
			RepairRemoveByTotalBetBonusData(totalBetBonus, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByTotalBetBonusAsync(long totalBetBonus, TransactionManager tm_ = null)
		{
			RepairRemoveByTotalBetBonusData(totalBetBonus, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByTotalBetBonusData(long totalBetBonus, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `TotalBetBonus` = @TotalBetBonus";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TotalBetBonus", totalBetBonus, MySqlDbType.Int64));
		}
		#endregion // RemoveByTotalBetBonus
		#region RemoveByTotalWinBonus
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "totalWinBonus">返奖时增加的bonus总额</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByTotalWinBonus(long totalWinBonus, TransactionManager tm_ = null)
		{
			RepairRemoveByTotalWinBonusData(totalWinBonus, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByTotalWinBonusAsync(long totalWinBonus, TransactionManager tm_ = null)
		{
			RepairRemoveByTotalWinBonusData(totalWinBonus, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByTotalWinBonusData(long totalWinBonus, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `TotalWinBonus` = @TotalWinBonus";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TotalWinBonus", totalWinBonus, MySqlDbType.Int64));
		}
		#endregion // RemoveByTotalWinBonus
		#region RemoveByTotalChangeAmount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "totalChangeAmount">变化总额</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByTotalChangeAmount(long totalChangeAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByTotalChangeAmountData(totalChangeAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByTotalChangeAmountAsync(long totalChangeAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByTotalChangeAmountData(totalChangeAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByTotalChangeAmountData(long totalChangeAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `TotalChangeAmount` = @TotalChangeAmount";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TotalChangeAmount", totalChangeAmount, MySqlDbType.Int64));
		}
		#endregion // RemoveByTotalChangeAmount
		#region RemoveByTotalChangeCount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "totalChangeCount">变化次数</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByTotalChangeCount(int totalChangeCount, TransactionManager tm_ = null)
		{
			RepairRemoveByTotalChangeCountData(totalChangeCount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByTotalChangeCountAsync(int totalChangeCount, TransactionManager tm_ = null)
		{
			RepairRemoveByTotalChangeCountData(totalChangeCount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByTotalChangeCountData(int totalChangeCount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `TotalChangeCount` = @TotalChangeCount";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TotalChangeCount", totalChangeCount, MySqlDbType.Int32));
		}
		#endregion // RemoveByTotalChangeCount
		#region RemoveByTotalBetAmount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "totalBetAmount">下注总额</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByTotalBetAmount(long totalBetAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByTotalBetAmountData(totalBetAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByTotalBetAmountAsync(long totalBetAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByTotalBetAmountData(totalBetAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByTotalBetAmountData(long totalBetAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `TotalBetAmount` = @TotalBetAmount";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TotalBetAmount", totalBetAmount, MySqlDbType.Int64));
		}
		#endregion // RemoveByTotalBetAmount
		#region RemoveByTotalBetCount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "totalBetCount">下注次数</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByTotalBetCount(int totalBetCount, TransactionManager tm_ = null)
		{
			RepairRemoveByTotalBetCountData(totalBetCount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByTotalBetCountAsync(int totalBetCount, TransactionManager tm_ = null)
		{
			RepairRemoveByTotalBetCountData(totalBetCount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByTotalBetCountData(int totalBetCount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `TotalBetCount` = @TotalBetCount";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TotalBetCount", totalBetCount, MySqlDbType.Int32));
		}
		#endregion // RemoveByTotalBetCount
		#region RemoveByTotalWinAmount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "totalWinAmount">返奖总额</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByTotalWinAmount(long totalWinAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByTotalWinAmountData(totalWinAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByTotalWinAmountAsync(long totalWinAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByTotalWinAmountData(totalWinAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByTotalWinAmountData(long totalWinAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `TotalWinAmount` = @TotalWinAmount";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TotalWinAmount", totalWinAmount, MySqlDbType.Int64));
		}
		#endregion // RemoveByTotalWinAmount
		#region RemoveByTotalWinCount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "totalWinCount">返奖次数</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByTotalWinCount(int totalWinCount, TransactionManager tm_ = null)
		{
			RepairRemoveByTotalWinCountData(totalWinCount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByTotalWinCountAsync(int totalWinCount, TransactionManager tm_ = null)
		{
			RepairRemoveByTotalWinCountData(totalWinCount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByTotalWinCountData(int totalWinCount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `TotalWinCount` = @TotalWinCount";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TotalWinCount", totalWinCount, MySqlDbType.Int32));
		}
		#endregion // RemoveByTotalWinCount
		#region RemoveByTotalPayAmount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "totalPayAmount">充值总额</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByTotalPayAmount(long totalPayAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByTotalPayAmountData(totalPayAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByTotalPayAmountAsync(long totalPayAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByTotalPayAmountData(totalPayAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByTotalPayAmountData(long totalPayAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `TotalPayAmount` = @TotalPayAmount";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TotalPayAmount", totalPayAmount, MySqlDbType.Int64));
		}
		#endregion // RemoveByTotalPayAmount
		#region RemoveByTotalPayCount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "totalPayCount">充值次数</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByTotalPayCount(int totalPayCount, TransactionManager tm_ = null)
		{
			RepairRemoveByTotalPayCountData(totalPayCount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByTotalPayCountAsync(int totalPayCount, TransactionManager tm_ = null)
		{
			RepairRemoveByTotalPayCountData(totalPayCount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByTotalPayCountData(int totalPayCount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `TotalPayCount` = @TotalPayCount";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TotalPayCount", totalPayCount, MySqlDbType.Int32));
		}
		#endregion // RemoveByTotalPayCount
		#region RemoveByTotalCashAmount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "totalCashAmount">提现总额</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByTotalCashAmount(long totalCashAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByTotalCashAmountData(totalCashAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByTotalCashAmountAsync(long totalCashAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByTotalCashAmountData(totalCashAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByTotalCashAmountData(long totalCashAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `TotalCashAmount` = @TotalCashAmount";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TotalCashAmount", totalCashAmount, MySqlDbType.Int64));
		}
		#endregion // RemoveByTotalCashAmount
		#region RemoveByTotalCashCount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "totalCashCount">提现次数</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByTotalCashCount(int totalCashCount, TransactionManager tm_ = null)
		{
			RepairRemoveByTotalCashCountData(totalCashCount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByTotalCashCountAsync(int totalCashCount, TransactionManager tm_ = null)
		{
			RepairRemoveByTotalCashCountData(totalCashCount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByTotalCashCountData(int totalCashCount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `TotalCashCount` = @TotalCashCount";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TotalCashCount", totalCashCount, MySqlDbType.Int32));
		}
		#endregion // RemoveByTotalCashCount
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
		public int Put(S_user_dayEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(S_user_dayEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(S_user_dayEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `DayID` = @DayID, `UserID` = @UserID, `FromMode` = @FromMode, `FromId` = @FromId, `UserKind` = @UserKind, `OperatorID` = @OperatorID, `CountryID` = @CountryID, `CurrencyID` = @CurrencyID, `IsNew` = @IsNew, `IsLogin` = @IsLogin, `LoginDays` = @LoginDays, `LastLoginTime` = @LastLoginTime, `IsRegister` = @IsRegister, `RegistDate` = @RegistDate, `IsNewBet` = @IsNewBet, `HasBet` = @HasBet, `IsNewPay` = @IsNewPay, `HasPay` = @HasPay, `IsNewCash` = @IsNewCash, `HasCash` = @HasCash, `TotalBonus` = @TotalBonus, `TotalBonusCount` = @TotalBonusCount, `TotalBetBonus` = @TotalBetBonus, `TotalWinBonus` = @TotalWinBonus, `TotalChangeAmount` = @TotalChangeAmount, `TotalChangeCount` = @TotalChangeCount, `TotalBetAmount` = @TotalBetAmount, `TotalBetCount` = @TotalBetCount, `TotalWinAmount` = @TotalWinAmount, `TotalWinCount` = @TotalWinCount, `TotalPayAmount` = @TotalPayAmount, `TotalPayCount` = @TotalPayCount, `TotalCashAmount` = @TotalCashAmount, `TotalCashCount` = @TotalCashCount, `UserIp` = @UserIp WHERE `DayID` = @DayID_Original AND `UserID` = @UserID_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", item.DayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", item.UserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@FromMode", item.FromMode, MySqlDbType.Int32),
				Database.CreateInParameter("@FromId", item.FromId != null ? item.FromId : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserKind", item.UserKind, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", item.OperatorID != null ? item.OperatorID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryID", item.CountryID != null ? item.CountryID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", item.CurrencyID != null ? item.CurrencyID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@IsNew", item.IsNew, MySqlDbType.Byte),
				Database.CreateInParameter("@IsLogin", item.IsLogin, MySqlDbType.Byte),
				Database.CreateInParameter("@LoginDays", item.LoginDays, MySqlDbType.Int32),
				Database.CreateInParameter("@LastLoginTime", item.LastLoginTime.HasValue ? item.LastLoginTime.Value : (object)DBNull.Value, MySqlDbType.DateTime),
				Database.CreateInParameter("@IsRegister", item.IsRegister, MySqlDbType.Byte),
				Database.CreateInParameter("@RegistDate", item.RegistDate.HasValue ? item.RegistDate.Value : (object)DBNull.Value, MySqlDbType.DateTime),
				Database.CreateInParameter("@IsNewBet", item.IsNewBet, MySqlDbType.Byte),
				Database.CreateInParameter("@HasBet", item.HasBet, MySqlDbType.Byte),
				Database.CreateInParameter("@IsNewPay", item.IsNewPay, MySqlDbType.Byte),
				Database.CreateInParameter("@HasPay", item.HasPay, MySqlDbType.Byte),
				Database.CreateInParameter("@IsNewCash", item.IsNewCash, MySqlDbType.Byte),
				Database.CreateInParameter("@HasCash", item.HasCash, MySqlDbType.Byte),
				Database.CreateInParameter("@TotalBonus", item.TotalBonus, MySqlDbType.Int64),
				Database.CreateInParameter("@TotalBonusCount", item.TotalBonusCount, MySqlDbType.Int32),
				Database.CreateInParameter("@TotalBetBonus", item.TotalBetBonus, MySqlDbType.Int64),
				Database.CreateInParameter("@TotalWinBonus", item.TotalWinBonus, MySqlDbType.Int64),
				Database.CreateInParameter("@TotalChangeAmount", item.TotalChangeAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@TotalChangeCount", item.TotalChangeCount, MySqlDbType.Int32),
				Database.CreateInParameter("@TotalBetAmount", item.TotalBetAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@TotalBetCount", item.TotalBetCount, MySqlDbType.Int32),
				Database.CreateInParameter("@TotalWinAmount", item.TotalWinAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@TotalWinCount", item.TotalWinCount, MySqlDbType.Int32),
				Database.CreateInParameter("@TotalPayAmount", item.TotalPayAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@TotalPayCount", item.TotalPayCount, MySqlDbType.Int32),
				Database.CreateInParameter("@TotalCashAmount", item.TotalCashAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@TotalCashCount", item.TotalCashCount, MySqlDbType.Int32),
				Database.CreateInParameter("@UserIp", item.UserIp != null ? item.UserIp : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@DayID_Original", item.HasOriginal ? item.OriginalDayID : item.DayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID_Original", item.HasOriginal ? item.OriginalUserID : item.UserID, MySqlDbType.VarChar),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<S_user_dayEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<S_user_dayEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(DateTime dayID, string userID, string set_, params object[] values_)
		{
			return Put(set_, "`DayID` = @DayID AND `UserID` = @UserID", ConcatValues(values_, dayID, userID));
		}
		public async Task<int> PutByPKAsync(DateTime dayID, string userID, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`DayID` = @DayID AND `UserID` = @UserID", ConcatValues(values_, dayID, userID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(DateTime dayID, string userID, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`DayID` = @DayID AND `UserID` = @UserID", tm_, ConcatValues(values_, dayID, userID));
		}
		public async Task<int> PutByPKAsync(DateTime dayID, string userID, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`DayID` = @DayID AND `UserID` = @UserID", tm_, ConcatValues(values_, dayID, userID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(DateTime dayID, string userID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
	        };
			return Put(set_, "`DayID` = @DayID AND `UserID` = @UserID", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(DateTime dayID, string userID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
	        };
			return await PutAsync(set_, "`DayID` = @DayID AND `UserID` = @UserID", ConcatParameters(paras_, newParas_), tm_);
		}
		#endregion // PutByPK
		
		#region PutXXX
		#region PutDayID
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutDayID(DateTime dayID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `DayID` = @DayID";
			var parameter_ = Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutDayIDAsync(DateTime dayID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `DayID` = @DayID";
			var parameter_ = Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutDayID
		#region PutUserID
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutUserID(string userID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `UserID` = @UserID";
			var parameter_ = Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutUserIDAsync(string userID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `UserID` = @UserID";
			var parameter_ = Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutUserID
		#region PutFromMode
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "fromMode">新用户来源方式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutFromModeByPK(DateTime dayID, string userID, int fromMode, TransactionManager tm_ = null)
		{
			RepairPutFromModeByPKData(dayID, userID, fromMode, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutFromModeByPKAsync(DateTime dayID, string userID, int fromMode, TransactionManager tm_ = null)
		{
			RepairPutFromModeByPKData(dayID, userID, fromMode, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutFromModeByPKData(DateTime dayID, string userID, int fromMode, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `FromMode` = @FromMode  WHERE `DayID` = @DayID AND `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@FromMode", fromMode, MySqlDbType.Int32),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
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
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "fromId">对应的编码（根据FromMode变化）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutFromIdByPK(DateTime dayID, string userID, string fromId, TransactionManager tm_ = null)
		{
			RepairPutFromIdByPKData(dayID, userID, fromId, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutFromIdByPKAsync(DateTime dayID, string userID, string fromId, TransactionManager tm_ = null)
		{
			RepairPutFromIdByPKData(dayID, userID, fromId, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutFromIdByPKData(DateTime dayID, string userID, string fromId, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `FromId` = @FromId  WHERE `DayID` = @DayID AND `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@FromId", fromId != null ? fromId : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
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
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "userKind">用户类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutUserKindByPK(DateTime dayID, string userID, int userKind, TransactionManager tm_ = null)
		{
			RepairPutUserKindByPKData(dayID, userID, userKind, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutUserKindByPKAsync(DateTime dayID, string userID, int userKind, TransactionManager tm_ = null)
		{
			RepairPutUserKindByPKData(dayID, userID, userKind, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutUserKindByPKData(DateTime dayID, string userID, int userKind, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `UserKind` = @UserKind  WHERE `DayID` = @DayID AND `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserKind", userKind, MySqlDbType.Int32),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
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
		#region PutOperatorID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOperatorIDByPK(DateTime dayID, string userID, string operatorID, TransactionManager tm_ = null)
		{
			RepairPutOperatorIDByPKData(dayID, userID, operatorID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutOperatorIDByPKAsync(DateTime dayID, string userID, string operatorID, TransactionManager tm_ = null)
		{
			RepairPutOperatorIDByPKData(dayID, userID, operatorID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutOperatorIDByPKData(DateTime dayID, string userID, string operatorID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `OperatorID` = @OperatorID  WHERE `DayID` = @DayID AND `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID != null ? operatorID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
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
		#region PutCountryID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCountryIDByPK(DateTime dayID, string userID, string countryID, TransactionManager tm_ = null)
		{
			RepairPutCountryIDByPKData(dayID, userID, countryID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutCountryIDByPKAsync(DateTime dayID, string userID, string countryID, TransactionManager tm_ = null)
		{
			RepairPutCountryIDByPKData(dayID, userID, countryID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutCountryIDByPKData(DateTime dayID, string userID, string countryID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `CountryID` = @CountryID  WHERE `DayID` = @DayID AND `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CountryID", countryID != null ? countryID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
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
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCurrencyIDByPK(DateTime dayID, string userID, string currencyID, TransactionManager tm_ = null)
		{
			RepairPutCurrencyIDByPKData(dayID, userID, currencyID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutCurrencyIDByPKAsync(DateTime dayID, string userID, string currencyID, TransactionManager tm_ = null)
		{
			RepairPutCurrencyIDByPKData(dayID, userID, currencyID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutCurrencyIDByPKData(DateTime dayID, string userID, string currencyID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `CurrencyID` = @CurrencyID  WHERE `DayID` = @DayID AND `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CurrencyID", currencyID != null ? currencyID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
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
		#region PutIsNew
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "isNew">是否新用户</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutIsNewByPK(DateTime dayID, string userID, bool isNew, TransactionManager tm_ = null)
		{
			RepairPutIsNewByPKData(dayID, userID, isNew, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutIsNewByPKAsync(DateTime dayID, string userID, bool isNew, TransactionManager tm_ = null)
		{
			RepairPutIsNewByPKData(dayID, userID, isNew, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutIsNewByPKData(DateTime dayID, string userID, bool isNew, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `IsNew` = @IsNew  WHERE `DayID` = @DayID AND `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@IsNew", isNew, MySqlDbType.Byte),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "isNew">是否新用户</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutIsNew(bool isNew, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `IsNew` = @IsNew";
			var parameter_ = Database.CreateInParameter("@IsNew", isNew, MySqlDbType.Byte);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutIsNewAsync(bool isNew, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `IsNew` = @IsNew";
			var parameter_ = Database.CreateInParameter("@IsNew", isNew, MySqlDbType.Byte);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutIsNew
		#region PutIsLogin
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "isLogin">当天是否登录</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutIsLoginByPK(DateTime dayID, string userID, bool isLogin, TransactionManager tm_ = null)
		{
			RepairPutIsLoginByPKData(dayID, userID, isLogin, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutIsLoginByPKAsync(DateTime dayID, string userID, bool isLogin, TransactionManager tm_ = null)
		{
			RepairPutIsLoginByPKData(dayID, userID, isLogin, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutIsLoginByPKData(DateTime dayID, string userID, bool isLogin, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `IsLogin` = @IsLogin  WHERE `DayID` = @DayID AND `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@IsLogin", isLogin, MySqlDbType.Byte),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "isLogin">当天是否登录</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutIsLogin(bool isLogin, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `IsLogin` = @IsLogin";
			var parameter_ = Database.CreateInParameter("@IsLogin", isLogin, MySqlDbType.Byte);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutIsLoginAsync(bool isLogin, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `IsLogin` = @IsLogin";
			var parameter_ = Database.CreateInParameter("@IsLogin", isLogin, MySqlDbType.Byte);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutIsLogin
		#region PutLoginDays
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "loginDays">连续登录天数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutLoginDaysByPK(DateTime dayID, string userID, int loginDays, TransactionManager tm_ = null)
		{
			RepairPutLoginDaysByPKData(dayID, userID, loginDays, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutLoginDaysByPKAsync(DateTime dayID, string userID, int loginDays, TransactionManager tm_ = null)
		{
			RepairPutLoginDaysByPKData(dayID, userID, loginDays, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutLoginDaysByPKData(DateTime dayID, string userID, int loginDays, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `LoginDays` = @LoginDays  WHERE `DayID` = @DayID AND `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LoginDays", loginDays, MySqlDbType.Int32),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "loginDays">连续登录天数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutLoginDays(int loginDays, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `LoginDays` = @LoginDays";
			var parameter_ = Database.CreateInParameter("@LoginDays", loginDays, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutLoginDaysAsync(int loginDays, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `LoginDays` = @LoginDays";
			var parameter_ = Database.CreateInParameter("@LoginDays", loginDays, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutLoginDays
		#region PutLastLoginTime
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "lastLoginTime">上次登录时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutLastLoginTimeByPK(DateTime dayID, string userID, DateTime? lastLoginTime, TransactionManager tm_ = null)
		{
			RepairPutLastLoginTimeByPKData(dayID, userID, lastLoginTime, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutLastLoginTimeByPKAsync(DateTime dayID, string userID, DateTime? lastLoginTime, TransactionManager tm_ = null)
		{
			RepairPutLastLoginTimeByPKData(dayID, userID, lastLoginTime, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutLastLoginTimeByPKData(DateTime dayID, string userID, DateTime? lastLoginTime, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `LastLoginTime` = @LastLoginTime  WHERE `DayID` = @DayID AND `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LastLoginTime", lastLoginTime.HasValue ? lastLoginTime.Value : (object)DBNull.Value, MySqlDbType.DateTime),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "lastLoginTime">上次登录时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutLastLoginTime(DateTime? lastLoginTime, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `LastLoginTime` = @LastLoginTime";
			var parameter_ = Database.CreateInParameter("@LastLoginTime", lastLoginTime.HasValue ? lastLoginTime.Value : (object)DBNull.Value, MySqlDbType.DateTime);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutLastLoginTimeAsync(DateTime? lastLoginTime, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `LastLoginTime` = @LastLoginTime";
			var parameter_ = Database.CreateInParameter("@LastLoginTime", lastLoginTime.HasValue ? lastLoginTime.Value : (object)DBNull.Value, MySqlDbType.DateTime);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutLastLoginTime
		#region PutIsRegister
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "isRegister">当天是否进行了注册</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutIsRegisterByPK(DateTime dayID, string userID, bool isRegister, TransactionManager tm_ = null)
		{
			RepairPutIsRegisterByPKData(dayID, userID, isRegister, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutIsRegisterByPKAsync(DateTime dayID, string userID, bool isRegister, TransactionManager tm_ = null)
		{
			RepairPutIsRegisterByPKData(dayID, userID, isRegister, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutIsRegisterByPKData(DateTime dayID, string userID, bool isRegister, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `IsRegister` = @IsRegister  WHERE `DayID` = @DayID AND `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@IsRegister", isRegister, MySqlDbType.Byte),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "isRegister">当天是否进行了注册</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutIsRegister(bool isRegister, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `IsRegister` = @IsRegister";
			var parameter_ = Database.CreateInParameter("@IsRegister", isRegister, MySqlDbType.Byte);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutIsRegisterAsync(bool isRegister, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `IsRegister` = @IsRegister";
			var parameter_ = Database.CreateInParameter("@IsRegister", isRegister, MySqlDbType.Byte);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutIsRegister
		#region PutRegistDate
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "registDate">注册时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRegistDateByPK(DateTime dayID, string userID, DateTime? registDate, TransactionManager tm_ = null)
		{
			RepairPutRegistDateByPKData(dayID, userID, registDate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutRegistDateByPKAsync(DateTime dayID, string userID, DateTime? registDate, TransactionManager tm_ = null)
		{
			RepairPutRegistDateByPKData(dayID, userID, registDate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutRegistDateByPKData(DateTime dayID, string userID, DateTime? registDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `RegistDate` = @RegistDate  WHERE `DayID` = @DayID AND `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RegistDate", registDate.HasValue ? registDate.Value : (object)DBNull.Value, MySqlDbType.DateTime),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "registDate">注册时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRegistDate(DateTime? registDate, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `RegistDate` = @RegistDate";
			var parameter_ = Database.CreateInParameter("@RegistDate", registDate.HasValue ? registDate.Value : (object)DBNull.Value, MySqlDbType.DateTime);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutRegistDateAsync(DateTime? registDate, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `RegistDate` = @RegistDate";
			var parameter_ = Database.CreateInParameter("@RegistDate", registDate.HasValue ? registDate.Value : (object)DBNull.Value, MySqlDbType.DateTime);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutRegistDate
		#region PutIsNewBet
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "isNewBet">是否是第一次下注用户</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutIsNewBetByPK(DateTime dayID, string userID, bool isNewBet, TransactionManager tm_ = null)
		{
			RepairPutIsNewBetByPKData(dayID, userID, isNewBet, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutIsNewBetByPKAsync(DateTime dayID, string userID, bool isNewBet, TransactionManager tm_ = null)
		{
			RepairPutIsNewBetByPKData(dayID, userID, isNewBet, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutIsNewBetByPKData(DateTime dayID, string userID, bool isNewBet, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `IsNewBet` = @IsNewBet  WHERE `DayID` = @DayID AND `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@IsNewBet", isNewBet, MySqlDbType.Byte),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "isNewBet">是否是第一次下注用户</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutIsNewBet(bool isNewBet, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `IsNewBet` = @IsNewBet";
			var parameter_ = Database.CreateInParameter("@IsNewBet", isNewBet, MySqlDbType.Byte);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutIsNewBetAsync(bool isNewBet, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `IsNewBet` = @IsNewBet";
			var parameter_ = Database.CreateInParameter("@IsNewBet", isNewBet, MySqlDbType.Byte);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutIsNewBet
		#region PutHasBet
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "hasBet">当天是否下注</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutHasBetByPK(DateTime dayID, string userID, bool hasBet, TransactionManager tm_ = null)
		{
			RepairPutHasBetByPKData(dayID, userID, hasBet, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutHasBetByPKAsync(DateTime dayID, string userID, bool hasBet, TransactionManager tm_ = null)
		{
			RepairPutHasBetByPKData(dayID, userID, hasBet, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutHasBetByPKData(DateTime dayID, string userID, bool hasBet, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `HasBet` = @HasBet  WHERE `DayID` = @DayID AND `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@HasBet", hasBet, MySqlDbType.Byte),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "hasBet">当天是否下注</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutHasBet(bool hasBet, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `HasBet` = @HasBet";
			var parameter_ = Database.CreateInParameter("@HasBet", hasBet, MySqlDbType.Byte);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutHasBetAsync(bool hasBet, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `HasBet` = @HasBet";
			var parameter_ = Database.CreateInParameter("@HasBet", hasBet, MySqlDbType.Byte);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutHasBet
		#region PutIsNewPay
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "isNewPay">是否是第一次充值用户</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutIsNewPayByPK(DateTime dayID, string userID, bool isNewPay, TransactionManager tm_ = null)
		{
			RepairPutIsNewPayByPKData(dayID, userID, isNewPay, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutIsNewPayByPKAsync(DateTime dayID, string userID, bool isNewPay, TransactionManager tm_ = null)
		{
			RepairPutIsNewPayByPKData(dayID, userID, isNewPay, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutIsNewPayByPKData(DateTime dayID, string userID, bool isNewPay, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `IsNewPay` = @IsNewPay  WHERE `DayID` = @DayID AND `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@IsNewPay", isNewPay, MySqlDbType.Byte),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "isNewPay">是否是第一次充值用户</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutIsNewPay(bool isNewPay, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `IsNewPay` = @IsNewPay";
			var parameter_ = Database.CreateInParameter("@IsNewPay", isNewPay, MySqlDbType.Byte);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutIsNewPayAsync(bool isNewPay, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `IsNewPay` = @IsNewPay";
			var parameter_ = Database.CreateInParameter("@IsNewPay", isNewPay, MySqlDbType.Byte);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutIsNewPay
		#region PutHasPay
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "hasPay">当天是否充值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutHasPayByPK(DateTime dayID, string userID, bool hasPay, TransactionManager tm_ = null)
		{
			RepairPutHasPayByPKData(dayID, userID, hasPay, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutHasPayByPKAsync(DateTime dayID, string userID, bool hasPay, TransactionManager tm_ = null)
		{
			RepairPutHasPayByPKData(dayID, userID, hasPay, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutHasPayByPKData(DateTime dayID, string userID, bool hasPay, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `HasPay` = @HasPay  WHERE `DayID` = @DayID AND `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@HasPay", hasPay, MySqlDbType.Byte),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "hasPay">当天是否充值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutHasPay(bool hasPay, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `HasPay` = @HasPay";
			var parameter_ = Database.CreateInParameter("@HasPay", hasPay, MySqlDbType.Byte);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutHasPayAsync(bool hasPay, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `HasPay` = @HasPay";
			var parameter_ = Database.CreateInParameter("@HasPay", hasPay, MySqlDbType.Byte);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutHasPay
		#region PutIsNewCash
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "isNewCash">是否第一次体现用户</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutIsNewCashByPK(DateTime dayID, string userID, bool isNewCash, TransactionManager tm_ = null)
		{
			RepairPutIsNewCashByPKData(dayID, userID, isNewCash, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutIsNewCashByPKAsync(DateTime dayID, string userID, bool isNewCash, TransactionManager tm_ = null)
		{
			RepairPutIsNewCashByPKData(dayID, userID, isNewCash, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutIsNewCashByPKData(DateTime dayID, string userID, bool isNewCash, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `IsNewCash` = @IsNewCash  WHERE `DayID` = @DayID AND `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@IsNewCash", isNewCash, MySqlDbType.Byte),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "isNewCash">是否第一次体现用户</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutIsNewCash(bool isNewCash, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `IsNewCash` = @IsNewCash";
			var parameter_ = Database.CreateInParameter("@IsNewCash", isNewCash, MySqlDbType.Byte);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutIsNewCashAsync(bool isNewCash, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `IsNewCash` = @IsNewCash";
			var parameter_ = Database.CreateInParameter("@IsNewCash", isNewCash, MySqlDbType.Byte);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutIsNewCash
		#region PutHasCash
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "hasCash">当天是否有提现行为</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutHasCashByPK(DateTime dayID, string userID, bool hasCash, TransactionManager tm_ = null)
		{
			RepairPutHasCashByPKData(dayID, userID, hasCash, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutHasCashByPKAsync(DateTime dayID, string userID, bool hasCash, TransactionManager tm_ = null)
		{
			RepairPutHasCashByPKData(dayID, userID, hasCash, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutHasCashByPKData(DateTime dayID, string userID, bool hasCash, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `HasCash` = @HasCash  WHERE `DayID` = @DayID AND `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@HasCash", hasCash, MySqlDbType.Byte),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "hasCash">当天是否有提现行为</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutHasCash(bool hasCash, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `HasCash` = @HasCash";
			var parameter_ = Database.CreateInParameter("@HasCash", hasCash, MySqlDbType.Byte);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutHasCashAsync(bool hasCash, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `HasCash` = @HasCash";
			var parameter_ = Database.CreateInParameter("@HasCash", hasCash, MySqlDbType.Byte);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutHasCash
		#region PutTotalBonus
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "totalBonus">赠金总额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTotalBonusByPK(DateTime dayID, string userID, long totalBonus, TransactionManager tm_ = null)
		{
			RepairPutTotalBonusByPKData(dayID, userID, totalBonus, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutTotalBonusByPKAsync(DateTime dayID, string userID, long totalBonus, TransactionManager tm_ = null)
		{
			RepairPutTotalBonusByPKData(dayID, userID, totalBonus, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutTotalBonusByPKData(DateTime dayID, string userID, long totalBonus, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `TotalBonus` = @TotalBonus  WHERE `DayID` = @DayID AND `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TotalBonus", totalBonus, MySqlDbType.Int64),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "totalBonus">赠金总额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTotalBonus(long totalBonus, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `TotalBonus` = @TotalBonus";
			var parameter_ = Database.CreateInParameter("@TotalBonus", totalBonus, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutTotalBonusAsync(long totalBonus, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `TotalBonus` = @TotalBonus";
			var parameter_ = Database.CreateInParameter("@TotalBonus", totalBonus, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutTotalBonus
		#region PutTotalBonusCount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "totalBonusCount">赠金次数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTotalBonusCountByPK(DateTime dayID, string userID, int totalBonusCount, TransactionManager tm_ = null)
		{
			RepairPutTotalBonusCountByPKData(dayID, userID, totalBonusCount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutTotalBonusCountByPKAsync(DateTime dayID, string userID, int totalBonusCount, TransactionManager tm_ = null)
		{
			RepairPutTotalBonusCountByPKData(dayID, userID, totalBonusCount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutTotalBonusCountByPKData(DateTime dayID, string userID, int totalBonusCount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `TotalBonusCount` = @TotalBonusCount  WHERE `DayID` = @DayID AND `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TotalBonusCount", totalBonusCount, MySqlDbType.Int32),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "totalBonusCount">赠金次数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTotalBonusCount(int totalBonusCount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `TotalBonusCount` = @TotalBonusCount";
			var parameter_ = Database.CreateInParameter("@TotalBonusCount", totalBonusCount, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutTotalBonusCountAsync(int totalBonusCount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `TotalBonusCount` = @TotalBonusCount";
			var parameter_ = Database.CreateInParameter("@TotalBonusCount", totalBonusCount, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutTotalBonusCount
		#region PutTotalBetBonus
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "totalBetBonus">下注时扣除的bonus总额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTotalBetBonusByPK(DateTime dayID, string userID, long totalBetBonus, TransactionManager tm_ = null)
		{
			RepairPutTotalBetBonusByPKData(dayID, userID, totalBetBonus, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutTotalBetBonusByPKAsync(DateTime dayID, string userID, long totalBetBonus, TransactionManager tm_ = null)
		{
			RepairPutTotalBetBonusByPKData(dayID, userID, totalBetBonus, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutTotalBetBonusByPKData(DateTime dayID, string userID, long totalBetBonus, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `TotalBetBonus` = @TotalBetBonus  WHERE `DayID` = @DayID AND `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TotalBetBonus", totalBetBonus, MySqlDbType.Int64),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "totalBetBonus">下注时扣除的bonus总额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTotalBetBonus(long totalBetBonus, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `TotalBetBonus` = @TotalBetBonus";
			var parameter_ = Database.CreateInParameter("@TotalBetBonus", totalBetBonus, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutTotalBetBonusAsync(long totalBetBonus, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `TotalBetBonus` = @TotalBetBonus";
			var parameter_ = Database.CreateInParameter("@TotalBetBonus", totalBetBonus, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutTotalBetBonus
		#region PutTotalWinBonus
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "totalWinBonus">返奖时增加的bonus总额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTotalWinBonusByPK(DateTime dayID, string userID, long totalWinBonus, TransactionManager tm_ = null)
		{
			RepairPutTotalWinBonusByPKData(dayID, userID, totalWinBonus, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutTotalWinBonusByPKAsync(DateTime dayID, string userID, long totalWinBonus, TransactionManager tm_ = null)
		{
			RepairPutTotalWinBonusByPKData(dayID, userID, totalWinBonus, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutTotalWinBonusByPKData(DateTime dayID, string userID, long totalWinBonus, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `TotalWinBonus` = @TotalWinBonus  WHERE `DayID` = @DayID AND `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TotalWinBonus", totalWinBonus, MySqlDbType.Int64),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "totalWinBonus">返奖时增加的bonus总额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTotalWinBonus(long totalWinBonus, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `TotalWinBonus` = @TotalWinBonus";
			var parameter_ = Database.CreateInParameter("@TotalWinBonus", totalWinBonus, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutTotalWinBonusAsync(long totalWinBonus, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `TotalWinBonus` = @TotalWinBonus";
			var parameter_ = Database.CreateInParameter("@TotalWinBonus", totalWinBonus, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutTotalWinBonus
		#region PutTotalChangeAmount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "totalChangeAmount">变化总额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTotalChangeAmountByPK(DateTime dayID, string userID, long totalChangeAmount, TransactionManager tm_ = null)
		{
			RepairPutTotalChangeAmountByPKData(dayID, userID, totalChangeAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutTotalChangeAmountByPKAsync(DateTime dayID, string userID, long totalChangeAmount, TransactionManager tm_ = null)
		{
			RepairPutTotalChangeAmountByPKData(dayID, userID, totalChangeAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutTotalChangeAmountByPKData(DateTime dayID, string userID, long totalChangeAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `TotalChangeAmount` = @TotalChangeAmount  WHERE `DayID` = @DayID AND `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TotalChangeAmount", totalChangeAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "totalChangeAmount">变化总额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTotalChangeAmount(long totalChangeAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `TotalChangeAmount` = @TotalChangeAmount";
			var parameter_ = Database.CreateInParameter("@TotalChangeAmount", totalChangeAmount, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutTotalChangeAmountAsync(long totalChangeAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `TotalChangeAmount` = @TotalChangeAmount";
			var parameter_ = Database.CreateInParameter("@TotalChangeAmount", totalChangeAmount, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutTotalChangeAmount
		#region PutTotalChangeCount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "totalChangeCount">变化次数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTotalChangeCountByPK(DateTime dayID, string userID, int totalChangeCount, TransactionManager tm_ = null)
		{
			RepairPutTotalChangeCountByPKData(dayID, userID, totalChangeCount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutTotalChangeCountByPKAsync(DateTime dayID, string userID, int totalChangeCount, TransactionManager tm_ = null)
		{
			RepairPutTotalChangeCountByPKData(dayID, userID, totalChangeCount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutTotalChangeCountByPKData(DateTime dayID, string userID, int totalChangeCount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `TotalChangeCount` = @TotalChangeCount  WHERE `DayID` = @DayID AND `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TotalChangeCount", totalChangeCount, MySqlDbType.Int32),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "totalChangeCount">变化次数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTotalChangeCount(int totalChangeCount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `TotalChangeCount` = @TotalChangeCount";
			var parameter_ = Database.CreateInParameter("@TotalChangeCount", totalChangeCount, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutTotalChangeCountAsync(int totalChangeCount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `TotalChangeCount` = @TotalChangeCount";
			var parameter_ = Database.CreateInParameter("@TotalChangeCount", totalChangeCount, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutTotalChangeCount
		#region PutTotalBetAmount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "totalBetAmount">下注总额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTotalBetAmountByPK(DateTime dayID, string userID, long totalBetAmount, TransactionManager tm_ = null)
		{
			RepairPutTotalBetAmountByPKData(dayID, userID, totalBetAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutTotalBetAmountByPKAsync(DateTime dayID, string userID, long totalBetAmount, TransactionManager tm_ = null)
		{
			RepairPutTotalBetAmountByPKData(dayID, userID, totalBetAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutTotalBetAmountByPKData(DateTime dayID, string userID, long totalBetAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `TotalBetAmount` = @TotalBetAmount  WHERE `DayID` = @DayID AND `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TotalBetAmount", totalBetAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "totalBetAmount">下注总额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTotalBetAmount(long totalBetAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `TotalBetAmount` = @TotalBetAmount";
			var parameter_ = Database.CreateInParameter("@TotalBetAmount", totalBetAmount, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutTotalBetAmountAsync(long totalBetAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `TotalBetAmount` = @TotalBetAmount";
			var parameter_ = Database.CreateInParameter("@TotalBetAmount", totalBetAmount, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutTotalBetAmount
		#region PutTotalBetCount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "totalBetCount">下注次数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTotalBetCountByPK(DateTime dayID, string userID, int totalBetCount, TransactionManager tm_ = null)
		{
			RepairPutTotalBetCountByPKData(dayID, userID, totalBetCount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutTotalBetCountByPKAsync(DateTime dayID, string userID, int totalBetCount, TransactionManager tm_ = null)
		{
			RepairPutTotalBetCountByPKData(dayID, userID, totalBetCount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutTotalBetCountByPKData(DateTime dayID, string userID, int totalBetCount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `TotalBetCount` = @TotalBetCount  WHERE `DayID` = @DayID AND `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TotalBetCount", totalBetCount, MySqlDbType.Int32),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "totalBetCount">下注次数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTotalBetCount(int totalBetCount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `TotalBetCount` = @TotalBetCount";
			var parameter_ = Database.CreateInParameter("@TotalBetCount", totalBetCount, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutTotalBetCountAsync(int totalBetCount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `TotalBetCount` = @TotalBetCount";
			var parameter_ = Database.CreateInParameter("@TotalBetCount", totalBetCount, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutTotalBetCount
		#region PutTotalWinAmount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "totalWinAmount">返奖总额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTotalWinAmountByPK(DateTime dayID, string userID, long totalWinAmount, TransactionManager tm_ = null)
		{
			RepairPutTotalWinAmountByPKData(dayID, userID, totalWinAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutTotalWinAmountByPKAsync(DateTime dayID, string userID, long totalWinAmount, TransactionManager tm_ = null)
		{
			RepairPutTotalWinAmountByPKData(dayID, userID, totalWinAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutTotalWinAmountByPKData(DateTime dayID, string userID, long totalWinAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `TotalWinAmount` = @TotalWinAmount  WHERE `DayID` = @DayID AND `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TotalWinAmount", totalWinAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "totalWinAmount">返奖总额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTotalWinAmount(long totalWinAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `TotalWinAmount` = @TotalWinAmount";
			var parameter_ = Database.CreateInParameter("@TotalWinAmount", totalWinAmount, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutTotalWinAmountAsync(long totalWinAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `TotalWinAmount` = @TotalWinAmount";
			var parameter_ = Database.CreateInParameter("@TotalWinAmount", totalWinAmount, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutTotalWinAmount
		#region PutTotalWinCount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "totalWinCount">返奖次数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTotalWinCountByPK(DateTime dayID, string userID, int totalWinCount, TransactionManager tm_ = null)
		{
			RepairPutTotalWinCountByPKData(dayID, userID, totalWinCount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutTotalWinCountByPKAsync(DateTime dayID, string userID, int totalWinCount, TransactionManager tm_ = null)
		{
			RepairPutTotalWinCountByPKData(dayID, userID, totalWinCount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutTotalWinCountByPKData(DateTime dayID, string userID, int totalWinCount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `TotalWinCount` = @TotalWinCount  WHERE `DayID` = @DayID AND `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TotalWinCount", totalWinCount, MySqlDbType.Int32),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "totalWinCount">返奖次数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTotalWinCount(int totalWinCount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `TotalWinCount` = @TotalWinCount";
			var parameter_ = Database.CreateInParameter("@TotalWinCount", totalWinCount, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutTotalWinCountAsync(int totalWinCount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `TotalWinCount` = @TotalWinCount";
			var parameter_ = Database.CreateInParameter("@TotalWinCount", totalWinCount, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutTotalWinCount
		#region PutTotalPayAmount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "totalPayAmount">充值总额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTotalPayAmountByPK(DateTime dayID, string userID, long totalPayAmount, TransactionManager tm_ = null)
		{
			RepairPutTotalPayAmountByPKData(dayID, userID, totalPayAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutTotalPayAmountByPKAsync(DateTime dayID, string userID, long totalPayAmount, TransactionManager tm_ = null)
		{
			RepairPutTotalPayAmountByPKData(dayID, userID, totalPayAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutTotalPayAmountByPKData(DateTime dayID, string userID, long totalPayAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `TotalPayAmount` = @TotalPayAmount  WHERE `DayID` = @DayID AND `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TotalPayAmount", totalPayAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "totalPayAmount">充值总额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTotalPayAmount(long totalPayAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `TotalPayAmount` = @TotalPayAmount";
			var parameter_ = Database.CreateInParameter("@TotalPayAmount", totalPayAmount, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutTotalPayAmountAsync(long totalPayAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `TotalPayAmount` = @TotalPayAmount";
			var parameter_ = Database.CreateInParameter("@TotalPayAmount", totalPayAmount, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutTotalPayAmount
		#region PutTotalPayCount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "totalPayCount">充值次数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTotalPayCountByPK(DateTime dayID, string userID, int totalPayCount, TransactionManager tm_ = null)
		{
			RepairPutTotalPayCountByPKData(dayID, userID, totalPayCount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutTotalPayCountByPKAsync(DateTime dayID, string userID, int totalPayCount, TransactionManager tm_ = null)
		{
			RepairPutTotalPayCountByPKData(dayID, userID, totalPayCount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutTotalPayCountByPKData(DateTime dayID, string userID, int totalPayCount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `TotalPayCount` = @TotalPayCount  WHERE `DayID` = @DayID AND `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TotalPayCount", totalPayCount, MySqlDbType.Int32),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "totalPayCount">充值次数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTotalPayCount(int totalPayCount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `TotalPayCount` = @TotalPayCount";
			var parameter_ = Database.CreateInParameter("@TotalPayCount", totalPayCount, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutTotalPayCountAsync(int totalPayCount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `TotalPayCount` = @TotalPayCount";
			var parameter_ = Database.CreateInParameter("@TotalPayCount", totalPayCount, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutTotalPayCount
		#region PutTotalCashAmount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "totalCashAmount">提现总额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTotalCashAmountByPK(DateTime dayID, string userID, long totalCashAmount, TransactionManager tm_ = null)
		{
			RepairPutTotalCashAmountByPKData(dayID, userID, totalCashAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutTotalCashAmountByPKAsync(DateTime dayID, string userID, long totalCashAmount, TransactionManager tm_ = null)
		{
			RepairPutTotalCashAmountByPKData(dayID, userID, totalCashAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutTotalCashAmountByPKData(DateTime dayID, string userID, long totalCashAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `TotalCashAmount` = @TotalCashAmount  WHERE `DayID` = @DayID AND `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TotalCashAmount", totalCashAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "totalCashAmount">提现总额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTotalCashAmount(long totalCashAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `TotalCashAmount` = @TotalCashAmount";
			var parameter_ = Database.CreateInParameter("@TotalCashAmount", totalCashAmount, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutTotalCashAmountAsync(long totalCashAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `TotalCashAmount` = @TotalCashAmount";
			var parameter_ = Database.CreateInParameter("@TotalCashAmount", totalCashAmount, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutTotalCashAmount
		#region PutTotalCashCount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "totalCashCount">提现次数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTotalCashCountByPK(DateTime dayID, string userID, int totalCashCount, TransactionManager tm_ = null)
		{
			RepairPutTotalCashCountByPKData(dayID, userID, totalCashCount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutTotalCashCountByPKAsync(DateTime dayID, string userID, int totalCashCount, TransactionManager tm_ = null)
		{
			RepairPutTotalCashCountByPKData(dayID, userID, totalCashCount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutTotalCashCountByPKData(DateTime dayID, string userID, int totalCashCount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `TotalCashCount` = @TotalCashCount  WHERE `DayID` = @DayID AND `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TotalCashCount", totalCashCount, MySqlDbType.Int32),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "totalCashCount">提现次数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTotalCashCount(int totalCashCount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `TotalCashCount` = @TotalCashCount";
			var parameter_ = Database.CreateInParameter("@TotalCashCount", totalCashCount, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutTotalCashCountAsync(int totalCashCount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `TotalCashCount` = @TotalCashCount";
			var parameter_ = Database.CreateInParameter("@TotalCashCount", totalCashCount, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutTotalCashCount
		#region PutUserIp
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "userIp">用户IP</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutUserIpByPK(DateTime dayID, string userID, string userIp, TransactionManager tm_ = null)
		{
			RepairPutUserIpByPKData(dayID, userID, userIp, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutUserIpByPKAsync(DateTime dayID, string userID, string userIp, TransactionManager tm_ = null)
		{
			RepairPutUserIpByPKData(dayID, userID, userIp, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutUserIpByPKData(DateTime dayID, string userID, string userIp, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `UserIp` = @UserIp  WHERE `DayID` = @DayID AND `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserIp", userIp != null ? userIp : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
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
		#region PutRecDate
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRecDateByPK(DateTime dayID, string userID, DateTime recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(dayID, userID, recDate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutRecDateByPKAsync(DateTime dayID, string userID, DateTime recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(dayID, userID, recDate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutRecDateByPKData(DateTime dayID, string userID, DateTime recDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `RecDate` = @RecDate  WHERE `DayID` = @DayID AND `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
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
		#endregion // PutXXX
		#endregion // Put
	   
		#region Set
		
		/// <summary>
		/// 插入或者更新数据
		/// </summary>
		/// <param name = "item">要更新的实体对象</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>true:插入操作；false:更新操作</return>
		public bool Set(S_user_dayEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.DayID, item.UserID) == null)
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
		public async Task<bool> SetAsync(S_user_dayEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.DayID, item.UserID) == null)
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
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public S_user_dayEO GetByPK(DateTime dayID, string userID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(dayID, userID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, S_user_dayEO.MapDataReader);
		}
		public async Task<S_user_dayEO> GetByPKAsync(DateTime dayID, string userID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(dayID, userID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, S_user_dayEO.MapDataReader);
		}
		private void RepairGetByPKData(DateTime dayID, string userID, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false, TransactionManager tm_ = null)
		{
			sql_ = BuildSelectSQL("`DayID` = @DayID AND `UserID` = @UserID", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
		#endregion // GetByPK
		
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 DayID（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime GetDayIDByPK(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (DateTime)GetScalar("`DayID`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		public async Task<DateTime> GetDayIDByPKAsync(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (DateTime)await GetScalarAsync("`DayID`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 UserID（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetUserIDByPK(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`UserID`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		public async Task<string> GetUserIDByPKAsync(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`UserID`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 FromMode（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetFromModeByPK(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`FromMode`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		public async Task<int> GetFromModeByPKAsync(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`FromMode`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 FromId（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetFromIdByPK(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`FromId`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		public async Task<string> GetFromIdByPKAsync(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`FromId`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 UserKind（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetUserKindByPK(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`UserKind`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		public async Task<int> GetUserKindByPKAsync(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`UserKind`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 OperatorID（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetOperatorIDByPK(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`OperatorID`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		public async Task<string> GetOperatorIDByPKAsync(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`OperatorID`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 CountryID（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetCountryIDByPK(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`CountryID`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		public async Task<string> GetCountryIDByPKAsync(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`CountryID`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 CurrencyID（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetCurrencyIDByPK(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`CurrencyID`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		public async Task<string> GetCurrencyIDByPKAsync(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`CurrencyID`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 IsNew（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public bool GetIsNewByPK(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (bool)GetScalar("`IsNew`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		public async Task<bool> GetIsNewByPKAsync(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (bool)await GetScalarAsync("`IsNew`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 IsLogin（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public bool GetIsLoginByPK(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (bool)GetScalar("`IsLogin`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		public async Task<bool> GetIsLoginByPKAsync(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (bool)await GetScalarAsync("`IsLogin`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 LoginDays（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetLoginDaysByPK(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`LoginDays`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		public async Task<int> GetLoginDaysByPKAsync(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`LoginDays`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 LastLoginTime（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime? GetLastLoginTimeByPK(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (DateTime?)GetScalar("`LastLoginTime`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		public async Task<DateTime?> GetLastLoginTimeByPKAsync(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (DateTime?)await GetScalarAsync("`LastLoginTime`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 IsRegister（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public bool GetIsRegisterByPK(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (bool)GetScalar("`IsRegister`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		public async Task<bool> GetIsRegisterByPKAsync(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (bool)await GetScalarAsync("`IsRegister`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 RegistDate（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime? GetRegistDateByPK(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (DateTime?)GetScalar("`RegistDate`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		public async Task<DateTime?> GetRegistDateByPKAsync(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (DateTime?)await GetScalarAsync("`RegistDate`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 IsNewBet（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public bool GetIsNewBetByPK(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (bool)GetScalar("`IsNewBet`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		public async Task<bool> GetIsNewBetByPKAsync(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (bool)await GetScalarAsync("`IsNewBet`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 HasBet（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public bool GetHasBetByPK(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (bool)GetScalar("`HasBet`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		public async Task<bool> GetHasBetByPKAsync(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (bool)await GetScalarAsync("`HasBet`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 IsNewPay（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public bool GetIsNewPayByPK(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (bool)GetScalar("`IsNewPay`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		public async Task<bool> GetIsNewPayByPKAsync(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (bool)await GetScalarAsync("`IsNewPay`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 HasPay（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public bool GetHasPayByPK(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (bool)GetScalar("`HasPay`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		public async Task<bool> GetHasPayByPKAsync(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (bool)await GetScalarAsync("`HasPay`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 IsNewCash（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public bool GetIsNewCashByPK(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (bool)GetScalar("`IsNewCash`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		public async Task<bool> GetIsNewCashByPKAsync(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (bool)await GetScalarAsync("`IsNewCash`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 HasCash（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public bool GetHasCashByPK(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (bool)GetScalar("`HasCash`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		public async Task<bool> GetHasCashByPKAsync(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (bool)await GetScalarAsync("`HasCash`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 TotalBonus（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetTotalBonusByPK(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`TotalBonus`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		public async Task<long> GetTotalBonusByPKAsync(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`TotalBonus`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 TotalBonusCount（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetTotalBonusCountByPK(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`TotalBonusCount`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		public async Task<int> GetTotalBonusCountByPKAsync(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`TotalBonusCount`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 TotalBetBonus（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetTotalBetBonusByPK(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`TotalBetBonus`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		public async Task<long> GetTotalBetBonusByPKAsync(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`TotalBetBonus`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 TotalWinBonus（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetTotalWinBonusByPK(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`TotalWinBonus`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		public async Task<long> GetTotalWinBonusByPKAsync(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`TotalWinBonus`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 TotalChangeAmount（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetTotalChangeAmountByPK(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`TotalChangeAmount`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		public async Task<long> GetTotalChangeAmountByPKAsync(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`TotalChangeAmount`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 TotalChangeCount（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetTotalChangeCountByPK(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`TotalChangeCount`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		public async Task<int> GetTotalChangeCountByPKAsync(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`TotalChangeCount`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 TotalBetAmount（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetTotalBetAmountByPK(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`TotalBetAmount`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		public async Task<long> GetTotalBetAmountByPKAsync(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`TotalBetAmount`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 TotalBetCount（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetTotalBetCountByPK(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`TotalBetCount`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		public async Task<int> GetTotalBetCountByPKAsync(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`TotalBetCount`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 TotalWinAmount（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetTotalWinAmountByPK(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`TotalWinAmount`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		public async Task<long> GetTotalWinAmountByPKAsync(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`TotalWinAmount`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 TotalWinCount（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetTotalWinCountByPK(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`TotalWinCount`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		public async Task<int> GetTotalWinCountByPKAsync(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`TotalWinCount`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 TotalPayAmount（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetTotalPayAmountByPK(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`TotalPayAmount`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		public async Task<long> GetTotalPayAmountByPKAsync(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`TotalPayAmount`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 TotalPayCount（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetTotalPayCountByPK(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`TotalPayCount`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		public async Task<int> GetTotalPayCountByPKAsync(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`TotalPayCount`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 TotalCashAmount（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetTotalCashAmountByPK(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`TotalCashAmount`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		public async Task<long> GetTotalCashAmountByPKAsync(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`TotalCashAmount`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 TotalCashCount（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetTotalCashCountByPK(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`TotalCashCount`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		public async Task<int> GetTotalCashCountByPKAsync(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`TotalCashCount`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 UserIp（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetUserIpByPK(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`UserIp`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		public async Task<string> GetUserIpByPKAsync(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`UserIp`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 RecDate（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime GetRecDateByPK(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (DateTime)GetScalar("`RecDate`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		public async Task<DateTime> GetRecDateByPKAsync(DateTime dayID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (DateTime)await GetScalarAsync("`RecDate`", "`DayID` = @DayID AND `UserID` = @UserID", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByDayID
		
		/// <summary>
		/// 按 DayID（字段） 查询
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByDayID(DateTime dayID)
		{
			return GetByDayID(dayID, 0, string.Empty, null);
		}
		public async Task<List<S_user_dayEO>> GetByDayIDAsync(DateTime dayID)
		{
			return await GetByDayIDAsync(dayID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DayID（字段） 查询
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByDayID(DateTime dayID, TransactionManager tm_)
		{
			return GetByDayID(dayID, 0, string.Empty, tm_);
		}
		public async Task<List<S_user_dayEO>> GetByDayIDAsync(DateTime dayID, TransactionManager tm_)
		{
			return await GetByDayIDAsync(dayID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DayID（字段） 查询
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByDayID(DateTime dayID, int top_)
		{
			return GetByDayID(dayID, top_, string.Empty, null);
		}
		public async Task<List<S_user_dayEO>> GetByDayIDAsync(DateTime dayID, int top_)
		{
			return await GetByDayIDAsync(dayID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DayID（字段） 查询
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByDayID(DateTime dayID, int top_, TransactionManager tm_)
		{
			return GetByDayID(dayID, top_, string.Empty, tm_);
		}
		public async Task<List<S_user_dayEO>> GetByDayIDAsync(DateTime dayID, int top_, TransactionManager tm_)
		{
			return await GetByDayIDAsync(dayID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DayID（字段） 查询
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByDayID(DateTime dayID, string sort_)
		{
			return GetByDayID(dayID, 0, sort_, null);
		}
		public async Task<List<S_user_dayEO>> GetByDayIDAsync(DateTime dayID, string sort_)
		{
			return await GetByDayIDAsync(dayID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 DayID（字段） 查询
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByDayID(DateTime dayID, string sort_, TransactionManager tm_)
		{
			return GetByDayID(dayID, 0, sort_, tm_);
		}
		public async Task<List<S_user_dayEO>> GetByDayIDAsync(DateTime dayID, string sort_, TransactionManager tm_)
		{
			return await GetByDayIDAsync(dayID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 DayID（字段） 查询
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByDayID(DateTime dayID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`DayID` = @DayID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date));
			return Database.ExecSqlList(sql_, paras_, tm_, S_user_dayEO.MapDataReader);
		}
		public async Task<List<S_user_dayEO>> GetByDayIDAsync(DateTime dayID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`DayID` = @DayID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_user_dayEO.MapDataReader);
		}
		#endregion // GetByDayID
		#region GetByUserID
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByUserID(string userID)
		{
			return GetByUserID(userID, 0, string.Empty, null);
		}
		public async Task<List<S_user_dayEO>> GetByUserIDAsync(string userID)
		{
			return await GetByUserIDAsync(userID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByUserID(string userID, TransactionManager tm_)
		{
			return GetByUserID(userID, 0, string.Empty, tm_);
		}
		public async Task<List<S_user_dayEO>> GetByUserIDAsync(string userID, TransactionManager tm_)
		{
			return await GetByUserIDAsync(userID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByUserID(string userID, int top_)
		{
			return GetByUserID(userID, top_, string.Empty, null);
		}
		public async Task<List<S_user_dayEO>> GetByUserIDAsync(string userID, int top_)
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
		public List<S_user_dayEO> GetByUserID(string userID, int top_, TransactionManager tm_)
		{
			return GetByUserID(userID, top_, string.Empty, tm_);
		}
		public async Task<List<S_user_dayEO>> GetByUserIDAsync(string userID, int top_, TransactionManager tm_)
		{
			return await GetByUserIDAsync(userID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByUserID(string userID, string sort_)
		{
			return GetByUserID(userID, 0, sort_, null);
		}
		public async Task<List<S_user_dayEO>> GetByUserIDAsync(string userID, string sort_)
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
		public List<S_user_dayEO> GetByUserID(string userID, string sort_, TransactionManager tm_)
		{
			return GetByUserID(userID, 0, sort_, tm_);
		}
		public async Task<List<S_user_dayEO>> GetByUserIDAsync(string userID, string sort_, TransactionManager tm_)
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
		public List<S_user_dayEO> GetByUserID(string userID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UserID` = @UserID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_user_dayEO.MapDataReader);
		}
		public async Task<List<S_user_dayEO>> GetByUserIDAsync(string userID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UserID` = @UserID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_user_dayEO.MapDataReader);
		}
		#endregion // GetByUserID
		#region GetByFromMode
		
		/// <summary>
		/// 按 FromMode（字段） 查询
		/// </summary>
		/// /// <param name = "fromMode">新用户来源方式</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByFromMode(int fromMode)
		{
			return GetByFromMode(fromMode, 0, string.Empty, null);
		}
		public async Task<List<S_user_dayEO>> GetByFromModeAsync(int fromMode)
		{
			return await GetByFromModeAsync(fromMode, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 FromMode（字段） 查询
		/// </summary>
		/// /// <param name = "fromMode">新用户来源方式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByFromMode(int fromMode, TransactionManager tm_)
		{
			return GetByFromMode(fromMode, 0, string.Empty, tm_);
		}
		public async Task<List<S_user_dayEO>> GetByFromModeAsync(int fromMode, TransactionManager tm_)
		{
			return await GetByFromModeAsync(fromMode, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FromMode（字段） 查询
		/// </summary>
		/// /// <param name = "fromMode">新用户来源方式</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByFromMode(int fromMode, int top_)
		{
			return GetByFromMode(fromMode, top_, string.Empty, null);
		}
		public async Task<List<S_user_dayEO>> GetByFromModeAsync(int fromMode, int top_)
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
		public List<S_user_dayEO> GetByFromMode(int fromMode, int top_, TransactionManager tm_)
		{
			return GetByFromMode(fromMode, top_, string.Empty, tm_);
		}
		public async Task<List<S_user_dayEO>> GetByFromModeAsync(int fromMode, int top_, TransactionManager tm_)
		{
			return await GetByFromModeAsync(fromMode, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FromMode（字段） 查询
		/// </summary>
		/// /// <param name = "fromMode">新用户来源方式</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByFromMode(int fromMode, string sort_)
		{
			return GetByFromMode(fromMode, 0, sort_, null);
		}
		public async Task<List<S_user_dayEO>> GetByFromModeAsync(int fromMode, string sort_)
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
		public List<S_user_dayEO> GetByFromMode(int fromMode, string sort_, TransactionManager tm_)
		{
			return GetByFromMode(fromMode, 0, sort_, tm_);
		}
		public async Task<List<S_user_dayEO>> GetByFromModeAsync(int fromMode, string sort_, TransactionManager tm_)
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
		public List<S_user_dayEO> GetByFromMode(int fromMode, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`FromMode` = @FromMode", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FromMode", fromMode, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, S_user_dayEO.MapDataReader);
		}
		public async Task<List<S_user_dayEO>> GetByFromModeAsync(int fromMode, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`FromMode` = @FromMode", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FromMode", fromMode, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_user_dayEO.MapDataReader);
		}
		#endregion // GetByFromMode
		#region GetByFromId
		
		/// <summary>
		/// 按 FromId（字段） 查询
		/// </summary>
		/// /// <param name = "fromId">对应的编码（根据FromMode变化）</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByFromId(string fromId)
		{
			return GetByFromId(fromId, 0, string.Empty, null);
		}
		public async Task<List<S_user_dayEO>> GetByFromIdAsync(string fromId)
		{
			return await GetByFromIdAsync(fromId, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 FromId（字段） 查询
		/// </summary>
		/// /// <param name = "fromId">对应的编码（根据FromMode变化）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByFromId(string fromId, TransactionManager tm_)
		{
			return GetByFromId(fromId, 0, string.Empty, tm_);
		}
		public async Task<List<S_user_dayEO>> GetByFromIdAsync(string fromId, TransactionManager tm_)
		{
			return await GetByFromIdAsync(fromId, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FromId（字段） 查询
		/// </summary>
		/// /// <param name = "fromId">对应的编码（根据FromMode变化）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByFromId(string fromId, int top_)
		{
			return GetByFromId(fromId, top_, string.Empty, null);
		}
		public async Task<List<S_user_dayEO>> GetByFromIdAsync(string fromId, int top_)
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
		public List<S_user_dayEO> GetByFromId(string fromId, int top_, TransactionManager tm_)
		{
			return GetByFromId(fromId, top_, string.Empty, tm_);
		}
		public async Task<List<S_user_dayEO>> GetByFromIdAsync(string fromId, int top_, TransactionManager tm_)
		{
			return await GetByFromIdAsync(fromId, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FromId（字段） 查询
		/// </summary>
		/// /// <param name = "fromId">对应的编码（根据FromMode变化）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByFromId(string fromId, string sort_)
		{
			return GetByFromId(fromId, 0, sort_, null);
		}
		public async Task<List<S_user_dayEO>> GetByFromIdAsync(string fromId, string sort_)
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
		public List<S_user_dayEO> GetByFromId(string fromId, string sort_, TransactionManager tm_)
		{
			return GetByFromId(fromId, 0, sort_, tm_);
		}
		public async Task<List<S_user_dayEO>> GetByFromIdAsync(string fromId, string sort_, TransactionManager tm_)
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
		public List<S_user_dayEO> GetByFromId(string fromId, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(fromId != null ? "`FromId` = @FromId" : "`FromId` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (fromId != null)
				paras_.Add(Database.CreateInParameter("@FromId", fromId, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_user_dayEO.MapDataReader);
		}
		public async Task<List<S_user_dayEO>> GetByFromIdAsync(string fromId, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(fromId != null ? "`FromId` = @FromId" : "`FromId` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (fromId != null)
				paras_.Add(Database.CreateInParameter("@FromId", fromId, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_user_dayEO.MapDataReader);
		}
		#endregion // GetByFromId
		#region GetByUserKind
		
		/// <summary>
		/// 按 UserKind（字段） 查询
		/// </summary>
		/// /// <param name = "userKind">用户类型</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByUserKind(int userKind)
		{
			return GetByUserKind(userKind, 0, string.Empty, null);
		}
		public async Task<List<S_user_dayEO>> GetByUserKindAsync(int userKind)
		{
			return await GetByUserKindAsync(userKind, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UserKind（字段） 查询
		/// </summary>
		/// /// <param name = "userKind">用户类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByUserKind(int userKind, TransactionManager tm_)
		{
			return GetByUserKind(userKind, 0, string.Empty, tm_);
		}
		public async Task<List<S_user_dayEO>> GetByUserKindAsync(int userKind, TransactionManager tm_)
		{
			return await GetByUserKindAsync(userKind, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserKind（字段） 查询
		/// </summary>
		/// /// <param name = "userKind">用户类型</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByUserKind(int userKind, int top_)
		{
			return GetByUserKind(userKind, top_, string.Empty, null);
		}
		public async Task<List<S_user_dayEO>> GetByUserKindAsync(int userKind, int top_)
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
		public List<S_user_dayEO> GetByUserKind(int userKind, int top_, TransactionManager tm_)
		{
			return GetByUserKind(userKind, top_, string.Empty, tm_);
		}
		public async Task<List<S_user_dayEO>> GetByUserKindAsync(int userKind, int top_, TransactionManager tm_)
		{
			return await GetByUserKindAsync(userKind, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserKind（字段） 查询
		/// </summary>
		/// /// <param name = "userKind">用户类型</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByUserKind(int userKind, string sort_)
		{
			return GetByUserKind(userKind, 0, sort_, null);
		}
		public async Task<List<S_user_dayEO>> GetByUserKindAsync(int userKind, string sort_)
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
		public List<S_user_dayEO> GetByUserKind(int userKind, string sort_, TransactionManager tm_)
		{
			return GetByUserKind(userKind, 0, sort_, tm_);
		}
		public async Task<List<S_user_dayEO>> GetByUserKindAsync(int userKind, string sort_, TransactionManager tm_)
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
		public List<S_user_dayEO> GetByUserKind(int userKind, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UserKind` = @UserKind", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserKind", userKind, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, S_user_dayEO.MapDataReader);
		}
		public async Task<List<S_user_dayEO>> GetByUserKindAsync(int userKind, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UserKind` = @UserKind", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserKind", userKind, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_user_dayEO.MapDataReader);
		}
		#endregion // GetByUserKind
		#region GetByOperatorID
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByOperatorID(string operatorID)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, null);
		}
		public async Task<List<S_user_dayEO>> GetByOperatorIDAsync(string operatorID)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByOperatorID(string operatorID, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, tm_);
		}
		public async Task<List<S_user_dayEO>> GetByOperatorIDAsync(string operatorID, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByOperatorID(string operatorID, int top_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, null);
		}
		public async Task<List<S_user_dayEO>> GetByOperatorIDAsync(string operatorID, int top_)
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
		public List<S_user_dayEO> GetByOperatorID(string operatorID, int top_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, tm_);
		}
		public async Task<List<S_user_dayEO>> GetByOperatorIDAsync(string operatorID, int top_, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByOperatorID(string operatorID, string sort_)
		{
			return GetByOperatorID(operatorID, 0, sort_, null);
		}
		public async Task<List<S_user_dayEO>> GetByOperatorIDAsync(string operatorID, string sort_)
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
		public List<S_user_dayEO> GetByOperatorID(string operatorID, string sort_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, sort_, tm_);
		}
		public async Task<List<S_user_dayEO>> GetByOperatorIDAsync(string operatorID, string sort_, TransactionManager tm_)
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
		public List<S_user_dayEO> GetByOperatorID(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(operatorID != null ? "`OperatorID` = @OperatorID" : "`OperatorID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (operatorID != null)
				paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_user_dayEO.MapDataReader);
		}
		public async Task<List<S_user_dayEO>> GetByOperatorIDAsync(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(operatorID != null ? "`OperatorID` = @OperatorID" : "`OperatorID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (operatorID != null)
				paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_user_dayEO.MapDataReader);
		}
		#endregion // GetByOperatorID
		#region GetByCountryID
		
		/// <summary>
		/// 按 CountryID（字段） 查询
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByCountryID(string countryID)
		{
			return GetByCountryID(countryID, 0, string.Empty, null);
		}
		public async Task<List<S_user_dayEO>> GetByCountryIDAsync(string countryID)
		{
			return await GetByCountryIDAsync(countryID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CountryID（字段） 查询
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByCountryID(string countryID, TransactionManager tm_)
		{
			return GetByCountryID(countryID, 0, string.Empty, tm_);
		}
		public async Task<List<S_user_dayEO>> GetByCountryIDAsync(string countryID, TransactionManager tm_)
		{
			return await GetByCountryIDAsync(countryID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CountryID（字段） 查询
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByCountryID(string countryID, int top_)
		{
			return GetByCountryID(countryID, top_, string.Empty, null);
		}
		public async Task<List<S_user_dayEO>> GetByCountryIDAsync(string countryID, int top_)
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
		public List<S_user_dayEO> GetByCountryID(string countryID, int top_, TransactionManager tm_)
		{
			return GetByCountryID(countryID, top_, string.Empty, tm_);
		}
		public async Task<List<S_user_dayEO>> GetByCountryIDAsync(string countryID, int top_, TransactionManager tm_)
		{
			return await GetByCountryIDAsync(countryID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CountryID（字段） 查询
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByCountryID(string countryID, string sort_)
		{
			return GetByCountryID(countryID, 0, sort_, null);
		}
		public async Task<List<S_user_dayEO>> GetByCountryIDAsync(string countryID, string sort_)
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
		public List<S_user_dayEO> GetByCountryID(string countryID, string sort_, TransactionManager tm_)
		{
			return GetByCountryID(countryID, 0, sort_, tm_);
		}
		public async Task<List<S_user_dayEO>> GetByCountryIDAsync(string countryID, string sort_, TransactionManager tm_)
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
		public List<S_user_dayEO> GetByCountryID(string countryID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(countryID != null ? "`CountryID` = @CountryID" : "`CountryID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (countryID != null)
				paras_.Add(Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_user_dayEO.MapDataReader);
		}
		public async Task<List<S_user_dayEO>> GetByCountryIDAsync(string countryID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(countryID != null ? "`CountryID` = @CountryID" : "`CountryID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (countryID != null)
				paras_.Add(Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_user_dayEO.MapDataReader);
		}
		#endregion // GetByCountryID
		#region GetByCurrencyID
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByCurrencyID(string currencyID)
		{
			return GetByCurrencyID(currencyID, 0, string.Empty, null);
		}
		public async Task<List<S_user_dayEO>> GetByCurrencyIDAsync(string currencyID)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByCurrencyID(string currencyID, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, 0, string.Empty, tm_);
		}
		public async Task<List<S_user_dayEO>> GetByCurrencyIDAsync(string currencyID, TransactionManager tm_)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByCurrencyID(string currencyID, int top_)
		{
			return GetByCurrencyID(currencyID, top_, string.Empty, null);
		}
		public async Task<List<S_user_dayEO>> GetByCurrencyIDAsync(string currencyID, int top_)
		{
			return await GetByCurrencyIDAsync(currencyID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByCurrencyID(string currencyID, int top_, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, top_, string.Empty, tm_);
		}
		public async Task<List<S_user_dayEO>> GetByCurrencyIDAsync(string currencyID, int top_, TransactionManager tm_)
		{
			return await GetByCurrencyIDAsync(currencyID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByCurrencyID(string currencyID, string sort_)
		{
			return GetByCurrencyID(currencyID, 0, sort_, null);
		}
		public async Task<List<S_user_dayEO>> GetByCurrencyIDAsync(string currencyID, string sort_)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByCurrencyID(string currencyID, string sort_, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, 0, sort_, tm_);
		}
		public async Task<List<S_user_dayEO>> GetByCurrencyIDAsync(string currencyID, string sort_, TransactionManager tm_)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByCurrencyID(string currencyID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(currencyID != null ? "`CurrencyID` = @CurrencyID" : "`CurrencyID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (currencyID != null)
				paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_user_dayEO.MapDataReader);
		}
		public async Task<List<S_user_dayEO>> GetByCurrencyIDAsync(string currencyID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(currencyID != null ? "`CurrencyID` = @CurrencyID" : "`CurrencyID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (currencyID != null)
				paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_user_dayEO.MapDataReader);
		}
		#endregion // GetByCurrencyID
		#region GetByIsNew
		
		/// <summary>
		/// 按 IsNew（字段） 查询
		/// </summary>
		/// /// <param name = "isNew">是否新用户</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByIsNew(bool isNew)
		{
			return GetByIsNew(isNew, 0, string.Empty, null);
		}
		public async Task<List<S_user_dayEO>> GetByIsNewAsync(bool isNew)
		{
			return await GetByIsNewAsync(isNew, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 IsNew（字段） 查询
		/// </summary>
		/// /// <param name = "isNew">是否新用户</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByIsNew(bool isNew, TransactionManager tm_)
		{
			return GetByIsNew(isNew, 0, string.Empty, tm_);
		}
		public async Task<List<S_user_dayEO>> GetByIsNewAsync(bool isNew, TransactionManager tm_)
		{
			return await GetByIsNewAsync(isNew, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IsNew（字段） 查询
		/// </summary>
		/// /// <param name = "isNew">是否新用户</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByIsNew(bool isNew, int top_)
		{
			return GetByIsNew(isNew, top_, string.Empty, null);
		}
		public async Task<List<S_user_dayEO>> GetByIsNewAsync(bool isNew, int top_)
		{
			return await GetByIsNewAsync(isNew, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 IsNew（字段） 查询
		/// </summary>
		/// /// <param name = "isNew">是否新用户</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByIsNew(bool isNew, int top_, TransactionManager tm_)
		{
			return GetByIsNew(isNew, top_, string.Empty, tm_);
		}
		public async Task<List<S_user_dayEO>> GetByIsNewAsync(bool isNew, int top_, TransactionManager tm_)
		{
			return await GetByIsNewAsync(isNew, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IsNew（字段） 查询
		/// </summary>
		/// /// <param name = "isNew">是否新用户</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByIsNew(bool isNew, string sort_)
		{
			return GetByIsNew(isNew, 0, sort_, null);
		}
		public async Task<List<S_user_dayEO>> GetByIsNewAsync(bool isNew, string sort_)
		{
			return await GetByIsNewAsync(isNew, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 IsNew（字段） 查询
		/// </summary>
		/// /// <param name = "isNew">是否新用户</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByIsNew(bool isNew, string sort_, TransactionManager tm_)
		{
			return GetByIsNew(isNew, 0, sort_, tm_);
		}
		public async Task<List<S_user_dayEO>> GetByIsNewAsync(bool isNew, string sort_, TransactionManager tm_)
		{
			return await GetByIsNewAsync(isNew, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 IsNew（字段） 查询
		/// </summary>
		/// /// <param name = "isNew">是否新用户</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByIsNew(bool isNew, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`IsNew` = @IsNew", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IsNew", isNew, MySqlDbType.Byte));
			return Database.ExecSqlList(sql_, paras_, tm_, S_user_dayEO.MapDataReader);
		}
		public async Task<List<S_user_dayEO>> GetByIsNewAsync(bool isNew, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`IsNew` = @IsNew", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IsNew", isNew, MySqlDbType.Byte));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_user_dayEO.MapDataReader);
		}
		#endregion // GetByIsNew
		#region GetByIsLogin
		
		/// <summary>
		/// 按 IsLogin（字段） 查询
		/// </summary>
		/// /// <param name = "isLogin">当天是否登录</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByIsLogin(bool isLogin)
		{
			return GetByIsLogin(isLogin, 0, string.Empty, null);
		}
		public async Task<List<S_user_dayEO>> GetByIsLoginAsync(bool isLogin)
		{
			return await GetByIsLoginAsync(isLogin, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 IsLogin（字段） 查询
		/// </summary>
		/// /// <param name = "isLogin">当天是否登录</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByIsLogin(bool isLogin, TransactionManager tm_)
		{
			return GetByIsLogin(isLogin, 0, string.Empty, tm_);
		}
		public async Task<List<S_user_dayEO>> GetByIsLoginAsync(bool isLogin, TransactionManager tm_)
		{
			return await GetByIsLoginAsync(isLogin, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IsLogin（字段） 查询
		/// </summary>
		/// /// <param name = "isLogin">当天是否登录</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByIsLogin(bool isLogin, int top_)
		{
			return GetByIsLogin(isLogin, top_, string.Empty, null);
		}
		public async Task<List<S_user_dayEO>> GetByIsLoginAsync(bool isLogin, int top_)
		{
			return await GetByIsLoginAsync(isLogin, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 IsLogin（字段） 查询
		/// </summary>
		/// /// <param name = "isLogin">当天是否登录</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByIsLogin(bool isLogin, int top_, TransactionManager tm_)
		{
			return GetByIsLogin(isLogin, top_, string.Empty, tm_);
		}
		public async Task<List<S_user_dayEO>> GetByIsLoginAsync(bool isLogin, int top_, TransactionManager tm_)
		{
			return await GetByIsLoginAsync(isLogin, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IsLogin（字段） 查询
		/// </summary>
		/// /// <param name = "isLogin">当天是否登录</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByIsLogin(bool isLogin, string sort_)
		{
			return GetByIsLogin(isLogin, 0, sort_, null);
		}
		public async Task<List<S_user_dayEO>> GetByIsLoginAsync(bool isLogin, string sort_)
		{
			return await GetByIsLoginAsync(isLogin, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 IsLogin（字段） 查询
		/// </summary>
		/// /// <param name = "isLogin">当天是否登录</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByIsLogin(bool isLogin, string sort_, TransactionManager tm_)
		{
			return GetByIsLogin(isLogin, 0, sort_, tm_);
		}
		public async Task<List<S_user_dayEO>> GetByIsLoginAsync(bool isLogin, string sort_, TransactionManager tm_)
		{
			return await GetByIsLoginAsync(isLogin, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 IsLogin（字段） 查询
		/// </summary>
		/// /// <param name = "isLogin">当天是否登录</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByIsLogin(bool isLogin, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`IsLogin` = @IsLogin", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IsLogin", isLogin, MySqlDbType.Byte));
			return Database.ExecSqlList(sql_, paras_, tm_, S_user_dayEO.MapDataReader);
		}
		public async Task<List<S_user_dayEO>> GetByIsLoginAsync(bool isLogin, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`IsLogin` = @IsLogin", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IsLogin", isLogin, MySqlDbType.Byte));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_user_dayEO.MapDataReader);
		}
		#endregion // GetByIsLogin
		#region GetByLoginDays
		
		/// <summary>
		/// 按 LoginDays（字段） 查询
		/// </summary>
		/// /// <param name = "loginDays">连续登录天数</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByLoginDays(int loginDays)
		{
			return GetByLoginDays(loginDays, 0, string.Empty, null);
		}
		public async Task<List<S_user_dayEO>> GetByLoginDaysAsync(int loginDays)
		{
			return await GetByLoginDaysAsync(loginDays, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LoginDays（字段） 查询
		/// </summary>
		/// /// <param name = "loginDays">连续登录天数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByLoginDays(int loginDays, TransactionManager tm_)
		{
			return GetByLoginDays(loginDays, 0, string.Empty, tm_);
		}
		public async Task<List<S_user_dayEO>> GetByLoginDaysAsync(int loginDays, TransactionManager tm_)
		{
			return await GetByLoginDaysAsync(loginDays, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LoginDays（字段） 查询
		/// </summary>
		/// /// <param name = "loginDays">连续登录天数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByLoginDays(int loginDays, int top_)
		{
			return GetByLoginDays(loginDays, top_, string.Empty, null);
		}
		public async Task<List<S_user_dayEO>> GetByLoginDaysAsync(int loginDays, int top_)
		{
			return await GetByLoginDaysAsync(loginDays, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LoginDays（字段） 查询
		/// </summary>
		/// /// <param name = "loginDays">连续登录天数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByLoginDays(int loginDays, int top_, TransactionManager tm_)
		{
			return GetByLoginDays(loginDays, top_, string.Empty, tm_);
		}
		public async Task<List<S_user_dayEO>> GetByLoginDaysAsync(int loginDays, int top_, TransactionManager tm_)
		{
			return await GetByLoginDaysAsync(loginDays, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LoginDays（字段） 查询
		/// </summary>
		/// /// <param name = "loginDays">连续登录天数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByLoginDays(int loginDays, string sort_)
		{
			return GetByLoginDays(loginDays, 0, sort_, null);
		}
		public async Task<List<S_user_dayEO>> GetByLoginDaysAsync(int loginDays, string sort_)
		{
			return await GetByLoginDaysAsync(loginDays, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 LoginDays（字段） 查询
		/// </summary>
		/// /// <param name = "loginDays">连续登录天数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByLoginDays(int loginDays, string sort_, TransactionManager tm_)
		{
			return GetByLoginDays(loginDays, 0, sort_, tm_);
		}
		public async Task<List<S_user_dayEO>> GetByLoginDaysAsync(int loginDays, string sort_, TransactionManager tm_)
		{
			return await GetByLoginDaysAsync(loginDays, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 LoginDays（字段） 查询
		/// </summary>
		/// /// <param name = "loginDays">连续登录天数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByLoginDays(int loginDays, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`LoginDays` = @LoginDays", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@LoginDays", loginDays, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, S_user_dayEO.MapDataReader);
		}
		public async Task<List<S_user_dayEO>> GetByLoginDaysAsync(int loginDays, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`LoginDays` = @LoginDays", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@LoginDays", loginDays, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_user_dayEO.MapDataReader);
		}
		#endregion // GetByLoginDays
		#region GetByLastLoginTime
		
		/// <summary>
		/// 按 LastLoginTime（字段） 查询
		/// </summary>
		/// /// <param name = "lastLoginTime">上次登录时间</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByLastLoginTime(DateTime? lastLoginTime)
		{
			return GetByLastLoginTime(lastLoginTime, 0, string.Empty, null);
		}
		public async Task<List<S_user_dayEO>> GetByLastLoginTimeAsync(DateTime? lastLoginTime)
		{
			return await GetByLastLoginTimeAsync(lastLoginTime, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LastLoginTime（字段） 查询
		/// </summary>
		/// /// <param name = "lastLoginTime">上次登录时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByLastLoginTime(DateTime? lastLoginTime, TransactionManager tm_)
		{
			return GetByLastLoginTime(lastLoginTime, 0, string.Empty, tm_);
		}
		public async Task<List<S_user_dayEO>> GetByLastLoginTimeAsync(DateTime? lastLoginTime, TransactionManager tm_)
		{
			return await GetByLastLoginTimeAsync(lastLoginTime, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LastLoginTime（字段） 查询
		/// </summary>
		/// /// <param name = "lastLoginTime">上次登录时间</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByLastLoginTime(DateTime? lastLoginTime, int top_)
		{
			return GetByLastLoginTime(lastLoginTime, top_, string.Empty, null);
		}
		public async Task<List<S_user_dayEO>> GetByLastLoginTimeAsync(DateTime? lastLoginTime, int top_)
		{
			return await GetByLastLoginTimeAsync(lastLoginTime, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LastLoginTime（字段） 查询
		/// </summary>
		/// /// <param name = "lastLoginTime">上次登录时间</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByLastLoginTime(DateTime? lastLoginTime, int top_, TransactionManager tm_)
		{
			return GetByLastLoginTime(lastLoginTime, top_, string.Empty, tm_);
		}
		public async Task<List<S_user_dayEO>> GetByLastLoginTimeAsync(DateTime? lastLoginTime, int top_, TransactionManager tm_)
		{
			return await GetByLastLoginTimeAsync(lastLoginTime, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LastLoginTime（字段） 查询
		/// </summary>
		/// /// <param name = "lastLoginTime">上次登录时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByLastLoginTime(DateTime? lastLoginTime, string sort_)
		{
			return GetByLastLoginTime(lastLoginTime, 0, sort_, null);
		}
		public async Task<List<S_user_dayEO>> GetByLastLoginTimeAsync(DateTime? lastLoginTime, string sort_)
		{
			return await GetByLastLoginTimeAsync(lastLoginTime, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 LastLoginTime（字段） 查询
		/// </summary>
		/// /// <param name = "lastLoginTime">上次登录时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByLastLoginTime(DateTime? lastLoginTime, string sort_, TransactionManager tm_)
		{
			return GetByLastLoginTime(lastLoginTime, 0, sort_, tm_);
		}
		public async Task<List<S_user_dayEO>> GetByLastLoginTimeAsync(DateTime? lastLoginTime, string sort_, TransactionManager tm_)
		{
			return await GetByLastLoginTimeAsync(lastLoginTime, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 LastLoginTime（字段） 查询
		/// </summary>
		/// /// <param name = "lastLoginTime">上次登录时间</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByLastLoginTime(DateTime? lastLoginTime, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(lastLoginTime.HasValue ? "`LastLoginTime` = @LastLoginTime" : "`LastLoginTime` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (lastLoginTime.HasValue)
				paras_.Add(Database.CreateInParameter("@LastLoginTime", lastLoginTime.Value, MySqlDbType.DateTime));
			return Database.ExecSqlList(sql_, paras_, tm_, S_user_dayEO.MapDataReader);
		}
		public async Task<List<S_user_dayEO>> GetByLastLoginTimeAsync(DateTime? lastLoginTime, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(lastLoginTime.HasValue ? "`LastLoginTime` = @LastLoginTime" : "`LastLoginTime` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (lastLoginTime.HasValue)
				paras_.Add(Database.CreateInParameter("@LastLoginTime", lastLoginTime.Value, MySqlDbType.DateTime));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_user_dayEO.MapDataReader);
		}
		#endregion // GetByLastLoginTime
		#region GetByIsRegister
		
		/// <summary>
		/// 按 IsRegister（字段） 查询
		/// </summary>
		/// /// <param name = "isRegister">当天是否进行了注册</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByIsRegister(bool isRegister)
		{
			return GetByIsRegister(isRegister, 0, string.Empty, null);
		}
		public async Task<List<S_user_dayEO>> GetByIsRegisterAsync(bool isRegister)
		{
			return await GetByIsRegisterAsync(isRegister, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 IsRegister（字段） 查询
		/// </summary>
		/// /// <param name = "isRegister">当天是否进行了注册</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByIsRegister(bool isRegister, TransactionManager tm_)
		{
			return GetByIsRegister(isRegister, 0, string.Empty, tm_);
		}
		public async Task<List<S_user_dayEO>> GetByIsRegisterAsync(bool isRegister, TransactionManager tm_)
		{
			return await GetByIsRegisterAsync(isRegister, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IsRegister（字段） 查询
		/// </summary>
		/// /// <param name = "isRegister">当天是否进行了注册</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByIsRegister(bool isRegister, int top_)
		{
			return GetByIsRegister(isRegister, top_, string.Empty, null);
		}
		public async Task<List<S_user_dayEO>> GetByIsRegisterAsync(bool isRegister, int top_)
		{
			return await GetByIsRegisterAsync(isRegister, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 IsRegister（字段） 查询
		/// </summary>
		/// /// <param name = "isRegister">当天是否进行了注册</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByIsRegister(bool isRegister, int top_, TransactionManager tm_)
		{
			return GetByIsRegister(isRegister, top_, string.Empty, tm_);
		}
		public async Task<List<S_user_dayEO>> GetByIsRegisterAsync(bool isRegister, int top_, TransactionManager tm_)
		{
			return await GetByIsRegisterAsync(isRegister, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IsRegister（字段） 查询
		/// </summary>
		/// /// <param name = "isRegister">当天是否进行了注册</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByIsRegister(bool isRegister, string sort_)
		{
			return GetByIsRegister(isRegister, 0, sort_, null);
		}
		public async Task<List<S_user_dayEO>> GetByIsRegisterAsync(bool isRegister, string sort_)
		{
			return await GetByIsRegisterAsync(isRegister, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 IsRegister（字段） 查询
		/// </summary>
		/// /// <param name = "isRegister">当天是否进行了注册</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByIsRegister(bool isRegister, string sort_, TransactionManager tm_)
		{
			return GetByIsRegister(isRegister, 0, sort_, tm_);
		}
		public async Task<List<S_user_dayEO>> GetByIsRegisterAsync(bool isRegister, string sort_, TransactionManager tm_)
		{
			return await GetByIsRegisterAsync(isRegister, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 IsRegister（字段） 查询
		/// </summary>
		/// /// <param name = "isRegister">当天是否进行了注册</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByIsRegister(bool isRegister, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`IsRegister` = @IsRegister", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IsRegister", isRegister, MySqlDbType.Byte));
			return Database.ExecSqlList(sql_, paras_, tm_, S_user_dayEO.MapDataReader);
		}
		public async Task<List<S_user_dayEO>> GetByIsRegisterAsync(bool isRegister, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`IsRegister` = @IsRegister", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IsRegister", isRegister, MySqlDbType.Byte));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_user_dayEO.MapDataReader);
		}
		#endregion // GetByIsRegister
		#region GetByRegistDate
		
		/// <summary>
		/// 按 RegistDate（字段） 查询
		/// </summary>
		/// /// <param name = "registDate">注册时间</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByRegistDate(DateTime? registDate)
		{
			return GetByRegistDate(registDate, 0, string.Empty, null);
		}
		public async Task<List<S_user_dayEO>> GetByRegistDateAsync(DateTime? registDate)
		{
			return await GetByRegistDateAsync(registDate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RegistDate（字段） 查询
		/// </summary>
		/// /// <param name = "registDate">注册时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByRegistDate(DateTime? registDate, TransactionManager tm_)
		{
			return GetByRegistDate(registDate, 0, string.Empty, tm_);
		}
		public async Task<List<S_user_dayEO>> GetByRegistDateAsync(DateTime? registDate, TransactionManager tm_)
		{
			return await GetByRegistDateAsync(registDate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RegistDate（字段） 查询
		/// </summary>
		/// /// <param name = "registDate">注册时间</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByRegistDate(DateTime? registDate, int top_)
		{
			return GetByRegistDate(registDate, top_, string.Empty, null);
		}
		public async Task<List<S_user_dayEO>> GetByRegistDateAsync(DateTime? registDate, int top_)
		{
			return await GetByRegistDateAsync(registDate, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RegistDate（字段） 查询
		/// </summary>
		/// /// <param name = "registDate">注册时间</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByRegistDate(DateTime? registDate, int top_, TransactionManager tm_)
		{
			return GetByRegistDate(registDate, top_, string.Empty, tm_);
		}
		public async Task<List<S_user_dayEO>> GetByRegistDateAsync(DateTime? registDate, int top_, TransactionManager tm_)
		{
			return await GetByRegistDateAsync(registDate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RegistDate（字段） 查询
		/// </summary>
		/// /// <param name = "registDate">注册时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByRegistDate(DateTime? registDate, string sort_)
		{
			return GetByRegistDate(registDate, 0, sort_, null);
		}
		public async Task<List<S_user_dayEO>> GetByRegistDateAsync(DateTime? registDate, string sort_)
		{
			return await GetByRegistDateAsync(registDate, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 RegistDate（字段） 查询
		/// </summary>
		/// /// <param name = "registDate">注册时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByRegistDate(DateTime? registDate, string sort_, TransactionManager tm_)
		{
			return GetByRegistDate(registDate, 0, sort_, tm_);
		}
		public async Task<List<S_user_dayEO>> GetByRegistDateAsync(DateTime? registDate, string sort_, TransactionManager tm_)
		{
			return await GetByRegistDateAsync(registDate, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 RegistDate（字段） 查询
		/// </summary>
		/// /// <param name = "registDate">注册时间</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByRegistDate(DateTime? registDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(registDate.HasValue ? "`RegistDate` = @RegistDate" : "`RegistDate` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (registDate.HasValue)
				paras_.Add(Database.CreateInParameter("@RegistDate", registDate.Value, MySqlDbType.DateTime));
			return Database.ExecSqlList(sql_, paras_, tm_, S_user_dayEO.MapDataReader);
		}
		public async Task<List<S_user_dayEO>> GetByRegistDateAsync(DateTime? registDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(registDate.HasValue ? "`RegistDate` = @RegistDate" : "`RegistDate` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (registDate.HasValue)
				paras_.Add(Database.CreateInParameter("@RegistDate", registDate.Value, MySqlDbType.DateTime));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_user_dayEO.MapDataReader);
		}
		#endregion // GetByRegistDate
		#region GetByIsNewBet
		
		/// <summary>
		/// 按 IsNewBet（字段） 查询
		/// </summary>
		/// /// <param name = "isNewBet">是否是第一次下注用户</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByIsNewBet(bool isNewBet)
		{
			return GetByIsNewBet(isNewBet, 0, string.Empty, null);
		}
		public async Task<List<S_user_dayEO>> GetByIsNewBetAsync(bool isNewBet)
		{
			return await GetByIsNewBetAsync(isNewBet, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 IsNewBet（字段） 查询
		/// </summary>
		/// /// <param name = "isNewBet">是否是第一次下注用户</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByIsNewBet(bool isNewBet, TransactionManager tm_)
		{
			return GetByIsNewBet(isNewBet, 0, string.Empty, tm_);
		}
		public async Task<List<S_user_dayEO>> GetByIsNewBetAsync(bool isNewBet, TransactionManager tm_)
		{
			return await GetByIsNewBetAsync(isNewBet, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IsNewBet（字段） 查询
		/// </summary>
		/// /// <param name = "isNewBet">是否是第一次下注用户</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByIsNewBet(bool isNewBet, int top_)
		{
			return GetByIsNewBet(isNewBet, top_, string.Empty, null);
		}
		public async Task<List<S_user_dayEO>> GetByIsNewBetAsync(bool isNewBet, int top_)
		{
			return await GetByIsNewBetAsync(isNewBet, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 IsNewBet（字段） 查询
		/// </summary>
		/// /// <param name = "isNewBet">是否是第一次下注用户</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByIsNewBet(bool isNewBet, int top_, TransactionManager tm_)
		{
			return GetByIsNewBet(isNewBet, top_, string.Empty, tm_);
		}
		public async Task<List<S_user_dayEO>> GetByIsNewBetAsync(bool isNewBet, int top_, TransactionManager tm_)
		{
			return await GetByIsNewBetAsync(isNewBet, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IsNewBet（字段） 查询
		/// </summary>
		/// /// <param name = "isNewBet">是否是第一次下注用户</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByIsNewBet(bool isNewBet, string sort_)
		{
			return GetByIsNewBet(isNewBet, 0, sort_, null);
		}
		public async Task<List<S_user_dayEO>> GetByIsNewBetAsync(bool isNewBet, string sort_)
		{
			return await GetByIsNewBetAsync(isNewBet, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 IsNewBet（字段） 查询
		/// </summary>
		/// /// <param name = "isNewBet">是否是第一次下注用户</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByIsNewBet(bool isNewBet, string sort_, TransactionManager tm_)
		{
			return GetByIsNewBet(isNewBet, 0, sort_, tm_);
		}
		public async Task<List<S_user_dayEO>> GetByIsNewBetAsync(bool isNewBet, string sort_, TransactionManager tm_)
		{
			return await GetByIsNewBetAsync(isNewBet, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 IsNewBet（字段） 查询
		/// </summary>
		/// /// <param name = "isNewBet">是否是第一次下注用户</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByIsNewBet(bool isNewBet, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`IsNewBet` = @IsNewBet", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IsNewBet", isNewBet, MySqlDbType.Byte));
			return Database.ExecSqlList(sql_, paras_, tm_, S_user_dayEO.MapDataReader);
		}
		public async Task<List<S_user_dayEO>> GetByIsNewBetAsync(bool isNewBet, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`IsNewBet` = @IsNewBet", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IsNewBet", isNewBet, MySqlDbType.Byte));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_user_dayEO.MapDataReader);
		}
		#endregion // GetByIsNewBet
		#region GetByHasBet
		
		/// <summary>
		/// 按 HasBet（字段） 查询
		/// </summary>
		/// /// <param name = "hasBet">当天是否下注</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByHasBet(bool hasBet)
		{
			return GetByHasBet(hasBet, 0, string.Empty, null);
		}
		public async Task<List<S_user_dayEO>> GetByHasBetAsync(bool hasBet)
		{
			return await GetByHasBetAsync(hasBet, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 HasBet（字段） 查询
		/// </summary>
		/// /// <param name = "hasBet">当天是否下注</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByHasBet(bool hasBet, TransactionManager tm_)
		{
			return GetByHasBet(hasBet, 0, string.Empty, tm_);
		}
		public async Task<List<S_user_dayEO>> GetByHasBetAsync(bool hasBet, TransactionManager tm_)
		{
			return await GetByHasBetAsync(hasBet, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 HasBet（字段） 查询
		/// </summary>
		/// /// <param name = "hasBet">当天是否下注</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByHasBet(bool hasBet, int top_)
		{
			return GetByHasBet(hasBet, top_, string.Empty, null);
		}
		public async Task<List<S_user_dayEO>> GetByHasBetAsync(bool hasBet, int top_)
		{
			return await GetByHasBetAsync(hasBet, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 HasBet（字段） 查询
		/// </summary>
		/// /// <param name = "hasBet">当天是否下注</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByHasBet(bool hasBet, int top_, TransactionManager tm_)
		{
			return GetByHasBet(hasBet, top_, string.Empty, tm_);
		}
		public async Task<List<S_user_dayEO>> GetByHasBetAsync(bool hasBet, int top_, TransactionManager tm_)
		{
			return await GetByHasBetAsync(hasBet, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 HasBet（字段） 查询
		/// </summary>
		/// /// <param name = "hasBet">当天是否下注</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByHasBet(bool hasBet, string sort_)
		{
			return GetByHasBet(hasBet, 0, sort_, null);
		}
		public async Task<List<S_user_dayEO>> GetByHasBetAsync(bool hasBet, string sort_)
		{
			return await GetByHasBetAsync(hasBet, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 HasBet（字段） 查询
		/// </summary>
		/// /// <param name = "hasBet">当天是否下注</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByHasBet(bool hasBet, string sort_, TransactionManager tm_)
		{
			return GetByHasBet(hasBet, 0, sort_, tm_);
		}
		public async Task<List<S_user_dayEO>> GetByHasBetAsync(bool hasBet, string sort_, TransactionManager tm_)
		{
			return await GetByHasBetAsync(hasBet, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 HasBet（字段） 查询
		/// </summary>
		/// /// <param name = "hasBet">当天是否下注</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByHasBet(bool hasBet, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`HasBet` = @HasBet", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@HasBet", hasBet, MySqlDbType.Byte));
			return Database.ExecSqlList(sql_, paras_, tm_, S_user_dayEO.MapDataReader);
		}
		public async Task<List<S_user_dayEO>> GetByHasBetAsync(bool hasBet, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`HasBet` = @HasBet", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@HasBet", hasBet, MySqlDbType.Byte));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_user_dayEO.MapDataReader);
		}
		#endregion // GetByHasBet
		#region GetByIsNewPay
		
		/// <summary>
		/// 按 IsNewPay（字段） 查询
		/// </summary>
		/// /// <param name = "isNewPay">是否是第一次充值用户</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByIsNewPay(bool isNewPay)
		{
			return GetByIsNewPay(isNewPay, 0, string.Empty, null);
		}
		public async Task<List<S_user_dayEO>> GetByIsNewPayAsync(bool isNewPay)
		{
			return await GetByIsNewPayAsync(isNewPay, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 IsNewPay（字段） 查询
		/// </summary>
		/// /// <param name = "isNewPay">是否是第一次充值用户</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByIsNewPay(bool isNewPay, TransactionManager tm_)
		{
			return GetByIsNewPay(isNewPay, 0, string.Empty, tm_);
		}
		public async Task<List<S_user_dayEO>> GetByIsNewPayAsync(bool isNewPay, TransactionManager tm_)
		{
			return await GetByIsNewPayAsync(isNewPay, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IsNewPay（字段） 查询
		/// </summary>
		/// /// <param name = "isNewPay">是否是第一次充值用户</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByIsNewPay(bool isNewPay, int top_)
		{
			return GetByIsNewPay(isNewPay, top_, string.Empty, null);
		}
		public async Task<List<S_user_dayEO>> GetByIsNewPayAsync(bool isNewPay, int top_)
		{
			return await GetByIsNewPayAsync(isNewPay, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 IsNewPay（字段） 查询
		/// </summary>
		/// /// <param name = "isNewPay">是否是第一次充值用户</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByIsNewPay(bool isNewPay, int top_, TransactionManager tm_)
		{
			return GetByIsNewPay(isNewPay, top_, string.Empty, tm_);
		}
		public async Task<List<S_user_dayEO>> GetByIsNewPayAsync(bool isNewPay, int top_, TransactionManager tm_)
		{
			return await GetByIsNewPayAsync(isNewPay, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IsNewPay（字段） 查询
		/// </summary>
		/// /// <param name = "isNewPay">是否是第一次充值用户</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByIsNewPay(bool isNewPay, string sort_)
		{
			return GetByIsNewPay(isNewPay, 0, sort_, null);
		}
		public async Task<List<S_user_dayEO>> GetByIsNewPayAsync(bool isNewPay, string sort_)
		{
			return await GetByIsNewPayAsync(isNewPay, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 IsNewPay（字段） 查询
		/// </summary>
		/// /// <param name = "isNewPay">是否是第一次充值用户</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByIsNewPay(bool isNewPay, string sort_, TransactionManager tm_)
		{
			return GetByIsNewPay(isNewPay, 0, sort_, tm_);
		}
		public async Task<List<S_user_dayEO>> GetByIsNewPayAsync(bool isNewPay, string sort_, TransactionManager tm_)
		{
			return await GetByIsNewPayAsync(isNewPay, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 IsNewPay（字段） 查询
		/// </summary>
		/// /// <param name = "isNewPay">是否是第一次充值用户</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByIsNewPay(bool isNewPay, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`IsNewPay` = @IsNewPay", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IsNewPay", isNewPay, MySqlDbType.Byte));
			return Database.ExecSqlList(sql_, paras_, tm_, S_user_dayEO.MapDataReader);
		}
		public async Task<List<S_user_dayEO>> GetByIsNewPayAsync(bool isNewPay, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`IsNewPay` = @IsNewPay", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IsNewPay", isNewPay, MySqlDbType.Byte));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_user_dayEO.MapDataReader);
		}
		#endregion // GetByIsNewPay
		#region GetByHasPay
		
		/// <summary>
		/// 按 HasPay（字段） 查询
		/// </summary>
		/// /// <param name = "hasPay">当天是否充值</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByHasPay(bool hasPay)
		{
			return GetByHasPay(hasPay, 0, string.Empty, null);
		}
		public async Task<List<S_user_dayEO>> GetByHasPayAsync(bool hasPay)
		{
			return await GetByHasPayAsync(hasPay, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 HasPay（字段） 查询
		/// </summary>
		/// /// <param name = "hasPay">当天是否充值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByHasPay(bool hasPay, TransactionManager tm_)
		{
			return GetByHasPay(hasPay, 0, string.Empty, tm_);
		}
		public async Task<List<S_user_dayEO>> GetByHasPayAsync(bool hasPay, TransactionManager tm_)
		{
			return await GetByHasPayAsync(hasPay, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 HasPay（字段） 查询
		/// </summary>
		/// /// <param name = "hasPay">当天是否充值</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByHasPay(bool hasPay, int top_)
		{
			return GetByHasPay(hasPay, top_, string.Empty, null);
		}
		public async Task<List<S_user_dayEO>> GetByHasPayAsync(bool hasPay, int top_)
		{
			return await GetByHasPayAsync(hasPay, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 HasPay（字段） 查询
		/// </summary>
		/// /// <param name = "hasPay">当天是否充值</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByHasPay(bool hasPay, int top_, TransactionManager tm_)
		{
			return GetByHasPay(hasPay, top_, string.Empty, tm_);
		}
		public async Task<List<S_user_dayEO>> GetByHasPayAsync(bool hasPay, int top_, TransactionManager tm_)
		{
			return await GetByHasPayAsync(hasPay, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 HasPay（字段） 查询
		/// </summary>
		/// /// <param name = "hasPay">当天是否充值</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByHasPay(bool hasPay, string sort_)
		{
			return GetByHasPay(hasPay, 0, sort_, null);
		}
		public async Task<List<S_user_dayEO>> GetByHasPayAsync(bool hasPay, string sort_)
		{
			return await GetByHasPayAsync(hasPay, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 HasPay（字段） 查询
		/// </summary>
		/// /// <param name = "hasPay">当天是否充值</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByHasPay(bool hasPay, string sort_, TransactionManager tm_)
		{
			return GetByHasPay(hasPay, 0, sort_, tm_);
		}
		public async Task<List<S_user_dayEO>> GetByHasPayAsync(bool hasPay, string sort_, TransactionManager tm_)
		{
			return await GetByHasPayAsync(hasPay, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 HasPay（字段） 查询
		/// </summary>
		/// /// <param name = "hasPay">当天是否充值</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByHasPay(bool hasPay, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`HasPay` = @HasPay", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@HasPay", hasPay, MySqlDbType.Byte));
			return Database.ExecSqlList(sql_, paras_, tm_, S_user_dayEO.MapDataReader);
		}
		public async Task<List<S_user_dayEO>> GetByHasPayAsync(bool hasPay, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`HasPay` = @HasPay", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@HasPay", hasPay, MySqlDbType.Byte));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_user_dayEO.MapDataReader);
		}
		#endregion // GetByHasPay
		#region GetByIsNewCash
		
		/// <summary>
		/// 按 IsNewCash（字段） 查询
		/// </summary>
		/// /// <param name = "isNewCash">是否第一次体现用户</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByIsNewCash(bool isNewCash)
		{
			return GetByIsNewCash(isNewCash, 0, string.Empty, null);
		}
		public async Task<List<S_user_dayEO>> GetByIsNewCashAsync(bool isNewCash)
		{
			return await GetByIsNewCashAsync(isNewCash, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 IsNewCash（字段） 查询
		/// </summary>
		/// /// <param name = "isNewCash">是否第一次体现用户</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByIsNewCash(bool isNewCash, TransactionManager tm_)
		{
			return GetByIsNewCash(isNewCash, 0, string.Empty, tm_);
		}
		public async Task<List<S_user_dayEO>> GetByIsNewCashAsync(bool isNewCash, TransactionManager tm_)
		{
			return await GetByIsNewCashAsync(isNewCash, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IsNewCash（字段） 查询
		/// </summary>
		/// /// <param name = "isNewCash">是否第一次体现用户</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByIsNewCash(bool isNewCash, int top_)
		{
			return GetByIsNewCash(isNewCash, top_, string.Empty, null);
		}
		public async Task<List<S_user_dayEO>> GetByIsNewCashAsync(bool isNewCash, int top_)
		{
			return await GetByIsNewCashAsync(isNewCash, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 IsNewCash（字段） 查询
		/// </summary>
		/// /// <param name = "isNewCash">是否第一次体现用户</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByIsNewCash(bool isNewCash, int top_, TransactionManager tm_)
		{
			return GetByIsNewCash(isNewCash, top_, string.Empty, tm_);
		}
		public async Task<List<S_user_dayEO>> GetByIsNewCashAsync(bool isNewCash, int top_, TransactionManager tm_)
		{
			return await GetByIsNewCashAsync(isNewCash, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IsNewCash（字段） 查询
		/// </summary>
		/// /// <param name = "isNewCash">是否第一次体现用户</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByIsNewCash(bool isNewCash, string sort_)
		{
			return GetByIsNewCash(isNewCash, 0, sort_, null);
		}
		public async Task<List<S_user_dayEO>> GetByIsNewCashAsync(bool isNewCash, string sort_)
		{
			return await GetByIsNewCashAsync(isNewCash, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 IsNewCash（字段） 查询
		/// </summary>
		/// /// <param name = "isNewCash">是否第一次体现用户</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByIsNewCash(bool isNewCash, string sort_, TransactionManager tm_)
		{
			return GetByIsNewCash(isNewCash, 0, sort_, tm_);
		}
		public async Task<List<S_user_dayEO>> GetByIsNewCashAsync(bool isNewCash, string sort_, TransactionManager tm_)
		{
			return await GetByIsNewCashAsync(isNewCash, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 IsNewCash（字段） 查询
		/// </summary>
		/// /// <param name = "isNewCash">是否第一次体现用户</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByIsNewCash(bool isNewCash, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`IsNewCash` = @IsNewCash", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IsNewCash", isNewCash, MySqlDbType.Byte));
			return Database.ExecSqlList(sql_, paras_, tm_, S_user_dayEO.MapDataReader);
		}
		public async Task<List<S_user_dayEO>> GetByIsNewCashAsync(bool isNewCash, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`IsNewCash` = @IsNewCash", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IsNewCash", isNewCash, MySqlDbType.Byte));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_user_dayEO.MapDataReader);
		}
		#endregion // GetByIsNewCash
		#region GetByHasCash
		
		/// <summary>
		/// 按 HasCash（字段） 查询
		/// </summary>
		/// /// <param name = "hasCash">当天是否有提现行为</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByHasCash(bool hasCash)
		{
			return GetByHasCash(hasCash, 0, string.Empty, null);
		}
		public async Task<List<S_user_dayEO>> GetByHasCashAsync(bool hasCash)
		{
			return await GetByHasCashAsync(hasCash, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 HasCash（字段） 查询
		/// </summary>
		/// /// <param name = "hasCash">当天是否有提现行为</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByHasCash(bool hasCash, TransactionManager tm_)
		{
			return GetByHasCash(hasCash, 0, string.Empty, tm_);
		}
		public async Task<List<S_user_dayEO>> GetByHasCashAsync(bool hasCash, TransactionManager tm_)
		{
			return await GetByHasCashAsync(hasCash, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 HasCash（字段） 查询
		/// </summary>
		/// /// <param name = "hasCash">当天是否有提现行为</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByHasCash(bool hasCash, int top_)
		{
			return GetByHasCash(hasCash, top_, string.Empty, null);
		}
		public async Task<List<S_user_dayEO>> GetByHasCashAsync(bool hasCash, int top_)
		{
			return await GetByHasCashAsync(hasCash, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 HasCash（字段） 查询
		/// </summary>
		/// /// <param name = "hasCash">当天是否有提现行为</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByHasCash(bool hasCash, int top_, TransactionManager tm_)
		{
			return GetByHasCash(hasCash, top_, string.Empty, tm_);
		}
		public async Task<List<S_user_dayEO>> GetByHasCashAsync(bool hasCash, int top_, TransactionManager tm_)
		{
			return await GetByHasCashAsync(hasCash, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 HasCash（字段） 查询
		/// </summary>
		/// /// <param name = "hasCash">当天是否有提现行为</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByHasCash(bool hasCash, string sort_)
		{
			return GetByHasCash(hasCash, 0, sort_, null);
		}
		public async Task<List<S_user_dayEO>> GetByHasCashAsync(bool hasCash, string sort_)
		{
			return await GetByHasCashAsync(hasCash, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 HasCash（字段） 查询
		/// </summary>
		/// /// <param name = "hasCash">当天是否有提现行为</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByHasCash(bool hasCash, string sort_, TransactionManager tm_)
		{
			return GetByHasCash(hasCash, 0, sort_, tm_);
		}
		public async Task<List<S_user_dayEO>> GetByHasCashAsync(bool hasCash, string sort_, TransactionManager tm_)
		{
			return await GetByHasCashAsync(hasCash, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 HasCash（字段） 查询
		/// </summary>
		/// /// <param name = "hasCash">当天是否有提现行为</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByHasCash(bool hasCash, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`HasCash` = @HasCash", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@HasCash", hasCash, MySqlDbType.Byte));
			return Database.ExecSqlList(sql_, paras_, tm_, S_user_dayEO.MapDataReader);
		}
		public async Task<List<S_user_dayEO>> GetByHasCashAsync(bool hasCash, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`HasCash` = @HasCash", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@HasCash", hasCash, MySqlDbType.Byte));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_user_dayEO.MapDataReader);
		}
		#endregion // GetByHasCash
		#region GetByTotalBonus
		
		/// <summary>
		/// 按 TotalBonus（字段） 查询
		/// </summary>
		/// /// <param name = "totalBonus">赠金总额</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByTotalBonus(long totalBonus)
		{
			return GetByTotalBonus(totalBonus, 0, string.Empty, null);
		}
		public async Task<List<S_user_dayEO>> GetByTotalBonusAsync(long totalBonus)
		{
			return await GetByTotalBonusAsync(totalBonus, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 TotalBonus（字段） 查询
		/// </summary>
		/// /// <param name = "totalBonus">赠金总额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByTotalBonus(long totalBonus, TransactionManager tm_)
		{
			return GetByTotalBonus(totalBonus, 0, string.Empty, tm_);
		}
		public async Task<List<S_user_dayEO>> GetByTotalBonusAsync(long totalBonus, TransactionManager tm_)
		{
			return await GetByTotalBonusAsync(totalBonus, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 TotalBonus（字段） 查询
		/// </summary>
		/// /// <param name = "totalBonus">赠金总额</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByTotalBonus(long totalBonus, int top_)
		{
			return GetByTotalBonus(totalBonus, top_, string.Empty, null);
		}
		public async Task<List<S_user_dayEO>> GetByTotalBonusAsync(long totalBonus, int top_)
		{
			return await GetByTotalBonusAsync(totalBonus, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 TotalBonus（字段） 查询
		/// </summary>
		/// /// <param name = "totalBonus">赠金总额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByTotalBonus(long totalBonus, int top_, TransactionManager tm_)
		{
			return GetByTotalBonus(totalBonus, top_, string.Empty, tm_);
		}
		public async Task<List<S_user_dayEO>> GetByTotalBonusAsync(long totalBonus, int top_, TransactionManager tm_)
		{
			return await GetByTotalBonusAsync(totalBonus, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 TotalBonus（字段） 查询
		/// </summary>
		/// /// <param name = "totalBonus">赠金总额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByTotalBonus(long totalBonus, string sort_)
		{
			return GetByTotalBonus(totalBonus, 0, sort_, null);
		}
		public async Task<List<S_user_dayEO>> GetByTotalBonusAsync(long totalBonus, string sort_)
		{
			return await GetByTotalBonusAsync(totalBonus, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 TotalBonus（字段） 查询
		/// </summary>
		/// /// <param name = "totalBonus">赠金总额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByTotalBonus(long totalBonus, string sort_, TransactionManager tm_)
		{
			return GetByTotalBonus(totalBonus, 0, sort_, tm_);
		}
		public async Task<List<S_user_dayEO>> GetByTotalBonusAsync(long totalBonus, string sort_, TransactionManager tm_)
		{
			return await GetByTotalBonusAsync(totalBonus, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 TotalBonus（字段） 查询
		/// </summary>
		/// /// <param name = "totalBonus">赠金总额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByTotalBonus(long totalBonus, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`TotalBonus` = @TotalBonus", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TotalBonus", totalBonus, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, S_user_dayEO.MapDataReader);
		}
		public async Task<List<S_user_dayEO>> GetByTotalBonusAsync(long totalBonus, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`TotalBonus` = @TotalBonus", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TotalBonus", totalBonus, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_user_dayEO.MapDataReader);
		}
		#endregion // GetByTotalBonus
		#region GetByTotalBonusCount
		
		/// <summary>
		/// 按 TotalBonusCount（字段） 查询
		/// </summary>
		/// /// <param name = "totalBonusCount">赠金次数</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByTotalBonusCount(int totalBonusCount)
		{
			return GetByTotalBonusCount(totalBonusCount, 0, string.Empty, null);
		}
		public async Task<List<S_user_dayEO>> GetByTotalBonusCountAsync(int totalBonusCount)
		{
			return await GetByTotalBonusCountAsync(totalBonusCount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 TotalBonusCount（字段） 查询
		/// </summary>
		/// /// <param name = "totalBonusCount">赠金次数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByTotalBonusCount(int totalBonusCount, TransactionManager tm_)
		{
			return GetByTotalBonusCount(totalBonusCount, 0, string.Empty, tm_);
		}
		public async Task<List<S_user_dayEO>> GetByTotalBonusCountAsync(int totalBonusCount, TransactionManager tm_)
		{
			return await GetByTotalBonusCountAsync(totalBonusCount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 TotalBonusCount（字段） 查询
		/// </summary>
		/// /// <param name = "totalBonusCount">赠金次数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByTotalBonusCount(int totalBonusCount, int top_)
		{
			return GetByTotalBonusCount(totalBonusCount, top_, string.Empty, null);
		}
		public async Task<List<S_user_dayEO>> GetByTotalBonusCountAsync(int totalBonusCount, int top_)
		{
			return await GetByTotalBonusCountAsync(totalBonusCount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 TotalBonusCount（字段） 查询
		/// </summary>
		/// /// <param name = "totalBonusCount">赠金次数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByTotalBonusCount(int totalBonusCount, int top_, TransactionManager tm_)
		{
			return GetByTotalBonusCount(totalBonusCount, top_, string.Empty, tm_);
		}
		public async Task<List<S_user_dayEO>> GetByTotalBonusCountAsync(int totalBonusCount, int top_, TransactionManager tm_)
		{
			return await GetByTotalBonusCountAsync(totalBonusCount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 TotalBonusCount（字段） 查询
		/// </summary>
		/// /// <param name = "totalBonusCount">赠金次数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByTotalBonusCount(int totalBonusCount, string sort_)
		{
			return GetByTotalBonusCount(totalBonusCount, 0, sort_, null);
		}
		public async Task<List<S_user_dayEO>> GetByTotalBonusCountAsync(int totalBonusCount, string sort_)
		{
			return await GetByTotalBonusCountAsync(totalBonusCount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 TotalBonusCount（字段） 查询
		/// </summary>
		/// /// <param name = "totalBonusCount">赠金次数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByTotalBonusCount(int totalBonusCount, string sort_, TransactionManager tm_)
		{
			return GetByTotalBonusCount(totalBonusCount, 0, sort_, tm_);
		}
		public async Task<List<S_user_dayEO>> GetByTotalBonusCountAsync(int totalBonusCount, string sort_, TransactionManager tm_)
		{
			return await GetByTotalBonusCountAsync(totalBonusCount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 TotalBonusCount（字段） 查询
		/// </summary>
		/// /// <param name = "totalBonusCount">赠金次数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByTotalBonusCount(int totalBonusCount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`TotalBonusCount` = @TotalBonusCount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TotalBonusCount", totalBonusCount, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, S_user_dayEO.MapDataReader);
		}
		public async Task<List<S_user_dayEO>> GetByTotalBonusCountAsync(int totalBonusCount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`TotalBonusCount` = @TotalBonusCount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TotalBonusCount", totalBonusCount, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_user_dayEO.MapDataReader);
		}
		#endregion // GetByTotalBonusCount
		#region GetByTotalBetBonus
		
		/// <summary>
		/// 按 TotalBetBonus（字段） 查询
		/// </summary>
		/// /// <param name = "totalBetBonus">下注时扣除的bonus总额</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByTotalBetBonus(long totalBetBonus)
		{
			return GetByTotalBetBonus(totalBetBonus, 0, string.Empty, null);
		}
		public async Task<List<S_user_dayEO>> GetByTotalBetBonusAsync(long totalBetBonus)
		{
			return await GetByTotalBetBonusAsync(totalBetBonus, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 TotalBetBonus（字段） 查询
		/// </summary>
		/// /// <param name = "totalBetBonus">下注时扣除的bonus总额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByTotalBetBonus(long totalBetBonus, TransactionManager tm_)
		{
			return GetByTotalBetBonus(totalBetBonus, 0, string.Empty, tm_);
		}
		public async Task<List<S_user_dayEO>> GetByTotalBetBonusAsync(long totalBetBonus, TransactionManager tm_)
		{
			return await GetByTotalBetBonusAsync(totalBetBonus, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 TotalBetBonus（字段） 查询
		/// </summary>
		/// /// <param name = "totalBetBonus">下注时扣除的bonus总额</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByTotalBetBonus(long totalBetBonus, int top_)
		{
			return GetByTotalBetBonus(totalBetBonus, top_, string.Empty, null);
		}
		public async Task<List<S_user_dayEO>> GetByTotalBetBonusAsync(long totalBetBonus, int top_)
		{
			return await GetByTotalBetBonusAsync(totalBetBonus, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 TotalBetBonus（字段） 查询
		/// </summary>
		/// /// <param name = "totalBetBonus">下注时扣除的bonus总额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByTotalBetBonus(long totalBetBonus, int top_, TransactionManager tm_)
		{
			return GetByTotalBetBonus(totalBetBonus, top_, string.Empty, tm_);
		}
		public async Task<List<S_user_dayEO>> GetByTotalBetBonusAsync(long totalBetBonus, int top_, TransactionManager tm_)
		{
			return await GetByTotalBetBonusAsync(totalBetBonus, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 TotalBetBonus（字段） 查询
		/// </summary>
		/// /// <param name = "totalBetBonus">下注时扣除的bonus总额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByTotalBetBonus(long totalBetBonus, string sort_)
		{
			return GetByTotalBetBonus(totalBetBonus, 0, sort_, null);
		}
		public async Task<List<S_user_dayEO>> GetByTotalBetBonusAsync(long totalBetBonus, string sort_)
		{
			return await GetByTotalBetBonusAsync(totalBetBonus, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 TotalBetBonus（字段） 查询
		/// </summary>
		/// /// <param name = "totalBetBonus">下注时扣除的bonus总额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByTotalBetBonus(long totalBetBonus, string sort_, TransactionManager tm_)
		{
			return GetByTotalBetBonus(totalBetBonus, 0, sort_, tm_);
		}
		public async Task<List<S_user_dayEO>> GetByTotalBetBonusAsync(long totalBetBonus, string sort_, TransactionManager tm_)
		{
			return await GetByTotalBetBonusAsync(totalBetBonus, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 TotalBetBonus（字段） 查询
		/// </summary>
		/// /// <param name = "totalBetBonus">下注时扣除的bonus总额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByTotalBetBonus(long totalBetBonus, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`TotalBetBonus` = @TotalBetBonus", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TotalBetBonus", totalBetBonus, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, S_user_dayEO.MapDataReader);
		}
		public async Task<List<S_user_dayEO>> GetByTotalBetBonusAsync(long totalBetBonus, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`TotalBetBonus` = @TotalBetBonus", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TotalBetBonus", totalBetBonus, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_user_dayEO.MapDataReader);
		}
		#endregion // GetByTotalBetBonus
		#region GetByTotalWinBonus
		
		/// <summary>
		/// 按 TotalWinBonus（字段） 查询
		/// </summary>
		/// /// <param name = "totalWinBonus">返奖时增加的bonus总额</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByTotalWinBonus(long totalWinBonus)
		{
			return GetByTotalWinBonus(totalWinBonus, 0, string.Empty, null);
		}
		public async Task<List<S_user_dayEO>> GetByTotalWinBonusAsync(long totalWinBonus)
		{
			return await GetByTotalWinBonusAsync(totalWinBonus, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 TotalWinBonus（字段） 查询
		/// </summary>
		/// /// <param name = "totalWinBonus">返奖时增加的bonus总额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByTotalWinBonus(long totalWinBonus, TransactionManager tm_)
		{
			return GetByTotalWinBonus(totalWinBonus, 0, string.Empty, tm_);
		}
		public async Task<List<S_user_dayEO>> GetByTotalWinBonusAsync(long totalWinBonus, TransactionManager tm_)
		{
			return await GetByTotalWinBonusAsync(totalWinBonus, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 TotalWinBonus（字段） 查询
		/// </summary>
		/// /// <param name = "totalWinBonus">返奖时增加的bonus总额</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByTotalWinBonus(long totalWinBonus, int top_)
		{
			return GetByTotalWinBonus(totalWinBonus, top_, string.Empty, null);
		}
		public async Task<List<S_user_dayEO>> GetByTotalWinBonusAsync(long totalWinBonus, int top_)
		{
			return await GetByTotalWinBonusAsync(totalWinBonus, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 TotalWinBonus（字段） 查询
		/// </summary>
		/// /// <param name = "totalWinBonus">返奖时增加的bonus总额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByTotalWinBonus(long totalWinBonus, int top_, TransactionManager tm_)
		{
			return GetByTotalWinBonus(totalWinBonus, top_, string.Empty, tm_);
		}
		public async Task<List<S_user_dayEO>> GetByTotalWinBonusAsync(long totalWinBonus, int top_, TransactionManager tm_)
		{
			return await GetByTotalWinBonusAsync(totalWinBonus, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 TotalWinBonus（字段） 查询
		/// </summary>
		/// /// <param name = "totalWinBonus">返奖时增加的bonus总额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByTotalWinBonus(long totalWinBonus, string sort_)
		{
			return GetByTotalWinBonus(totalWinBonus, 0, sort_, null);
		}
		public async Task<List<S_user_dayEO>> GetByTotalWinBonusAsync(long totalWinBonus, string sort_)
		{
			return await GetByTotalWinBonusAsync(totalWinBonus, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 TotalWinBonus（字段） 查询
		/// </summary>
		/// /// <param name = "totalWinBonus">返奖时增加的bonus总额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByTotalWinBonus(long totalWinBonus, string sort_, TransactionManager tm_)
		{
			return GetByTotalWinBonus(totalWinBonus, 0, sort_, tm_);
		}
		public async Task<List<S_user_dayEO>> GetByTotalWinBonusAsync(long totalWinBonus, string sort_, TransactionManager tm_)
		{
			return await GetByTotalWinBonusAsync(totalWinBonus, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 TotalWinBonus（字段） 查询
		/// </summary>
		/// /// <param name = "totalWinBonus">返奖时增加的bonus总额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByTotalWinBonus(long totalWinBonus, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`TotalWinBonus` = @TotalWinBonus", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TotalWinBonus", totalWinBonus, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, S_user_dayEO.MapDataReader);
		}
		public async Task<List<S_user_dayEO>> GetByTotalWinBonusAsync(long totalWinBonus, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`TotalWinBonus` = @TotalWinBonus", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TotalWinBonus", totalWinBonus, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_user_dayEO.MapDataReader);
		}
		#endregion // GetByTotalWinBonus
		#region GetByTotalChangeAmount
		
		/// <summary>
		/// 按 TotalChangeAmount（字段） 查询
		/// </summary>
		/// /// <param name = "totalChangeAmount">变化总额</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByTotalChangeAmount(long totalChangeAmount)
		{
			return GetByTotalChangeAmount(totalChangeAmount, 0, string.Empty, null);
		}
		public async Task<List<S_user_dayEO>> GetByTotalChangeAmountAsync(long totalChangeAmount)
		{
			return await GetByTotalChangeAmountAsync(totalChangeAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 TotalChangeAmount（字段） 查询
		/// </summary>
		/// /// <param name = "totalChangeAmount">变化总额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByTotalChangeAmount(long totalChangeAmount, TransactionManager tm_)
		{
			return GetByTotalChangeAmount(totalChangeAmount, 0, string.Empty, tm_);
		}
		public async Task<List<S_user_dayEO>> GetByTotalChangeAmountAsync(long totalChangeAmount, TransactionManager tm_)
		{
			return await GetByTotalChangeAmountAsync(totalChangeAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 TotalChangeAmount（字段） 查询
		/// </summary>
		/// /// <param name = "totalChangeAmount">变化总额</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByTotalChangeAmount(long totalChangeAmount, int top_)
		{
			return GetByTotalChangeAmount(totalChangeAmount, top_, string.Empty, null);
		}
		public async Task<List<S_user_dayEO>> GetByTotalChangeAmountAsync(long totalChangeAmount, int top_)
		{
			return await GetByTotalChangeAmountAsync(totalChangeAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 TotalChangeAmount（字段） 查询
		/// </summary>
		/// /// <param name = "totalChangeAmount">变化总额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByTotalChangeAmount(long totalChangeAmount, int top_, TransactionManager tm_)
		{
			return GetByTotalChangeAmount(totalChangeAmount, top_, string.Empty, tm_);
		}
		public async Task<List<S_user_dayEO>> GetByTotalChangeAmountAsync(long totalChangeAmount, int top_, TransactionManager tm_)
		{
			return await GetByTotalChangeAmountAsync(totalChangeAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 TotalChangeAmount（字段） 查询
		/// </summary>
		/// /// <param name = "totalChangeAmount">变化总额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByTotalChangeAmount(long totalChangeAmount, string sort_)
		{
			return GetByTotalChangeAmount(totalChangeAmount, 0, sort_, null);
		}
		public async Task<List<S_user_dayEO>> GetByTotalChangeAmountAsync(long totalChangeAmount, string sort_)
		{
			return await GetByTotalChangeAmountAsync(totalChangeAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 TotalChangeAmount（字段） 查询
		/// </summary>
		/// /// <param name = "totalChangeAmount">变化总额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByTotalChangeAmount(long totalChangeAmount, string sort_, TransactionManager tm_)
		{
			return GetByTotalChangeAmount(totalChangeAmount, 0, sort_, tm_);
		}
		public async Task<List<S_user_dayEO>> GetByTotalChangeAmountAsync(long totalChangeAmount, string sort_, TransactionManager tm_)
		{
			return await GetByTotalChangeAmountAsync(totalChangeAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 TotalChangeAmount（字段） 查询
		/// </summary>
		/// /// <param name = "totalChangeAmount">变化总额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByTotalChangeAmount(long totalChangeAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`TotalChangeAmount` = @TotalChangeAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TotalChangeAmount", totalChangeAmount, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, S_user_dayEO.MapDataReader);
		}
		public async Task<List<S_user_dayEO>> GetByTotalChangeAmountAsync(long totalChangeAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`TotalChangeAmount` = @TotalChangeAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TotalChangeAmount", totalChangeAmount, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_user_dayEO.MapDataReader);
		}
		#endregion // GetByTotalChangeAmount
		#region GetByTotalChangeCount
		
		/// <summary>
		/// 按 TotalChangeCount（字段） 查询
		/// </summary>
		/// /// <param name = "totalChangeCount">变化次数</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByTotalChangeCount(int totalChangeCount)
		{
			return GetByTotalChangeCount(totalChangeCount, 0, string.Empty, null);
		}
		public async Task<List<S_user_dayEO>> GetByTotalChangeCountAsync(int totalChangeCount)
		{
			return await GetByTotalChangeCountAsync(totalChangeCount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 TotalChangeCount（字段） 查询
		/// </summary>
		/// /// <param name = "totalChangeCount">变化次数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByTotalChangeCount(int totalChangeCount, TransactionManager tm_)
		{
			return GetByTotalChangeCount(totalChangeCount, 0, string.Empty, tm_);
		}
		public async Task<List<S_user_dayEO>> GetByTotalChangeCountAsync(int totalChangeCount, TransactionManager tm_)
		{
			return await GetByTotalChangeCountAsync(totalChangeCount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 TotalChangeCount（字段） 查询
		/// </summary>
		/// /// <param name = "totalChangeCount">变化次数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByTotalChangeCount(int totalChangeCount, int top_)
		{
			return GetByTotalChangeCount(totalChangeCount, top_, string.Empty, null);
		}
		public async Task<List<S_user_dayEO>> GetByTotalChangeCountAsync(int totalChangeCount, int top_)
		{
			return await GetByTotalChangeCountAsync(totalChangeCount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 TotalChangeCount（字段） 查询
		/// </summary>
		/// /// <param name = "totalChangeCount">变化次数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByTotalChangeCount(int totalChangeCount, int top_, TransactionManager tm_)
		{
			return GetByTotalChangeCount(totalChangeCount, top_, string.Empty, tm_);
		}
		public async Task<List<S_user_dayEO>> GetByTotalChangeCountAsync(int totalChangeCount, int top_, TransactionManager tm_)
		{
			return await GetByTotalChangeCountAsync(totalChangeCount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 TotalChangeCount（字段） 查询
		/// </summary>
		/// /// <param name = "totalChangeCount">变化次数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByTotalChangeCount(int totalChangeCount, string sort_)
		{
			return GetByTotalChangeCount(totalChangeCount, 0, sort_, null);
		}
		public async Task<List<S_user_dayEO>> GetByTotalChangeCountAsync(int totalChangeCount, string sort_)
		{
			return await GetByTotalChangeCountAsync(totalChangeCount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 TotalChangeCount（字段） 查询
		/// </summary>
		/// /// <param name = "totalChangeCount">变化次数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByTotalChangeCount(int totalChangeCount, string sort_, TransactionManager tm_)
		{
			return GetByTotalChangeCount(totalChangeCount, 0, sort_, tm_);
		}
		public async Task<List<S_user_dayEO>> GetByTotalChangeCountAsync(int totalChangeCount, string sort_, TransactionManager tm_)
		{
			return await GetByTotalChangeCountAsync(totalChangeCount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 TotalChangeCount（字段） 查询
		/// </summary>
		/// /// <param name = "totalChangeCount">变化次数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByTotalChangeCount(int totalChangeCount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`TotalChangeCount` = @TotalChangeCount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TotalChangeCount", totalChangeCount, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, S_user_dayEO.MapDataReader);
		}
		public async Task<List<S_user_dayEO>> GetByTotalChangeCountAsync(int totalChangeCount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`TotalChangeCount` = @TotalChangeCount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TotalChangeCount", totalChangeCount, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_user_dayEO.MapDataReader);
		}
		#endregion // GetByTotalChangeCount
		#region GetByTotalBetAmount
		
		/// <summary>
		/// 按 TotalBetAmount（字段） 查询
		/// </summary>
		/// /// <param name = "totalBetAmount">下注总额</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByTotalBetAmount(long totalBetAmount)
		{
			return GetByTotalBetAmount(totalBetAmount, 0, string.Empty, null);
		}
		public async Task<List<S_user_dayEO>> GetByTotalBetAmountAsync(long totalBetAmount)
		{
			return await GetByTotalBetAmountAsync(totalBetAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 TotalBetAmount（字段） 查询
		/// </summary>
		/// /// <param name = "totalBetAmount">下注总额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByTotalBetAmount(long totalBetAmount, TransactionManager tm_)
		{
			return GetByTotalBetAmount(totalBetAmount, 0, string.Empty, tm_);
		}
		public async Task<List<S_user_dayEO>> GetByTotalBetAmountAsync(long totalBetAmount, TransactionManager tm_)
		{
			return await GetByTotalBetAmountAsync(totalBetAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 TotalBetAmount（字段） 查询
		/// </summary>
		/// /// <param name = "totalBetAmount">下注总额</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByTotalBetAmount(long totalBetAmount, int top_)
		{
			return GetByTotalBetAmount(totalBetAmount, top_, string.Empty, null);
		}
		public async Task<List<S_user_dayEO>> GetByTotalBetAmountAsync(long totalBetAmount, int top_)
		{
			return await GetByTotalBetAmountAsync(totalBetAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 TotalBetAmount（字段） 查询
		/// </summary>
		/// /// <param name = "totalBetAmount">下注总额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByTotalBetAmount(long totalBetAmount, int top_, TransactionManager tm_)
		{
			return GetByTotalBetAmount(totalBetAmount, top_, string.Empty, tm_);
		}
		public async Task<List<S_user_dayEO>> GetByTotalBetAmountAsync(long totalBetAmount, int top_, TransactionManager tm_)
		{
			return await GetByTotalBetAmountAsync(totalBetAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 TotalBetAmount（字段） 查询
		/// </summary>
		/// /// <param name = "totalBetAmount">下注总额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByTotalBetAmount(long totalBetAmount, string sort_)
		{
			return GetByTotalBetAmount(totalBetAmount, 0, sort_, null);
		}
		public async Task<List<S_user_dayEO>> GetByTotalBetAmountAsync(long totalBetAmount, string sort_)
		{
			return await GetByTotalBetAmountAsync(totalBetAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 TotalBetAmount（字段） 查询
		/// </summary>
		/// /// <param name = "totalBetAmount">下注总额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByTotalBetAmount(long totalBetAmount, string sort_, TransactionManager tm_)
		{
			return GetByTotalBetAmount(totalBetAmount, 0, sort_, tm_);
		}
		public async Task<List<S_user_dayEO>> GetByTotalBetAmountAsync(long totalBetAmount, string sort_, TransactionManager tm_)
		{
			return await GetByTotalBetAmountAsync(totalBetAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 TotalBetAmount（字段） 查询
		/// </summary>
		/// /// <param name = "totalBetAmount">下注总额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByTotalBetAmount(long totalBetAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`TotalBetAmount` = @TotalBetAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TotalBetAmount", totalBetAmount, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, S_user_dayEO.MapDataReader);
		}
		public async Task<List<S_user_dayEO>> GetByTotalBetAmountAsync(long totalBetAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`TotalBetAmount` = @TotalBetAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TotalBetAmount", totalBetAmount, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_user_dayEO.MapDataReader);
		}
		#endregion // GetByTotalBetAmount
		#region GetByTotalBetCount
		
		/// <summary>
		/// 按 TotalBetCount（字段） 查询
		/// </summary>
		/// /// <param name = "totalBetCount">下注次数</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByTotalBetCount(int totalBetCount)
		{
			return GetByTotalBetCount(totalBetCount, 0, string.Empty, null);
		}
		public async Task<List<S_user_dayEO>> GetByTotalBetCountAsync(int totalBetCount)
		{
			return await GetByTotalBetCountAsync(totalBetCount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 TotalBetCount（字段） 查询
		/// </summary>
		/// /// <param name = "totalBetCount">下注次数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByTotalBetCount(int totalBetCount, TransactionManager tm_)
		{
			return GetByTotalBetCount(totalBetCount, 0, string.Empty, tm_);
		}
		public async Task<List<S_user_dayEO>> GetByTotalBetCountAsync(int totalBetCount, TransactionManager tm_)
		{
			return await GetByTotalBetCountAsync(totalBetCount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 TotalBetCount（字段） 查询
		/// </summary>
		/// /// <param name = "totalBetCount">下注次数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByTotalBetCount(int totalBetCount, int top_)
		{
			return GetByTotalBetCount(totalBetCount, top_, string.Empty, null);
		}
		public async Task<List<S_user_dayEO>> GetByTotalBetCountAsync(int totalBetCount, int top_)
		{
			return await GetByTotalBetCountAsync(totalBetCount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 TotalBetCount（字段） 查询
		/// </summary>
		/// /// <param name = "totalBetCount">下注次数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByTotalBetCount(int totalBetCount, int top_, TransactionManager tm_)
		{
			return GetByTotalBetCount(totalBetCount, top_, string.Empty, tm_);
		}
		public async Task<List<S_user_dayEO>> GetByTotalBetCountAsync(int totalBetCount, int top_, TransactionManager tm_)
		{
			return await GetByTotalBetCountAsync(totalBetCount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 TotalBetCount（字段） 查询
		/// </summary>
		/// /// <param name = "totalBetCount">下注次数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByTotalBetCount(int totalBetCount, string sort_)
		{
			return GetByTotalBetCount(totalBetCount, 0, sort_, null);
		}
		public async Task<List<S_user_dayEO>> GetByTotalBetCountAsync(int totalBetCount, string sort_)
		{
			return await GetByTotalBetCountAsync(totalBetCount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 TotalBetCount（字段） 查询
		/// </summary>
		/// /// <param name = "totalBetCount">下注次数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByTotalBetCount(int totalBetCount, string sort_, TransactionManager tm_)
		{
			return GetByTotalBetCount(totalBetCount, 0, sort_, tm_);
		}
		public async Task<List<S_user_dayEO>> GetByTotalBetCountAsync(int totalBetCount, string sort_, TransactionManager tm_)
		{
			return await GetByTotalBetCountAsync(totalBetCount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 TotalBetCount（字段） 查询
		/// </summary>
		/// /// <param name = "totalBetCount">下注次数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByTotalBetCount(int totalBetCount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`TotalBetCount` = @TotalBetCount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TotalBetCount", totalBetCount, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, S_user_dayEO.MapDataReader);
		}
		public async Task<List<S_user_dayEO>> GetByTotalBetCountAsync(int totalBetCount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`TotalBetCount` = @TotalBetCount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TotalBetCount", totalBetCount, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_user_dayEO.MapDataReader);
		}
		#endregion // GetByTotalBetCount
		#region GetByTotalWinAmount
		
		/// <summary>
		/// 按 TotalWinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "totalWinAmount">返奖总额</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByTotalWinAmount(long totalWinAmount)
		{
			return GetByTotalWinAmount(totalWinAmount, 0, string.Empty, null);
		}
		public async Task<List<S_user_dayEO>> GetByTotalWinAmountAsync(long totalWinAmount)
		{
			return await GetByTotalWinAmountAsync(totalWinAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 TotalWinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "totalWinAmount">返奖总额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByTotalWinAmount(long totalWinAmount, TransactionManager tm_)
		{
			return GetByTotalWinAmount(totalWinAmount, 0, string.Empty, tm_);
		}
		public async Task<List<S_user_dayEO>> GetByTotalWinAmountAsync(long totalWinAmount, TransactionManager tm_)
		{
			return await GetByTotalWinAmountAsync(totalWinAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 TotalWinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "totalWinAmount">返奖总额</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByTotalWinAmount(long totalWinAmount, int top_)
		{
			return GetByTotalWinAmount(totalWinAmount, top_, string.Empty, null);
		}
		public async Task<List<S_user_dayEO>> GetByTotalWinAmountAsync(long totalWinAmount, int top_)
		{
			return await GetByTotalWinAmountAsync(totalWinAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 TotalWinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "totalWinAmount">返奖总额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByTotalWinAmount(long totalWinAmount, int top_, TransactionManager tm_)
		{
			return GetByTotalWinAmount(totalWinAmount, top_, string.Empty, tm_);
		}
		public async Task<List<S_user_dayEO>> GetByTotalWinAmountAsync(long totalWinAmount, int top_, TransactionManager tm_)
		{
			return await GetByTotalWinAmountAsync(totalWinAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 TotalWinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "totalWinAmount">返奖总额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByTotalWinAmount(long totalWinAmount, string sort_)
		{
			return GetByTotalWinAmount(totalWinAmount, 0, sort_, null);
		}
		public async Task<List<S_user_dayEO>> GetByTotalWinAmountAsync(long totalWinAmount, string sort_)
		{
			return await GetByTotalWinAmountAsync(totalWinAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 TotalWinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "totalWinAmount">返奖总额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByTotalWinAmount(long totalWinAmount, string sort_, TransactionManager tm_)
		{
			return GetByTotalWinAmount(totalWinAmount, 0, sort_, tm_);
		}
		public async Task<List<S_user_dayEO>> GetByTotalWinAmountAsync(long totalWinAmount, string sort_, TransactionManager tm_)
		{
			return await GetByTotalWinAmountAsync(totalWinAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 TotalWinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "totalWinAmount">返奖总额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByTotalWinAmount(long totalWinAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`TotalWinAmount` = @TotalWinAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TotalWinAmount", totalWinAmount, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, S_user_dayEO.MapDataReader);
		}
		public async Task<List<S_user_dayEO>> GetByTotalWinAmountAsync(long totalWinAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`TotalWinAmount` = @TotalWinAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TotalWinAmount", totalWinAmount, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_user_dayEO.MapDataReader);
		}
		#endregion // GetByTotalWinAmount
		#region GetByTotalWinCount
		
		/// <summary>
		/// 按 TotalWinCount（字段） 查询
		/// </summary>
		/// /// <param name = "totalWinCount">返奖次数</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByTotalWinCount(int totalWinCount)
		{
			return GetByTotalWinCount(totalWinCount, 0, string.Empty, null);
		}
		public async Task<List<S_user_dayEO>> GetByTotalWinCountAsync(int totalWinCount)
		{
			return await GetByTotalWinCountAsync(totalWinCount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 TotalWinCount（字段） 查询
		/// </summary>
		/// /// <param name = "totalWinCount">返奖次数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByTotalWinCount(int totalWinCount, TransactionManager tm_)
		{
			return GetByTotalWinCount(totalWinCount, 0, string.Empty, tm_);
		}
		public async Task<List<S_user_dayEO>> GetByTotalWinCountAsync(int totalWinCount, TransactionManager tm_)
		{
			return await GetByTotalWinCountAsync(totalWinCount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 TotalWinCount（字段） 查询
		/// </summary>
		/// /// <param name = "totalWinCount">返奖次数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByTotalWinCount(int totalWinCount, int top_)
		{
			return GetByTotalWinCount(totalWinCount, top_, string.Empty, null);
		}
		public async Task<List<S_user_dayEO>> GetByTotalWinCountAsync(int totalWinCount, int top_)
		{
			return await GetByTotalWinCountAsync(totalWinCount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 TotalWinCount（字段） 查询
		/// </summary>
		/// /// <param name = "totalWinCount">返奖次数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByTotalWinCount(int totalWinCount, int top_, TransactionManager tm_)
		{
			return GetByTotalWinCount(totalWinCount, top_, string.Empty, tm_);
		}
		public async Task<List<S_user_dayEO>> GetByTotalWinCountAsync(int totalWinCount, int top_, TransactionManager tm_)
		{
			return await GetByTotalWinCountAsync(totalWinCount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 TotalWinCount（字段） 查询
		/// </summary>
		/// /// <param name = "totalWinCount">返奖次数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByTotalWinCount(int totalWinCount, string sort_)
		{
			return GetByTotalWinCount(totalWinCount, 0, sort_, null);
		}
		public async Task<List<S_user_dayEO>> GetByTotalWinCountAsync(int totalWinCount, string sort_)
		{
			return await GetByTotalWinCountAsync(totalWinCount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 TotalWinCount（字段） 查询
		/// </summary>
		/// /// <param name = "totalWinCount">返奖次数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByTotalWinCount(int totalWinCount, string sort_, TransactionManager tm_)
		{
			return GetByTotalWinCount(totalWinCount, 0, sort_, tm_);
		}
		public async Task<List<S_user_dayEO>> GetByTotalWinCountAsync(int totalWinCount, string sort_, TransactionManager tm_)
		{
			return await GetByTotalWinCountAsync(totalWinCount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 TotalWinCount（字段） 查询
		/// </summary>
		/// /// <param name = "totalWinCount">返奖次数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByTotalWinCount(int totalWinCount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`TotalWinCount` = @TotalWinCount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TotalWinCount", totalWinCount, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, S_user_dayEO.MapDataReader);
		}
		public async Task<List<S_user_dayEO>> GetByTotalWinCountAsync(int totalWinCount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`TotalWinCount` = @TotalWinCount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TotalWinCount", totalWinCount, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_user_dayEO.MapDataReader);
		}
		#endregion // GetByTotalWinCount
		#region GetByTotalPayAmount
		
		/// <summary>
		/// 按 TotalPayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "totalPayAmount">充值总额</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByTotalPayAmount(long totalPayAmount)
		{
			return GetByTotalPayAmount(totalPayAmount, 0, string.Empty, null);
		}
		public async Task<List<S_user_dayEO>> GetByTotalPayAmountAsync(long totalPayAmount)
		{
			return await GetByTotalPayAmountAsync(totalPayAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 TotalPayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "totalPayAmount">充值总额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByTotalPayAmount(long totalPayAmount, TransactionManager tm_)
		{
			return GetByTotalPayAmount(totalPayAmount, 0, string.Empty, tm_);
		}
		public async Task<List<S_user_dayEO>> GetByTotalPayAmountAsync(long totalPayAmount, TransactionManager tm_)
		{
			return await GetByTotalPayAmountAsync(totalPayAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 TotalPayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "totalPayAmount">充值总额</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByTotalPayAmount(long totalPayAmount, int top_)
		{
			return GetByTotalPayAmount(totalPayAmount, top_, string.Empty, null);
		}
		public async Task<List<S_user_dayEO>> GetByTotalPayAmountAsync(long totalPayAmount, int top_)
		{
			return await GetByTotalPayAmountAsync(totalPayAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 TotalPayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "totalPayAmount">充值总额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByTotalPayAmount(long totalPayAmount, int top_, TransactionManager tm_)
		{
			return GetByTotalPayAmount(totalPayAmount, top_, string.Empty, tm_);
		}
		public async Task<List<S_user_dayEO>> GetByTotalPayAmountAsync(long totalPayAmount, int top_, TransactionManager tm_)
		{
			return await GetByTotalPayAmountAsync(totalPayAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 TotalPayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "totalPayAmount">充值总额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByTotalPayAmount(long totalPayAmount, string sort_)
		{
			return GetByTotalPayAmount(totalPayAmount, 0, sort_, null);
		}
		public async Task<List<S_user_dayEO>> GetByTotalPayAmountAsync(long totalPayAmount, string sort_)
		{
			return await GetByTotalPayAmountAsync(totalPayAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 TotalPayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "totalPayAmount">充值总额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByTotalPayAmount(long totalPayAmount, string sort_, TransactionManager tm_)
		{
			return GetByTotalPayAmount(totalPayAmount, 0, sort_, tm_);
		}
		public async Task<List<S_user_dayEO>> GetByTotalPayAmountAsync(long totalPayAmount, string sort_, TransactionManager tm_)
		{
			return await GetByTotalPayAmountAsync(totalPayAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 TotalPayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "totalPayAmount">充值总额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByTotalPayAmount(long totalPayAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`TotalPayAmount` = @TotalPayAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TotalPayAmount", totalPayAmount, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, S_user_dayEO.MapDataReader);
		}
		public async Task<List<S_user_dayEO>> GetByTotalPayAmountAsync(long totalPayAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`TotalPayAmount` = @TotalPayAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TotalPayAmount", totalPayAmount, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_user_dayEO.MapDataReader);
		}
		#endregion // GetByTotalPayAmount
		#region GetByTotalPayCount
		
		/// <summary>
		/// 按 TotalPayCount（字段） 查询
		/// </summary>
		/// /// <param name = "totalPayCount">充值次数</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByTotalPayCount(int totalPayCount)
		{
			return GetByTotalPayCount(totalPayCount, 0, string.Empty, null);
		}
		public async Task<List<S_user_dayEO>> GetByTotalPayCountAsync(int totalPayCount)
		{
			return await GetByTotalPayCountAsync(totalPayCount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 TotalPayCount（字段） 查询
		/// </summary>
		/// /// <param name = "totalPayCount">充值次数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByTotalPayCount(int totalPayCount, TransactionManager tm_)
		{
			return GetByTotalPayCount(totalPayCount, 0, string.Empty, tm_);
		}
		public async Task<List<S_user_dayEO>> GetByTotalPayCountAsync(int totalPayCount, TransactionManager tm_)
		{
			return await GetByTotalPayCountAsync(totalPayCount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 TotalPayCount（字段） 查询
		/// </summary>
		/// /// <param name = "totalPayCount">充值次数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByTotalPayCount(int totalPayCount, int top_)
		{
			return GetByTotalPayCount(totalPayCount, top_, string.Empty, null);
		}
		public async Task<List<S_user_dayEO>> GetByTotalPayCountAsync(int totalPayCount, int top_)
		{
			return await GetByTotalPayCountAsync(totalPayCount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 TotalPayCount（字段） 查询
		/// </summary>
		/// /// <param name = "totalPayCount">充值次数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByTotalPayCount(int totalPayCount, int top_, TransactionManager tm_)
		{
			return GetByTotalPayCount(totalPayCount, top_, string.Empty, tm_);
		}
		public async Task<List<S_user_dayEO>> GetByTotalPayCountAsync(int totalPayCount, int top_, TransactionManager tm_)
		{
			return await GetByTotalPayCountAsync(totalPayCount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 TotalPayCount（字段） 查询
		/// </summary>
		/// /// <param name = "totalPayCount">充值次数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByTotalPayCount(int totalPayCount, string sort_)
		{
			return GetByTotalPayCount(totalPayCount, 0, sort_, null);
		}
		public async Task<List<S_user_dayEO>> GetByTotalPayCountAsync(int totalPayCount, string sort_)
		{
			return await GetByTotalPayCountAsync(totalPayCount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 TotalPayCount（字段） 查询
		/// </summary>
		/// /// <param name = "totalPayCount">充值次数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByTotalPayCount(int totalPayCount, string sort_, TransactionManager tm_)
		{
			return GetByTotalPayCount(totalPayCount, 0, sort_, tm_);
		}
		public async Task<List<S_user_dayEO>> GetByTotalPayCountAsync(int totalPayCount, string sort_, TransactionManager tm_)
		{
			return await GetByTotalPayCountAsync(totalPayCount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 TotalPayCount（字段） 查询
		/// </summary>
		/// /// <param name = "totalPayCount">充值次数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByTotalPayCount(int totalPayCount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`TotalPayCount` = @TotalPayCount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TotalPayCount", totalPayCount, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, S_user_dayEO.MapDataReader);
		}
		public async Task<List<S_user_dayEO>> GetByTotalPayCountAsync(int totalPayCount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`TotalPayCount` = @TotalPayCount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TotalPayCount", totalPayCount, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_user_dayEO.MapDataReader);
		}
		#endregion // GetByTotalPayCount
		#region GetByTotalCashAmount
		
		/// <summary>
		/// 按 TotalCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "totalCashAmount">提现总额</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByTotalCashAmount(long totalCashAmount)
		{
			return GetByTotalCashAmount(totalCashAmount, 0, string.Empty, null);
		}
		public async Task<List<S_user_dayEO>> GetByTotalCashAmountAsync(long totalCashAmount)
		{
			return await GetByTotalCashAmountAsync(totalCashAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 TotalCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "totalCashAmount">提现总额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByTotalCashAmount(long totalCashAmount, TransactionManager tm_)
		{
			return GetByTotalCashAmount(totalCashAmount, 0, string.Empty, tm_);
		}
		public async Task<List<S_user_dayEO>> GetByTotalCashAmountAsync(long totalCashAmount, TransactionManager tm_)
		{
			return await GetByTotalCashAmountAsync(totalCashAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 TotalCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "totalCashAmount">提现总额</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByTotalCashAmount(long totalCashAmount, int top_)
		{
			return GetByTotalCashAmount(totalCashAmount, top_, string.Empty, null);
		}
		public async Task<List<S_user_dayEO>> GetByTotalCashAmountAsync(long totalCashAmount, int top_)
		{
			return await GetByTotalCashAmountAsync(totalCashAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 TotalCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "totalCashAmount">提现总额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByTotalCashAmount(long totalCashAmount, int top_, TransactionManager tm_)
		{
			return GetByTotalCashAmount(totalCashAmount, top_, string.Empty, tm_);
		}
		public async Task<List<S_user_dayEO>> GetByTotalCashAmountAsync(long totalCashAmount, int top_, TransactionManager tm_)
		{
			return await GetByTotalCashAmountAsync(totalCashAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 TotalCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "totalCashAmount">提现总额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByTotalCashAmount(long totalCashAmount, string sort_)
		{
			return GetByTotalCashAmount(totalCashAmount, 0, sort_, null);
		}
		public async Task<List<S_user_dayEO>> GetByTotalCashAmountAsync(long totalCashAmount, string sort_)
		{
			return await GetByTotalCashAmountAsync(totalCashAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 TotalCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "totalCashAmount">提现总额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByTotalCashAmount(long totalCashAmount, string sort_, TransactionManager tm_)
		{
			return GetByTotalCashAmount(totalCashAmount, 0, sort_, tm_);
		}
		public async Task<List<S_user_dayEO>> GetByTotalCashAmountAsync(long totalCashAmount, string sort_, TransactionManager tm_)
		{
			return await GetByTotalCashAmountAsync(totalCashAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 TotalCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "totalCashAmount">提现总额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByTotalCashAmount(long totalCashAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`TotalCashAmount` = @TotalCashAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TotalCashAmount", totalCashAmount, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, S_user_dayEO.MapDataReader);
		}
		public async Task<List<S_user_dayEO>> GetByTotalCashAmountAsync(long totalCashAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`TotalCashAmount` = @TotalCashAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TotalCashAmount", totalCashAmount, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_user_dayEO.MapDataReader);
		}
		#endregion // GetByTotalCashAmount
		#region GetByTotalCashCount
		
		/// <summary>
		/// 按 TotalCashCount（字段） 查询
		/// </summary>
		/// /// <param name = "totalCashCount">提现次数</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByTotalCashCount(int totalCashCount)
		{
			return GetByTotalCashCount(totalCashCount, 0, string.Empty, null);
		}
		public async Task<List<S_user_dayEO>> GetByTotalCashCountAsync(int totalCashCount)
		{
			return await GetByTotalCashCountAsync(totalCashCount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 TotalCashCount（字段） 查询
		/// </summary>
		/// /// <param name = "totalCashCount">提现次数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByTotalCashCount(int totalCashCount, TransactionManager tm_)
		{
			return GetByTotalCashCount(totalCashCount, 0, string.Empty, tm_);
		}
		public async Task<List<S_user_dayEO>> GetByTotalCashCountAsync(int totalCashCount, TransactionManager tm_)
		{
			return await GetByTotalCashCountAsync(totalCashCount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 TotalCashCount（字段） 查询
		/// </summary>
		/// /// <param name = "totalCashCount">提现次数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByTotalCashCount(int totalCashCount, int top_)
		{
			return GetByTotalCashCount(totalCashCount, top_, string.Empty, null);
		}
		public async Task<List<S_user_dayEO>> GetByTotalCashCountAsync(int totalCashCount, int top_)
		{
			return await GetByTotalCashCountAsync(totalCashCount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 TotalCashCount（字段） 查询
		/// </summary>
		/// /// <param name = "totalCashCount">提现次数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByTotalCashCount(int totalCashCount, int top_, TransactionManager tm_)
		{
			return GetByTotalCashCount(totalCashCount, top_, string.Empty, tm_);
		}
		public async Task<List<S_user_dayEO>> GetByTotalCashCountAsync(int totalCashCount, int top_, TransactionManager tm_)
		{
			return await GetByTotalCashCountAsync(totalCashCount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 TotalCashCount（字段） 查询
		/// </summary>
		/// /// <param name = "totalCashCount">提现次数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByTotalCashCount(int totalCashCount, string sort_)
		{
			return GetByTotalCashCount(totalCashCount, 0, sort_, null);
		}
		public async Task<List<S_user_dayEO>> GetByTotalCashCountAsync(int totalCashCount, string sort_)
		{
			return await GetByTotalCashCountAsync(totalCashCount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 TotalCashCount（字段） 查询
		/// </summary>
		/// /// <param name = "totalCashCount">提现次数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByTotalCashCount(int totalCashCount, string sort_, TransactionManager tm_)
		{
			return GetByTotalCashCount(totalCashCount, 0, sort_, tm_);
		}
		public async Task<List<S_user_dayEO>> GetByTotalCashCountAsync(int totalCashCount, string sort_, TransactionManager tm_)
		{
			return await GetByTotalCashCountAsync(totalCashCount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 TotalCashCount（字段） 查询
		/// </summary>
		/// /// <param name = "totalCashCount">提现次数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByTotalCashCount(int totalCashCount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`TotalCashCount` = @TotalCashCount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TotalCashCount", totalCashCount, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, S_user_dayEO.MapDataReader);
		}
		public async Task<List<S_user_dayEO>> GetByTotalCashCountAsync(int totalCashCount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`TotalCashCount` = @TotalCashCount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TotalCashCount", totalCashCount, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_user_dayEO.MapDataReader);
		}
		#endregion // GetByTotalCashCount
		#region GetByUserIp
		
		/// <summary>
		/// 按 UserIp（字段） 查询
		/// </summary>
		/// /// <param name = "userIp">用户IP</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByUserIp(string userIp)
		{
			return GetByUserIp(userIp, 0, string.Empty, null);
		}
		public async Task<List<S_user_dayEO>> GetByUserIpAsync(string userIp)
		{
			return await GetByUserIpAsync(userIp, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UserIp（字段） 查询
		/// </summary>
		/// /// <param name = "userIp">用户IP</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByUserIp(string userIp, TransactionManager tm_)
		{
			return GetByUserIp(userIp, 0, string.Empty, tm_);
		}
		public async Task<List<S_user_dayEO>> GetByUserIpAsync(string userIp, TransactionManager tm_)
		{
			return await GetByUserIpAsync(userIp, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserIp（字段） 查询
		/// </summary>
		/// /// <param name = "userIp">用户IP</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByUserIp(string userIp, int top_)
		{
			return GetByUserIp(userIp, top_, string.Empty, null);
		}
		public async Task<List<S_user_dayEO>> GetByUserIpAsync(string userIp, int top_)
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
		public List<S_user_dayEO> GetByUserIp(string userIp, int top_, TransactionManager tm_)
		{
			return GetByUserIp(userIp, top_, string.Empty, tm_);
		}
		public async Task<List<S_user_dayEO>> GetByUserIpAsync(string userIp, int top_, TransactionManager tm_)
		{
			return await GetByUserIpAsync(userIp, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserIp（字段） 查询
		/// </summary>
		/// /// <param name = "userIp">用户IP</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByUserIp(string userIp, string sort_)
		{
			return GetByUserIp(userIp, 0, sort_, null);
		}
		public async Task<List<S_user_dayEO>> GetByUserIpAsync(string userIp, string sort_)
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
		public List<S_user_dayEO> GetByUserIp(string userIp, string sort_, TransactionManager tm_)
		{
			return GetByUserIp(userIp, 0, sort_, tm_);
		}
		public async Task<List<S_user_dayEO>> GetByUserIpAsync(string userIp, string sort_, TransactionManager tm_)
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
		public List<S_user_dayEO> GetByUserIp(string userIp, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(userIp != null ? "`UserIp` = @UserIp" : "`UserIp` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (userIp != null)
				paras_.Add(Database.CreateInParameter("@UserIp", userIp, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_user_dayEO.MapDataReader);
		}
		public async Task<List<S_user_dayEO>> GetByUserIpAsync(string userIp, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(userIp != null ? "`UserIp` = @UserIp" : "`UserIp` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (userIp != null)
				paras_.Add(Database.CreateInParameter("@UserIp", userIp, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_user_dayEO.MapDataReader);
		}
		#endregion // GetByUserIp
		#region GetByRecDate
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByRecDate(DateTime recDate)
		{
			return GetByRecDate(recDate, 0, string.Empty, null);
		}
		public async Task<List<S_user_dayEO>> GetByRecDateAsync(DateTime recDate)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByRecDate(DateTime recDate, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, string.Empty, tm_);
		}
		public async Task<List<S_user_dayEO>> GetByRecDateAsync(DateTime recDate, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByRecDate(DateTime recDate, int top_)
		{
			return GetByRecDate(recDate, top_, string.Empty, null);
		}
		public async Task<List<S_user_dayEO>> GetByRecDateAsync(DateTime recDate, int top_)
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
		public List<S_user_dayEO> GetByRecDate(DateTime recDate, int top_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, top_, string.Empty, tm_);
		}
		public async Task<List<S_user_dayEO>> GetByRecDateAsync(DateTime recDate, int top_, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_user_dayEO> GetByRecDate(DateTime recDate, string sort_)
		{
			return GetByRecDate(recDate, 0, sort_, null);
		}
		public async Task<List<S_user_dayEO>> GetByRecDateAsync(DateTime recDate, string sort_)
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
		public List<S_user_dayEO> GetByRecDate(DateTime recDate, string sort_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, sort_, tm_);
		}
		public async Task<List<S_user_dayEO>> GetByRecDateAsync(DateTime recDate, string sort_, TransactionManager tm_)
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
		public List<S_user_dayEO> GetByRecDate(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return Database.ExecSqlList(sql_, paras_, tm_, S_user_dayEO.MapDataReader);
		}
		public async Task<List<S_user_dayEO>> GetByRecDateAsync(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_user_dayEO.MapDataReader);
		}
		#endregion // GetByRecDate
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}

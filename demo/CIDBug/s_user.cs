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
	/// 用户表
	/// 【表 s_user 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class S_userEO : IRowMapper<S_userEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public S_userEO()
		{
			this.UserMode = 1;
			this.OAuthType = 0;
			this.FromMode = 0;
			this.Cash = 0;
			this.Bonus = 0;
			this.Coin = 0;
			this.Gold = 0;
			this.SWB = 0;
			this.Point = 0;
			this.VIP = 1;
			this.UserProfile = 0;
			this.UserKind = 0;
			this.Status = 0;
			this.RecDate = DateTime.Now;
			this.LastLoginDate = DateTime.Now;
			this.HasBet = false;
			this.HasPay = false;
			this.HasCash = false;
		}
		#region 主键原始值 & 主键集合
	    
		/// <summary>
		/// 当前对象是否保存原始主键值，当修改了主键值时为 true
		/// </summary>
		public bool HasOriginal { get; protected set; }
		
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
	        return new Dictionary<string, object>() { { "UserID", UserID }, };
	    }
	    /// <summary>
	    /// 获取主键集合JSON格式
	    /// </summary>
	    /// <returns></returns>
	    public string GetPrimaryKeysJson() => SerializerUtil.SerializeJson(GetPrimaryKeys());
		#endregion // 主键原始值
		#region 所有字段
		/// <summary>
		/// 用户编码(GUID)
		/// 【主键 varchar(38)】
		/// </summary>
		[DataMember(Order = 1)]
		public string UserID { get; set; }
		/// <summary>
		/// 用户登录模式 1-游客 2-注册用户
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 2)]
		public int UserMode { get; set; }
		/// <summary>
		/// 授权登录方式0-我方1-facebook2-google3-twitter
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 3)]
		public int OAuthType { get; set; }
		/// <summary>
		/// 授权登录用户ID
		/// 【字段 varchar(255)】
		/// </summary>
		[DataMember(Order = 4)]
		public string OAuthID { get; set; }
		/// <summary>
		/// 昵称
		/// 【字段 varchar(100)】
		/// </summary>
		[DataMember(Order = 5)]
		public string Nickname { get; set; }
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
		/// 运营商编码
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 8)]
		public string OperatorID { get; set; }
		/// <summary>
		/// 运营商用户标识（用户关联）
		///              我方运营商为null
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 9)]
		public string OperatorUserId { get; set; }
		/// <summary>
		/// 国家编码ISO 3166-1三位字母
		/// 【字段 varchar(5)】
		/// </summary>
		[DataMember(Order = 10)]
		public string CountryID { get; set; }
		/// <summary>
		/// 货币类型
		/// 【字段 varchar(5)】
		/// </summary>
		[DataMember(Order = 11)]
		public string CurrencyID { get; set; }
		/// <summary>
		/// 现金（一级货币）*100000
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 12)]
		public long Cash { get; set; }
		/// <summary>
		/// 剩余赠金
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 13)]
		public long Bonus { get; set; }
		/// <summary>
		/// 硬币（二级货币）
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 14)]
		public long Coin { get; set; }
		/// <summary>
		/// 金币
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 15)]
		public long Gold { get; set; }
		/// <summary>
		/// 试玩币
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 16)]
		public long SWB { get; set; }
		/// <summary>
		/// vip积分
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 17)]
		public long Point { get; set; }
		/// <summary>
		/// vip等级
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 18)]
		public int VIP { get; set; }
		/// <summary>
		/// 1级推广员用户编码（直接推广员）
		/// 【字段 varchar(38)】
		/// </summary>
		[DataMember(Order = 19)]
		public string PUserID1 { get; set; }
		/// <summary>
		/// 2级推广员用户编码
		/// 【字段 varchar(38)】
		/// </summary>
		[DataMember(Order = 20)]
		public string PUserID2 { get; set; }
		/// <summary>
		/// 用户画像
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 21)]
		public int UserProfile { get; set; }
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
		[DataMember(Order = 22)]
		public int UserKind { get; set; }
		/// <summary>
		/// 
		/// 【字段 varchar(20)】
		/// </summary>
		[DataMember(Order = 23)]
		public string IMEI { get; set; }
		/// <summary>
		/// 
		/// 【字段 varchar(36)】
		/// </summary>
		[DataMember(Order = 24)]
		public string GAID { get; set; }
		/// <summary>
		/// 用户IP
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 25)]
		public string UserIp { get; set; }
		/// <summary>
		/// 用户第一次进入客户端时的url
		/// 【字段 varchar(255)】
		/// </summary>
		[DataMember(Order = 26)]
		public string ClientUrl { get; set; }
		/// <summary>
		/// 样式编码
		/// 【字段 varchar(36)】
		/// </summary>
		[DataMember(Order = 27)]
		public string ThemesID { get; set; }
		/// <summary>
		/// 状态
		///              0-未知
		///              1-有效
		///              2-用户数据异常封闭
		///              9-系统封闭
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 28)]
		public int Status { get; set; }
		/// <summary>
		/// 记录时间
		/// 【字段 datetime】
		/// </summary>
		[DataMember(Order = 29)]
		public DateTime RecDate { get; set; }
		/// <summary>
		/// 注册时间
		/// 【字段 datetime】
		/// </summary>
		[DataMember(Order = 30)]
		public DateTime? RegistDate { get; set; }
		/// <summary>
		/// 最后一次登录时间
		/// 【字段 datetime】
		/// </summary>
		[DataMember(Order = 31)]
		public DateTime LastLoginDate { get; set; }
		/// <summary>
		/// 手机号
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 32)]
		public string Mobile { get; set; }
		/// <summary>
		/// 邮箱
		/// 【字段 varchar(100)】
		/// </summary>
		[DataMember(Order = 33)]
		public string Email { get; set; }
		/// <summary>
		/// 登录用户名
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 34)]
		public string Username { get; set; }
		/// <summary>
		/// 密码哈希值
		/// 【字段 varchar(255)】
		/// </summary>
		[DataMember(Order = 35)]
		public string Password { get; set; }
		/// <summary>
		/// 密码哈希Salt
		/// 【字段 varchar(40)】
		/// </summary>
		[DataMember(Order = 36)]
		public string PasswordSalt { get; set; }
		/// <summary>
		/// 是否下过注
		/// 【字段 tinyint(1)】
		/// </summary>
		[DataMember(Order = 37)]
		public bool HasBet { get; set; }
		/// <summary>
		/// 是否充过值
		/// 【字段 tinyint(1)】
		/// </summary>
		[DataMember(Order = 38)]
		public bool HasPay { get; set; }
		/// <summary>
		/// 是否提过现
		/// 【字段 tinyint(1)】
		/// </summary>
		[DataMember(Order = 39)]
		public bool HasCash { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public S_userEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static S_userEO MapDataReader(IDataReader reader)
		{
		    S_userEO ret = new S_userEO();
			ret.UserID = reader.ToString("UserID");
			ret.OriginalUserID = ret.UserID;
			ret.UserMode = reader.ToInt32("UserMode");
			ret.OAuthType = reader.ToInt32("OAuthType");
			ret.OAuthID = reader.ToString("OAuthID");
			ret.Nickname = reader.ToString("Nickname");
			ret.FromMode = reader.ToInt32("FromMode");
			ret.FromId = reader.ToString("FromId");
			ret.OperatorID = reader.ToString("OperatorID");
			ret.OperatorUserId = reader.ToString("OperatorUserId");
			ret.CountryID = reader.ToString("CountryID");
			ret.CurrencyID = reader.ToString("CurrencyID");
			ret.Cash = reader.ToInt64("Cash");
			ret.Bonus = reader.ToInt64("Bonus");
			ret.Coin = reader.ToInt64("Coin");
			ret.Gold = reader.ToInt64("Gold");
			ret.SWB = reader.ToInt64("SWB");
			ret.Point = reader.ToInt64("Point");
			ret.VIP = reader.ToInt32("VIP");
			ret.PUserID1 = reader.ToString("PUserID1");
			ret.PUserID2 = reader.ToString("PUserID2");
			ret.UserProfile = reader.ToInt32("UserProfile");
			ret.UserKind = reader.ToInt32("UserKind");
			ret.IMEI = reader.ToString("IMEI");
			ret.GAID = reader.ToString("GAID");
			ret.UserIp = reader.ToString("UserIp");
			ret.ClientUrl = reader.ToString("ClientUrl");
			ret.ThemesID = reader.ToString("ThemesID");
			ret.Status = reader.ToInt32("Status");
			ret.RecDate = reader.ToDateTime("RecDate");
			ret.RegistDate = reader.ToDateTimeN("RegistDate");
			ret.LastLoginDate = reader.ToDateTime("LastLoginDate");
			ret.Mobile = reader.ToString("Mobile");
			ret.Email = reader.ToString("Email");
			ret.Username = reader.ToString("Username");
			ret.Password = reader.ToString("Password");
			ret.PasswordSalt = reader.ToString("PasswordSalt");
			ret.HasBet = reader.ToBoolean("HasBet");
			ret.HasPay = reader.ToBoolean("HasPay");
			ret.HasCash = reader.ToBoolean("HasCash");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 用户表
	/// 【表 s_user 的操作类】
	/// </summary>
	[Obsolete]
	public class S_userMO : MySqlTableMO<S_userEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`s_user`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public S_userMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public S_userMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public S_userMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(S_userEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(S_userEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(S_userEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`UserID`, `UserMode`, `OAuthType`, `OAuthID`, `Nickname`, `FromMode`, `FromId`, `OperatorID`, `OperatorUserId`, `CountryID`, `CurrencyID`, `Cash`, `Bonus`, `Coin`, `Gold`, `SWB`, `Point`, `VIP`, `PUserID1`, `PUserID2`, `UserProfile`, `UserKind`, `IMEI`, `GAID`, `UserIp`, `ClientUrl`, `ThemesID`, `Status`, `RecDate`, `RegistDate`, `LastLoginDate`, `Mobile`, `Email`, `Username`, `Password`, `PasswordSalt`, `HasBet`, `HasPay`, `HasCash`) VALUE (@UserID, @UserMode, @OAuthType, @OAuthID, @Nickname, @FromMode, @FromId, @OperatorID, @OperatorUserId, @CountryID, @CurrencyID, @Cash, @Bonus, @Coin, @Gold, @SWB, @Point, @VIP, @PUserID1, @PUserID2, @UserProfile, @UserKind, @IMEI, @GAID, @UserIp, @ClientUrl, @ThemesID, @Status, @RecDate, @RegistDate, @LastLoginDate, @Mobile, @Email, @Username, @Password, @PasswordSalt, @HasBet, @HasPay, @HasCash);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", item.UserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserMode", item.UserMode, MySqlDbType.Int32),
				Database.CreateInParameter("@OAuthType", item.OAuthType, MySqlDbType.Int32),
				Database.CreateInParameter("@OAuthID", item.OAuthID != null ? item.OAuthID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Nickname", item.Nickname != null ? item.Nickname : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@FromMode", item.FromMode, MySqlDbType.Int32),
				Database.CreateInParameter("@FromId", item.FromId != null ? item.FromId : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", item.OperatorID != null ? item.OperatorID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorUserId", item.OperatorUserId != null ? item.OperatorUserId : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryID", item.CountryID != null ? item.CountryID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", item.CurrencyID != null ? item.CurrencyID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Cash", item.Cash, MySqlDbType.Int64),
				Database.CreateInParameter("@Bonus", item.Bonus, MySqlDbType.Int64),
				Database.CreateInParameter("@Coin", item.Coin, MySqlDbType.Int64),
				Database.CreateInParameter("@Gold", item.Gold, MySqlDbType.Int64),
				Database.CreateInParameter("@SWB", item.SWB, MySqlDbType.Int64),
				Database.CreateInParameter("@Point", item.Point, MySqlDbType.Int64),
				Database.CreateInParameter("@VIP", item.VIP, MySqlDbType.Int32),
				Database.CreateInParameter("@PUserID1", item.PUserID1 != null ? item.PUserID1 : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@PUserID2", item.PUserID2 != null ? item.PUserID2 : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserProfile", item.UserProfile, MySqlDbType.Int32),
				Database.CreateInParameter("@UserKind", item.UserKind, MySqlDbType.Int32),
				Database.CreateInParameter("@IMEI", item.IMEI != null ? item.IMEI : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@GAID", item.GAID != null ? item.GAID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserIp", item.UserIp != null ? item.UserIp : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ClientUrl", item.ClientUrl != null ? item.ClientUrl : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ThemesID", item.ThemesID != null ? item.ThemesID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Status", item.Status, MySqlDbType.Int32),
				Database.CreateInParameter("@RecDate", item.RecDate, MySqlDbType.DateTime),
				Database.CreateInParameter("@RegistDate", item.RegistDate.HasValue ? item.RegistDate.Value : (object)DBNull.Value, MySqlDbType.DateTime),
				Database.CreateInParameter("@LastLoginDate", item.LastLoginDate, MySqlDbType.DateTime),
				Database.CreateInParameter("@Mobile", item.Mobile != null ? item.Mobile : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Email", item.Email != null ? item.Email : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Username", item.Username != null ? item.Username : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Password", item.Password != null ? item.Password : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@PasswordSalt", item.PasswordSalt != null ? item.PasswordSalt : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@HasBet", item.HasBet, MySqlDbType.Byte),
				Database.CreateInParameter("@HasPay", item.HasPay, MySqlDbType.Byte),
				Database.CreateInParameter("@HasCash", item.HasCash, MySqlDbType.Byte),
			};
		}
		public int AddByBatch(IEnumerable<S_userEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<S_userEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<S_userEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`UserID`, `UserMode`, `OAuthType`, `OAuthID`, `Nickname`, `FromMode`, `FromId`, `OperatorID`, `OperatorUserId`, `CountryID`, `CurrencyID`, `Cash`, `Bonus`, `Coin`, `Gold`, `SWB`, `Point`, `VIP`, `PUserID1`, `PUserID2`, `UserProfile`, `UserKind`, `IMEI`, `GAID`, `UserIp`, `ClientUrl`, `ThemesID`, `Status`, `RecDate`, `RegistDate`, `LastLoginDate`, `Mobile`, `Email`, `Username`, `Password`, `PasswordSalt`, `HasBet`, `HasPay`, `HasCash`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"('{item.UserID}',{item.UserMode},{item.OAuthType},'{item.OAuthID}','{item.Nickname}',{item.FromMode},'{item.FromId}','{item.OperatorID}','{item.OperatorUserId}','{item.CountryID}','{item.CurrencyID}',{item.Cash},{item.Bonus},{item.Coin},{item.Gold},{item.SWB},{item.Point},{item.VIP},'{item.PUserID1}','{item.PUserID2}',{item.UserProfile},{item.UserKind},'{item.IMEI}','{item.GAID}','{item.UserIp}','{item.ClientUrl}','{item.ThemesID}',{item.Status},'{item.RecDate.ToString("yyyy-MM-dd HH:mm:ss")}','{item.RegistDate?.ToString("yyyy-MM-dd HH:mm:ss")}','{item.LastLoginDate.ToString("yyyy-MM-dd HH:mm:ss")}','{item.Mobile}','{item.Email}','{item.Username}','{item.Password}','{item.PasswordSalt}',{item.HasBet},{item.HasPay},{item.HasCash}),");
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
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(string userID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(userID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(string userID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(userID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(string userID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(S_userEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.UserID, tm_);
		}
		public async Task<int> RemoveAsync(S_userEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.UserID, tm_);
		}
		#endregion // RemoveByPK
		
		#region RemoveByXXX
		#region RemoveByUserMode
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "userMode">用户登录模式 1-游客 2-注册用户</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByUserMode(int userMode, TransactionManager tm_ = null)
		{
			RepairRemoveByUserModeData(userMode, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByUserModeAsync(int userMode, TransactionManager tm_ = null)
		{
			RepairRemoveByUserModeData(userMode, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByUserModeData(int userMode, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `UserMode` = @UserMode";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserMode", userMode, MySqlDbType.Int32));
		}
		#endregion // RemoveByUserMode
		#region RemoveByOAuthType
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "oAuthType">授权登录方式0-我方1-facebook2-google3-twitter</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByOAuthType(int oAuthType, TransactionManager tm_ = null)
		{
			RepairRemoveByOAuthTypeData(oAuthType, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByOAuthTypeAsync(int oAuthType, TransactionManager tm_ = null)
		{
			RepairRemoveByOAuthTypeData(oAuthType, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByOAuthTypeData(int oAuthType, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `OAuthType` = @OAuthType";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OAuthType", oAuthType, MySqlDbType.Int32));
		}
		#endregion // RemoveByOAuthType
		#region RemoveByOAuthID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "oAuthID">授权登录用户ID</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByOAuthID(string oAuthID, TransactionManager tm_ = null)
		{
			RepairRemoveByOAuthIDData(oAuthID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByOAuthIDAsync(string oAuthID, TransactionManager tm_ = null)
		{
			RepairRemoveByOAuthIDData(oAuthID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByOAuthIDData(string oAuthID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (oAuthID != null ? "`OAuthID` = @OAuthID" : "`OAuthID` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (oAuthID != null)
				paras_.Add(Database.CreateInParameter("@OAuthID", oAuthID, MySqlDbType.VarChar));
		}
		#endregion // RemoveByOAuthID
		#region RemoveByNickname
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "nickname">昵称</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByNickname(string nickname, TransactionManager tm_ = null)
		{
			RepairRemoveByNicknameData(nickname, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByNicknameAsync(string nickname, TransactionManager tm_ = null)
		{
			RepairRemoveByNicknameData(nickname, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByNicknameData(string nickname, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (nickname != null ? "`Nickname` = @Nickname" : "`Nickname` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (nickname != null)
				paras_.Add(Database.CreateInParameter("@Nickname", nickname, MySqlDbType.VarChar));
		}
		#endregion // RemoveByNickname
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
		#region RemoveByOperatorUserId
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "operatorUserId">运营商用户标识（用户关联）</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByOperatorUserId(string operatorUserId, TransactionManager tm_ = null)
		{
			RepairRemoveByOperatorUserIdData(operatorUserId, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByOperatorUserIdAsync(string operatorUserId, TransactionManager tm_ = null)
		{
			RepairRemoveByOperatorUserIdData(operatorUserId, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByOperatorUserIdData(string operatorUserId, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (operatorUserId != null ? "`OperatorUserId` = @OperatorUserId" : "`OperatorUserId` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (operatorUserId != null)
				paras_.Add(Database.CreateInParameter("@OperatorUserId", operatorUserId, MySqlDbType.VarChar));
		}
		#endregion // RemoveByOperatorUserId
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
		#region RemoveByCash
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "cash">现金（一级货币）*100000</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByCash(long cash, TransactionManager tm_ = null)
		{
			RepairRemoveByCashData(cash, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByCashAsync(long cash, TransactionManager tm_ = null)
		{
			RepairRemoveByCashData(cash, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByCashData(long cash, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `Cash` = @Cash";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Cash", cash, MySqlDbType.Int64));
		}
		#endregion // RemoveByCash
		#region RemoveByBonus
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "bonus">剩余赠金</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByBonus(long bonus, TransactionManager tm_ = null)
		{
			RepairRemoveByBonusData(bonus, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByBonusAsync(long bonus, TransactionManager tm_ = null)
		{
			RepairRemoveByBonusData(bonus, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByBonusData(long bonus, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `Bonus` = @Bonus";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Bonus", bonus, MySqlDbType.Int64));
		}
		#endregion // RemoveByBonus
		#region RemoveByCoin
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "coin">硬币（二级货币）</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByCoin(long coin, TransactionManager tm_ = null)
		{
			RepairRemoveByCoinData(coin, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByCoinAsync(long coin, TransactionManager tm_ = null)
		{
			RepairRemoveByCoinData(coin, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByCoinData(long coin, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `Coin` = @Coin";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Coin", coin, MySqlDbType.Int64));
		}
		#endregion // RemoveByCoin
		#region RemoveByGold
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "gold">金币</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByGold(long gold, TransactionManager tm_ = null)
		{
			RepairRemoveByGoldData(gold, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByGoldAsync(long gold, TransactionManager tm_ = null)
		{
			RepairRemoveByGoldData(gold, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByGoldData(long gold, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `Gold` = @Gold";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Gold", gold, MySqlDbType.Int64));
		}
		#endregion // RemoveByGold
		#region RemoveBySWB
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "sWB">试玩币</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveBySWB(long sWB, TransactionManager tm_ = null)
		{
			RepairRemoveBySWBData(sWB, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveBySWBAsync(long sWB, TransactionManager tm_ = null)
		{
			RepairRemoveBySWBData(sWB, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveBySWBData(long sWB, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `SWB` = @SWB";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@SWB", sWB, MySqlDbType.Int64));
		}
		#endregion // RemoveBySWB
		#region RemoveByPoint
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "point">vip积分</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPoint(long point, TransactionManager tm_ = null)
		{
			RepairRemoveByPointData(point, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPointAsync(long point, TransactionManager tm_ = null)
		{
			RepairRemoveByPointData(point, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByPointData(long point, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `Point` = @Point";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Point", point, MySqlDbType.Int64));
		}
		#endregion // RemoveByPoint
		#region RemoveByVIP
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "vIP">vip等级</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByVIP(int vIP, TransactionManager tm_ = null)
		{
			RepairRemoveByVIPData(vIP, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByVIPAsync(int vIP, TransactionManager tm_ = null)
		{
			RepairRemoveByVIPData(vIP, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByVIPData(int vIP, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `VIP` = @VIP";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@VIP", vIP, MySqlDbType.Int32));
		}
		#endregion // RemoveByVIP
		#region RemoveByPUserID1
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "pUserID1">1级推广员用户编码（直接推广员）</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPUserID1(string pUserID1, TransactionManager tm_ = null)
		{
			RepairRemoveByPUserID1Data(pUserID1, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPUserID1Async(string pUserID1, TransactionManager tm_ = null)
		{
			RepairRemoveByPUserID1Data(pUserID1, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByPUserID1Data(string pUserID1, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (pUserID1 != null ? "`PUserID1` = @PUserID1" : "`PUserID1` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (pUserID1 != null)
				paras_.Add(Database.CreateInParameter("@PUserID1", pUserID1, MySqlDbType.VarChar));
		}
		#endregion // RemoveByPUserID1
		#region RemoveByPUserID2
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "pUserID2">2级推广员用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPUserID2(string pUserID2, TransactionManager tm_ = null)
		{
			RepairRemoveByPUserID2Data(pUserID2, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPUserID2Async(string pUserID2, TransactionManager tm_ = null)
		{
			RepairRemoveByPUserID2Data(pUserID2, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByPUserID2Data(string pUserID2, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (pUserID2 != null ? "`PUserID2` = @PUserID2" : "`PUserID2` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (pUserID2 != null)
				paras_.Add(Database.CreateInParameter("@PUserID2", pUserID2, MySqlDbType.VarChar));
		}
		#endregion // RemoveByPUserID2
		#region RemoveByUserProfile
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "userProfile">用户画像</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByUserProfile(int userProfile, TransactionManager tm_ = null)
		{
			RepairRemoveByUserProfileData(userProfile, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByUserProfileAsync(int userProfile, TransactionManager tm_ = null)
		{
			RepairRemoveByUserProfileData(userProfile, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByUserProfileData(int userProfile, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `UserProfile` = @UserProfile";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserProfile", userProfile, MySqlDbType.Int32));
		}
		#endregion // RemoveByUserProfile
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
		#region RemoveByIMEI
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "iMEI"></param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByIMEI(string iMEI, TransactionManager tm_ = null)
		{
			RepairRemoveByIMEIData(iMEI, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByIMEIAsync(string iMEI, TransactionManager tm_ = null)
		{
			RepairRemoveByIMEIData(iMEI, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByIMEIData(string iMEI, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (iMEI != null ? "`IMEI` = @IMEI" : "`IMEI` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (iMEI != null)
				paras_.Add(Database.CreateInParameter("@IMEI", iMEI, MySqlDbType.VarChar));
		}
		#endregion // RemoveByIMEI
		#region RemoveByGAID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "gAID"></param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByGAID(string gAID, TransactionManager tm_ = null)
		{
			RepairRemoveByGAIDData(gAID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByGAIDAsync(string gAID, TransactionManager tm_ = null)
		{
			RepairRemoveByGAIDData(gAID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByGAIDData(string gAID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (gAID != null ? "`GAID` = @GAID" : "`GAID` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (gAID != null)
				paras_.Add(Database.CreateInParameter("@GAID", gAID, MySqlDbType.VarChar));
		}
		#endregion // RemoveByGAID
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
		#region RemoveByClientUrl
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "clientUrl">用户第一次进入客户端时的url</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByClientUrl(string clientUrl, TransactionManager tm_ = null)
		{
			RepairRemoveByClientUrlData(clientUrl, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByClientUrlAsync(string clientUrl, TransactionManager tm_ = null)
		{
			RepairRemoveByClientUrlData(clientUrl, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByClientUrlData(string clientUrl, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (clientUrl != null ? "`ClientUrl` = @ClientUrl" : "`ClientUrl` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (clientUrl != null)
				paras_.Add(Database.CreateInParameter("@ClientUrl", clientUrl, MySqlDbType.VarChar));
		}
		#endregion // RemoveByClientUrl
		#region RemoveByThemesID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "themesID">样式编码</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByThemesID(string themesID, TransactionManager tm_ = null)
		{
			RepairRemoveByThemesIDData(themesID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByThemesIDAsync(string themesID, TransactionManager tm_ = null)
		{
			RepairRemoveByThemesIDData(themesID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByThemesIDData(string themesID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (themesID != null ? "`ThemesID` = @ThemesID" : "`ThemesID` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (themesID != null)
				paras_.Add(Database.CreateInParameter("@ThemesID", themesID, MySqlDbType.VarChar));
		}
		#endregion // RemoveByThemesID
		#region RemoveByStatus
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "status">状态</param>
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
		#region RemoveByLastLoginDate
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "lastLoginDate">最后一次登录时间</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByLastLoginDate(DateTime lastLoginDate, TransactionManager tm_ = null)
		{
			RepairRemoveByLastLoginDateData(lastLoginDate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByLastLoginDateAsync(DateTime lastLoginDate, TransactionManager tm_ = null)
		{
			RepairRemoveByLastLoginDateData(lastLoginDate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByLastLoginDateData(DateTime lastLoginDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `LastLoginDate` = @LastLoginDate";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@LastLoginDate", lastLoginDate, MySqlDbType.DateTime));
		}
		#endregion // RemoveByLastLoginDate
		#region RemoveByMobile
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "mobile">手机号</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByMobile(string mobile, TransactionManager tm_ = null)
		{
			RepairRemoveByMobileData(mobile, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByMobileAsync(string mobile, TransactionManager tm_ = null)
		{
			RepairRemoveByMobileData(mobile, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByMobileData(string mobile, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (mobile != null ? "`Mobile` = @Mobile" : "`Mobile` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (mobile != null)
				paras_.Add(Database.CreateInParameter("@Mobile", mobile, MySqlDbType.VarChar));
		}
		#endregion // RemoveByMobile
		#region RemoveByEmail
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "email">邮箱</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByEmail(string email, TransactionManager tm_ = null)
		{
			RepairRemoveByEmailData(email, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByEmailAsync(string email, TransactionManager tm_ = null)
		{
			RepairRemoveByEmailData(email, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByEmailData(string email, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (email != null ? "`Email` = @Email" : "`Email` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (email != null)
				paras_.Add(Database.CreateInParameter("@Email", email, MySqlDbType.VarChar));
		}
		#endregion // RemoveByEmail
		#region RemoveByUsername
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "username">登录用户名</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByUsername(string username, TransactionManager tm_ = null)
		{
			RepairRemoveByUsernameData(username, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByUsernameAsync(string username, TransactionManager tm_ = null)
		{
			RepairRemoveByUsernameData(username, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByUsernameData(string username, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (username != null ? "`Username` = @Username" : "`Username` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (username != null)
				paras_.Add(Database.CreateInParameter("@Username", username, MySqlDbType.VarChar));
		}
		#endregion // RemoveByUsername
		#region RemoveByPassword
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "password">密码哈希值</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPassword(string password, TransactionManager tm_ = null)
		{
			RepairRemoveByPasswordData(password, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPasswordAsync(string password, TransactionManager tm_ = null)
		{
			RepairRemoveByPasswordData(password, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByPasswordData(string password, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (password != null ? "`Password` = @Password" : "`Password` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (password != null)
				paras_.Add(Database.CreateInParameter("@Password", password, MySqlDbType.VarChar));
		}
		#endregion // RemoveByPassword
		#region RemoveByPasswordSalt
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "passwordSalt">密码哈希Salt</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPasswordSalt(string passwordSalt, TransactionManager tm_ = null)
		{
			RepairRemoveByPasswordSaltData(passwordSalt, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPasswordSaltAsync(string passwordSalt, TransactionManager tm_ = null)
		{
			RepairRemoveByPasswordSaltData(passwordSalt, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByPasswordSaltData(string passwordSalt, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (passwordSalt != null ? "`PasswordSalt` = @PasswordSalt" : "`PasswordSalt` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (passwordSalt != null)
				paras_.Add(Database.CreateInParameter("@PasswordSalt", passwordSalt, MySqlDbType.VarChar));
		}
		#endregion // RemoveByPasswordSalt
		#region RemoveByHasBet
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "hasBet">是否下过注</param>
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
		#region RemoveByHasPay
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "hasPay">是否充过值</param>
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
		#region RemoveByHasCash
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "hasCash">是否提过现</param>
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
		public int Put(S_userEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(S_userEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(S_userEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `UserID` = @UserID, `UserMode` = @UserMode, `OAuthType` = @OAuthType, `OAuthID` = @OAuthID, `Nickname` = @Nickname, `FromMode` = @FromMode, `FromId` = @FromId, `OperatorID` = @OperatorID, `OperatorUserId` = @OperatorUserId, `CountryID` = @CountryID, `CurrencyID` = @CurrencyID, `Cash` = @Cash, `Bonus` = @Bonus, `Coin` = @Coin, `Gold` = @Gold, `SWB` = @SWB, `Point` = @Point, `VIP` = @VIP, `PUserID1` = @PUserID1, `PUserID2` = @PUserID2, `UserProfile` = @UserProfile, `UserKind` = @UserKind, `IMEI` = @IMEI, `GAID` = @GAID, `UserIp` = @UserIp, `ClientUrl` = @ClientUrl, `ThemesID` = @ThemesID, `Status` = @Status, `RegistDate` = @RegistDate, `Mobile` = @Mobile, `Email` = @Email, `Username` = @Username, `Password` = @Password, `PasswordSalt` = @PasswordSalt, `HasBet` = @HasBet, `HasPay` = @HasPay, `HasCash` = @HasCash WHERE `UserID` = @UserID_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", item.UserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserMode", item.UserMode, MySqlDbType.Int32),
				Database.CreateInParameter("@OAuthType", item.OAuthType, MySqlDbType.Int32),
				Database.CreateInParameter("@OAuthID", item.OAuthID != null ? item.OAuthID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Nickname", item.Nickname != null ? item.Nickname : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@FromMode", item.FromMode, MySqlDbType.Int32),
				Database.CreateInParameter("@FromId", item.FromId != null ? item.FromId : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", item.OperatorID != null ? item.OperatorID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorUserId", item.OperatorUserId != null ? item.OperatorUserId : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryID", item.CountryID != null ? item.CountryID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", item.CurrencyID != null ? item.CurrencyID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Cash", item.Cash, MySqlDbType.Int64),
				Database.CreateInParameter("@Bonus", item.Bonus, MySqlDbType.Int64),
				Database.CreateInParameter("@Coin", item.Coin, MySqlDbType.Int64),
				Database.CreateInParameter("@Gold", item.Gold, MySqlDbType.Int64),
				Database.CreateInParameter("@SWB", item.SWB, MySqlDbType.Int64),
				Database.CreateInParameter("@Point", item.Point, MySqlDbType.Int64),
				Database.CreateInParameter("@VIP", item.VIP, MySqlDbType.Int32),
				Database.CreateInParameter("@PUserID1", item.PUserID1 != null ? item.PUserID1 : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@PUserID2", item.PUserID2 != null ? item.PUserID2 : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserProfile", item.UserProfile, MySqlDbType.Int32),
				Database.CreateInParameter("@UserKind", item.UserKind, MySqlDbType.Int32),
				Database.CreateInParameter("@IMEI", item.IMEI != null ? item.IMEI : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@GAID", item.GAID != null ? item.GAID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserIp", item.UserIp != null ? item.UserIp : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ClientUrl", item.ClientUrl != null ? item.ClientUrl : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ThemesID", item.ThemesID != null ? item.ThemesID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Status", item.Status, MySqlDbType.Int32),
				Database.CreateInParameter("@RegistDate", item.RegistDate.HasValue ? item.RegistDate.Value : (object)DBNull.Value, MySqlDbType.DateTime),
				Database.CreateInParameter("@Mobile", item.Mobile != null ? item.Mobile : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Email", item.Email != null ? item.Email : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Username", item.Username != null ? item.Username : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Password", item.Password != null ? item.Password : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@PasswordSalt", item.PasswordSalt != null ? item.PasswordSalt : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@HasBet", item.HasBet, MySqlDbType.Byte),
				Database.CreateInParameter("@HasPay", item.HasPay, MySqlDbType.Byte),
				Database.CreateInParameter("@HasCash", item.HasCash, MySqlDbType.Byte),
				Database.CreateInParameter("@UserID_Original", item.HasOriginal ? item.OriginalUserID : item.UserID, MySqlDbType.VarChar),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<S_userEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<S_userEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string userID, string set_, params object[] values_)
		{
			return Put(set_, "`UserID` = @UserID", ConcatValues(values_, userID));
		}
		public async Task<int> PutByPKAsync(string userID, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`UserID` = @UserID", ConcatValues(values_, userID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string userID, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`UserID` = @UserID", tm_, ConcatValues(values_, userID));
		}
		public async Task<int> PutByPKAsync(string userID, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`UserID` = @UserID", tm_, ConcatValues(values_, userID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string userID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
	        };
			return Put(set_, "`UserID` = @UserID", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(string userID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
	        };
			return await PutAsync(set_, "`UserID` = @UserID", ConcatParameters(paras_, newParas_), tm_);
		}
		#endregion // PutByPK
		
		#region PutXXX
		#region PutUserMode
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "userMode">用户登录模式 1-游客 2-注册用户</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutUserModeByPK(string userID, int userMode, TransactionManager tm_ = null)
		{
			RepairPutUserModeByPKData(userID, userMode, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutUserModeByPKAsync(string userID, int userMode, TransactionManager tm_ = null)
		{
			RepairPutUserModeByPKData(userID, userMode, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutUserModeByPKData(string userID, int userMode, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `UserMode` = @UserMode  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserMode", userMode, MySqlDbType.Int32),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "userMode">用户登录模式 1-游客 2-注册用户</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutUserMode(int userMode, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `UserMode` = @UserMode";
			var parameter_ = Database.CreateInParameter("@UserMode", userMode, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutUserModeAsync(int userMode, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `UserMode` = @UserMode";
			var parameter_ = Database.CreateInParameter("@UserMode", userMode, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutUserMode
		#region PutOAuthType
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "oAuthType">授权登录方式0-我方1-facebook2-google3-twitter</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOAuthTypeByPK(string userID, int oAuthType, TransactionManager tm_ = null)
		{
			RepairPutOAuthTypeByPKData(userID, oAuthType, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutOAuthTypeByPKAsync(string userID, int oAuthType, TransactionManager tm_ = null)
		{
			RepairPutOAuthTypeByPKData(userID, oAuthType, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutOAuthTypeByPKData(string userID, int oAuthType, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `OAuthType` = @OAuthType  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OAuthType", oAuthType, MySqlDbType.Int32),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "oAuthType">授权登录方式0-我方1-facebook2-google3-twitter</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOAuthType(int oAuthType, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `OAuthType` = @OAuthType";
			var parameter_ = Database.CreateInParameter("@OAuthType", oAuthType, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutOAuthTypeAsync(int oAuthType, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `OAuthType` = @OAuthType";
			var parameter_ = Database.CreateInParameter("@OAuthType", oAuthType, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutOAuthType
		#region PutOAuthID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "oAuthID">授权登录用户ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOAuthIDByPK(string userID, string oAuthID, TransactionManager tm_ = null)
		{
			RepairPutOAuthIDByPKData(userID, oAuthID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutOAuthIDByPKAsync(string userID, string oAuthID, TransactionManager tm_ = null)
		{
			RepairPutOAuthIDByPKData(userID, oAuthID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutOAuthIDByPKData(string userID, string oAuthID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `OAuthID` = @OAuthID  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OAuthID", oAuthID != null ? oAuthID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "oAuthID">授权登录用户ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOAuthID(string oAuthID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `OAuthID` = @OAuthID";
			var parameter_ = Database.CreateInParameter("@OAuthID", oAuthID != null ? oAuthID : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutOAuthIDAsync(string oAuthID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `OAuthID` = @OAuthID";
			var parameter_ = Database.CreateInParameter("@OAuthID", oAuthID != null ? oAuthID : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutOAuthID
		#region PutNickname
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "nickname">昵称</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutNicknameByPK(string userID, string nickname, TransactionManager tm_ = null)
		{
			RepairPutNicknameByPKData(userID, nickname, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutNicknameByPKAsync(string userID, string nickname, TransactionManager tm_ = null)
		{
			RepairPutNicknameByPKData(userID, nickname, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutNicknameByPKData(string userID, string nickname, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Nickname` = @Nickname  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Nickname", nickname != null ? nickname : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "nickname">昵称</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutNickname(string nickname, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Nickname` = @Nickname";
			var parameter_ = Database.CreateInParameter("@Nickname", nickname != null ? nickname : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutNicknameAsync(string nickname, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Nickname` = @Nickname";
			var parameter_ = Database.CreateInParameter("@Nickname", nickname != null ? nickname : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutNickname
		#region PutFromMode
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "fromMode">新用户来源方式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutFromModeByPK(string userID, int fromMode, TransactionManager tm_ = null)
		{
			RepairPutFromModeByPKData(userID, fromMode, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutFromModeByPKAsync(string userID, int fromMode, TransactionManager tm_ = null)
		{
			RepairPutFromModeByPKData(userID, fromMode, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutFromModeByPKData(string userID, int fromMode, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `FromMode` = @FromMode  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@FromMode", fromMode, MySqlDbType.Int32),
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
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "fromId">对应的编码（根据FromMode变化）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutFromIdByPK(string userID, string fromId, TransactionManager tm_ = null)
		{
			RepairPutFromIdByPKData(userID, fromId, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutFromIdByPKAsync(string userID, string fromId, TransactionManager tm_ = null)
		{
			RepairPutFromIdByPKData(userID, fromId, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutFromIdByPKData(string userID, string fromId, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `FromId` = @FromId  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@FromId", fromId != null ? fromId : (object)DBNull.Value, MySqlDbType.VarChar),
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
		#region PutOperatorID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOperatorIDByPK(string userID, string operatorID, TransactionManager tm_ = null)
		{
			RepairPutOperatorIDByPKData(userID, operatorID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutOperatorIDByPKAsync(string userID, string operatorID, TransactionManager tm_ = null)
		{
			RepairPutOperatorIDByPKData(userID, operatorID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutOperatorIDByPKData(string userID, string operatorID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `OperatorID` = @OperatorID  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID != null ? operatorID : (object)DBNull.Value, MySqlDbType.VarChar),
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
		#region PutOperatorUserId
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "operatorUserId">运营商用户标识（用户关联）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOperatorUserIdByPK(string userID, string operatorUserId, TransactionManager tm_ = null)
		{
			RepairPutOperatorUserIdByPKData(userID, operatorUserId, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutOperatorUserIdByPKAsync(string userID, string operatorUserId, TransactionManager tm_ = null)
		{
			RepairPutOperatorUserIdByPKData(userID, operatorUserId, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutOperatorUserIdByPKData(string userID, string operatorUserId, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `OperatorUserId` = @OperatorUserId  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorUserId", operatorUserId != null ? operatorUserId : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "operatorUserId">运营商用户标识（用户关联）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOperatorUserId(string operatorUserId, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `OperatorUserId` = @OperatorUserId";
			var parameter_ = Database.CreateInParameter("@OperatorUserId", operatorUserId != null ? operatorUserId : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutOperatorUserIdAsync(string operatorUserId, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `OperatorUserId` = @OperatorUserId";
			var parameter_ = Database.CreateInParameter("@OperatorUserId", operatorUserId != null ? operatorUserId : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutOperatorUserId
		#region PutCountryID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCountryIDByPK(string userID, string countryID, TransactionManager tm_ = null)
		{
			RepairPutCountryIDByPKData(userID, countryID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutCountryIDByPKAsync(string userID, string countryID, TransactionManager tm_ = null)
		{
			RepairPutCountryIDByPKData(userID, countryID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutCountryIDByPKData(string userID, string countryID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `CountryID` = @CountryID  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CountryID", countryID != null ? countryID : (object)DBNull.Value, MySqlDbType.VarChar),
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
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCurrencyIDByPK(string userID, string currencyID, TransactionManager tm_ = null)
		{
			RepairPutCurrencyIDByPKData(userID, currencyID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutCurrencyIDByPKAsync(string userID, string currencyID, TransactionManager tm_ = null)
		{
			RepairPutCurrencyIDByPKData(userID, currencyID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutCurrencyIDByPKData(string userID, string currencyID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `CurrencyID` = @CurrencyID  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CurrencyID", currencyID != null ? currencyID : (object)DBNull.Value, MySqlDbType.VarChar),
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
		#region PutCash
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "cash">现金（一级货币）*100000</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCashByPK(string userID, long cash, TransactionManager tm_ = null)
		{
			RepairPutCashByPKData(userID, cash, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutCashByPKAsync(string userID, long cash, TransactionManager tm_ = null)
		{
			RepairPutCashByPKData(userID, cash, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutCashByPKData(string userID, long cash, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Cash` = @Cash  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Cash", cash, MySqlDbType.Int64),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "cash">现金（一级货币）*100000</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCash(long cash, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Cash` = @Cash";
			var parameter_ = Database.CreateInParameter("@Cash", cash, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutCashAsync(long cash, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Cash` = @Cash";
			var parameter_ = Database.CreateInParameter("@Cash", cash, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutCash
		#region PutBonus
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "bonus">剩余赠金</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBonusByPK(string userID, long bonus, TransactionManager tm_ = null)
		{
			RepairPutBonusByPKData(userID, bonus, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutBonusByPKAsync(string userID, long bonus, TransactionManager tm_ = null)
		{
			RepairPutBonusByPKData(userID, bonus, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutBonusByPKData(string userID, long bonus, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Bonus` = @Bonus  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Bonus", bonus, MySqlDbType.Int64),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "bonus">剩余赠金</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBonus(long bonus, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Bonus` = @Bonus";
			var parameter_ = Database.CreateInParameter("@Bonus", bonus, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutBonusAsync(long bonus, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Bonus` = @Bonus";
			var parameter_ = Database.CreateInParameter("@Bonus", bonus, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutBonus
		#region PutCoin
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "coin">硬币（二级货币）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCoinByPK(string userID, long coin, TransactionManager tm_ = null)
		{
			RepairPutCoinByPKData(userID, coin, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutCoinByPKAsync(string userID, long coin, TransactionManager tm_ = null)
		{
			RepairPutCoinByPKData(userID, coin, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutCoinByPKData(string userID, long coin, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Coin` = @Coin  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Coin", coin, MySqlDbType.Int64),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "coin">硬币（二级货币）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCoin(long coin, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Coin` = @Coin";
			var parameter_ = Database.CreateInParameter("@Coin", coin, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutCoinAsync(long coin, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Coin` = @Coin";
			var parameter_ = Database.CreateInParameter("@Coin", coin, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutCoin
		#region PutGold
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "gold">金币</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutGoldByPK(string userID, long gold, TransactionManager tm_ = null)
		{
			RepairPutGoldByPKData(userID, gold, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutGoldByPKAsync(string userID, long gold, TransactionManager tm_ = null)
		{
			RepairPutGoldByPKData(userID, gold, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutGoldByPKData(string userID, long gold, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Gold` = @Gold  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Gold", gold, MySqlDbType.Int64),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "gold">金币</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutGold(long gold, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Gold` = @Gold";
			var parameter_ = Database.CreateInParameter("@Gold", gold, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutGoldAsync(long gold, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Gold` = @Gold";
			var parameter_ = Database.CreateInParameter("@Gold", gold, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutGold
		#region PutSWB
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "sWB">试玩币</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutSWBByPK(string userID, long sWB, TransactionManager tm_ = null)
		{
			RepairPutSWBByPKData(userID, sWB, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutSWBByPKAsync(string userID, long sWB, TransactionManager tm_ = null)
		{
			RepairPutSWBByPKData(userID, sWB, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutSWBByPKData(string userID, long sWB, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `SWB` = @SWB  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@SWB", sWB, MySqlDbType.Int64),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "sWB">试玩币</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutSWB(long sWB, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `SWB` = @SWB";
			var parameter_ = Database.CreateInParameter("@SWB", sWB, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutSWBAsync(long sWB, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `SWB` = @SWB";
			var parameter_ = Database.CreateInParameter("@SWB", sWB, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutSWB
		#region PutPoint
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "point">vip积分</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPointByPK(string userID, long point, TransactionManager tm_ = null)
		{
			RepairPutPointByPKData(userID, point, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutPointByPKAsync(string userID, long point, TransactionManager tm_ = null)
		{
			RepairPutPointByPKData(userID, point, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutPointByPKData(string userID, long point, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Point` = @Point  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Point", point, MySqlDbType.Int64),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "point">vip积分</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPoint(long point, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Point` = @Point";
			var parameter_ = Database.CreateInParameter("@Point", point, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutPointAsync(long point, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Point` = @Point";
			var parameter_ = Database.CreateInParameter("@Point", point, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutPoint
		#region PutVIP
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "vIP">vip等级</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutVIPByPK(string userID, int vIP, TransactionManager tm_ = null)
		{
			RepairPutVIPByPKData(userID, vIP, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutVIPByPKAsync(string userID, int vIP, TransactionManager tm_ = null)
		{
			RepairPutVIPByPKData(userID, vIP, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutVIPByPKData(string userID, int vIP, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `VIP` = @VIP  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@VIP", vIP, MySqlDbType.Int32),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "vIP">vip等级</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutVIP(int vIP, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `VIP` = @VIP";
			var parameter_ = Database.CreateInParameter("@VIP", vIP, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutVIPAsync(int vIP, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `VIP` = @VIP";
			var parameter_ = Database.CreateInParameter("@VIP", vIP, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutVIP
		#region PutPUserID1
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "pUserID1">1级推广员用户编码（直接推广员）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPUserID1ByPK(string userID, string pUserID1, TransactionManager tm_ = null)
		{
			RepairPutPUserID1ByPKData(userID, pUserID1, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutPUserID1ByPKAsync(string userID, string pUserID1, TransactionManager tm_ = null)
		{
			RepairPutPUserID1ByPKData(userID, pUserID1, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutPUserID1ByPKData(string userID, string pUserID1, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `PUserID1` = @PUserID1  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@PUserID1", pUserID1 != null ? pUserID1 : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "pUserID1">1级推广员用户编码（直接推广员）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPUserID1(string pUserID1, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `PUserID1` = @PUserID1";
			var parameter_ = Database.CreateInParameter("@PUserID1", pUserID1 != null ? pUserID1 : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutPUserID1Async(string pUserID1, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `PUserID1` = @PUserID1";
			var parameter_ = Database.CreateInParameter("@PUserID1", pUserID1 != null ? pUserID1 : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutPUserID1
		#region PutPUserID2
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "pUserID2">2级推广员用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPUserID2ByPK(string userID, string pUserID2, TransactionManager tm_ = null)
		{
			RepairPutPUserID2ByPKData(userID, pUserID2, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutPUserID2ByPKAsync(string userID, string pUserID2, TransactionManager tm_ = null)
		{
			RepairPutPUserID2ByPKData(userID, pUserID2, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutPUserID2ByPKData(string userID, string pUserID2, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `PUserID2` = @PUserID2  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@PUserID2", pUserID2 != null ? pUserID2 : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "pUserID2">2级推广员用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPUserID2(string pUserID2, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `PUserID2` = @PUserID2";
			var parameter_ = Database.CreateInParameter("@PUserID2", pUserID2 != null ? pUserID2 : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutPUserID2Async(string pUserID2, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `PUserID2` = @PUserID2";
			var parameter_ = Database.CreateInParameter("@PUserID2", pUserID2 != null ? pUserID2 : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutPUserID2
		#region PutUserProfile
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "userProfile">用户画像</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutUserProfileByPK(string userID, int userProfile, TransactionManager tm_ = null)
		{
			RepairPutUserProfileByPKData(userID, userProfile, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutUserProfileByPKAsync(string userID, int userProfile, TransactionManager tm_ = null)
		{
			RepairPutUserProfileByPKData(userID, userProfile, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutUserProfileByPKData(string userID, int userProfile, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `UserProfile` = @UserProfile  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserProfile", userProfile, MySqlDbType.Int32),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "userProfile">用户画像</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutUserProfile(int userProfile, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `UserProfile` = @UserProfile";
			var parameter_ = Database.CreateInParameter("@UserProfile", userProfile, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutUserProfileAsync(int userProfile, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `UserProfile` = @UserProfile";
			var parameter_ = Database.CreateInParameter("@UserProfile", userProfile, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutUserProfile
		#region PutUserKind
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "userKind">用户类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutUserKindByPK(string userID, int userKind, TransactionManager tm_ = null)
		{
			RepairPutUserKindByPKData(userID, userKind, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutUserKindByPKAsync(string userID, int userKind, TransactionManager tm_ = null)
		{
			RepairPutUserKindByPKData(userID, userKind, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutUserKindByPKData(string userID, int userKind, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `UserKind` = @UserKind  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserKind", userKind, MySqlDbType.Int32),
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
		#region PutIMEI
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "iMEI"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutIMEIByPK(string userID, string iMEI, TransactionManager tm_ = null)
		{
			RepairPutIMEIByPKData(userID, iMEI, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutIMEIByPKAsync(string userID, string iMEI, TransactionManager tm_ = null)
		{
			RepairPutIMEIByPKData(userID, iMEI, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutIMEIByPKData(string userID, string iMEI, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `IMEI` = @IMEI  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@IMEI", iMEI != null ? iMEI : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "iMEI"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutIMEI(string iMEI, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `IMEI` = @IMEI";
			var parameter_ = Database.CreateInParameter("@IMEI", iMEI != null ? iMEI : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutIMEIAsync(string iMEI, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `IMEI` = @IMEI";
			var parameter_ = Database.CreateInParameter("@IMEI", iMEI != null ? iMEI : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutIMEI
		#region PutGAID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "gAID"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutGAIDByPK(string userID, string gAID, TransactionManager tm_ = null)
		{
			RepairPutGAIDByPKData(userID, gAID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutGAIDByPKAsync(string userID, string gAID, TransactionManager tm_ = null)
		{
			RepairPutGAIDByPKData(userID, gAID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutGAIDByPKData(string userID, string gAID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `GAID` = @GAID  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@GAID", gAID != null ? gAID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "gAID"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutGAID(string gAID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `GAID` = @GAID";
			var parameter_ = Database.CreateInParameter("@GAID", gAID != null ? gAID : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutGAIDAsync(string gAID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `GAID` = @GAID";
			var parameter_ = Database.CreateInParameter("@GAID", gAID != null ? gAID : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutGAID
		#region PutUserIp
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "userIp">用户IP</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutUserIpByPK(string userID, string userIp, TransactionManager tm_ = null)
		{
			RepairPutUserIpByPKData(userID, userIp, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutUserIpByPKAsync(string userID, string userIp, TransactionManager tm_ = null)
		{
			RepairPutUserIpByPKData(userID, userIp, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutUserIpByPKData(string userID, string userIp, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `UserIp` = @UserIp  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserIp", userIp != null ? userIp : (object)DBNull.Value, MySqlDbType.VarChar),
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
		#region PutClientUrl
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "clientUrl">用户第一次进入客户端时的url</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutClientUrlByPK(string userID, string clientUrl, TransactionManager tm_ = null)
		{
			RepairPutClientUrlByPKData(userID, clientUrl, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutClientUrlByPKAsync(string userID, string clientUrl, TransactionManager tm_ = null)
		{
			RepairPutClientUrlByPKData(userID, clientUrl, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutClientUrlByPKData(string userID, string clientUrl, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `ClientUrl` = @ClientUrl  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ClientUrl", clientUrl != null ? clientUrl : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "clientUrl">用户第一次进入客户端时的url</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutClientUrl(string clientUrl, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ClientUrl` = @ClientUrl";
			var parameter_ = Database.CreateInParameter("@ClientUrl", clientUrl != null ? clientUrl : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutClientUrlAsync(string clientUrl, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ClientUrl` = @ClientUrl";
			var parameter_ = Database.CreateInParameter("@ClientUrl", clientUrl != null ? clientUrl : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutClientUrl
		#region PutThemesID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "themesID">样式编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutThemesIDByPK(string userID, string themesID, TransactionManager tm_ = null)
		{
			RepairPutThemesIDByPKData(userID, themesID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutThemesIDByPKAsync(string userID, string themesID, TransactionManager tm_ = null)
		{
			RepairPutThemesIDByPKData(userID, themesID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutThemesIDByPKData(string userID, string themesID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `ThemesID` = @ThemesID  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ThemesID", themesID != null ? themesID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "themesID">样式编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutThemesID(string themesID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ThemesID` = @ThemesID";
			var parameter_ = Database.CreateInParameter("@ThemesID", themesID != null ? themesID : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutThemesIDAsync(string themesID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ThemesID` = @ThemesID";
			var parameter_ = Database.CreateInParameter("@ThemesID", themesID != null ? themesID : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutThemesID
		#region PutStatus
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "status">状态</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutStatusByPK(string userID, int status, TransactionManager tm_ = null)
		{
			RepairPutStatusByPKData(userID, status, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutStatusByPKAsync(string userID, int status, TransactionManager tm_ = null)
		{
			RepairPutStatusByPKData(userID, status, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutStatusByPKData(string userID, int status, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Status` = @Status  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Status", status, MySqlDbType.Int32),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "status">状态</param>
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
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRecDateByPK(string userID, DateTime recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(userID, recDate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutRecDateByPKAsync(string userID, DateTime recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(userID, recDate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutRecDateByPKData(string userID, DateTime recDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `RecDate` = @RecDate  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime),
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
		#region PutRegistDate
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "registDate">注册时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRegistDateByPK(string userID, DateTime? registDate, TransactionManager tm_ = null)
		{
			RepairPutRegistDateByPKData(userID, registDate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutRegistDateByPKAsync(string userID, DateTime? registDate, TransactionManager tm_ = null)
		{
			RepairPutRegistDateByPKData(userID, registDate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutRegistDateByPKData(string userID, DateTime? registDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `RegistDate` = @RegistDate  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RegistDate", registDate.HasValue ? registDate.Value : (object)DBNull.Value, MySqlDbType.DateTime),
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
		#region PutLastLoginDate
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "lastLoginDate">最后一次登录时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutLastLoginDateByPK(string userID, DateTime lastLoginDate, TransactionManager tm_ = null)
		{
			RepairPutLastLoginDateByPKData(userID, lastLoginDate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutLastLoginDateByPKAsync(string userID, DateTime lastLoginDate, TransactionManager tm_ = null)
		{
			RepairPutLastLoginDateByPKData(userID, lastLoginDate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutLastLoginDateByPKData(string userID, DateTime lastLoginDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `LastLoginDate` = @LastLoginDate  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LastLoginDate", lastLoginDate, MySqlDbType.DateTime),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "lastLoginDate">最后一次登录时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutLastLoginDate(DateTime lastLoginDate, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `LastLoginDate` = @LastLoginDate";
			var parameter_ = Database.CreateInParameter("@LastLoginDate", lastLoginDate, MySqlDbType.DateTime);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutLastLoginDateAsync(DateTime lastLoginDate, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `LastLoginDate` = @LastLoginDate";
			var parameter_ = Database.CreateInParameter("@LastLoginDate", lastLoginDate, MySqlDbType.DateTime);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutLastLoginDate
		#region PutMobile
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "mobile">手机号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutMobileByPK(string userID, string mobile, TransactionManager tm_ = null)
		{
			RepairPutMobileByPKData(userID, mobile, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutMobileByPKAsync(string userID, string mobile, TransactionManager tm_ = null)
		{
			RepairPutMobileByPKData(userID, mobile, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutMobileByPKData(string userID, string mobile, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Mobile` = @Mobile  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Mobile", mobile != null ? mobile : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "mobile">手机号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutMobile(string mobile, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Mobile` = @Mobile";
			var parameter_ = Database.CreateInParameter("@Mobile", mobile != null ? mobile : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutMobileAsync(string mobile, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Mobile` = @Mobile";
			var parameter_ = Database.CreateInParameter("@Mobile", mobile != null ? mobile : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutMobile
		#region PutEmail
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "email">邮箱</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutEmailByPK(string userID, string email, TransactionManager tm_ = null)
		{
			RepairPutEmailByPKData(userID, email, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutEmailByPKAsync(string userID, string email, TransactionManager tm_ = null)
		{
			RepairPutEmailByPKData(userID, email, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutEmailByPKData(string userID, string email, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Email` = @Email  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Email", email != null ? email : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "email">邮箱</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutEmail(string email, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Email` = @Email";
			var parameter_ = Database.CreateInParameter("@Email", email != null ? email : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutEmailAsync(string email, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Email` = @Email";
			var parameter_ = Database.CreateInParameter("@Email", email != null ? email : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutEmail
		#region PutUsername
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "username">登录用户名</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutUsernameByPK(string userID, string username, TransactionManager tm_ = null)
		{
			RepairPutUsernameByPKData(userID, username, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutUsernameByPKAsync(string userID, string username, TransactionManager tm_ = null)
		{
			RepairPutUsernameByPKData(userID, username, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutUsernameByPKData(string userID, string username, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Username` = @Username  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Username", username != null ? username : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "username">登录用户名</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutUsername(string username, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Username` = @Username";
			var parameter_ = Database.CreateInParameter("@Username", username != null ? username : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutUsernameAsync(string username, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Username` = @Username";
			var parameter_ = Database.CreateInParameter("@Username", username != null ? username : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutUsername
		#region PutPassword
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "password">密码哈希值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPasswordByPK(string userID, string password, TransactionManager tm_ = null)
		{
			RepairPutPasswordByPKData(userID, password, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutPasswordByPKAsync(string userID, string password, TransactionManager tm_ = null)
		{
			RepairPutPasswordByPKData(userID, password, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutPasswordByPKData(string userID, string password, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Password` = @Password  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Password", password != null ? password : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "password">密码哈希值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPassword(string password, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Password` = @Password";
			var parameter_ = Database.CreateInParameter("@Password", password != null ? password : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutPasswordAsync(string password, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Password` = @Password";
			var parameter_ = Database.CreateInParameter("@Password", password != null ? password : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutPassword
		#region PutPasswordSalt
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "passwordSalt">密码哈希Salt</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPasswordSaltByPK(string userID, string passwordSalt, TransactionManager tm_ = null)
		{
			RepairPutPasswordSaltByPKData(userID, passwordSalt, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutPasswordSaltByPKAsync(string userID, string passwordSalt, TransactionManager tm_ = null)
		{
			RepairPutPasswordSaltByPKData(userID, passwordSalt, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutPasswordSaltByPKData(string userID, string passwordSalt, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `PasswordSalt` = @PasswordSalt  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@PasswordSalt", passwordSalt != null ? passwordSalt : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "passwordSalt">密码哈希Salt</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPasswordSalt(string passwordSalt, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `PasswordSalt` = @PasswordSalt";
			var parameter_ = Database.CreateInParameter("@PasswordSalt", passwordSalt != null ? passwordSalt : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutPasswordSaltAsync(string passwordSalt, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `PasswordSalt` = @PasswordSalt";
			var parameter_ = Database.CreateInParameter("@PasswordSalt", passwordSalt != null ? passwordSalt : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutPasswordSalt
		#region PutHasBet
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "hasBet">是否下过注</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutHasBetByPK(string userID, bool hasBet, TransactionManager tm_ = null)
		{
			RepairPutHasBetByPKData(userID, hasBet, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutHasBetByPKAsync(string userID, bool hasBet, TransactionManager tm_ = null)
		{
			RepairPutHasBetByPKData(userID, hasBet, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutHasBetByPKData(string userID, bool hasBet, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `HasBet` = @HasBet  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@HasBet", hasBet, MySqlDbType.Byte),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "hasBet">是否下过注</param>
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
		#region PutHasPay
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "hasPay">是否充过值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutHasPayByPK(string userID, bool hasPay, TransactionManager tm_ = null)
		{
			RepairPutHasPayByPKData(userID, hasPay, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutHasPayByPKAsync(string userID, bool hasPay, TransactionManager tm_ = null)
		{
			RepairPutHasPayByPKData(userID, hasPay, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutHasPayByPKData(string userID, bool hasPay, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `HasPay` = @HasPay  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@HasPay", hasPay, MySqlDbType.Byte),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "hasPay">是否充过值</param>
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
		#region PutHasCash
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "hasCash">是否提过现</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutHasCashByPK(string userID, bool hasCash, TransactionManager tm_ = null)
		{
			RepairPutHasCashByPKData(userID, hasCash, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutHasCashByPKAsync(string userID, bool hasCash, TransactionManager tm_ = null)
		{
			RepairPutHasCashByPKData(userID, hasCash, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutHasCashByPKData(string userID, bool hasCash, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `HasCash` = @HasCash  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@HasCash", hasCash, MySqlDbType.Byte),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "hasCash">是否提过现</param>
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
		#endregion // PutXXX
		#endregion // Put
	   
		#region Set
		
		/// <summary>
		/// 插入或者更新数据
		/// </summary>
		/// <param name = "item">要更新的实体对象</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>true:插入操作；false:更新操作</return>
		public bool Set(S_userEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.UserID) == null)
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
		public async Task<bool> SetAsync(S_userEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.UserID) == null)
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
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public S_userEO GetByPK(string userID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(userID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, S_userEO.MapDataReader);
		}
		public async Task<S_userEO> GetByPKAsync(string userID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(userID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, S_userEO.MapDataReader);
		}
		private void RepairGetByPKData(string userID, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false, TransactionManager tm_ = null)
		{
			sql_ = BuildSelectSQL("`UserID` = @UserID", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
		#endregion // GetByPK
		
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 UserMode（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetUserModeByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`UserMode`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<int> GetUserModeByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`UserMode`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 OAuthType（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetOAuthTypeByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`OAuthType`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<int> GetOAuthTypeByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`OAuthType`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 OAuthID（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetOAuthIDByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`OAuthID`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<string> GetOAuthIDByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`OAuthID`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Nickname（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetNicknameByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`Nickname`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<string> GetNicknameByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`Nickname`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 FromMode（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetFromModeByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`FromMode`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<int> GetFromModeByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`FromMode`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 FromId（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetFromIdByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`FromId`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<string> GetFromIdByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`FromId`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 OperatorID（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetOperatorIDByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`OperatorID`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<string> GetOperatorIDByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`OperatorID`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 OperatorUserId（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetOperatorUserIdByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`OperatorUserId`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<string> GetOperatorUserIdByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`OperatorUserId`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 CountryID（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetCountryIDByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`CountryID`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<string> GetCountryIDByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`CountryID`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 CurrencyID（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetCurrencyIDByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`CurrencyID`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<string> GetCurrencyIDByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`CurrencyID`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Cash（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetCashByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`Cash`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<long> GetCashByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`Cash`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Bonus（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetBonusByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`Bonus`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<long> GetBonusByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`Bonus`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Coin（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetCoinByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`Coin`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<long> GetCoinByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`Coin`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Gold（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetGoldByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`Gold`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<long> GetGoldByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`Gold`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 SWB（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetSWBByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`SWB`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<long> GetSWBByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`SWB`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Point（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetPointByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`Point`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<long> GetPointByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`Point`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 VIP（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetVIPByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`VIP`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<int> GetVIPByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`VIP`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 PUserID1（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetPUserID1ByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`PUserID1`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<string> GetPUserID1ByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`PUserID1`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 PUserID2（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetPUserID2ByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`PUserID2`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<string> GetPUserID2ByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`PUserID2`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 UserProfile（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetUserProfileByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`UserProfile`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<int> GetUserProfileByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`UserProfile`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 UserKind（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetUserKindByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`UserKind`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<int> GetUserKindByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`UserKind`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 IMEI（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetIMEIByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`IMEI`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<string> GetIMEIByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`IMEI`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 GAID（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetGAIDByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`GAID`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<string> GetGAIDByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`GAID`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 UserIp（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetUserIpByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`UserIp`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<string> GetUserIpByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`UserIp`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 ClientUrl（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetClientUrlByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`ClientUrl`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<string> GetClientUrlByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`ClientUrl`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 ThemesID（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetThemesIDByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`ThemesID`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<string> GetThemesIDByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`ThemesID`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Status（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetStatusByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`Status`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<int> GetStatusByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`Status`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 RecDate（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime GetRecDateByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (DateTime)GetScalar("`RecDate`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<DateTime> GetRecDateByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (DateTime)await GetScalarAsync("`RecDate`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 RegistDate（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime? GetRegistDateByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (DateTime?)GetScalar("`RegistDate`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<DateTime?> GetRegistDateByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (DateTime?)await GetScalarAsync("`RegistDate`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 LastLoginDate（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime GetLastLoginDateByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (DateTime)GetScalar("`LastLoginDate`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<DateTime> GetLastLoginDateByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (DateTime)await GetScalarAsync("`LastLoginDate`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Mobile（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetMobileByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`Mobile`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<string> GetMobileByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`Mobile`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Email（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetEmailByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`Email`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<string> GetEmailByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`Email`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Username（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetUsernameByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`Username`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<string> GetUsernameByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`Username`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Password（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetPasswordByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`Password`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<string> GetPasswordByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`Password`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 PasswordSalt（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetPasswordSaltByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`PasswordSalt`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<string> GetPasswordSaltByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`PasswordSalt`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 HasBet（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public bool GetHasBetByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (bool)GetScalar("`HasBet`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<bool> GetHasBetByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (bool)await GetScalarAsync("`HasBet`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 HasPay（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public bool GetHasPayByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (bool)GetScalar("`HasPay`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<bool> GetHasPayByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (bool)await GetScalarAsync("`HasPay`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 HasCash（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public bool GetHasCashByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (bool)GetScalar("`HasCash`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<bool> GetHasCashByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (bool)await GetScalarAsync("`HasCash`", "`UserID` = @UserID", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByUserMode
		
		/// <summary>
		/// 按 UserMode（字段） 查询
		/// </summary>
		/// /// <param name = "userMode">用户登录模式 1-游客 2-注册用户</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByUserMode(int userMode)
		{
			return GetByUserMode(userMode, 0, string.Empty, null);
		}
		public async Task<List<S_userEO>> GetByUserModeAsync(int userMode)
		{
			return await GetByUserModeAsync(userMode, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UserMode（字段） 查询
		/// </summary>
		/// /// <param name = "userMode">用户登录模式 1-游客 2-注册用户</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByUserMode(int userMode, TransactionManager tm_)
		{
			return GetByUserMode(userMode, 0, string.Empty, tm_);
		}
		public async Task<List<S_userEO>> GetByUserModeAsync(int userMode, TransactionManager tm_)
		{
			return await GetByUserModeAsync(userMode, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserMode（字段） 查询
		/// </summary>
		/// /// <param name = "userMode">用户登录模式 1-游客 2-注册用户</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByUserMode(int userMode, int top_)
		{
			return GetByUserMode(userMode, top_, string.Empty, null);
		}
		public async Task<List<S_userEO>> GetByUserModeAsync(int userMode, int top_)
		{
			return await GetByUserModeAsync(userMode, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UserMode（字段） 查询
		/// </summary>
		/// /// <param name = "userMode">用户登录模式 1-游客 2-注册用户</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByUserMode(int userMode, int top_, TransactionManager tm_)
		{
			return GetByUserMode(userMode, top_, string.Empty, tm_);
		}
		public async Task<List<S_userEO>> GetByUserModeAsync(int userMode, int top_, TransactionManager tm_)
		{
			return await GetByUserModeAsync(userMode, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserMode（字段） 查询
		/// </summary>
		/// /// <param name = "userMode">用户登录模式 1-游客 2-注册用户</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByUserMode(int userMode, string sort_)
		{
			return GetByUserMode(userMode, 0, sort_, null);
		}
		public async Task<List<S_userEO>> GetByUserModeAsync(int userMode, string sort_)
		{
			return await GetByUserModeAsync(userMode, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 UserMode（字段） 查询
		/// </summary>
		/// /// <param name = "userMode">用户登录模式 1-游客 2-注册用户</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByUserMode(int userMode, string sort_, TransactionManager tm_)
		{
			return GetByUserMode(userMode, 0, sort_, tm_);
		}
		public async Task<List<S_userEO>> GetByUserModeAsync(int userMode, string sort_, TransactionManager tm_)
		{
			return await GetByUserModeAsync(userMode, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 UserMode（字段） 查询
		/// </summary>
		/// /// <param name = "userMode">用户登录模式 1-游客 2-注册用户</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByUserMode(int userMode, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UserMode` = @UserMode", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserMode", userMode, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, S_userEO.MapDataReader);
		}
		public async Task<List<S_userEO>> GetByUserModeAsync(int userMode, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UserMode` = @UserMode", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserMode", userMode, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_userEO.MapDataReader);
		}
		#endregion // GetByUserMode
		#region GetByOAuthType
		
		/// <summary>
		/// 按 OAuthType（字段） 查询
		/// </summary>
		/// /// <param name = "oAuthType">授权登录方式0-我方1-facebook2-google3-twitter</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByOAuthType(int oAuthType)
		{
			return GetByOAuthType(oAuthType, 0, string.Empty, null);
		}
		public async Task<List<S_userEO>> GetByOAuthTypeAsync(int oAuthType)
		{
			return await GetByOAuthTypeAsync(oAuthType, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OAuthType（字段） 查询
		/// </summary>
		/// /// <param name = "oAuthType">授权登录方式0-我方1-facebook2-google3-twitter</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByOAuthType(int oAuthType, TransactionManager tm_)
		{
			return GetByOAuthType(oAuthType, 0, string.Empty, tm_);
		}
		public async Task<List<S_userEO>> GetByOAuthTypeAsync(int oAuthType, TransactionManager tm_)
		{
			return await GetByOAuthTypeAsync(oAuthType, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OAuthType（字段） 查询
		/// </summary>
		/// /// <param name = "oAuthType">授权登录方式0-我方1-facebook2-google3-twitter</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByOAuthType(int oAuthType, int top_)
		{
			return GetByOAuthType(oAuthType, top_, string.Empty, null);
		}
		public async Task<List<S_userEO>> GetByOAuthTypeAsync(int oAuthType, int top_)
		{
			return await GetByOAuthTypeAsync(oAuthType, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OAuthType（字段） 查询
		/// </summary>
		/// /// <param name = "oAuthType">授权登录方式0-我方1-facebook2-google3-twitter</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByOAuthType(int oAuthType, int top_, TransactionManager tm_)
		{
			return GetByOAuthType(oAuthType, top_, string.Empty, tm_);
		}
		public async Task<List<S_userEO>> GetByOAuthTypeAsync(int oAuthType, int top_, TransactionManager tm_)
		{
			return await GetByOAuthTypeAsync(oAuthType, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OAuthType（字段） 查询
		/// </summary>
		/// /// <param name = "oAuthType">授权登录方式0-我方1-facebook2-google3-twitter</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByOAuthType(int oAuthType, string sort_)
		{
			return GetByOAuthType(oAuthType, 0, sort_, null);
		}
		public async Task<List<S_userEO>> GetByOAuthTypeAsync(int oAuthType, string sort_)
		{
			return await GetByOAuthTypeAsync(oAuthType, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 OAuthType（字段） 查询
		/// </summary>
		/// /// <param name = "oAuthType">授权登录方式0-我方1-facebook2-google3-twitter</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByOAuthType(int oAuthType, string sort_, TransactionManager tm_)
		{
			return GetByOAuthType(oAuthType, 0, sort_, tm_);
		}
		public async Task<List<S_userEO>> GetByOAuthTypeAsync(int oAuthType, string sort_, TransactionManager tm_)
		{
			return await GetByOAuthTypeAsync(oAuthType, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 OAuthType（字段） 查询
		/// </summary>
		/// /// <param name = "oAuthType">授权登录方式0-我方1-facebook2-google3-twitter</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByOAuthType(int oAuthType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OAuthType` = @OAuthType", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OAuthType", oAuthType, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, S_userEO.MapDataReader);
		}
		public async Task<List<S_userEO>> GetByOAuthTypeAsync(int oAuthType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OAuthType` = @OAuthType", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OAuthType", oAuthType, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_userEO.MapDataReader);
		}
		#endregion // GetByOAuthType
		#region GetByOAuthID
		
		/// <summary>
		/// 按 OAuthID（字段） 查询
		/// </summary>
		/// /// <param name = "oAuthID">授权登录用户ID</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByOAuthID(string oAuthID)
		{
			return GetByOAuthID(oAuthID, 0, string.Empty, null);
		}
		public async Task<List<S_userEO>> GetByOAuthIDAsync(string oAuthID)
		{
			return await GetByOAuthIDAsync(oAuthID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OAuthID（字段） 查询
		/// </summary>
		/// /// <param name = "oAuthID">授权登录用户ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByOAuthID(string oAuthID, TransactionManager tm_)
		{
			return GetByOAuthID(oAuthID, 0, string.Empty, tm_);
		}
		public async Task<List<S_userEO>> GetByOAuthIDAsync(string oAuthID, TransactionManager tm_)
		{
			return await GetByOAuthIDAsync(oAuthID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OAuthID（字段） 查询
		/// </summary>
		/// /// <param name = "oAuthID">授权登录用户ID</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByOAuthID(string oAuthID, int top_)
		{
			return GetByOAuthID(oAuthID, top_, string.Empty, null);
		}
		public async Task<List<S_userEO>> GetByOAuthIDAsync(string oAuthID, int top_)
		{
			return await GetByOAuthIDAsync(oAuthID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OAuthID（字段） 查询
		/// </summary>
		/// /// <param name = "oAuthID">授权登录用户ID</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByOAuthID(string oAuthID, int top_, TransactionManager tm_)
		{
			return GetByOAuthID(oAuthID, top_, string.Empty, tm_);
		}
		public async Task<List<S_userEO>> GetByOAuthIDAsync(string oAuthID, int top_, TransactionManager tm_)
		{
			return await GetByOAuthIDAsync(oAuthID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OAuthID（字段） 查询
		/// </summary>
		/// /// <param name = "oAuthID">授权登录用户ID</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByOAuthID(string oAuthID, string sort_)
		{
			return GetByOAuthID(oAuthID, 0, sort_, null);
		}
		public async Task<List<S_userEO>> GetByOAuthIDAsync(string oAuthID, string sort_)
		{
			return await GetByOAuthIDAsync(oAuthID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 OAuthID（字段） 查询
		/// </summary>
		/// /// <param name = "oAuthID">授权登录用户ID</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByOAuthID(string oAuthID, string sort_, TransactionManager tm_)
		{
			return GetByOAuthID(oAuthID, 0, sort_, tm_);
		}
		public async Task<List<S_userEO>> GetByOAuthIDAsync(string oAuthID, string sort_, TransactionManager tm_)
		{
			return await GetByOAuthIDAsync(oAuthID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 OAuthID（字段） 查询
		/// </summary>
		/// /// <param name = "oAuthID">授权登录用户ID</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByOAuthID(string oAuthID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(oAuthID != null ? "`OAuthID` = @OAuthID" : "`OAuthID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (oAuthID != null)
				paras_.Add(Database.CreateInParameter("@OAuthID", oAuthID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_userEO.MapDataReader);
		}
		public async Task<List<S_userEO>> GetByOAuthIDAsync(string oAuthID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(oAuthID != null ? "`OAuthID` = @OAuthID" : "`OAuthID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (oAuthID != null)
				paras_.Add(Database.CreateInParameter("@OAuthID", oAuthID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_userEO.MapDataReader);
		}
		#endregion // GetByOAuthID
		#region GetByNickname
		
		/// <summary>
		/// 按 Nickname（字段） 查询
		/// </summary>
		/// /// <param name = "nickname">昵称</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByNickname(string nickname)
		{
			return GetByNickname(nickname, 0, string.Empty, null);
		}
		public async Task<List<S_userEO>> GetByNicknameAsync(string nickname)
		{
			return await GetByNicknameAsync(nickname, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Nickname（字段） 查询
		/// </summary>
		/// /// <param name = "nickname">昵称</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByNickname(string nickname, TransactionManager tm_)
		{
			return GetByNickname(nickname, 0, string.Empty, tm_);
		}
		public async Task<List<S_userEO>> GetByNicknameAsync(string nickname, TransactionManager tm_)
		{
			return await GetByNicknameAsync(nickname, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Nickname（字段） 查询
		/// </summary>
		/// /// <param name = "nickname">昵称</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByNickname(string nickname, int top_)
		{
			return GetByNickname(nickname, top_, string.Empty, null);
		}
		public async Task<List<S_userEO>> GetByNicknameAsync(string nickname, int top_)
		{
			return await GetByNicknameAsync(nickname, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Nickname（字段） 查询
		/// </summary>
		/// /// <param name = "nickname">昵称</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByNickname(string nickname, int top_, TransactionManager tm_)
		{
			return GetByNickname(nickname, top_, string.Empty, tm_);
		}
		public async Task<List<S_userEO>> GetByNicknameAsync(string nickname, int top_, TransactionManager tm_)
		{
			return await GetByNicknameAsync(nickname, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Nickname（字段） 查询
		/// </summary>
		/// /// <param name = "nickname">昵称</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByNickname(string nickname, string sort_)
		{
			return GetByNickname(nickname, 0, sort_, null);
		}
		public async Task<List<S_userEO>> GetByNicknameAsync(string nickname, string sort_)
		{
			return await GetByNicknameAsync(nickname, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Nickname（字段） 查询
		/// </summary>
		/// /// <param name = "nickname">昵称</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByNickname(string nickname, string sort_, TransactionManager tm_)
		{
			return GetByNickname(nickname, 0, sort_, tm_);
		}
		public async Task<List<S_userEO>> GetByNicknameAsync(string nickname, string sort_, TransactionManager tm_)
		{
			return await GetByNicknameAsync(nickname, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Nickname（字段） 查询
		/// </summary>
		/// /// <param name = "nickname">昵称</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByNickname(string nickname, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(nickname != null ? "`Nickname` = @Nickname" : "`Nickname` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (nickname != null)
				paras_.Add(Database.CreateInParameter("@Nickname", nickname, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_userEO.MapDataReader);
		}
		public async Task<List<S_userEO>> GetByNicknameAsync(string nickname, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(nickname != null ? "`Nickname` = @Nickname" : "`Nickname` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (nickname != null)
				paras_.Add(Database.CreateInParameter("@Nickname", nickname, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_userEO.MapDataReader);
		}
		#endregion // GetByNickname
		#region GetByFromMode
		
		/// <summary>
		/// 按 FromMode（字段） 查询
		/// </summary>
		/// /// <param name = "fromMode">新用户来源方式</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByFromMode(int fromMode)
		{
			return GetByFromMode(fromMode, 0, string.Empty, null);
		}
		public async Task<List<S_userEO>> GetByFromModeAsync(int fromMode)
		{
			return await GetByFromModeAsync(fromMode, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 FromMode（字段） 查询
		/// </summary>
		/// /// <param name = "fromMode">新用户来源方式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByFromMode(int fromMode, TransactionManager tm_)
		{
			return GetByFromMode(fromMode, 0, string.Empty, tm_);
		}
		public async Task<List<S_userEO>> GetByFromModeAsync(int fromMode, TransactionManager tm_)
		{
			return await GetByFromModeAsync(fromMode, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FromMode（字段） 查询
		/// </summary>
		/// /// <param name = "fromMode">新用户来源方式</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByFromMode(int fromMode, int top_)
		{
			return GetByFromMode(fromMode, top_, string.Empty, null);
		}
		public async Task<List<S_userEO>> GetByFromModeAsync(int fromMode, int top_)
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
		public List<S_userEO> GetByFromMode(int fromMode, int top_, TransactionManager tm_)
		{
			return GetByFromMode(fromMode, top_, string.Empty, tm_);
		}
		public async Task<List<S_userEO>> GetByFromModeAsync(int fromMode, int top_, TransactionManager tm_)
		{
			return await GetByFromModeAsync(fromMode, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FromMode（字段） 查询
		/// </summary>
		/// /// <param name = "fromMode">新用户来源方式</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByFromMode(int fromMode, string sort_)
		{
			return GetByFromMode(fromMode, 0, sort_, null);
		}
		public async Task<List<S_userEO>> GetByFromModeAsync(int fromMode, string sort_)
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
		public List<S_userEO> GetByFromMode(int fromMode, string sort_, TransactionManager tm_)
		{
			return GetByFromMode(fromMode, 0, sort_, tm_);
		}
		public async Task<List<S_userEO>> GetByFromModeAsync(int fromMode, string sort_, TransactionManager tm_)
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
		public List<S_userEO> GetByFromMode(int fromMode, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`FromMode` = @FromMode", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FromMode", fromMode, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, S_userEO.MapDataReader);
		}
		public async Task<List<S_userEO>> GetByFromModeAsync(int fromMode, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`FromMode` = @FromMode", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FromMode", fromMode, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_userEO.MapDataReader);
		}
		#endregion // GetByFromMode
		#region GetByFromId
		
		/// <summary>
		/// 按 FromId（字段） 查询
		/// </summary>
		/// /// <param name = "fromId">对应的编码（根据FromMode变化）</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByFromId(string fromId)
		{
			return GetByFromId(fromId, 0, string.Empty, null);
		}
		public async Task<List<S_userEO>> GetByFromIdAsync(string fromId)
		{
			return await GetByFromIdAsync(fromId, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 FromId（字段） 查询
		/// </summary>
		/// /// <param name = "fromId">对应的编码（根据FromMode变化）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByFromId(string fromId, TransactionManager tm_)
		{
			return GetByFromId(fromId, 0, string.Empty, tm_);
		}
		public async Task<List<S_userEO>> GetByFromIdAsync(string fromId, TransactionManager tm_)
		{
			return await GetByFromIdAsync(fromId, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FromId（字段） 查询
		/// </summary>
		/// /// <param name = "fromId">对应的编码（根据FromMode变化）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByFromId(string fromId, int top_)
		{
			return GetByFromId(fromId, top_, string.Empty, null);
		}
		public async Task<List<S_userEO>> GetByFromIdAsync(string fromId, int top_)
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
		public List<S_userEO> GetByFromId(string fromId, int top_, TransactionManager tm_)
		{
			return GetByFromId(fromId, top_, string.Empty, tm_);
		}
		public async Task<List<S_userEO>> GetByFromIdAsync(string fromId, int top_, TransactionManager tm_)
		{
			return await GetByFromIdAsync(fromId, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FromId（字段） 查询
		/// </summary>
		/// /// <param name = "fromId">对应的编码（根据FromMode变化）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByFromId(string fromId, string sort_)
		{
			return GetByFromId(fromId, 0, sort_, null);
		}
		public async Task<List<S_userEO>> GetByFromIdAsync(string fromId, string sort_)
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
		public List<S_userEO> GetByFromId(string fromId, string sort_, TransactionManager tm_)
		{
			return GetByFromId(fromId, 0, sort_, tm_);
		}
		public async Task<List<S_userEO>> GetByFromIdAsync(string fromId, string sort_, TransactionManager tm_)
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
		public List<S_userEO> GetByFromId(string fromId, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(fromId != null ? "`FromId` = @FromId" : "`FromId` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (fromId != null)
				paras_.Add(Database.CreateInParameter("@FromId", fromId, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_userEO.MapDataReader);
		}
		public async Task<List<S_userEO>> GetByFromIdAsync(string fromId, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(fromId != null ? "`FromId` = @FromId" : "`FromId` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (fromId != null)
				paras_.Add(Database.CreateInParameter("@FromId", fromId, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_userEO.MapDataReader);
		}
		#endregion // GetByFromId
		#region GetByOperatorID
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByOperatorID(string operatorID)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, null);
		}
		public async Task<List<S_userEO>> GetByOperatorIDAsync(string operatorID)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByOperatorID(string operatorID, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, tm_);
		}
		public async Task<List<S_userEO>> GetByOperatorIDAsync(string operatorID, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByOperatorID(string operatorID, int top_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, null);
		}
		public async Task<List<S_userEO>> GetByOperatorIDAsync(string operatorID, int top_)
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
		public List<S_userEO> GetByOperatorID(string operatorID, int top_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, tm_);
		}
		public async Task<List<S_userEO>> GetByOperatorIDAsync(string operatorID, int top_, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByOperatorID(string operatorID, string sort_)
		{
			return GetByOperatorID(operatorID, 0, sort_, null);
		}
		public async Task<List<S_userEO>> GetByOperatorIDAsync(string operatorID, string sort_)
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
		public List<S_userEO> GetByOperatorID(string operatorID, string sort_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, sort_, tm_);
		}
		public async Task<List<S_userEO>> GetByOperatorIDAsync(string operatorID, string sort_, TransactionManager tm_)
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
		public List<S_userEO> GetByOperatorID(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(operatorID != null ? "`OperatorID` = @OperatorID" : "`OperatorID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (operatorID != null)
				paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_userEO.MapDataReader);
		}
		public async Task<List<S_userEO>> GetByOperatorIDAsync(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(operatorID != null ? "`OperatorID` = @OperatorID" : "`OperatorID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (operatorID != null)
				paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_userEO.MapDataReader);
		}
		#endregion // GetByOperatorID
		#region GetByOperatorUserId
		
		/// <summary>
		/// 按 OperatorUserId（字段） 查询
		/// </summary>
		/// /// <param name = "operatorUserId">运营商用户标识（用户关联）</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByOperatorUserId(string operatorUserId)
		{
			return GetByOperatorUserId(operatorUserId, 0, string.Empty, null);
		}
		public async Task<List<S_userEO>> GetByOperatorUserIdAsync(string operatorUserId)
		{
			return await GetByOperatorUserIdAsync(operatorUserId, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorUserId（字段） 查询
		/// </summary>
		/// /// <param name = "operatorUserId">运营商用户标识（用户关联）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByOperatorUserId(string operatorUserId, TransactionManager tm_)
		{
			return GetByOperatorUserId(operatorUserId, 0, string.Empty, tm_);
		}
		public async Task<List<S_userEO>> GetByOperatorUserIdAsync(string operatorUserId, TransactionManager tm_)
		{
			return await GetByOperatorUserIdAsync(operatorUserId, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorUserId（字段） 查询
		/// </summary>
		/// /// <param name = "operatorUserId">运营商用户标识（用户关联）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByOperatorUserId(string operatorUserId, int top_)
		{
			return GetByOperatorUserId(operatorUserId, top_, string.Empty, null);
		}
		public async Task<List<S_userEO>> GetByOperatorUserIdAsync(string operatorUserId, int top_)
		{
			return await GetByOperatorUserIdAsync(operatorUserId, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorUserId（字段） 查询
		/// </summary>
		/// /// <param name = "operatorUserId">运营商用户标识（用户关联）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByOperatorUserId(string operatorUserId, int top_, TransactionManager tm_)
		{
			return GetByOperatorUserId(operatorUserId, top_, string.Empty, tm_);
		}
		public async Task<List<S_userEO>> GetByOperatorUserIdAsync(string operatorUserId, int top_, TransactionManager tm_)
		{
			return await GetByOperatorUserIdAsync(operatorUserId, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorUserId（字段） 查询
		/// </summary>
		/// /// <param name = "operatorUserId">运营商用户标识（用户关联）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByOperatorUserId(string operatorUserId, string sort_)
		{
			return GetByOperatorUserId(operatorUserId, 0, sort_, null);
		}
		public async Task<List<S_userEO>> GetByOperatorUserIdAsync(string operatorUserId, string sort_)
		{
			return await GetByOperatorUserIdAsync(operatorUserId, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 OperatorUserId（字段） 查询
		/// </summary>
		/// /// <param name = "operatorUserId">运营商用户标识（用户关联）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByOperatorUserId(string operatorUserId, string sort_, TransactionManager tm_)
		{
			return GetByOperatorUserId(operatorUserId, 0, sort_, tm_);
		}
		public async Task<List<S_userEO>> GetByOperatorUserIdAsync(string operatorUserId, string sort_, TransactionManager tm_)
		{
			return await GetByOperatorUserIdAsync(operatorUserId, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 OperatorUserId（字段） 查询
		/// </summary>
		/// /// <param name = "operatorUserId">运营商用户标识（用户关联）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByOperatorUserId(string operatorUserId, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(operatorUserId != null ? "`OperatorUserId` = @OperatorUserId" : "`OperatorUserId` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (operatorUserId != null)
				paras_.Add(Database.CreateInParameter("@OperatorUserId", operatorUserId, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_userEO.MapDataReader);
		}
		public async Task<List<S_userEO>> GetByOperatorUserIdAsync(string operatorUserId, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(operatorUserId != null ? "`OperatorUserId` = @OperatorUserId" : "`OperatorUserId` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (operatorUserId != null)
				paras_.Add(Database.CreateInParameter("@OperatorUserId", operatorUserId, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_userEO.MapDataReader);
		}
		#endregion // GetByOperatorUserId
		#region GetByCountryID
		
		/// <summary>
		/// 按 CountryID（字段） 查询
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByCountryID(string countryID)
		{
			return GetByCountryID(countryID, 0, string.Empty, null);
		}
		public async Task<List<S_userEO>> GetByCountryIDAsync(string countryID)
		{
			return await GetByCountryIDAsync(countryID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CountryID（字段） 查询
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByCountryID(string countryID, TransactionManager tm_)
		{
			return GetByCountryID(countryID, 0, string.Empty, tm_);
		}
		public async Task<List<S_userEO>> GetByCountryIDAsync(string countryID, TransactionManager tm_)
		{
			return await GetByCountryIDAsync(countryID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CountryID（字段） 查询
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByCountryID(string countryID, int top_)
		{
			return GetByCountryID(countryID, top_, string.Empty, null);
		}
		public async Task<List<S_userEO>> GetByCountryIDAsync(string countryID, int top_)
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
		public List<S_userEO> GetByCountryID(string countryID, int top_, TransactionManager tm_)
		{
			return GetByCountryID(countryID, top_, string.Empty, tm_);
		}
		public async Task<List<S_userEO>> GetByCountryIDAsync(string countryID, int top_, TransactionManager tm_)
		{
			return await GetByCountryIDAsync(countryID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CountryID（字段） 查询
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByCountryID(string countryID, string sort_)
		{
			return GetByCountryID(countryID, 0, sort_, null);
		}
		public async Task<List<S_userEO>> GetByCountryIDAsync(string countryID, string sort_)
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
		public List<S_userEO> GetByCountryID(string countryID, string sort_, TransactionManager tm_)
		{
			return GetByCountryID(countryID, 0, sort_, tm_);
		}
		public async Task<List<S_userEO>> GetByCountryIDAsync(string countryID, string sort_, TransactionManager tm_)
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
		public List<S_userEO> GetByCountryID(string countryID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(countryID != null ? "`CountryID` = @CountryID" : "`CountryID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (countryID != null)
				paras_.Add(Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_userEO.MapDataReader);
		}
		public async Task<List<S_userEO>> GetByCountryIDAsync(string countryID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(countryID != null ? "`CountryID` = @CountryID" : "`CountryID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (countryID != null)
				paras_.Add(Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_userEO.MapDataReader);
		}
		#endregion // GetByCountryID
		#region GetByCurrencyID
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByCurrencyID(string currencyID)
		{
			return GetByCurrencyID(currencyID, 0, string.Empty, null);
		}
		public async Task<List<S_userEO>> GetByCurrencyIDAsync(string currencyID)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByCurrencyID(string currencyID, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, 0, string.Empty, tm_);
		}
		public async Task<List<S_userEO>> GetByCurrencyIDAsync(string currencyID, TransactionManager tm_)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByCurrencyID(string currencyID, int top_)
		{
			return GetByCurrencyID(currencyID, top_, string.Empty, null);
		}
		public async Task<List<S_userEO>> GetByCurrencyIDAsync(string currencyID, int top_)
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
		public List<S_userEO> GetByCurrencyID(string currencyID, int top_, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, top_, string.Empty, tm_);
		}
		public async Task<List<S_userEO>> GetByCurrencyIDAsync(string currencyID, int top_, TransactionManager tm_)
		{
			return await GetByCurrencyIDAsync(currencyID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByCurrencyID(string currencyID, string sort_)
		{
			return GetByCurrencyID(currencyID, 0, sort_, null);
		}
		public async Task<List<S_userEO>> GetByCurrencyIDAsync(string currencyID, string sort_)
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
		public List<S_userEO> GetByCurrencyID(string currencyID, string sort_, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, 0, sort_, tm_);
		}
		public async Task<List<S_userEO>> GetByCurrencyIDAsync(string currencyID, string sort_, TransactionManager tm_)
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
		public List<S_userEO> GetByCurrencyID(string currencyID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(currencyID != null ? "`CurrencyID` = @CurrencyID" : "`CurrencyID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (currencyID != null)
				paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_userEO.MapDataReader);
		}
		public async Task<List<S_userEO>> GetByCurrencyIDAsync(string currencyID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(currencyID != null ? "`CurrencyID` = @CurrencyID" : "`CurrencyID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (currencyID != null)
				paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_userEO.MapDataReader);
		}
		#endregion // GetByCurrencyID
		#region GetByCash
		
		/// <summary>
		/// 按 Cash（字段） 查询
		/// </summary>
		/// /// <param name = "cash">现金（一级货币）*100000</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByCash(long cash)
		{
			return GetByCash(cash, 0, string.Empty, null);
		}
		public async Task<List<S_userEO>> GetByCashAsync(long cash)
		{
			return await GetByCashAsync(cash, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Cash（字段） 查询
		/// </summary>
		/// /// <param name = "cash">现金（一级货币）*100000</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByCash(long cash, TransactionManager tm_)
		{
			return GetByCash(cash, 0, string.Empty, tm_);
		}
		public async Task<List<S_userEO>> GetByCashAsync(long cash, TransactionManager tm_)
		{
			return await GetByCashAsync(cash, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Cash（字段） 查询
		/// </summary>
		/// /// <param name = "cash">现金（一级货币）*100000</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByCash(long cash, int top_)
		{
			return GetByCash(cash, top_, string.Empty, null);
		}
		public async Task<List<S_userEO>> GetByCashAsync(long cash, int top_)
		{
			return await GetByCashAsync(cash, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Cash（字段） 查询
		/// </summary>
		/// /// <param name = "cash">现金（一级货币）*100000</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByCash(long cash, int top_, TransactionManager tm_)
		{
			return GetByCash(cash, top_, string.Empty, tm_);
		}
		public async Task<List<S_userEO>> GetByCashAsync(long cash, int top_, TransactionManager tm_)
		{
			return await GetByCashAsync(cash, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Cash（字段） 查询
		/// </summary>
		/// /// <param name = "cash">现金（一级货币）*100000</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByCash(long cash, string sort_)
		{
			return GetByCash(cash, 0, sort_, null);
		}
		public async Task<List<S_userEO>> GetByCashAsync(long cash, string sort_)
		{
			return await GetByCashAsync(cash, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Cash（字段） 查询
		/// </summary>
		/// /// <param name = "cash">现金（一级货币）*100000</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByCash(long cash, string sort_, TransactionManager tm_)
		{
			return GetByCash(cash, 0, sort_, tm_);
		}
		public async Task<List<S_userEO>> GetByCashAsync(long cash, string sort_, TransactionManager tm_)
		{
			return await GetByCashAsync(cash, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Cash（字段） 查询
		/// </summary>
		/// /// <param name = "cash">现金（一级货币）*100000</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByCash(long cash, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Cash` = @Cash", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Cash", cash, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, S_userEO.MapDataReader);
		}
		public async Task<List<S_userEO>> GetByCashAsync(long cash, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Cash` = @Cash", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Cash", cash, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_userEO.MapDataReader);
		}
		#endregion // GetByCash
		#region GetByBonus
		
		/// <summary>
		/// 按 Bonus（字段） 查询
		/// </summary>
		/// /// <param name = "bonus">剩余赠金</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByBonus(long bonus)
		{
			return GetByBonus(bonus, 0, string.Empty, null);
		}
		public async Task<List<S_userEO>> GetByBonusAsync(long bonus)
		{
			return await GetByBonusAsync(bonus, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Bonus（字段） 查询
		/// </summary>
		/// /// <param name = "bonus">剩余赠金</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByBonus(long bonus, TransactionManager tm_)
		{
			return GetByBonus(bonus, 0, string.Empty, tm_);
		}
		public async Task<List<S_userEO>> GetByBonusAsync(long bonus, TransactionManager tm_)
		{
			return await GetByBonusAsync(bonus, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Bonus（字段） 查询
		/// </summary>
		/// /// <param name = "bonus">剩余赠金</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByBonus(long bonus, int top_)
		{
			return GetByBonus(bonus, top_, string.Empty, null);
		}
		public async Task<List<S_userEO>> GetByBonusAsync(long bonus, int top_)
		{
			return await GetByBonusAsync(bonus, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Bonus（字段） 查询
		/// </summary>
		/// /// <param name = "bonus">剩余赠金</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByBonus(long bonus, int top_, TransactionManager tm_)
		{
			return GetByBonus(bonus, top_, string.Empty, tm_);
		}
		public async Task<List<S_userEO>> GetByBonusAsync(long bonus, int top_, TransactionManager tm_)
		{
			return await GetByBonusAsync(bonus, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Bonus（字段） 查询
		/// </summary>
		/// /// <param name = "bonus">剩余赠金</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByBonus(long bonus, string sort_)
		{
			return GetByBonus(bonus, 0, sort_, null);
		}
		public async Task<List<S_userEO>> GetByBonusAsync(long bonus, string sort_)
		{
			return await GetByBonusAsync(bonus, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Bonus（字段） 查询
		/// </summary>
		/// /// <param name = "bonus">剩余赠金</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByBonus(long bonus, string sort_, TransactionManager tm_)
		{
			return GetByBonus(bonus, 0, sort_, tm_);
		}
		public async Task<List<S_userEO>> GetByBonusAsync(long bonus, string sort_, TransactionManager tm_)
		{
			return await GetByBonusAsync(bonus, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Bonus（字段） 查询
		/// </summary>
		/// /// <param name = "bonus">剩余赠金</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByBonus(long bonus, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Bonus` = @Bonus", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Bonus", bonus, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, S_userEO.MapDataReader);
		}
		public async Task<List<S_userEO>> GetByBonusAsync(long bonus, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Bonus` = @Bonus", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Bonus", bonus, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_userEO.MapDataReader);
		}
		#endregion // GetByBonus
		#region GetByCoin
		
		/// <summary>
		/// 按 Coin（字段） 查询
		/// </summary>
		/// /// <param name = "coin">硬币（二级货币）</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByCoin(long coin)
		{
			return GetByCoin(coin, 0, string.Empty, null);
		}
		public async Task<List<S_userEO>> GetByCoinAsync(long coin)
		{
			return await GetByCoinAsync(coin, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Coin（字段） 查询
		/// </summary>
		/// /// <param name = "coin">硬币（二级货币）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByCoin(long coin, TransactionManager tm_)
		{
			return GetByCoin(coin, 0, string.Empty, tm_);
		}
		public async Task<List<S_userEO>> GetByCoinAsync(long coin, TransactionManager tm_)
		{
			return await GetByCoinAsync(coin, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Coin（字段） 查询
		/// </summary>
		/// /// <param name = "coin">硬币（二级货币）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByCoin(long coin, int top_)
		{
			return GetByCoin(coin, top_, string.Empty, null);
		}
		public async Task<List<S_userEO>> GetByCoinAsync(long coin, int top_)
		{
			return await GetByCoinAsync(coin, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Coin（字段） 查询
		/// </summary>
		/// /// <param name = "coin">硬币（二级货币）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByCoin(long coin, int top_, TransactionManager tm_)
		{
			return GetByCoin(coin, top_, string.Empty, tm_);
		}
		public async Task<List<S_userEO>> GetByCoinAsync(long coin, int top_, TransactionManager tm_)
		{
			return await GetByCoinAsync(coin, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Coin（字段） 查询
		/// </summary>
		/// /// <param name = "coin">硬币（二级货币）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByCoin(long coin, string sort_)
		{
			return GetByCoin(coin, 0, sort_, null);
		}
		public async Task<List<S_userEO>> GetByCoinAsync(long coin, string sort_)
		{
			return await GetByCoinAsync(coin, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Coin（字段） 查询
		/// </summary>
		/// /// <param name = "coin">硬币（二级货币）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByCoin(long coin, string sort_, TransactionManager tm_)
		{
			return GetByCoin(coin, 0, sort_, tm_);
		}
		public async Task<List<S_userEO>> GetByCoinAsync(long coin, string sort_, TransactionManager tm_)
		{
			return await GetByCoinAsync(coin, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Coin（字段） 查询
		/// </summary>
		/// /// <param name = "coin">硬币（二级货币）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByCoin(long coin, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Coin` = @Coin", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Coin", coin, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, S_userEO.MapDataReader);
		}
		public async Task<List<S_userEO>> GetByCoinAsync(long coin, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Coin` = @Coin", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Coin", coin, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_userEO.MapDataReader);
		}
		#endregion // GetByCoin
		#region GetByGold
		
		/// <summary>
		/// 按 Gold（字段） 查询
		/// </summary>
		/// /// <param name = "gold">金币</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByGold(long gold)
		{
			return GetByGold(gold, 0, string.Empty, null);
		}
		public async Task<List<S_userEO>> GetByGoldAsync(long gold)
		{
			return await GetByGoldAsync(gold, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Gold（字段） 查询
		/// </summary>
		/// /// <param name = "gold">金币</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByGold(long gold, TransactionManager tm_)
		{
			return GetByGold(gold, 0, string.Empty, tm_);
		}
		public async Task<List<S_userEO>> GetByGoldAsync(long gold, TransactionManager tm_)
		{
			return await GetByGoldAsync(gold, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Gold（字段） 查询
		/// </summary>
		/// /// <param name = "gold">金币</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByGold(long gold, int top_)
		{
			return GetByGold(gold, top_, string.Empty, null);
		}
		public async Task<List<S_userEO>> GetByGoldAsync(long gold, int top_)
		{
			return await GetByGoldAsync(gold, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Gold（字段） 查询
		/// </summary>
		/// /// <param name = "gold">金币</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByGold(long gold, int top_, TransactionManager tm_)
		{
			return GetByGold(gold, top_, string.Empty, tm_);
		}
		public async Task<List<S_userEO>> GetByGoldAsync(long gold, int top_, TransactionManager tm_)
		{
			return await GetByGoldAsync(gold, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Gold（字段） 查询
		/// </summary>
		/// /// <param name = "gold">金币</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByGold(long gold, string sort_)
		{
			return GetByGold(gold, 0, sort_, null);
		}
		public async Task<List<S_userEO>> GetByGoldAsync(long gold, string sort_)
		{
			return await GetByGoldAsync(gold, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Gold（字段） 查询
		/// </summary>
		/// /// <param name = "gold">金币</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByGold(long gold, string sort_, TransactionManager tm_)
		{
			return GetByGold(gold, 0, sort_, tm_);
		}
		public async Task<List<S_userEO>> GetByGoldAsync(long gold, string sort_, TransactionManager tm_)
		{
			return await GetByGoldAsync(gold, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Gold（字段） 查询
		/// </summary>
		/// /// <param name = "gold">金币</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByGold(long gold, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Gold` = @Gold", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Gold", gold, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, S_userEO.MapDataReader);
		}
		public async Task<List<S_userEO>> GetByGoldAsync(long gold, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Gold` = @Gold", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Gold", gold, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_userEO.MapDataReader);
		}
		#endregion // GetByGold
		#region GetBySWB
		
		/// <summary>
		/// 按 SWB（字段） 查询
		/// </summary>
		/// /// <param name = "sWB">试玩币</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetBySWB(long sWB)
		{
			return GetBySWB(sWB, 0, string.Empty, null);
		}
		public async Task<List<S_userEO>> GetBySWBAsync(long sWB)
		{
			return await GetBySWBAsync(sWB, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 SWB（字段） 查询
		/// </summary>
		/// /// <param name = "sWB">试玩币</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetBySWB(long sWB, TransactionManager tm_)
		{
			return GetBySWB(sWB, 0, string.Empty, tm_);
		}
		public async Task<List<S_userEO>> GetBySWBAsync(long sWB, TransactionManager tm_)
		{
			return await GetBySWBAsync(sWB, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SWB（字段） 查询
		/// </summary>
		/// /// <param name = "sWB">试玩币</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetBySWB(long sWB, int top_)
		{
			return GetBySWB(sWB, top_, string.Empty, null);
		}
		public async Task<List<S_userEO>> GetBySWBAsync(long sWB, int top_)
		{
			return await GetBySWBAsync(sWB, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 SWB（字段） 查询
		/// </summary>
		/// /// <param name = "sWB">试玩币</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetBySWB(long sWB, int top_, TransactionManager tm_)
		{
			return GetBySWB(sWB, top_, string.Empty, tm_);
		}
		public async Task<List<S_userEO>> GetBySWBAsync(long sWB, int top_, TransactionManager tm_)
		{
			return await GetBySWBAsync(sWB, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SWB（字段） 查询
		/// </summary>
		/// /// <param name = "sWB">试玩币</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetBySWB(long sWB, string sort_)
		{
			return GetBySWB(sWB, 0, sort_, null);
		}
		public async Task<List<S_userEO>> GetBySWBAsync(long sWB, string sort_)
		{
			return await GetBySWBAsync(sWB, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 SWB（字段） 查询
		/// </summary>
		/// /// <param name = "sWB">试玩币</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetBySWB(long sWB, string sort_, TransactionManager tm_)
		{
			return GetBySWB(sWB, 0, sort_, tm_);
		}
		public async Task<List<S_userEO>> GetBySWBAsync(long sWB, string sort_, TransactionManager tm_)
		{
			return await GetBySWBAsync(sWB, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 SWB（字段） 查询
		/// </summary>
		/// /// <param name = "sWB">试玩币</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetBySWB(long sWB, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`SWB` = @SWB", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@SWB", sWB, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, S_userEO.MapDataReader);
		}
		public async Task<List<S_userEO>> GetBySWBAsync(long sWB, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`SWB` = @SWB", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@SWB", sWB, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_userEO.MapDataReader);
		}
		#endregion // GetBySWB
		#region GetByPoint
		
		/// <summary>
		/// 按 Point（字段） 查询
		/// </summary>
		/// /// <param name = "point">vip积分</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByPoint(long point)
		{
			return GetByPoint(point, 0, string.Empty, null);
		}
		public async Task<List<S_userEO>> GetByPointAsync(long point)
		{
			return await GetByPointAsync(point, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Point（字段） 查询
		/// </summary>
		/// /// <param name = "point">vip积分</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByPoint(long point, TransactionManager tm_)
		{
			return GetByPoint(point, 0, string.Empty, tm_);
		}
		public async Task<List<S_userEO>> GetByPointAsync(long point, TransactionManager tm_)
		{
			return await GetByPointAsync(point, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Point（字段） 查询
		/// </summary>
		/// /// <param name = "point">vip积分</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByPoint(long point, int top_)
		{
			return GetByPoint(point, top_, string.Empty, null);
		}
		public async Task<List<S_userEO>> GetByPointAsync(long point, int top_)
		{
			return await GetByPointAsync(point, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Point（字段） 查询
		/// </summary>
		/// /// <param name = "point">vip积分</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByPoint(long point, int top_, TransactionManager tm_)
		{
			return GetByPoint(point, top_, string.Empty, tm_);
		}
		public async Task<List<S_userEO>> GetByPointAsync(long point, int top_, TransactionManager tm_)
		{
			return await GetByPointAsync(point, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Point（字段） 查询
		/// </summary>
		/// /// <param name = "point">vip积分</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByPoint(long point, string sort_)
		{
			return GetByPoint(point, 0, sort_, null);
		}
		public async Task<List<S_userEO>> GetByPointAsync(long point, string sort_)
		{
			return await GetByPointAsync(point, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Point（字段） 查询
		/// </summary>
		/// /// <param name = "point">vip积分</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByPoint(long point, string sort_, TransactionManager tm_)
		{
			return GetByPoint(point, 0, sort_, tm_);
		}
		public async Task<List<S_userEO>> GetByPointAsync(long point, string sort_, TransactionManager tm_)
		{
			return await GetByPointAsync(point, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Point（字段） 查询
		/// </summary>
		/// /// <param name = "point">vip积分</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByPoint(long point, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Point` = @Point", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Point", point, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, S_userEO.MapDataReader);
		}
		public async Task<List<S_userEO>> GetByPointAsync(long point, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Point` = @Point", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Point", point, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_userEO.MapDataReader);
		}
		#endregion // GetByPoint
		#region GetByVIP
		
		/// <summary>
		/// 按 VIP（字段） 查询
		/// </summary>
		/// /// <param name = "vIP">vip等级</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByVIP(int vIP)
		{
			return GetByVIP(vIP, 0, string.Empty, null);
		}
		public async Task<List<S_userEO>> GetByVIPAsync(int vIP)
		{
			return await GetByVIPAsync(vIP, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 VIP（字段） 查询
		/// </summary>
		/// /// <param name = "vIP">vip等级</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByVIP(int vIP, TransactionManager tm_)
		{
			return GetByVIP(vIP, 0, string.Empty, tm_);
		}
		public async Task<List<S_userEO>> GetByVIPAsync(int vIP, TransactionManager tm_)
		{
			return await GetByVIPAsync(vIP, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 VIP（字段） 查询
		/// </summary>
		/// /// <param name = "vIP">vip等级</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByVIP(int vIP, int top_)
		{
			return GetByVIP(vIP, top_, string.Empty, null);
		}
		public async Task<List<S_userEO>> GetByVIPAsync(int vIP, int top_)
		{
			return await GetByVIPAsync(vIP, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 VIP（字段） 查询
		/// </summary>
		/// /// <param name = "vIP">vip等级</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByVIP(int vIP, int top_, TransactionManager tm_)
		{
			return GetByVIP(vIP, top_, string.Empty, tm_);
		}
		public async Task<List<S_userEO>> GetByVIPAsync(int vIP, int top_, TransactionManager tm_)
		{
			return await GetByVIPAsync(vIP, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 VIP（字段） 查询
		/// </summary>
		/// /// <param name = "vIP">vip等级</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByVIP(int vIP, string sort_)
		{
			return GetByVIP(vIP, 0, sort_, null);
		}
		public async Task<List<S_userEO>> GetByVIPAsync(int vIP, string sort_)
		{
			return await GetByVIPAsync(vIP, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 VIP（字段） 查询
		/// </summary>
		/// /// <param name = "vIP">vip等级</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByVIP(int vIP, string sort_, TransactionManager tm_)
		{
			return GetByVIP(vIP, 0, sort_, tm_);
		}
		public async Task<List<S_userEO>> GetByVIPAsync(int vIP, string sort_, TransactionManager tm_)
		{
			return await GetByVIPAsync(vIP, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 VIP（字段） 查询
		/// </summary>
		/// /// <param name = "vIP">vip等级</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByVIP(int vIP, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`VIP` = @VIP", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@VIP", vIP, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, S_userEO.MapDataReader);
		}
		public async Task<List<S_userEO>> GetByVIPAsync(int vIP, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`VIP` = @VIP", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@VIP", vIP, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_userEO.MapDataReader);
		}
		#endregion // GetByVIP
		#region GetByPUserID1
		
		/// <summary>
		/// 按 PUserID1（字段） 查询
		/// </summary>
		/// /// <param name = "pUserID1">1级推广员用户编码（直接推广员）</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByPUserID1(string pUserID1)
		{
			return GetByPUserID1(pUserID1, 0, string.Empty, null);
		}
		public async Task<List<S_userEO>> GetByPUserID1Async(string pUserID1)
		{
			return await GetByPUserID1Async(pUserID1, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PUserID1（字段） 查询
		/// </summary>
		/// /// <param name = "pUserID1">1级推广员用户编码（直接推广员）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByPUserID1(string pUserID1, TransactionManager tm_)
		{
			return GetByPUserID1(pUserID1, 0, string.Empty, tm_);
		}
		public async Task<List<S_userEO>> GetByPUserID1Async(string pUserID1, TransactionManager tm_)
		{
			return await GetByPUserID1Async(pUserID1, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PUserID1（字段） 查询
		/// </summary>
		/// /// <param name = "pUserID1">1级推广员用户编码（直接推广员）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByPUserID1(string pUserID1, int top_)
		{
			return GetByPUserID1(pUserID1, top_, string.Empty, null);
		}
		public async Task<List<S_userEO>> GetByPUserID1Async(string pUserID1, int top_)
		{
			return await GetByPUserID1Async(pUserID1, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PUserID1（字段） 查询
		/// </summary>
		/// /// <param name = "pUserID1">1级推广员用户编码（直接推广员）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByPUserID1(string pUserID1, int top_, TransactionManager tm_)
		{
			return GetByPUserID1(pUserID1, top_, string.Empty, tm_);
		}
		public async Task<List<S_userEO>> GetByPUserID1Async(string pUserID1, int top_, TransactionManager tm_)
		{
			return await GetByPUserID1Async(pUserID1, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PUserID1（字段） 查询
		/// </summary>
		/// /// <param name = "pUserID1">1级推广员用户编码（直接推广员）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByPUserID1(string pUserID1, string sort_)
		{
			return GetByPUserID1(pUserID1, 0, sort_, null);
		}
		public async Task<List<S_userEO>> GetByPUserID1Async(string pUserID1, string sort_)
		{
			return await GetByPUserID1Async(pUserID1, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 PUserID1（字段） 查询
		/// </summary>
		/// /// <param name = "pUserID1">1级推广员用户编码（直接推广员）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByPUserID1(string pUserID1, string sort_, TransactionManager tm_)
		{
			return GetByPUserID1(pUserID1, 0, sort_, tm_);
		}
		public async Task<List<S_userEO>> GetByPUserID1Async(string pUserID1, string sort_, TransactionManager tm_)
		{
			return await GetByPUserID1Async(pUserID1, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 PUserID1（字段） 查询
		/// </summary>
		/// /// <param name = "pUserID1">1级推广员用户编码（直接推广员）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByPUserID1(string pUserID1, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(pUserID1 != null ? "`PUserID1` = @PUserID1" : "`PUserID1` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (pUserID1 != null)
				paras_.Add(Database.CreateInParameter("@PUserID1", pUserID1, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_userEO.MapDataReader);
		}
		public async Task<List<S_userEO>> GetByPUserID1Async(string pUserID1, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(pUserID1 != null ? "`PUserID1` = @PUserID1" : "`PUserID1` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (pUserID1 != null)
				paras_.Add(Database.CreateInParameter("@PUserID1", pUserID1, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_userEO.MapDataReader);
		}
		#endregion // GetByPUserID1
		#region GetByPUserID2
		
		/// <summary>
		/// 按 PUserID2（字段） 查询
		/// </summary>
		/// /// <param name = "pUserID2">2级推广员用户编码</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByPUserID2(string pUserID2)
		{
			return GetByPUserID2(pUserID2, 0, string.Empty, null);
		}
		public async Task<List<S_userEO>> GetByPUserID2Async(string pUserID2)
		{
			return await GetByPUserID2Async(pUserID2, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PUserID2（字段） 查询
		/// </summary>
		/// /// <param name = "pUserID2">2级推广员用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByPUserID2(string pUserID2, TransactionManager tm_)
		{
			return GetByPUserID2(pUserID2, 0, string.Empty, tm_);
		}
		public async Task<List<S_userEO>> GetByPUserID2Async(string pUserID2, TransactionManager tm_)
		{
			return await GetByPUserID2Async(pUserID2, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PUserID2（字段） 查询
		/// </summary>
		/// /// <param name = "pUserID2">2级推广员用户编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByPUserID2(string pUserID2, int top_)
		{
			return GetByPUserID2(pUserID2, top_, string.Empty, null);
		}
		public async Task<List<S_userEO>> GetByPUserID2Async(string pUserID2, int top_)
		{
			return await GetByPUserID2Async(pUserID2, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PUserID2（字段） 查询
		/// </summary>
		/// /// <param name = "pUserID2">2级推广员用户编码</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByPUserID2(string pUserID2, int top_, TransactionManager tm_)
		{
			return GetByPUserID2(pUserID2, top_, string.Empty, tm_);
		}
		public async Task<List<S_userEO>> GetByPUserID2Async(string pUserID2, int top_, TransactionManager tm_)
		{
			return await GetByPUserID2Async(pUserID2, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PUserID2（字段） 查询
		/// </summary>
		/// /// <param name = "pUserID2">2级推广员用户编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByPUserID2(string pUserID2, string sort_)
		{
			return GetByPUserID2(pUserID2, 0, sort_, null);
		}
		public async Task<List<S_userEO>> GetByPUserID2Async(string pUserID2, string sort_)
		{
			return await GetByPUserID2Async(pUserID2, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 PUserID2（字段） 查询
		/// </summary>
		/// /// <param name = "pUserID2">2级推广员用户编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByPUserID2(string pUserID2, string sort_, TransactionManager tm_)
		{
			return GetByPUserID2(pUserID2, 0, sort_, tm_);
		}
		public async Task<List<S_userEO>> GetByPUserID2Async(string pUserID2, string sort_, TransactionManager tm_)
		{
			return await GetByPUserID2Async(pUserID2, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 PUserID2（字段） 查询
		/// </summary>
		/// /// <param name = "pUserID2">2级推广员用户编码</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByPUserID2(string pUserID2, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(pUserID2 != null ? "`PUserID2` = @PUserID2" : "`PUserID2` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (pUserID2 != null)
				paras_.Add(Database.CreateInParameter("@PUserID2", pUserID2, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_userEO.MapDataReader);
		}
		public async Task<List<S_userEO>> GetByPUserID2Async(string pUserID2, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(pUserID2 != null ? "`PUserID2` = @PUserID2" : "`PUserID2` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (pUserID2 != null)
				paras_.Add(Database.CreateInParameter("@PUserID2", pUserID2, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_userEO.MapDataReader);
		}
		#endregion // GetByPUserID2
		#region GetByUserProfile
		
		/// <summary>
		/// 按 UserProfile（字段） 查询
		/// </summary>
		/// /// <param name = "userProfile">用户画像</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByUserProfile(int userProfile)
		{
			return GetByUserProfile(userProfile, 0, string.Empty, null);
		}
		public async Task<List<S_userEO>> GetByUserProfileAsync(int userProfile)
		{
			return await GetByUserProfileAsync(userProfile, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UserProfile（字段） 查询
		/// </summary>
		/// /// <param name = "userProfile">用户画像</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByUserProfile(int userProfile, TransactionManager tm_)
		{
			return GetByUserProfile(userProfile, 0, string.Empty, tm_);
		}
		public async Task<List<S_userEO>> GetByUserProfileAsync(int userProfile, TransactionManager tm_)
		{
			return await GetByUserProfileAsync(userProfile, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserProfile（字段） 查询
		/// </summary>
		/// /// <param name = "userProfile">用户画像</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByUserProfile(int userProfile, int top_)
		{
			return GetByUserProfile(userProfile, top_, string.Empty, null);
		}
		public async Task<List<S_userEO>> GetByUserProfileAsync(int userProfile, int top_)
		{
			return await GetByUserProfileAsync(userProfile, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UserProfile（字段） 查询
		/// </summary>
		/// /// <param name = "userProfile">用户画像</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByUserProfile(int userProfile, int top_, TransactionManager tm_)
		{
			return GetByUserProfile(userProfile, top_, string.Empty, tm_);
		}
		public async Task<List<S_userEO>> GetByUserProfileAsync(int userProfile, int top_, TransactionManager tm_)
		{
			return await GetByUserProfileAsync(userProfile, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserProfile（字段） 查询
		/// </summary>
		/// /// <param name = "userProfile">用户画像</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByUserProfile(int userProfile, string sort_)
		{
			return GetByUserProfile(userProfile, 0, sort_, null);
		}
		public async Task<List<S_userEO>> GetByUserProfileAsync(int userProfile, string sort_)
		{
			return await GetByUserProfileAsync(userProfile, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 UserProfile（字段） 查询
		/// </summary>
		/// /// <param name = "userProfile">用户画像</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByUserProfile(int userProfile, string sort_, TransactionManager tm_)
		{
			return GetByUserProfile(userProfile, 0, sort_, tm_);
		}
		public async Task<List<S_userEO>> GetByUserProfileAsync(int userProfile, string sort_, TransactionManager tm_)
		{
			return await GetByUserProfileAsync(userProfile, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 UserProfile（字段） 查询
		/// </summary>
		/// /// <param name = "userProfile">用户画像</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByUserProfile(int userProfile, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UserProfile` = @UserProfile", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserProfile", userProfile, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, S_userEO.MapDataReader);
		}
		public async Task<List<S_userEO>> GetByUserProfileAsync(int userProfile, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UserProfile` = @UserProfile", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserProfile", userProfile, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_userEO.MapDataReader);
		}
		#endregion // GetByUserProfile
		#region GetByUserKind
		
		/// <summary>
		/// 按 UserKind（字段） 查询
		/// </summary>
		/// /// <param name = "userKind">用户类型</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByUserKind(int userKind)
		{
			return GetByUserKind(userKind, 0, string.Empty, null);
		}
		public async Task<List<S_userEO>> GetByUserKindAsync(int userKind)
		{
			return await GetByUserKindAsync(userKind, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UserKind（字段） 查询
		/// </summary>
		/// /// <param name = "userKind">用户类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByUserKind(int userKind, TransactionManager tm_)
		{
			return GetByUserKind(userKind, 0, string.Empty, tm_);
		}
		public async Task<List<S_userEO>> GetByUserKindAsync(int userKind, TransactionManager tm_)
		{
			return await GetByUserKindAsync(userKind, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserKind（字段） 查询
		/// </summary>
		/// /// <param name = "userKind">用户类型</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByUserKind(int userKind, int top_)
		{
			return GetByUserKind(userKind, top_, string.Empty, null);
		}
		public async Task<List<S_userEO>> GetByUserKindAsync(int userKind, int top_)
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
		public List<S_userEO> GetByUserKind(int userKind, int top_, TransactionManager tm_)
		{
			return GetByUserKind(userKind, top_, string.Empty, tm_);
		}
		public async Task<List<S_userEO>> GetByUserKindAsync(int userKind, int top_, TransactionManager tm_)
		{
			return await GetByUserKindAsync(userKind, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserKind（字段） 查询
		/// </summary>
		/// /// <param name = "userKind">用户类型</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByUserKind(int userKind, string sort_)
		{
			return GetByUserKind(userKind, 0, sort_, null);
		}
		public async Task<List<S_userEO>> GetByUserKindAsync(int userKind, string sort_)
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
		public List<S_userEO> GetByUserKind(int userKind, string sort_, TransactionManager tm_)
		{
			return GetByUserKind(userKind, 0, sort_, tm_);
		}
		public async Task<List<S_userEO>> GetByUserKindAsync(int userKind, string sort_, TransactionManager tm_)
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
		public List<S_userEO> GetByUserKind(int userKind, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UserKind` = @UserKind", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserKind", userKind, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, S_userEO.MapDataReader);
		}
		public async Task<List<S_userEO>> GetByUserKindAsync(int userKind, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UserKind` = @UserKind", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserKind", userKind, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_userEO.MapDataReader);
		}
		#endregion // GetByUserKind
		#region GetByIMEI
		
		/// <summary>
		/// 按 IMEI（字段） 查询
		/// </summary>
		/// /// <param name = "iMEI"></param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByIMEI(string iMEI)
		{
			return GetByIMEI(iMEI, 0, string.Empty, null);
		}
		public async Task<List<S_userEO>> GetByIMEIAsync(string iMEI)
		{
			return await GetByIMEIAsync(iMEI, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 IMEI（字段） 查询
		/// </summary>
		/// /// <param name = "iMEI"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByIMEI(string iMEI, TransactionManager tm_)
		{
			return GetByIMEI(iMEI, 0, string.Empty, tm_);
		}
		public async Task<List<S_userEO>> GetByIMEIAsync(string iMEI, TransactionManager tm_)
		{
			return await GetByIMEIAsync(iMEI, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IMEI（字段） 查询
		/// </summary>
		/// /// <param name = "iMEI"></param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByIMEI(string iMEI, int top_)
		{
			return GetByIMEI(iMEI, top_, string.Empty, null);
		}
		public async Task<List<S_userEO>> GetByIMEIAsync(string iMEI, int top_)
		{
			return await GetByIMEIAsync(iMEI, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 IMEI（字段） 查询
		/// </summary>
		/// /// <param name = "iMEI"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByIMEI(string iMEI, int top_, TransactionManager tm_)
		{
			return GetByIMEI(iMEI, top_, string.Empty, tm_);
		}
		public async Task<List<S_userEO>> GetByIMEIAsync(string iMEI, int top_, TransactionManager tm_)
		{
			return await GetByIMEIAsync(iMEI, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IMEI（字段） 查询
		/// </summary>
		/// /// <param name = "iMEI"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByIMEI(string iMEI, string sort_)
		{
			return GetByIMEI(iMEI, 0, sort_, null);
		}
		public async Task<List<S_userEO>> GetByIMEIAsync(string iMEI, string sort_)
		{
			return await GetByIMEIAsync(iMEI, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 IMEI（字段） 查询
		/// </summary>
		/// /// <param name = "iMEI"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByIMEI(string iMEI, string sort_, TransactionManager tm_)
		{
			return GetByIMEI(iMEI, 0, sort_, tm_);
		}
		public async Task<List<S_userEO>> GetByIMEIAsync(string iMEI, string sort_, TransactionManager tm_)
		{
			return await GetByIMEIAsync(iMEI, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 IMEI（字段） 查询
		/// </summary>
		/// /// <param name = "iMEI"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByIMEI(string iMEI, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(iMEI != null ? "`IMEI` = @IMEI" : "`IMEI` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (iMEI != null)
				paras_.Add(Database.CreateInParameter("@IMEI", iMEI, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_userEO.MapDataReader);
		}
		public async Task<List<S_userEO>> GetByIMEIAsync(string iMEI, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(iMEI != null ? "`IMEI` = @IMEI" : "`IMEI` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (iMEI != null)
				paras_.Add(Database.CreateInParameter("@IMEI", iMEI, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_userEO.MapDataReader);
		}
		#endregion // GetByIMEI
		#region GetByGAID
		
		/// <summary>
		/// 按 GAID（字段） 查询
		/// </summary>
		/// /// <param name = "gAID"></param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByGAID(string gAID)
		{
			return GetByGAID(gAID, 0, string.Empty, null);
		}
		public async Task<List<S_userEO>> GetByGAIDAsync(string gAID)
		{
			return await GetByGAIDAsync(gAID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 GAID（字段） 查询
		/// </summary>
		/// /// <param name = "gAID"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByGAID(string gAID, TransactionManager tm_)
		{
			return GetByGAID(gAID, 0, string.Empty, tm_);
		}
		public async Task<List<S_userEO>> GetByGAIDAsync(string gAID, TransactionManager tm_)
		{
			return await GetByGAIDAsync(gAID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 GAID（字段） 查询
		/// </summary>
		/// /// <param name = "gAID"></param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByGAID(string gAID, int top_)
		{
			return GetByGAID(gAID, top_, string.Empty, null);
		}
		public async Task<List<S_userEO>> GetByGAIDAsync(string gAID, int top_)
		{
			return await GetByGAIDAsync(gAID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 GAID（字段） 查询
		/// </summary>
		/// /// <param name = "gAID"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByGAID(string gAID, int top_, TransactionManager tm_)
		{
			return GetByGAID(gAID, top_, string.Empty, tm_);
		}
		public async Task<List<S_userEO>> GetByGAIDAsync(string gAID, int top_, TransactionManager tm_)
		{
			return await GetByGAIDAsync(gAID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 GAID（字段） 查询
		/// </summary>
		/// /// <param name = "gAID"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByGAID(string gAID, string sort_)
		{
			return GetByGAID(gAID, 0, sort_, null);
		}
		public async Task<List<S_userEO>> GetByGAIDAsync(string gAID, string sort_)
		{
			return await GetByGAIDAsync(gAID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 GAID（字段） 查询
		/// </summary>
		/// /// <param name = "gAID"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByGAID(string gAID, string sort_, TransactionManager tm_)
		{
			return GetByGAID(gAID, 0, sort_, tm_);
		}
		public async Task<List<S_userEO>> GetByGAIDAsync(string gAID, string sort_, TransactionManager tm_)
		{
			return await GetByGAIDAsync(gAID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 GAID（字段） 查询
		/// </summary>
		/// /// <param name = "gAID"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByGAID(string gAID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(gAID != null ? "`GAID` = @GAID" : "`GAID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (gAID != null)
				paras_.Add(Database.CreateInParameter("@GAID", gAID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_userEO.MapDataReader);
		}
		public async Task<List<S_userEO>> GetByGAIDAsync(string gAID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(gAID != null ? "`GAID` = @GAID" : "`GAID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (gAID != null)
				paras_.Add(Database.CreateInParameter("@GAID", gAID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_userEO.MapDataReader);
		}
		#endregion // GetByGAID
		#region GetByUserIp
		
		/// <summary>
		/// 按 UserIp（字段） 查询
		/// </summary>
		/// /// <param name = "userIp">用户IP</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByUserIp(string userIp)
		{
			return GetByUserIp(userIp, 0, string.Empty, null);
		}
		public async Task<List<S_userEO>> GetByUserIpAsync(string userIp)
		{
			return await GetByUserIpAsync(userIp, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UserIp（字段） 查询
		/// </summary>
		/// /// <param name = "userIp">用户IP</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByUserIp(string userIp, TransactionManager tm_)
		{
			return GetByUserIp(userIp, 0, string.Empty, tm_);
		}
		public async Task<List<S_userEO>> GetByUserIpAsync(string userIp, TransactionManager tm_)
		{
			return await GetByUserIpAsync(userIp, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserIp（字段） 查询
		/// </summary>
		/// /// <param name = "userIp">用户IP</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByUserIp(string userIp, int top_)
		{
			return GetByUserIp(userIp, top_, string.Empty, null);
		}
		public async Task<List<S_userEO>> GetByUserIpAsync(string userIp, int top_)
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
		public List<S_userEO> GetByUserIp(string userIp, int top_, TransactionManager tm_)
		{
			return GetByUserIp(userIp, top_, string.Empty, tm_);
		}
		public async Task<List<S_userEO>> GetByUserIpAsync(string userIp, int top_, TransactionManager tm_)
		{
			return await GetByUserIpAsync(userIp, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserIp（字段） 查询
		/// </summary>
		/// /// <param name = "userIp">用户IP</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByUserIp(string userIp, string sort_)
		{
			return GetByUserIp(userIp, 0, sort_, null);
		}
		public async Task<List<S_userEO>> GetByUserIpAsync(string userIp, string sort_)
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
		public List<S_userEO> GetByUserIp(string userIp, string sort_, TransactionManager tm_)
		{
			return GetByUserIp(userIp, 0, sort_, tm_);
		}
		public async Task<List<S_userEO>> GetByUserIpAsync(string userIp, string sort_, TransactionManager tm_)
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
		public List<S_userEO> GetByUserIp(string userIp, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(userIp != null ? "`UserIp` = @UserIp" : "`UserIp` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (userIp != null)
				paras_.Add(Database.CreateInParameter("@UserIp", userIp, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_userEO.MapDataReader);
		}
		public async Task<List<S_userEO>> GetByUserIpAsync(string userIp, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(userIp != null ? "`UserIp` = @UserIp" : "`UserIp` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (userIp != null)
				paras_.Add(Database.CreateInParameter("@UserIp", userIp, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_userEO.MapDataReader);
		}
		#endregion // GetByUserIp
		#region GetByClientUrl
		
		/// <summary>
		/// 按 ClientUrl（字段） 查询
		/// </summary>
		/// /// <param name = "clientUrl">用户第一次进入客户端时的url</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByClientUrl(string clientUrl)
		{
			return GetByClientUrl(clientUrl, 0, string.Empty, null);
		}
		public async Task<List<S_userEO>> GetByClientUrlAsync(string clientUrl)
		{
			return await GetByClientUrlAsync(clientUrl, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ClientUrl（字段） 查询
		/// </summary>
		/// /// <param name = "clientUrl">用户第一次进入客户端时的url</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByClientUrl(string clientUrl, TransactionManager tm_)
		{
			return GetByClientUrl(clientUrl, 0, string.Empty, tm_);
		}
		public async Task<List<S_userEO>> GetByClientUrlAsync(string clientUrl, TransactionManager tm_)
		{
			return await GetByClientUrlAsync(clientUrl, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ClientUrl（字段） 查询
		/// </summary>
		/// /// <param name = "clientUrl">用户第一次进入客户端时的url</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByClientUrl(string clientUrl, int top_)
		{
			return GetByClientUrl(clientUrl, top_, string.Empty, null);
		}
		public async Task<List<S_userEO>> GetByClientUrlAsync(string clientUrl, int top_)
		{
			return await GetByClientUrlAsync(clientUrl, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ClientUrl（字段） 查询
		/// </summary>
		/// /// <param name = "clientUrl">用户第一次进入客户端时的url</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByClientUrl(string clientUrl, int top_, TransactionManager tm_)
		{
			return GetByClientUrl(clientUrl, top_, string.Empty, tm_);
		}
		public async Task<List<S_userEO>> GetByClientUrlAsync(string clientUrl, int top_, TransactionManager tm_)
		{
			return await GetByClientUrlAsync(clientUrl, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ClientUrl（字段） 查询
		/// </summary>
		/// /// <param name = "clientUrl">用户第一次进入客户端时的url</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByClientUrl(string clientUrl, string sort_)
		{
			return GetByClientUrl(clientUrl, 0, sort_, null);
		}
		public async Task<List<S_userEO>> GetByClientUrlAsync(string clientUrl, string sort_)
		{
			return await GetByClientUrlAsync(clientUrl, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 ClientUrl（字段） 查询
		/// </summary>
		/// /// <param name = "clientUrl">用户第一次进入客户端时的url</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByClientUrl(string clientUrl, string sort_, TransactionManager tm_)
		{
			return GetByClientUrl(clientUrl, 0, sort_, tm_);
		}
		public async Task<List<S_userEO>> GetByClientUrlAsync(string clientUrl, string sort_, TransactionManager tm_)
		{
			return await GetByClientUrlAsync(clientUrl, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 ClientUrl（字段） 查询
		/// </summary>
		/// /// <param name = "clientUrl">用户第一次进入客户端时的url</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByClientUrl(string clientUrl, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(clientUrl != null ? "`ClientUrl` = @ClientUrl" : "`ClientUrl` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (clientUrl != null)
				paras_.Add(Database.CreateInParameter("@ClientUrl", clientUrl, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_userEO.MapDataReader);
		}
		public async Task<List<S_userEO>> GetByClientUrlAsync(string clientUrl, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(clientUrl != null ? "`ClientUrl` = @ClientUrl" : "`ClientUrl` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (clientUrl != null)
				paras_.Add(Database.CreateInParameter("@ClientUrl", clientUrl, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_userEO.MapDataReader);
		}
		#endregion // GetByClientUrl
		#region GetByThemesID
		
		/// <summary>
		/// 按 ThemesID（字段） 查询
		/// </summary>
		/// /// <param name = "themesID">样式编码</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByThemesID(string themesID)
		{
			return GetByThemesID(themesID, 0, string.Empty, null);
		}
		public async Task<List<S_userEO>> GetByThemesIDAsync(string themesID)
		{
			return await GetByThemesIDAsync(themesID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ThemesID（字段） 查询
		/// </summary>
		/// /// <param name = "themesID">样式编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByThemesID(string themesID, TransactionManager tm_)
		{
			return GetByThemesID(themesID, 0, string.Empty, tm_);
		}
		public async Task<List<S_userEO>> GetByThemesIDAsync(string themesID, TransactionManager tm_)
		{
			return await GetByThemesIDAsync(themesID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ThemesID（字段） 查询
		/// </summary>
		/// /// <param name = "themesID">样式编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByThemesID(string themesID, int top_)
		{
			return GetByThemesID(themesID, top_, string.Empty, null);
		}
		public async Task<List<S_userEO>> GetByThemesIDAsync(string themesID, int top_)
		{
			return await GetByThemesIDAsync(themesID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ThemesID（字段） 查询
		/// </summary>
		/// /// <param name = "themesID">样式编码</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByThemesID(string themesID, int top_, TransactionManager tm_)
		{
			return GetByThemesID(themesID, top_, string.Empty, tm_);
		}
		public async Task<List<S_userEO>> GetByThemesIDAsync(string themesID, int top_, TransactionManager tm_)
		{
			return await GetByThemesIDAsync(themesID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ThemesID（字段） 查询
		/// </summary>
		/// /// <param name = "themesID">样式编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByThemesID(string themesID, string sort_)
		{
			return GetByThemesID(themesID, 0, sort_, null);
		}
		public async Task<List<S_userEO>> GetByThemesIDAsync(string themesID, string sort_)
		{
			return await GetByThemesIDAsync(themesID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 ThemesID（字段） 查询
		/// </summary>
		/// /// <param name = "themesID">样式编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByThemesID(string themesID, string sort_, TransactionManager tm_)
		{
			return GetByThemesID(themesID, 0, sort_, tm_);
		}
		public async Task<List<S_userEO>> GetByThemesIDAsync(string themesID, string sort_, TransactionManager tm_)
		{
			return await GetByThemesIDAsync(themesID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 ThemesID（字段） 查询
		/// </summary>
		/// /// <param name = "themesID">样式编码</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByThemesID(string themesID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(themesID != null ? "`ThemesID` = @ThemesID" : "`ThemesID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (themesID != null)
				paras_.Add(Database.CreateInParameter("@ThemesID", themesID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_userEO.MapDataReader);
		}
		public async Task<List<S_userEO>> GetByThemesIDAsync(string themesID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(themesID != null ? "`ThemesID` = @ThemesID" : "`ThemesID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (themesID != null)
				paras_.Add(Database.CreateInParameter("@ThemesID", themesID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_userEO.MapDataReader);
		}
		#endregion // GetByThemesID
		#region GetByStatus
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByStatus(int status)
		{
			return GetByStatus(status, 0, string.Empty, null);
		}
		public async Task<List<S_userEO>> GetByStatusAsync(int status)
		{
			return await GetByStatusAsync(status, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByStatus(int status, TransactionManager tm_)
		{
			return GetByStatus(status, 0, string.Empty, tm_);
		}
		public async Task<List<S_userEO>> GetByStatusAsync(int status, TransactionManager tm_)
		{
			return await GetByStatusAsync(status, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByStatus(int status, int top_)
		{
			return GetByStatus(status, top_, string.Empty, null);
		}
		public async Task<List<S_userEO>> GetByStatusAsync(int status, int top_)
		{
			return await GetByStatusAsync(status, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByStatus(int status, int top_, TransactionManager tm_)
		{
			return GetByStatus(status, top_, string.Empty, tm_);
		}
		public async Task<List<S_userEO>> GetByStatusAsync(int status, int top_, TransactionManager tm_)
		{
			return await GetByStatusAsync(status, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByStatus(int status, string sort_)
		{
			return GetByStatus(status, 0, sort_, null);
		}
		public async Task<List<S_userEO>> GetByStatusAsync(int status, string sort_)
		{
			return await GetByStatusAsync(status, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByStatus(int status, string sort_, TransactionManager tm_)
		{
			return GetByStatus(status, 0, sort_, tm_);
		}
		public async Task<List<S_userEO>> GetByStatusAsync(int status, string sort_, TransactionManager tm_)
		{
			return await GetByStatusAsync(status, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByStatus(int status, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Status` = @Status", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Status", status, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, S_userEO.MapDataReader);
		}
		public async Task<List<S_userEO>> GetByStatusAsync(int status, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Status` = @Status", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Status", status, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_userEO.MapDataReader);
		}
		#endregion // GetByStatus
		#region GetByRecDate
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByRecDate(DateTime recDate)
		{
			return GetByRecDate(recDate, 0, string.Empty, null);
		}
		public async Task<List<S_userEO>> GetByRecDateAsync(DateTime recDate)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByRecDate(DateTime recDate, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, string.Empty, tm_);
		}
		public async Task<List<S_userEO>> GetByRecDateAsync(DateTime recDate, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByRecDate(DateTime recDate, int top_)
		{
			return GetByRecDate(recDate, top_, string.Empty, null);
		}
		public async Task<List<S_userEO>> GetByRecDateAsync(DateTime recDate, int top_)
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
		public List<S_userEO> GetByRecDate(DateTime recDate, int top_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, top_, string.Empty, tm_);
		}
		public async Task<List<S_userEO>> GetByRecDateAsync(DateTime recDate, int top_, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByRecDate(DateTime recDate, string sort_)
		{
			return GetByRecDate(recDate, 0, sort_, null);
		}
		public async Task<List<S_userEO>> GetByRecDateAsync(DateTime recDate, string sort_)
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
		public List<S_userEO> GetByRecDate(DateTime recDate, string sort_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, sort_, tm_);
		}
		public async Task<List<S_userEO>> GetByRecDateAsync(DateTime recDate, string sort_, TransactionManager tm_)
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
		public List<S_userEO> GetByRecDate(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return Database.ExecSqlList(sql_, paras_, tm_, S_userEO.MapDataReader);
		}
		public async Task<List<S_userEO>> GetByRecDateAsync(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_userEO.MapDataReader);
		}
		#endregion // GetByRecDate
		#region GetByRegistDate
		
		/// <summary>
		/// 按 RegistDate（字段） 查询
		/// </summary>
		/// /// <param name = "registDate">注册时间</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByRegistDate(DateTime? registDate)
		{
			return GetByRegistDate(registDate, 0, string.Empty, null);
		}
		public async Task<List<S_userEO>> GetByRegistDateAsync(DateTime? registDate)
		{
			return await GetByRegistDateAsync(registDate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RegistDate（字段） 查询
		/// </summary>
		/// /// <param name = "registDate">注册时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByRegistDate(DateTime? registDate, TransactionManager tm_)
		{
			return GetByRegistDate(registDate, 0, string.Empty, tm_);
		}
		public async Task<List<S_userEO>> GetByRegistDateAsync(DateTime? registDate, TransactionManager tm_)
		{
			return await GetByRegistDateAsync(registDate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RegistDate（字段） 查询
		/// </summary>
		/// /// <param name = "registDate">注册时间</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByRegistDate(DateTime? registDate, int top_)
		{
			return GetByRegistDate(registDate, top_, string.Empty, null);
		}
		public async Task<List<S_userEO>> GetByRegistDateAsync(DateTime? registDate, int top_)
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
		public List<S_userEO> GetByRegistDate(DateTime? registDate, int top_, TransactionManager tm_)
		{
			return GetByRegistDate(registDate, top_, string.Empty, tm_);
		}
		public async Task<List<S_userEO>> GetByRegistDateAsync(DateTime? registDate, int top_, TransactionManager tm_)
		{
			return await GetByRegistDateAsync(registDate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RegistDate（字段） 查询
		/// </summary>
		/// /// <param name = "registDate">注册时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByRegistDate(DateTime? registDate, string sort_)
		{
			return GetByRegistDate(registDate, 0, sort_, null);
		}
		public async Task<List<S_userEO>> GetByRegistDateAsync(DateTime? registDate, string sort_)
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
		public List<S_userEO> GetByRegistDate(DateTime? registDate, string sort_, TransactionManager tm_)
		{
			return GetByRegistDate(registDate, 0, sort_, tm_);
		}
		public async Task<List<S_userEO>> GetByRegistDateAsync(DateTime? registDate, string sort_, TransactionManager tm_)
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
		public List<S_userEO> GetByRegistDate(DateTime? registDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(registDate.HasValue ? "`RegistDate` = @RegistDate" : "`RegistDate` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (registDate.HasValue)
				paras_.Add(Database.CreateInParameter("@RegistDate", registDate.Value, MySqlDbType.DateTime));
			return Database.ExecSqlList(sql_, paras_, tm_, S_userEO.MapDataReader);
		}
		public async Task<List<S_userEO>> GetByRegistDateAsync(DateTime? registDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(registDate.HasValue ? "`RegistDate` = @RegistDate" : "`RegistDate` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (registDate.HasValue)
				paras_.Add(Database.CreateInParameter("@RegistDate", registDate.Value, MySqlDbType.DateTime));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_userEO.MapDataReader);
		}
		#endregion // GetByRegistDate
		#region GetByLastLoginDate
		
		/// <summary>
		/// 按 LastLoginDate（字段） 查询
		/// </summary>
		/// /// <param name = "lastLoginDate">最后一次登录时间</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByLastLoginDate(DateTime lastLoginDate)
		{
			return GetByLastLoginDate(lastLoginDate, 0, string.Empty, null);
		}
		public async Task<List<S_userEO>> GetByLastLoginDateAsync(DateTime lastLoginDate)
		{
			return await GetByLastLoginDateAsync(lastLoginDate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LastLoginDate（字段） 查询
		/// </summary>
		/// /// <param name = "lastLoginDate">最后一次登录时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByLastLoginDate(DateTime lastLoginDate, TransactionManager tm_)
		{
			return GetByLastLoginDate(lastLoginDate, 0, string.Empty, tm_);
		}
		public async Task<List<S_userEO>> GetByLastLoginDateAsync(DateTime lastLoginDate, TransactionManager tm_)
		{
			return await GetByLastLoginDateAsync(lastLoginDate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LastLoginDate（字段） 查询
		/// </summary>
		/// /// <param name = "lastLoginDate">最后一次登录时间</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByLastLoginDate(DateTime lastLoginDate, int top_)
		{
			return GetByLastLoginDate(lastLoginDate, top_, string.Empty, null);
		}
		public async Task<List<S_userEO>> GetByLastLoginDateAsync(DateTime lastLoginDate, int top_)
		{
			return await GetByLastLoginDateAsync(lastLoginDate, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LastLoginDate（字段） 查询
		/// </summary>
		/// /// <param name = "lastLoginDate">最后一次登录时间</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByLastLoginDate(DateTime lastLoginDate, int top_, TransactionManager tm_)
		{
			return GetByLastLoginDate(lastLoginDate, top_, string.Empty, tm_);
		}
		public async Task<List<S_userEO>> GetByLastLoginDateAsync(DateTime lastLoginDate, int top_, TransactionManager tm_)
		{
			return await GetByLastLoginDateAsync(lastLoginDate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LastLoginDate（字段） 查询
		/// </summary>
		/// /// <param name = "lastLoginDate">最后一次登录时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByLastLoginDate(DateTime lastLoginDate, string sort_)
		{
			return GetByLastLoginDate(lastLoginDate, 0, sort_, null);
		}
		public async Task<List<S_userEO>> GetByLastLoginDateAsync(DateTime lastLoginDate, string sort_)
		{
			return await GetByLastLoginDateAsync(lastLoginDate, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 LastLoginDate（字段） 查询
		/// </summary>
		/// /// <param name = "lastLoginDate">最后一次登录时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByLastLoginDate(DateTime lastLoginDate, string sort_, TransactionManager tm_)
		{
			return GetByLastLoginDate(lastLoginDate, 0, sort_, tm_);
		}
		public async Task<List<S_userEO>> GetByLastLoginDateAsync(DateTime lastLoginDate, string sort_, TransactionManager tm_)
		{
			return await GetByLastLoginDateAsync(lastLoginDate, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 LastLoginDate（字段） 查询
		/// </summary>
		/// /// <param name = "lastLoginDate">最后一次登录时间</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByLastLoginDate(DateTime lastLoginDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`LastLoginDate` = @LastLoginDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@LastLoginDate", lastLoginDate, MySqlDbType.DateTime));
			return Database.ExecSqlList(sql_, paras_, tm_, S_userEO.MapDataReader);
		}
		public async Task<List<S_userEO>> GetByLastLoginDateAsync(DateTime lastLoginDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`LastLoginDate` = @LastLoginDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@LastLoginDate", lastLoginDate, MySqlDbType.DateTime));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_userEO.MapDataReader);
		}
		#endregion // GetByLastLoginDate
		#region GetByMobile
		
		/// <summary>
		/// 按 Mobile（字段） 查询
		/// </summary>
		/// /// <param name = "mobile">手机号</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByMobile(string mobile)
		{
			return GetByMobile(mobile, 0, string.Empty, null);
		}
		public async Task<List<S_userEO>> GetByMobileAsync(string mobile)
		{
			return await GetByMobileAsync(mobile, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Mobile（字段） 查询
		/// </summary>
		/// /// <param name = "mobile">手机号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByMobile(string mobile, TransactionManager tm_)
		{
			return GetByMobile(mobile, 0, string.Empty, tm_);
		}
		public async Task<List<S_userEO>> GetByMobileAsync(string mobile, TransactionManager tm_)
		{
			return await GetByMobileAsync(mobile, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Mobile（字段） 查询
		/// </summary>
		/// /// <param name = "mobile">手机号</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByMobile(string mobile, int top_)
		{
			return GetByMobile(mobile, top_, string.Empty, null);
		}
		public async Task<List<S_userEO>> GetByMobileAsync(string mobile, int top_)
		{
			return await GetByMobileAsync(mobile, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Mobile（字段） 查询
		/// </summary>
		/// /// <param name = "mobile">手机号</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByMobile(string mobile, int top_, TransactionManager tm_)
		{
			return GetByMobile(mobile, top_, string.Empty, tm_);
		}
		public async Task<List<S_userEO>> GetByMobileAsync(string mobile, int top_, TransactionManager tm_)
		{
			return await GetByMobileAsync(mobile, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Mobile（字段） 查询
		/// </summary>
		/// /// <param name = "mobile">手机号</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByMobile(string mobile, string sort_)
		{
			return GetByMobile(mobile, 0, sort_, null);
		}
		public async Task<List<S_userEO>> GetByMobileAsync(string mobile, string sort_)
		{
			return await GetByMobileAsync(mobile, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Mobile（字段） 查询
		/// </summary>
		/// /// <param name = "mobile">手机号</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByMobile(string mobile, string sort_, TransactionManager tm_)
		{
			return GetByMobile(mobile, 0, sort_, tm_);
		}
		public async Task<List<S_userEO>> GetByMobileAsync(string mobile, string sort_, TransactionManager tm_)
		{
			return await GetByMobileAsync(mobile, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Mobile（字段） 查询
		/// </summary>
		/// /// <param name = "mobile">手机号</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByMobile(string mobile, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(mobile != null ? "`Mobile` = @Mobile" : "`Mobile` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (mobile != null)
				paras_.Add(Database.CreateInParameter("@Mobile", mobile, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_userEO.MapDataReader);
		}
		public async Task<List<S_userEO>> GetByMobileAsync(string mobile, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(mobile != null ? "`Mobile` = @Mobile" : "`Mobile` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (mobile != null)
				paras_.Add(Database.CreateInParameter("@Mobile", mobile, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_userEO.MapDataReader);
		}
		#endregion // GetByMobile
		#region GetByEmail
		
		/// <summary>
		/// 按 Email（字段） 查询
		/// </summary>
		/// /// <param name = "email">邮箱</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByEmail(string email)
		{
			return GetByEmail(email, 0, string.Empty, null);
		}
		public async Task<List<S_userEO>> GetByEmailAsync(string email)
		{
			return await GetByEmailAsync(email, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Email（字段） 查询
		/// </summary>
		/// /// <param name = "email">邮箱</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByEmail(string email, TransactionManager tm_)
		{
			return GetByEmail(email, 0, string.Empty, tm_);
		}
		public async Task<List<S_userEO>> GetByEmailAsync(string email, TransactionManager tm_)
		{
			return await GetByEmailAsync(email, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Email（字段） 查询
		/// </summary>
		/// /// <param name = "email">邮箱</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByEmail(string email, int top_)
		{
			return GetByEmail(email, top_, string.Empty, null);
		}
		public async Task<List<S_userEO>> GetByEmailAsync(string email, int top_)
		{
			return await GetByEmailAsync(email, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Email（字段） 查询
		/// </summary>
		/// /// <param name = "email">邮箱</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByEmail(string email, int top_, TransactionManager tm_)
		{
			return GetByEmail(email, top_, string.Empty, tm_);
		}
		public async Task<List<S_userEO>> GetByEmailAsync(string email, int top_, TransactionManager tm_)
		{
			return await GetByEmailAsync(email, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Email（字段） 查询
		/// </summary>
		/// /// <param name = "email">邮箱</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByEmail(string email, string sort_)
		{
			return GetByEmail(email, 0, sort_, null);
		}
		public async Task<List<S_userEO>> GetByEmailAsync(string email, string sort_)
		{
			return await GetByEmailAsync(email, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Email（字段） 查询
		/// </summary>
		/// /// <param name = "email">邮箱</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByEmail(string email, string sort_, TransactionManager tm_)
		{
			return GetByEmail(email, 0, sort_, tm_);
		}
		public async Task<List<S_userEO>> GetByEmailAsync(string email, string sort_, TransactionManager tm_)
		{
			return await GetByEmailAsync(email, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Email（字段） 查询
		/// </summary>
		/// /// <param name = "email">邮箱</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByEmail(string email, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(email != null ? "`Email` = @Email" : "`Email` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (email != null)
				paras_.Add(Database.CreateInParameter("@Email", email, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_userEO.MapDataReader);
		}
		public async Task<List<S_userEO>> GetByEmailAsync(string email, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(email != null ? "`Email` = @Email" : "`Email` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (email != null)
				paras_.Add(Database.CreateInParameter("@Email", email, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_userEO.MapDataReader);
		}
		#endregion // GetByEmail
		#region GetByUsername
		
		/// <summary>
		/// 按 Username（字段） 查询
		/// </summary>
		/// /// <param name = "username">登录用户名</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByUsername(string username)
		{
			return GetByUsername(username, 0, string.Empty, null);
		}
		public async Task<List<S_userEO>> GetByUsernameAsync(string username)
		{
			return await GetByUsernameAsync(username, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Username（字段） 查询
		/// </summary>
		/// /// <param name = "username">登录用户名</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByUsername(string username, TransactionManager tm_)
		{
			return GetByUsername(username, 0, string.Empty, tm_);
		}
		public async Task<List<S_userEO>> GetByUsernameAsync(string username, TransactionManager tm_)
		{
			return await GetByUsernameAsync(username, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Username（字段） 查询
		/// </summary>
		/// /// <param name = "username">登录用户名</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByUsername(string username, int top_)
		{
			return GetByUsername(username, top_, string.Empty, null);
		}
		public async Task<List<S_userEO>> GetByUsernameAsync(string username, int top_)
		{
			return await GetByUsernameAsync(username, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Username（字段） 查询
		/// </summary>
		/// /// <param name = "username">登录用户名</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByUsername(string username, int top_, TransactionManager tm_)
		{
			return GetByUsername(username, top_, string.Empty, tm_);
		}
		public async Task<List<S_userEO>> GetByUsernameAsync(string username, int top_, TransactionManager tm_)
		{
			return await GetByUsernameAsync(username, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Username（字段） 查询
		/// </summary>
		/// /// <param name = "username">登录用户名</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByUsername(string username, string sort_)
		{
			return GetByUsername(username, 0, sort_, null);
		}
		public async Task<List<S_userEO>> GetByUsernameAsync(string username, string sort_)
		{
			return await GetByUsernameAsync(username, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Username（字段） 查询
		/// </summary>
		/// /// <param name = "username">登录用户名</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByUsername(string username, string sort_, TransactionManager tm_)
		{
			return GetByUsername(username, 0, sort_, tm_);
		}
		public async Task<List<S_userEO>> GetByUsernameAsync(string username, string sort_, TransactionManager tm_)
		{
			return await GetByUsernameAsync(username, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Username（字段） 查询
		/// </summary>
		/// /// <param name = "username">登录用户名</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByUsername(string username, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(username != null ? "`Username` = @Username" : "`Username` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (username != null)
				paras_.Add(Database.CreateInParameter("@Username", username, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_userEO.MapDataReader);
		}
		public async Task<List<S_userEO>> GetByUsernameAsync(string username, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(username != null ? "`Username` = @Username" : "`Username` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (username != null)
				paras_.Add(Database.CreateInParameter("@Username", username, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_userEO.MapDataReader);
		}
		#endregion // GetByUsername
		#region GetByPassword
		
		/// <summary>
		/// 按 Password（字段） 查询
		/// </summary>
		/// /// <param name = "password">密码哈希值</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByPassword(string password)
		{
			return GetByPassword(password, 0, string.Empty, null);
		}
		public async Task<List<S_userEO>> GetByPasswordAsync(string password)
		{
			return await GetByPasswordAsync(password, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Password（字段） 查询
		/// </summary>
		/// /// <param name = "password">密码哈希值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByPassword(string password, TransactionManager tm_)
		{
			return GetByPassword(password, 0, string.Empty, tm_);
		}
		public async Task<List<S_userEO>> GetByPasswordAsync(string password, TransactionManager tm_)
		{
			return await GetByPasswordAsync(password, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Password（字段） 查询
		/// </summary>
		/// /// <param name = "password">密码哈希值</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByPassword(string password, int top_)
		{
			return GetByPassword(password, top_, string.Empty, null);
		}
		public async Task<List<S_userEO>> GetByPasswordAsync(string password, int top_)
		{
			return await GetByPasswordAsync(password, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Password（字段） 查询
		/// </summary>
		/// /// <param name = "password">密码哈希值</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByPassword(string password, int top_, TransactionManager tm_)
		{
			return GetByPassword(password, top_, string.Empty, tm_);
		}
		public async Task<List<S_userEO>> GetByPasswordAsync(string password, int top_, TransactionManager tm_)
		{
			return await GetByPasswordAsync(password, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Password（字段） 查询
		/// </summary>
		/// /// <param name = "password">密码哈希值</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByPassword(string password, string sort_)
		{
			return GetByPassword(password, 0, sort_, null);
		}
		public async Task<List<S_userEO>> GetByPasswordAsync(string password, string sort_)
		{
			return await GetByPasswordAsync(password, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Password（字段） 查询
		/// </summary>
		/// /// <param name = "password">密码哈希值</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByPassword(string password, string sort_, TransactionManager tm_)
		{
			return GetByPassword(password, 0, sort_, tm_);
		}
		public async Task<List<S_userEO>> GetByPasswordAsync(string password, string sort_, TransactionManager tm_)
		{
			return await GetByPasswordAsync(password, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Password（字段） 查询
		/// </summary>
		/// /// <param name = "password">密码哈希值</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByPassword(string password, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(password != null ? "`Password` = @Password" : "`Password` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (password != null)
				paras_.Add(Database.CreateInParameter("@Password", password, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_userEO.MapDataReader);
		}
		public async Task<List<S_userEO>> GetByPasswordAsync(string password, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(password != null ? "`Password` = @Password" : "`Password` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (password != null)
				paras_.Add(Database.CreateInParameter("@Password", password, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_userEO.MapDataReader);
		}
		#endregion // GetByPassword
		#region GetByPasswordSalt
		
		/// <summary>
		/// 按 PasswordSalt（字段） 查询
		/// </summary>
		/// /// <param name = "passwordSalt">密码哈希Salt</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByPasswordSalt(string passwordSalt)
		{
			return GetByPasswordSalt(passwordSalt, 0, string.Empty, null);
		}
		public async Task<List<S_userEO>> GetByPasswordSaltAsync(string passwordSalt)
		{
			return await GetByPasswordSaltAsync(passwordSalt, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PasswordSalt（字段） 查询
		/// </summary>
		/// /// <param name = "passwordSalt">密码哈希Salt</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByPasswordSalt(string passwordSalt, TransactionManager tm_)
		{
			return GetByPasswordSalt(passwordSalt, 0, string.Empty, tm_);
		}
		public async Task<List<S_userEO>> GetByPasswordSaltAsync(string passwordSalt, TransactionManager tm_)
		{
			return await GetByPasswordSaltAsync(passwordSalt, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PasswordSalt（字段） 查询
		/// </summary>
		/// /// <param name = "passwordSalt">密码哈希Salt</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByPasswordSalt(string passwordSalt, int top_)
		{
			return GetByPasswordSalt(passwordSalt, top_, string.Empty, null);
		}
		public async Task<List<S_userEO>> GetByPasswordSaltAsync(string passwordSalt, int top_)
		{
			return await GetByPasswordSaltAsync(passwordSalt, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PasswordSalt（字段） 查询
		/// </summary>
		/// /// <param name = "passwordSalt">密码哈希Salt</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByPasswordSalt(string passwordSalt, int top_, TransactionManager tm_)
		{
			return GetByPasswordSalt(passwordSalt, top_, string.Empty, tm_);
		}
		public async Task<List<S_userEO>> GetByPasswordSaltAsync(string passwordSalt, int top_, TransactionManager tm_)
		{
			return await GetByPasswordSaltAsync(passwordSalt, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PasswordSalt（字段） 查询
		/// </summary>
		/// /// <param name = "passwordSalt">密码哈希Salt</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByPasswordSalt(string passwordSalt, string sort_)
		{
			return GetByPasswordSalt(passwordSalt, 0, sort_, null);
		}
		public async Task<List<S_userEO>> GetByPasswordSaltAsync(string passwordSalt, string sort_)
		{
			return await GetByPasswordSaltAsync(passwordSalt, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 PasswordSalt（字段） 查询
		/// </summary>
		/// /// <param name = "passwordSalt">密码哈希Salt</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByPasswordSalt(string passwordSalt, string sort_, TransactionManager tm_)
		{
			return GetByPasswordSalt(passwordSalt, 0, sort_, tm_);
		}
		public async Task<List<S_userEO>> GetByPasswordSaltAsync(string passwordSalt, string sort_, TransactionManager tm_)
		{
			return await GetByPasswordSaltAsync(passwordSalt, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 PasswordSalt（字段） 查询
		/// </summary>
		/// /// <param name = "passwordSalt">密码哈希Salt</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByPasswordSalt(string passwordSalt, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(passwordSalt != null ? "`PasswordSalt` = @PasswordSalt" : "`PasswordSalt` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (passwordSalt != null)
				paras_.Add(Database.CreateInParameter("@PasswordSalt", passwordSalt, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_userEO.MapDataReader);
		}
		public async Task<List<S_userEO>> GetByPasswordSaltAsync(string passwordSalt, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(passwordSalt != null ? "`PasswordSalt` = @PasswordSalt" : "`PasswordSalt` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (passwordSalt != null)
				paras_.Add(Database.CreateInParameter("@PasswordSalt", passwordSalt, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_userEO.MapDataReader);
		}
		#endregion // GetByPasswordSalt
		#region GetByHasBet
		
		/// <summary>
		/// 按 HasBet（字段） 查询
		/// </summary>
		/// /// <param name = "hasBet">是否下过注</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByHasBet(bool hasBet)
		{
			return GetByHasBet(hasBet, 0, string.Empty, null);
		}
		public async Task<List<S_userEO>> GetByHasBetAsync(bool hasBet)
		{
			return await GetByHasBetAsync(hasBet, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 HasBet（字段） 查询
		/// </summary>
		/// /// <param name = "hasBet">是否下过注</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByHasBet(bool hasBet, TransactionManager tm_)
		{
			return GetByHasBet(hasBet, 0, string.Empty, tm_);
		}
		public async Task<List<S_userEO>> GetByHasBetAsync(bool hasBet, TransactionManager tm_)
		{
			return await GetByHasBetAsync(hasBet, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 HasBet（字段） 查询
		/// </summary>
		/// /// <param name = "hasBet">是否下过注</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByHasBet(bool hasBet, int top_)
		{
			return GetByHasBet(hasBet, top_, string.Empty, null);
		}
		public async Task<List<S_userEO>> GetByHasBetAsync(bool hasBet, int top_)
		{
			return await GetByHasBetAsync(hasBet, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 HasBet（字段） 查询
		/// </summary>
		/// /// <param name = "hasBet">是否下过注</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByHasBet(bool hasBet, int top_, TransactionManager tm_)
		{
			return GetByHasBet(hasBet, top_, string.Empty, tm_);
		}
		public async Task<List<S_userEO>> GetByHasBetAsync(bool hasBet, int top_, TransactionManager tm_)
		{
			return await GetByHasBetAsync(hasBet, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 HasBet（字段） 查询
		/// </summary>
		/// /// <param name = "hasBet">是否下过注</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByHasBet(bool hasBet, string sort_)
		{
			return GetByHasBet(hasBet, 0, sort_, null);
		}
		public async Task<List<S_userEO>> GetByHasBetAsync(bool hasBet, string sort_)
		{
			return await GetByHasBetAsync(hasBet, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 HasBet（字段） 查询
		/// </summary>
		/// /// <param name = "hasBet">是否下过注</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByHasBet(bool hasBet, string sort_, TransactionManager tm_)
		{
			return GetByHasBet(hasBet, 0, sort_, tm_);
		}
		public async Task<List<S_userEO>> GetByHasBetAsync(bool hasBet, string sort_, TransactionManager tm_)
		{
			return await GetByHasBetAsync(hasBet, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 HasBet（字段） 查询
		/// </summary>
		/// /// <param name = "hasBet">是否下过注</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByHasBet(bool hasBet, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`HasBet` = @HasBet", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@HasBet", hasBet, MySqlDbType.Byte));
			return Database.ExecSqlList(sql_, paras_, tm_, S_userEO.MapDataReader);
		}
		public async Task<List<S_userEO>> GetByHasBetAsync(bool hasBet, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`HasBet` = @HasBet", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@HasBet", hasBet, MySqlDbType.Byte));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_userEO.MapDataReader);
		}
		#endregion // GetByHasBet
		#region GetByHasPay
		
		/// <summary>
		/// 按 HasPay（字段） 查询
		/// </summary>
		/// /// <param name = "hasPay">是否充过值</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByHasPay(bool hasPay)
		{
			return GetByHasPay(hasPay, 0, string.Empty, null);
		}
		public async Task<List<S_userEO>> GetByHasPayAsync(bool hasPay)
		{
			return await GetByHasPayAsync(hasPay, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 HasPay（字段） 查询
		/// </summary>
		/// /// <param name = "hasPay">是否充过值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByHasPay(bool hasPay, TransactionManager tm_)
		{
			return GetByHasPay(hasPay, 0, string.Empty, tm_);
		}
		public async Task<List<S_userEO>> GetByHasPayAsync(bool hasPay, TransactionManager tm_)
		{
			return await GetByHasPayAsync(hasPay, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 HasPay（字段） 查询
		/// </summary>
		/// /// <param name = "hasPay">是否充过值</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByHasPay(bool hasPay, int top_)
		{
			return GetByHasPay(hasPay, top_, string.Empty, null);
		}
		public async Task<List<S_userEO>> GetByHasPayAsync(bool hasPay, int top_)
		{
			return await GetByHasPayAsync(hasPay, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 HasPay（字段） 查询
		/// </summary>
		/// /// <param name = "hasPay">是否充过值</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByHasPay(bool hasPay, int top_, TransactionManager tm_)
		{
			return GetByHasPay(hasPay, top_, string.Empty, tm_);
		}
		public async Task<List<S_userEO>> GetByHasPayAsync(bool hasPay, int top_, TransactionManager tm_)
		{
			return await GetByHasPayAsync(hasPay, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 HasPay（字段） 查询
		/// </summary>
		/// /// <param name = "hasPay">是否充过值</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByHasPay(bool hasPay, string sort_)
		{
			return GetByHasPay(hasPay, 0, sort_, null);
		}
		public async Task<List<S_userEO>> GetByHasPayAsync(bool hasPay, string sort_)
		{
			return await GetByHasPayAsync(hasPay, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 HasPay（字段） 查询
		/// </summary>
		/// /// <param name = "hasPay">是否充过值</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByHasPay(bool hasPay, string sort_, TransactionManager tm_)
		{
			return GetByHasPay(hasPay, 0, sort_, tm_);
		}
		public async Task<List<S_userEO>> GetByHasPayAsync(bool hasPay, string sort_, TransactionManager tm_)
		{
			return await GetByHasPayAsync(hasPay, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 HasPay（字段） 查询
		/// </summary>
		/// /// <param name = "hasPay">是否充过值</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByHasPay(bool hasPay, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`HasPay` = @HasPay", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@HasPay", hasPay, MySqlDbType.Byte));
			return Database.ExecSqlList(sql_, paras_, tm_, S_userEO.MapDataReader);
		}
		public async Task<List<S_userEO>> GetByHasPayAsync(bool hasPay, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`HasPay` = @HasPay", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@HasPay", hasPay, MySqlDbType.Byte));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_userEO.MapDataReader);
		}
		#endregion // GetByHasPay
		#region GetByHasCash
		
		/// <summary>
		/// 按 HasCash（字段） 查询
		/// </summary>
		/// /// <param name = "hasCash">是否提过现</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByHasCash(bool hasCash)
		{
			return GetByHasCash(hasCash, 0, string.Empty, null);
		}
		public async Task<List<S_userEO>> GetByHasCashAsync(bool hasCash)
		{
			return await GetByHasCashAsync(hasCash, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 HasCash（字段） 查询
		/// </summary>
		/// /// <param name = "hasCash">是否提过现</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByHasCash(bool hasCash, TransactionManager tm_)
		{
			return GetByHasCash(hasCash, 0, string.Empty, tm_);
		}
		public async Task<List<S_userEO>> GetByHasCashAsync(bool hasCash, TransactionManager tm_)
		{
			return await GetByHasCashAsync(hasCash, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 HasCash（字段） 查询
		/// </summary>
		/// /// <param name = "hasCash">是否提过现</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByHasCash(bool hasCash, int top_)
		{
			return GetByHasCash(hasCash, top_, string.Empty, null);
		}
		public async Task<List<S_userEO>> GetByHasCashAsync(bool hasCash, int top_)
		{
			return await GetByHasCashAsync(hasCash, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 HasCash（字段） 查询
		/// </summary>
		/// /// <param name = "hasCash">是否提过现</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByHasCash(bool hasCash, int top_, TransactionManager tm_)
		{
			return GetByHasCash(hasCash, top_, string.Empty, tm_);
		}
		public async Task<List<S_userEO>> GetByHasCashAsync(bool hasCash, int top_, TransactionManager tm_)
		{
			return await GetByHasCashAsync(hasCash, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 HasCash（字段） 查询
		/// </summary>
		/// /// <param name = "hasCash">是否提过现</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByHasCash(bool hasCash, string sort_)
		{
			return GetByHasCash(hasCash, 0, sort_, null);
		}
		public async Task<List<S_userEO>> GetByHasCashAsync(bool hasCash, string sort_)
		{
			return await GetByHasCashAsync(hasCash, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 HasCash（字段） 查询
		/// </summary>
		/// /// <param name = "hasCash">是否提过现</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByHasCash(bool hasCash, string sort_, TransactionManager tm_)
		{
			return GetByHasCash(hasCash, 0, sort_, tm_);
		}
		public async Task<List<S_userEO>> GetByHasCashAsync(bool hasCash, string sort_, TransactionManager tm_)
		{
			return await GetByHasCashAsync(hasCash, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 HasCash（字段） 查询
		/// </summary>
		/// /// <param name = "hasCash">是否提过现</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_userEO> GetByHasCash(bool hasCash, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`HasCash` = @HasCash", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@HasCash", hasCash, MySqlDbType.Byte));
			return Database.ExecSqlList(sql_, paras_, tm_, S_userEO.MapDataReader);
		}
		public async Task<List<S_userEO>> GetByHasCashAsync(bool hasCash, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`HasCash` = @HasCash", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@HasCash", hasCash, MySqlDbType.Byte));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_userEO.MapDataReader);
		}
		#endregion // GetByHasCash
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}

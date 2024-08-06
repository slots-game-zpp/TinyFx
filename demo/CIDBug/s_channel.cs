/******************************************************
 * 此代码由代码生成器工具自动生成，请不要修改
 * TinyFx代码生成器核心库版本号：1.0.0.0
 * git: https://github.com/jh98net/TinyFx
 * 文档生成时间：2023-12-29 15: 09:48
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
	/// 用户推广渠道（仅拉新用户，无产品定制需求）
	/// 【表 s_channel 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class S_channelEO : IRowMapper<S_channelEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public S_channelEO()
		{
			this.CType = 0;
			this.Status = 0;
			this.RecDate = DateTime.Now;
		}
		#region 主键原始值 & 主键集合
	    
		/// <summary>
		/// 当前对象是否保存原始主键值，当修改了主键值时为 true
		/// </summary>
		public bool HasOriginal { get; protected set; }
		
		private string _originalChannelID;
		/// <summary>
		/// 【数据库中的原始主键 ChannelID 值的副本，用于主键值更新】
		/// </summary>
		public string OriginalChannelID
		{
			get { return _originalChannelID; }
			set { HasOriginal = true; _originalChannelID = value; }
		}
	    /// <summary>
	    /// 获取主键集合。key: 数据库字段名称, value: 主键值
	    /// </summary>
	    /// <returns></returns>
	    public Dictionary<string, object> GetPrimaryKeys()
	    {
	        return new Dictionary<string, object>() { { "ChannelID", ChannelID }, };
	    }
	    /// <summary>
	    /// 获取主键集合JSON格式
	    /// </summary>
	    /// <returns></returns>
	    public string GetPrimaryKeysJson() => SerializerUtil.SerializeJson(GetPrimaryKeys());
		#endregion // 主键原始值
		#region 所有字段
		/// <summary>
		/// 推广渠道编码
		/// 【主键 varchar(50)】
		/// </summary>
		[DataMember(Order = 1)]
		public string ChannelID { get; set; }
		/// <summary>
		/// 运营商编码
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 2)]
		public string OperatorID { get; set; }
		/// <summary>
		/// 渠道名称
		/// 【字段 varchar(100)】
		/// </summary>
		[DataMember(Order = 3)]
		public string CName { get; set; }
		/// <summary>
		/// 渠道类型（0-公司1-个人）
		/// 【字段 tinyint】
		/// </summary>
		[DataMember(Order = 4)]
		public int CType { get; set; }
		/// <summary>
		/// branch关键字
		/// 【字段 varchar(255)】
		/// </summary>
		[DataMember(Order = 5)]
		public string BranchKey { get; set; }
		/// <summary>
		/// facebook pixelid
		/// 【字段 varchar(255)】
		/// </summary>
		[DataMember(Order = 6)]
		public string FBPixelId { get; set; }
		/// <summary>
		/// Facebook AccessToken
		/// 【字段 varchar(255)】
		/// </summary>
		[DataMember(Order = 7)]
		public string FBAccessToken { get; set; }
		/// <summary>
		/// 快手打点配置
		/// 【字段 varchar(1000)】
		/// </summary>
		[DataMember(Order = 8)]
		public string KwaiConfig { get; set; }
		/// <summary>
		/// GA关键字
		/// 【字段 varchar(255)】
		/// </summary>
		[DataMember(Order = 9)]
		public string GAKey { get; set; }
		/// <summary>
		/// 埋点配置信息
		/// 【字段 text】
		/// </summary>
		[DataMember(Order = 10)]
		public string TrackConfigs { get; set; }
		/// <summary>
		/// 备注信息
		/// 【字段 varchar(1000)】
		/// </summary>
		[DataMember(Order = 11)]
		public string Note { get; set; }
		/// <summary>
		/// 状态(0-无效1-有效)
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 12)]
		public int Status { get; set; }
		/// <summary>
		/// 记录时间
		/// 【字段 datetime】
		/// </summary>
		[DataMember(Order = 13)]
		public DateTime RecDate { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public S_channelEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static S_channelEO MapDataReader(IDataReader reader)
		{
		    S_channelEO ret = new S_channelEO();
			ret.ChannelID = reader.ToString("ChannelID");
			ret.OriginalChannelID = ret.ChannelID;
			ret.OperatorID = reader.ToString("OperatorID");
			ret.CName = reader.ToString("CName");
			ret.CType = reader.ToInt32("CType");
			ret.BranchKey = reader.ToString("BranchKey");
			ret.FBPixelId = reader.ToString("FBPixelId");
			ret.FBAccessToken = reader.ToString("FBAccessToken");
			ret.KwaiConfig = reader.ToString("KwaiConfig");
			ret.GAKey = reader.ToString("GAKey");
			ret.TrackConfigs = reader.ToString("TrackConfigs");
			ret.Note = reader.ToString("Note");
			ret.Status = reader.ToInt32("Status");
			ret.RecDate = reader.ToDateTime("RecDate");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 用户推广渠道（仅拉新用户，无产品定制需求）
	/// 【表 s_channel 的操作类】
	/// </summary>
	[Obsolete]
	public class S_channelMO : MySqlTableMO<S_channelEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`s_channel`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public S_channelMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public S_channelMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public S_channelMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(S_channelEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(S_channelEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(S_channelEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`ChannelID`, `OperatorID`, `CName`, `CType`, `BranchKey`, `FBPixelId`, `FBAccessToken`, `KwaiConfig`, `GAKey`, `TrackConfigs`, `Note`, `Status`, `RecDate`) VALUE (@ChannelID, @OperatorID, @CName, @CType, @BranchKey, @FBPixelId, @FBAccessToken, @KwaiConfig, @GAKey, @TrackConfigs, @Note, @Status, @RecDate);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChannelID", item.ChannelID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", item.OperatorID != null ? item.OperatorID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@CName", item.CName != null ? item.CName : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@CType", item.CType, MySqlDbType.Byte),
				Database.CreateInParameter("@BranchKey", item.BranchKey != null ? item.BranchKey : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@FBPixelId", item.FBPixelId != null ? item.FBPixelId : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@FBAccessToken", item.FBAccessToken != null ? item.FBAccessToken : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@KwaiConfig", item.KwaiConfig != null ? item.KwaiConfig : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@GAKey", item.GAKey != null ? item.GAKey : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@TrackConfigs", item.TrackConfigs != null ? item.TrackConfigs : (object)DBNull.Value, MySqlDbType.Text),
				Database.CreateInParameter("@Note", item.Note != null ? item.Note : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Status", item.Status, MySqlDbType.Int32),
				Database.CreateInParameter("@RecDate", item.RecDate, MySqlDbType.DateTime),
			};
		}
		public int AddByBatch(IEnumerable<S_channelEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<S_channelEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<S_channelEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`ChannelID`, `OperatorID`, `CName`, `CType`, `BranchKey`, `FBPixelId`, `FBAccessToken`, `KwaiConfig`, `GAKey`, `TrackConfigs`, `Note`, `Status`, `RecDate`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"('{item.ChannelID}','{item.OperatorID}','{item.CName}',{item.CType},'{item.BranchKey}','{item.FBPixelId}','{item.FBAccessToken}','{item.KwaiConfig}','{item.GAKey}','{item.TrackConfigs}','{item.Note}',{item.Status},'{item.RecDate.ToString("yyyy-MM-dd HH:mm:ss")}'),");
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
		/// /// <param name = "channelID">推广渠道编码</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(string channelID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(channelID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(string channelID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(channelID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(string channelID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `ChannelID` = @ChannelID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChannelID", channelID, MySqlDbType.VarChar),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(S_channelEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.ChannelID, tm_);
		}
		public async Task<int> RemoveAsync(S_channelEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.ChannelID, tm_);
		}
		#endregion // RemoveByPK
		
		#region RemoveByXXX
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
		#region RemoveByCName
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "cName">渠道名称</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByCName(string cName, TransactionManager tm_ = null)
		{
			RepairRemoveByCNameData(cName, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByCNameAsync(string cName, TransactionManager tm_ = null)
		{
			RepairRemoveByCNameData(cName, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByCNameData(string cName, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (cName != null ? "`CName` = @CName" : "`CName` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (cName != null)
				paras_.Add(Database.CreateInParameter("@CName", cName, MySqlDbType.VarChar));
		}
		#endregion // RemoveByCName
		#region RemoveByCType
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "cType">渠道类型（0-公司1-个人）</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByCType(int cType, TransactionManager tm_ = null)
		{
			RepairRemoveByCTypeData(cType, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByCTypeAsync(int cType, TransactionManager tm_ = null)
		{
			RepairRemoveByCTypeData(cType, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByCTypeData(int cType, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `CType` = @CType";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CType", cType, MySqlDbType.Byte));
		}
		#endregion // RemoveByCType
		#region RemoveByBranchKey
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "branchKey">branch关键字</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByBranchKey(string branchKey, TransactionManager tm_ = null)
		{
			RepairRemoveByBranchKeyData(branchKey, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByBranchKeyAsync(string branchKey, TransactionManager tm_ = null)
		{
			RepairRemoveByBranchKeyData(branchKey, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByBranchKeyData(string branchKey, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (branchKey != null ? "`BranchKey` = @BranchKey" : "`BranchKey` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (branchKey != null)
				paras_.Add(Database.CreateInParameter("@BranchKey", branchKey, MySqlDbType.VarChar));
		}
		#endregion // RemoveByBranchKey
		#region RemoveByFBPixelId
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "fBPixelId">facebook pixelid</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByFBPixelId(string fBPixelId, TransactionManager tm_ = null)
		{
			RepairRemoveByFBPixelIdData(fBPixelId, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByFBPixelIdAsync(string fBPixelId, TransactionManager tm_ = null)
		{
			RepairRemoveByFBPixelIdData(fBPixelId, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByFBPixelIdData(string fBPixelId, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (fBPixelId != null ? "`FBPixelId` = @FBPixelId" : "`FBPixelId` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (fBPixelId != null)
				paras_.Add(Database.CreateInParameter("@FBPixelId", fBPixelId, MySqlDbType.VarChar));
		}
		#endregion // RemoveByFBPixelId
		#region RemoveByFBAccessToken
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "fBAccessToken">Facebook AccessToken</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByFBAccessToken(string fBAccessToken, TransactionManager tm_ = null)
		{
			RepairRemoveByFBAccessTokenData(fBAccessToken, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByFBAccessTokenAsync(string fBAccessToken, TransactionManager tm_ = null)
		{
			RepairRemoveByFBAccessTokenData(fBAccessToken, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByFBAccessTokenData(string fBAccessToken, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (fBAccessToken != null ? "`FBAccessToken` = @FBAccessToken" : "`FBAccessToken` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (fBAccessToken != null)
				paras_.Add(Database.CreateInParameter("@FBAccessToken", fBAccessToken, MySqlDbType.VarChar));
		}
		#endregion // RemoveByFBAccessToken
		#region RemoveByKwaiConfig
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "kwaiConfig">快手打点配置</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByKwaiConfig(string kwaiConfig, TransactionManager tm_ = null)
		{
			RepairRemoveByKwaiConfigData(kwaiConfig, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByKwaiConfigAsync(string kwaiConfig, TransactionManager tm_ = null)
		{
			RepairRemoveByKwaiConfigData(kwaiConfig, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByKwaiConfigData(string kwaiConfig, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (kwaiConfig != null ? "`KwaiConfig` = @KwaiConfig" : "`KwaiConfig` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (kwaiConfig != null)
				paras_.Add(Database.CreateInParameter("@KwaiConfig", kwaiConfig, MySqlDbType.VarChar));
		}
		#endregion // RemoveByKwaiConfig
		#region RemoveByGAKey
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "gAKey">GA关键字</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByGAKey(string gAKey, TransactionManager tm_ = null)
		{
			RepairRemoveByGAKeyData(gAKey, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByGAKeyAsync(string gAKey, TransactionManager tm_ = null)
		{
			RepairRemoveByGAKeyData(gAKey, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByGAKeyData(string gAKey, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (gAKey != null ? "`GAKey` = @GAKey" : "`GAKey` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (gAKey != null)
				paras_.Add(Database.CreateInParameter("@GAKey", gAKey, MySqlDbType.VarChar));
		}
		#endregion // RemoveByGAKey
		#region RemoveByTrackConfigs
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "trackConfigs">埋点配置信息</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByTrackConfigs(string trackConfigs, TransactionManager tm_ = null)
		{
			RepairRemoveByTrackConfigsData(trackConfigs, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByTrackConfigsAsync(string trackConfigs, TransactionManager tm_ = null)
		{
			RepairRemoveByTrackConfigsData(trackConfigs, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByTrackConfigsData(string trackConfigs, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (trackConfigs != null ? "`TrackConfigs` = @TrackConfigs" : "`TrackConfigs` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (trackConfigs != null)
				paras_.Add(Database.CreateInParameter("@TrackConfigs", trackConfigs, MySqlDbType.Text));
		}
		#endregion // RemoveByTrackConfigs
		#region RemoveByNote
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "note">备注信息</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByNote(string note, TransactionManager tm_ = null)
		{
			RepairRemoveByNoteData(note, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByNoteAsync(string note, TransactionManager tm_ = null)
		{
			RepairRemoveByNoteData(note, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByNoteData(string note, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (note != null ? "`Note` = @Note" : "`Note` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (note != null)
				paras_.Add(Database.CreateInParameter("@Note", note, MySqlDbType.VarChar));
		}
		#endregion // RemoveByNote
		#region RemoveByStatus
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "status">状态(0-无效1-有效)</param>
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
		public int Put(S_channelEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(S_channelEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(S_channelEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `ChannelID` = @ChannelID, `OperatorID` = @OperatorID, `CName` = @CName, `CType` = @CType, `BranchKey` = @BranchKey, `FBPixelId` = @FBPixelId, `FBAccessToken` = @FBAccessToken, `KwaiConfig` = @KwaiConfig, `GAKey` = @GAKey, `TrackConfigs` = @TrackConfigs, `Note` = @Note, `Status` = @Status WHERE `ChannelID` = @ChannelID_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChannelID", item.ChannelID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", item.OperatorID != null ? item.OperatorID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@CName", item.CName != null ? item.CName : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@CType", item.CType, MySqlDbType.Byte),
				Database.CreateInParameter("@BranchKey", item.BranchKey != null ? item.BranchKey : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@FBPixelId", item.FBPixelId != null ? item.FBPixelId : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@FBAccessToken", item.FBAccessToken != null ? item.FBAccessToken : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@KwaiConfig", item.KwaiConfig != null ? item.KwaiConfig : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@GAKey", item.GAKey != null ? item.GAKey : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@TrackConfigs", item.TrackConfigs != null ? item.TrackConfigs : (object)DBNull.Value, MySqlDbType.Text),
				Database.CreateInParameter("@Note", item.Note != null ? item.Note : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Status", item.Status, MySqlDbType.Int32),
				Database.CreateInParameter("@ChannelID_Original", item.HasOriginal ? item.OriginalChannelID : item.ChannelID, MySqlDbType.VarChar),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<S_channelEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<S_channelEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "channelID">推广渠道编码</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string channelID, string set_, params object[] values_)
		{
			return Put(set_, "`ChannelID` = @ChannelID", ConcatValues(values_, channelID));
		}
		public async Task<int> PutByPKAsync(string channelID, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`ChannelID` = @ChannelID", ConcatValues(values_, channelID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "channelID">推广渠道编码</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string channelID, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`ChannelID` = @ChannelID", tm_, ConcatValues(values_, channelID));
		}
		public async Task<int> PutByPKAsync(string channelID, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`ChannelID` = @ChannelID", tm_, ConcatValues(values_, channelID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "channelID">推广渠道编码</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string channelID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@ChannelID", channelID, MySqlDbType.VarChar),
	        };
			return Put(set_, "`ChannelID` = @ChannelID", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(string channelID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@ChannelID", channelID, MySqlDbType.VarChar),
	        };
			return await PutAsync(set_, "`ChannelID` = @ChannelID", ConcatParameters(paras_, newParas_), tm_);
		}
		#endregion // PutByPK
		
		#region PutXXX
		#region PutOperatorID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "channelID">推广渠道编码</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOperatorIDByPK(string channelID, string operatorID, TransactionManager tm_ = null)
		{
			RepairPutOperatorIDByPKData(channelID, operatorID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutOperatorIDByPKAsync(string channelID, string operatorID, TransactionManager tm_ = null)
		{
			RepairPutOperatorIDByPKData(channelID, operatorID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutOperatorIDByPKData(string channelID, string operatorID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `OperatorID` = @OperatorID  WHERE `ChannelID` = @ChannelID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID != null ? operatorID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ChannelID", channelID, MySqlDbType.VarChar),
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
		#region PutCName
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "channelID">推广渠道编码</param>
		/// /// <param name = "cName">渠道名称</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCNameByPK(string channelID, string cName, TransactionManager tm_ = null)
		{
			RepairPutCNameByPKData(channelID, cName, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutCNameByPKAsync(string channelID, string cName, TransactionManager tm_ = null)
		{
			RepairPutCNameByPKData(channelID, cName, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutCNameByPKData(string channelID, string cName, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `CName` = @CName  WHERE `ChannelID` = @ChannelID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CName", cName != null ? cName : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ChannelID", channelID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "cName">渠道名称</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCName(string cName, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CName` = @CName";
			var parameter_ = Database.CreateInParameter("@CName", cName != null ? cName : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutCNameAsync(string cName, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CName` = @CName";
			var parameter_ = Database.CreateInParameter("@CName", cName != null ? cName : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutCName
		#region PutCType
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "channelID">推广渠道编码</param>
		/// /// <param name = "cType">渠道类型（0-公司1-个人）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCTypeByPK(string channelID, int cType, TransactionManager tm_ = null)
		{
			RepairPutCTypeByPKData(channelID, cType, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutCTypeByPKAsync(string channelID, int cType, TransactionManager tm_ = null)
		{
			RepairPutCTypeByPKData(channelID, cType, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutCTypeByPKData(string channelID, int cType, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `CType` = @CType  WHERE `ChannelID` = @ChannelID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CType", cType, MySqlDbType.Byte),
				Database.CreateInParameter("@ChannelID", channelID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "cType">渠道类型（0-公司1-个人）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCType(int cType, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CType` = @CType";
			var parameter_ = Database.CreateInParameter("@CType", cType, MySqlDbType.Byte);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutCTypeAsync(int cType, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CType` = @CType";
			var parameter_ = Database.CreateInParameter("@CType", cType, MySqlDbType.Byte);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutCType
		#region PutBranchKey
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "channelID">推广渠道编码</param>
		/// /// <param name = "branchKey">branch关键字</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBranchKeyByPK(string channelID, string branchKey, TransactionManager tm_ = null)
		{
			RepairPutBranchKeyByPKData(channelID, branchKey, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutBranchKeyByPKAsync(string channelID, string branchKey, TransactionManager tm_ = null)
		{
			RepairPutBranchKeyByPKData(channelID, branchKey, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutBranchKeyByPKData(string channelID, string branchKey, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `BranchKey` = @BranchKey  WHERE `ChannelID` = @ChannelID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BranchKey", branchKey != null ? branchKey : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ChannelID", channelID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "branchKey">branch关键字</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBranchKey(string branchKey, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `BranchKey` = @BranchKey";
			var parameter_ = Database.CreateInParameter("@BranchKey", branchKey != null ? branchKey : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutBranchKeyAsync(string branchKey, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `BranchKey` = @BranchKey";
			var parameter_ = Database.CreateInParameter("@BranchKey", branchKey != null ? branchKey : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutBranchKey
		#region PutFBPixelId
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "channelID">推广渠道编码</param>
		/// /// <param name = "fBPixelId">facebook pixelid</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutFBPixelIdByPK(string channelID, string fBPixelId, TransactionManager tm_ = null)
		{
			RepairPutFBPixelIdByPKData(channelID, fBPixelId, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutFBPixelIdByPKAsync(string channelID, string fBPixelId, TransactionManager tm_ = null)
		{
			RepairPutFBPixelIdByPKData(channelID, fBPixelId, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutFBPixelIdByPKData(string channelID, string fBPixelId, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `FBPixelId` = @FBPixelId  WHERE `ChannelID` = @ChannelID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@FBPixelId", fBPixelId != null ? fBPixelId : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ChannelID", channelID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "fBPixelId">facebook pixelid</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutFBPixelId(string fBPixelId, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `FBPixelId` = @FBPixelId";
			var parameter_ = Database.CreateInParameter("@FBPixelId", fBPixelId != null ? fBPixelId : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutFBPixelIdAsync(string fBPixelId, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `FBPixelId` = @FBPixelId";
			var parameter_ = Database.CreateInParameter("@FBPixelId", fBPixelId != null ? fBPixelId : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutFBPixelId
		#region PutFBAccessToken
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "channelID">推广渠道编码</param>
		/// /// <param name = "fBAccessToken">Facebook AccessToken</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutFBAccessTokenByPK(string channelID, string fBAccessToken, TransactionManager tm_ = null)
		{
			RepairPutFBAccessTokenByPKData(channelID, fBAccessToken, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutFBAccessTokenByPKAsync(string channelID, string fBAccessToken, TransactionManager tm_ = null)
		{
			RepairPutFBAccessTokenByPKData(channelID, fBAccessToken, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutFBAccessTokenByPKData(string channelID, string fBAccessToken, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `FBAccessToken` = @FBAccessToken  WHERE `ChannelID` = @ChannelID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@FBAccessToken", fBAccessToken != null ? fBAccessToken : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ChannelID", channelID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "fBAccessToken">Facebook AccessToken</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutFBAccessToken(string fBAccessToken, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `FBAccessToken` = @FBAccessToken";
			var parameter_ = Database.CreateInParameter("@FBAccessToken", fBAccessToken != null ? fBAccessToken : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutFBAccessTokenAsync(string fBAccessToken, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `FBAccessToken` = @FBAccessToken";
			var parameter_ = Database.CreateInParameter("@FBAccessToken", fBAccessToken != null ? fBAccessToken : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutFBAccessToken
		#region PutKwaiConfig
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "channelID">推广渠道编码</param>
		/// /// <param name = "kwaiConfig">快手打点配置</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutKwaiConfigByPK(string channelID, string kwaiConfig, TransactionManager tm_ = null)
		{
			RepairPutKwaiConfigByPKData(channelID, kwaiConfig, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutKwaiConfigByPKAsync(string channelID, string kwaiConfig, TransactionManager tm_ = null)
		{
			RepairPutKwaiConfigByPKData(channelID, kwaiConfig, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutKwaiConfigByPKData(string channelID, string kwaiConfig, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `KwaiConfig` = @KwaiConfig  WHERE `ChannelID` = @ChannelID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@KwaiConfig", kwaiConfig != null ? kwaiConfig : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ChannelID", channelID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "kwaiConfig">快手打点配置</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutKwaiConfig(string kwaiConfig, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `KwaiConfig` = @KwaiConfig";
			var parameter_ = Database.CreateInParameter("@KwaiConfig", kwaiConfig != null ? kwaiConfig : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutKwaiConfigAsync(string kwaiConfig, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `KwaiConfig` = @KwaiConfig";
			var parameter_ = Database.CreateInParameter("@KwaiConfig", kwaiConfig != null ? kwaiConfig : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutKwaiConfig
		#region PutGAKey
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "channelID">推广渠道编码</param>
		/// /// <param name = "gAKey">GA关键字</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutGAKeyByPK(string channelID, string gAKey, TransactionManager tm_ = null)
		{
			RepairPutGAKeyByPKData(channelID, gAKey, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutGAKeyByPKAsync(string channelID, string gAKey, TransactionManager tm_ = null)
		{
			RepairPutGAKeyByPKData(channelID, gAKey, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutGAKeyByPKData(string channelID, string gAKey, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `GAKey` = @GAKey  WHERE `ChannelID` = @ChannelID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@GAKey", gAKey != null ? gAKey : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ChannelID", channelID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "gAKey">GA关键字</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutGAKey(string gAKey, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `GAKey` = @GAKey";
			var parameter_ = Database.CreateInParameter("@GAKey", gAKey != null ? gAKey : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutGAKeyAsync(string gAKey, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `GAKey` = @GAKey";
			var parameter_ = Database.CreateInParameter("@GAKey", gAKey != null ? gAKey : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutGAKey
		#region PutTrackConfigs
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "channelID">推广渠道编码</param>
		/// /// <param name = "trackConfigs">埋点配置信息</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTrackConfigsByPK(string channelID, string trackConfigs, TransactionManager tm_ = null)
		{
			RepairPutTrackConfigsByPKData(channelID, trackConfigs, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutTrackConfigsByPKAsync(string channelID, string trackConfigs, TransactionManager tm_ = null)
		{
			RepairPutTrackConfigsByPKData(channelID, trackConfigs, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutTrackConfigsByPKData(string channelID, string trackConfigs, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `TrackConfigs` = @TrackConfigs  WHERE `ChannelID` = @ChannelID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TrackConfigs", trackConfigs != null ? trackConfigs : (object)DBNull.Value, MySqlDbType.Text),
				Database.CreateInParameter("@ChannelID", channelID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "trackConfigs">埋点配置信息</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTrackConfigs(string trackConfigs, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `TrackConfigs` = @TrackConfigs";
			var parameter_ = Database.CreateInParameter("@TrackConfigs", trackConfigs != null ? trackConfigs : (object)DBNull.Value, MySqlDbType.Text);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutTrackConfigsAsync(string trackConfigs, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `TrackConfigs` = @TrackConfigs";
			var parameter_ = Database.CreateInParameter("@TrackConfigs", trackConfigs != null ? trackConfigs : (object)DBNull.Value, MySqlDbType.Text);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutTrackConfigs
		#region PutNote
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "channelID">推广渠道编码</param>
		/// /// <param name = "note">备注信息</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutNoteByPK(string channelID, string note, TransactionManager tm_ = null)
		{
			RepairPutNoteByPKData(channelID, note, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutNoteByPKAsync(string channelID, string note, TransactionManager tm_ = null)
		{
			RepairPutNoteByPKData(channelID, note, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutNoteByPKData(string channelID, string note, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Note` = @Note  WHERE `ChannelID` = @ChannelID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Note", note != null ? note : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ChannelID", channelID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "note">备注信息</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutNote(string note, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Note` = @Note";
			var parameter_ = Database.CreateInParameter("@Note", note != null ? note : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutNoteAsync(string note, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Note` = @Note";
			var parameter_ = Database.CreateInParameter("@Note", note != null ? note : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutNote
		#region PutStatus
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "channelID">推广渠道编码</param>
		/// /// <param name = "status">状态(0-无效1-有效)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutStatusByPK(string channelID, int status, TransactionManager tm_ = null)
		{
			RepairPutStatusByPKData(channelID, status, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutStatusByPKAsync(string channelID, int status, TransactionManager tm_ = null)
		{
			RepairPutStatusByPKData(channelID, status, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutStatusByPKData(string channelID, int status, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Status` = @Status  WHERE `ChannelID` = @ChannelID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Status", status, MySqlDbType.Int32),
				Database.CreateInParameter("@ChannelID", channelID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "status">状态(0-无效1-有效)</param>
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
		/// /// <param name = "channelID">推广渠道编码</param>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRecDateByPK(string channelID, DateTime recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(channelID, recDate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutRecDateByPKAsync(string channelID, DateTime recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(channelID, recDate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutRecDateByPKData(string channelID, DateTime recDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `RecDate` = @RecDate  WHERE `ChannelID` = @ChannelID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime),
				Database.CreateInParameter("@ChannelID", channelID, MySqlDbType.VarChar),
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
		public bool Set(S_channelEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.ChannelID) == null)
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
		public async Task<bool> SetAsync(S_channelEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.ChannelID) == null)
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
		/// /// <param name = "channelID">推广渠道编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public S_channelEO GetByPK(string channelID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(channelID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, S_channelEO.MapDataReader);
		}
		public async Task<S_channelEO> GetByPKAsync(string channelID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(channelID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, S_channelEO.MapDataReader);
		}
		private void RepairGetByPKData(string channelID, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false, TransactionManager tm_ = null)
		{
			sql_ = BuildSelectSQL("`ChannelID` = @ChannelID", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChannelID", channelID, MySqlDbType.VarChar),
			};
		}
		#endregion // GetByPK
		
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 OperatorID（字段）
		/// </summary>
		/// /// <param name = "channelID">推广渠道编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetOperatorIDByPK(string channelID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChannelID", channelID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`OperatorID`", "`ChannelID` = @ChannelID", paras_, tm_);
		}
		public async Task<string> GetOperatorIDByPKAsync(string channelID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChannelID", channelID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`OperatorID`", "`ChannelID` = @ChannelID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 CName（字段）
		/// </summary>
		/// /// <param name = "channelID">推广渠道编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetCNameByPK(string channelID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChannelID", channelID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`CName`", "`ChannelID` = @ChannelID", paras_, tm_);
		}
		public async Task<string> GetCNameByPKAsync(string channelID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChannelID", channelID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`CName`", "`ChannelID` = @ChannelID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 CType（字段）
		/// </summary>
		/// /// <param name = "channelID">推广渠道编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetCTypeByPK(string channelID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChannelID", channelID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`CType`", "`ChannelID` = @ChannelID", paras_, tm_);
		}
		public async Task<int> GetCTypeByPKAsync(string channelID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChannelID", channelID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`CType`", "`ChannelID` = @ChannelID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 BranchKey（字段）
		/// </summary>
		/// /// <param name = "channelID">推广渠道编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetBranchKeyByPK(string channelID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChannelID", channelID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`BranchKey`", "`ChannelID` = @ChannelID", paras_, tm_);
		}
		public async Task<string> GetBranchKeyByPKAsync(string channelID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChannelID", channelID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`BranchKey`", "`ChannelID` = @ChannelID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 FBPixelId（字段）
		/// </summary>
		/// /// <param name = "channelID">推广渠道编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetFBPixelIdByPK(string channelID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChannelID", channelID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`FBPixelId`", "`ChannelID` = @ChannelID", paras_, tm_);
		}
		public async Task<string> GetFBPixelIdByPKAsync(string channelID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChannelID", channelID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`FBPixelId`", "`ChannelID` = @ChannelID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 FBAccessToken（字段）
		/// </summary>
		/// /// <param name = "channelID">推广渠道编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetFBAccessTokenByPK(string channelID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChannelID", channelID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`FBAccessToken`", "`ChannelID` = @ChannelID", paras_, tm_);
		}
		public async Task<string> GetFBAccessTokenByPKAsync(string channelID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChannelID", channelID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`FBAccessToken`", "`ChannelID` = @ChannelID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 KwaiConfig（字段）
		/// </summary>
		/// /// <param name = "channelID">推广渠道编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetKwaiConfigByPK(string channelID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChannelID", channelID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`KwaiConfig`", "`ChannelID` = @ChannelID", paras_, tm_);
		}
		public async Task<string> GetKwaiConfigByPKAsync(string channelID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChannelID", channelID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`KwaiConfig`", "`ChannelID` = @ChannelID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 GAKey（字段）
		/// </summary>
		/// /// <param name = "channelID">推广渠道编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetGAKeyByPK(string channelID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChannelID", channelID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`GAKey`", "`ChannelID` = @ChannelID", paras_, tm_);
		}
		public async Task<string> GetGAKeyByPKAsync(string channelID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChannelID", channelID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`GAKey`", "`ChannelID` = @ChannelID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 TrackConfigs（字段）
		/// </summary>
		/// /// <param name = "channelID">推广渠道编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetTrackConfigsByPK(string channelID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChannelID", channelID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`TrackConfigs`", "`ChannelID` = @ChannelID", paras_, tm_);
		}
		public async Task<string> GetTrackConfigsByPKAsync(string channelID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChannelID", channelID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`TrackConfigs`", "`ChannelID` = @ChannelID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Note（字段）
		/// </summary>
		/// /// <param name = "channelID">推广渠道编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetNoteByPK(string channelID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChannelID", channelID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`Note`", "`ChannelID` = @ChannelID", paras_, tm_);
		}
		public async Task<string> GetNoteByPKAsync(string channelID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChannelID", channelID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`Note`", "`ChannelID` = @ChannelID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Status（字段）
		/// </summary>
		/// /// <param name = "channelID">推广渠道编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetStatusByPK(string channelID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChannelID", channelID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`Status`", "`ChannelID` = @ChannelID", paras_, tm_);
		}
		public async Task<int> GetStatusByPKAsync(string channelID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChannelID", channelID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`Status`", "`ChannelID` = @ChannelID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 RecDate（字段）
		/// </summary>
		/// /// <param name = "channelID">推广渠道编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime GetRecDateByPK(string channelID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChannelID", channelID, MySqlDbType.VarChar),
			};
			return (DateTime)GetScalar("`RecDate`", "`ChannelID` = @ChannelID", paras_, tm_);
		}
		public async Task<DateTime> GetRecDateByPKAsync(string channelID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChannelID", channelID, MySqlDbType.VarChar),
			};
			return (DateTime)await GetScalarAsync("`RecDate`", "`ChannelID` = @ChannelID", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByOperatorID
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <return>实体对象集合</return>
		public List<S_channelEO> GetByOperatorID(string operatorID)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, null);
		}
		public async Task<List<S_channelEO>> GetByOperatorIDAsync(string operatorID)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_channelEO> GetByOperatorID(string operatorID, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, tm_);
		}
		public async Task<List<S_channelEO>> GetByOperatorIDAsync(string operatorID, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_channelEO> GetByOperatorID(string operatorID, int top_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, null);
		}
		public async Task<List<S_channelEO>> GetByOperatorIDAsync(string operatorID, int top_)
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
		public List<S_channelEO> GetByOperatorID(string operatorID, int top_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, tm_);
		}
		public async Task<List<S_channelEO>> GetByOperatorIDAsync(string operatorID, int top_, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_channelEO> GetByOperatorID(string operatorID, string sort_)
		{
			return GetByOperatorID(operatorID, 0, sort_, null);
		}
		public async Task<List<S_channelEO>> GetByOperatorIDAsync(string operatorID, string sort_)
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
		public List<S_channelEO> GetByOperatorID(string operatorID, string sort_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, sort_, tm_);
		}
		public async Task<List<S_channelEO>> GetByOperatorIDAsync(string operatorID, string sort_, TransactionManager tm_)
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
		public List<S_channelEO> GetByOperatorID(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(operatorID != null ? "`OperatorID` = @OperatorID" : "`OperatorID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (operatorID != null)
				paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_channelEO.MapDataReader);
		}
		public async Task<List<S_channelEO>> GetByOperatorIDAsync(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(operatorID != null ? "`OperatorID` = @OperatorID" : "`OperatorID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (operatorID != null)
				paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_channelEO.MapDataReader);
		}
		#endregion // GetByOperatorID
		#region GetByCName
		
		/// <summary>
		/// 按 CName（字段） 查询
		/// </summary>
		/// /// <param name = "cName">渠道名称</param>
		/// <return>实体对象集合</return>
		public List<S_channelEO> GetByCName(string cName)
		{
			return GetByCName(cName, 0, string.Empty, null);
		}
		public async Task<List<S_channelEO>> GetByCNameAsync(string cName)
		{
			return await GetByCNameAsync(cName, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CName（字段） 查询
		/// </summary>
		/// /// <param name = "cName">渠道名称</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_channelEO> GetByCName(string cName, TransactionManager tm_)
		{
			return GetByCName(cName, 0, string.Empty, tm_);
		}
		public async Task<List<S_channelEO>> GetByCNameAsync(string cName, TransactionManager tm_)
		{
			return await GetByCNameAsync(cName, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CName（字段） 查询
		/// </summary>
		/// /// <param name = "cName">渠道名称</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_channelEO> GetByCName(string cName, int top_)
		{
			return GetByCName(cName, top_, string.Empty, null);
		}
		public async Task<List<S_channelEO>> GetByCNameAsync(string cName, int top_)
		{
			return await GetByCNameAsync(cName, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CName（字段） 查询
		/// </summary>
		/// /// <param name = "cName">渠道名称</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_channelEO> GetByCName(string cName, int top_, TransactionManager tm_)
		{
			return GetByCName(cName, top_, string.Empty, tm_);
		}
		public async Task<List<S_channelEO>> GetByCNameAsync(string cName, int top_, TransactionManager tm_)
		{
			return await GetByCNameAsync(cName, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CName（字段） 查询
		/// </summary>
		/// /// <param name = "cName">渠道名称</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_channelEO> GetByCName(string cName, string sort_)
		{
			return GetByCName(cName, 0, sort_, null);
		}
		public async Task<List<S_channelEO>> GetByCNameAsync(string cName, string sort_)
		{
			return await GetByCNameAsync(cName, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 CName（字段） 查询
		/// </summary>
		/// /// <param name = "cName">渠道名称</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_channelEO> GetByCName(string cName, string sort_, TransactionManager tm_)
		{
			return GetByCName(cName, 0, sort_, tm_);
		}
		public async Task<List<S_channelEO>> GetByCNameAsync(string cName, string sort_, TransactionManager tm_)
		{
			return await GetByCNameAsync(cName, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 CName（字段） 查询
		/// </summary>
		/// /// <param name = "cName">渠道名称</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_channelEO> GetByCName(string cName, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(cName != null ? "`CName` = @CName" : "`CName` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (cName != null)
				paras_.Add(Database.CreateInParameter("@CName", cName, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_channelEO.MapDataReader);
		}
		public async Task<List<S_channelEO>> GetByCNameAsync(string cName, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(cName != null ? "`CName` = @CName" : "`CName` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (cName != null)
				paras_.Add(Database.CreateInParameter("@CName", cName, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_channelEO.MapDataReader);
		}
		#endregion // GetByCName
		#region GetByCType
		
		/// <summary>
		/// 按 CType（字段） 查询
		/// </summary>
		/// /// <param name = "cType">渠道类型（0-公司1-个人）</param>
		/// <return>实体对象集合</return>
		public List<S_channelEO> GetByCType(int cType)
		{
			return GetByCType(cType, 0, string.Empty, null);
		}
		public async Task<List<S_channelEO>> GetByCTypeAsync(int cType)
		{
			return await GetByCTypeAsync(cType, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CType（字段） 查询
		/// </summary>
		/// /// <param name = "cType">渠道类型（0-公司1-个人）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_channelEO> GetByCType(int cType, TransactionManager tm_)
		{
			return GetByCType(cType, 0, string.Empty, tm_);
		}
		public async Task<List<S_channelEO>> GetByCTypeAsync(int cType, TransactionManager tm_)
		{
			return await GetByCTypeAsync(cType, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CType（字段） 查询
		/// </summary>
		/// /// <param name = "cType">渠道类型（0-公司1-个人）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_channelEO> GetByCType(int cType, int top_)
		{
			return GetByCType(cType, top_, string.Empty, null);
		}
		public async Task<List<S_channelEO>> GetByCTypeAsync(int cType, int top_)
		{
			return await GetByCTypeAsync(cType, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CType（字段） 查询
		/// </summary>
		/// /// <param name = "cType">渠道类型（0-公司1-个人）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_channelEO> GetByCType(int cType, int top_, TransactionManager tm_)
		{
			return GetByCType(cType, top_, string.Empty, tm_);
		}
		public async Task<List<S_channelEO>> GetByCTypeAsync(int cType, int top_, TransactionManager tm_)
		{
			return await GetByCTypeAsync(cType, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CType（字段） 查询
		/// </summary>
		/// /// <param name = "cType">渠道类型（0-公司1-个人）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_channelEO> GetByCType(int cType, string sort_)
		{
			return GetByCType(cType, 0, sort_, null);
		}
		public async Task<List<S_channelEO>> GetByCTypeAsync(int cType, string sort_)
		{
			return await GetByCTypeAsync(cType, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 CType（字段） 查询
		/// </summary>
		/// /// <param name = "cType">渠道类型（0-公司1-个人）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_channelEO> GetByCType(int cType, string sort_, TransactionManager tm_)
		{
			return GetByCType(cType, 0, sort_, tm_);
		}
		public async Task<List<S_channelEO>> GetByCTypeAsync(int cType, string sort_, TransactionManager tm_)
		{
			return await GetByCTypeAsync(cType, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 CType（字段） 查询
		/// </summary>
		/// /// <param name = "cType">渠道类型（0-公司1-个人）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_channelEO> GetByCType(int cType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CType` = @CType", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CType", cType, MySqlDbType.Byte));
			return Database.ExecSqlList(sql_, paras_, tm_, S_channelEO.MapDataReader);
		}
		public async Task<List<S_channelEO>> GetByCTypeAsync(int cType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CType` = @CType", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CType", cType, MySqlDbType.Byte));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_channelEO.MapDataReader);
		}
		#endregion // GetByCType
		#region GetByBranchKey
		
		/// <summary>
		/// 按 BranchKey（字段） 查询
		/// </summary>
		/// /// <param name = "branchKey">branch关键字</param>
		/// <return>实体对象集合</return>
		public List<S_channelEO> GetByBranchKey(string branchKey)
		{
			return GetByBranchKey(branchKey, 0, string.Empty, null);
		}
		public async Task<List<S_channelEO>> GetByBranchKeyAsync(string branchKey)
		{
			return await GetByBranchKeyAsync(branchKey, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BranchKey（字段） 查询
		/// </summary>
		/// /// <param name = "branchKey">branch关键字</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_channelEO> GetByBranchKey(string branchKey, TransactionManager tm_)
		{
			return GetByBranchKey(branchKey, 0, string.Empty, tm_);
		}
		public async Task<List<S_channelEO>> GetByBranchKeyAsync(string branchKey, TransactionManager tm_)
		{
			return await GetByBranchKeyAsync(branchKey, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BranchKey（字段） 查询
		/// </summary>
		/// /// <param name = "branchKey">branch关键字</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_channelEO> GetByBranchKey(string branchKey, int top_)
		{
			return GetByBranchKey(branchKey, top_, string.Empty, null);
		}
		public async Task<List<S_channelEO>> GetByBranchKeyAsync(string branchKey, int top_)
		{
			return await GetByBranchKeyAsync(branchKey, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BranchKey（字段） 查询
		/// </summary>
		/// /// <param name = "branchKey">branch关键字</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_channelEO> GetByBranchKey(string branchKey, int top_, TransactionManager tm_)
		{
			return GetByBranchKey(branchKey, top_, string.Empty, tm_);
		}
		public async Task<List<S_channelEO>> GetByBranchKeyAsync(string branchKey, int top_, TransactionManager tm_)
		{
			return await GetByBranchKeyAsync(branchKey, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BranchKey（字段） 查询
		/// </summary>
		/// /// <param name = "branchKey">branch关键字</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_channelEO> GetByBranchKey(string branchKey, string sort_)
		{
			return GetByBranchKey(branchKey, 0, sort_, null);
		}
		public async Task<List<S_channelEO>> GetByBranchKeyAsync(string branchKey, string sort_)
		{
			return await GetByBranchKeyAsync(branchKey, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 BranchKey（字段） 查询
		/// </summary>
		/// /// <param name = "branchKey">branch关键字</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_channelEO> GetByBranchKey(string branchKey, string sort_, TransactionManager tm_)
		{
			return GetByBranchKey(branchKey, 0, sort_, tm_);
		}
		public async Task<List<S_channelEO>> GetByBranchKeyAsync(string branchKey, string sort_, TransactionManager tm_)
		{
			return await GetByBranchKeyAsync(branchKey, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 BranchKey（字段） 查询
		/// </summary>
		/// /// <param name = "branchKey">branch关键字</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_channelEO> GetByBranchKey(string branchKey, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(branchKey != null ? "`BranchKey` = @BranchKey" : "`BranchKey` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (branchKey != null)
				paras_.Add(Database.CreateInParameter("@BranchKey", branchKey, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_channelEO.MapDataReader);
		}
		public async Task<List<S_channelEO>> GetByBranchKeyAsync(string branchKey, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(branchKey != null ? "`BranchKey` = @BranchKey" : "`BranchKey` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (branchKey != null)
				paras_.Add(Database.CreateInParameter("@BranchKey", branchKey, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_channelEO.MapDataReader);
		}
		#endregion // GetByBranchKey
		#region GetByFBPixelId
		
		/// <summary>
		/// 按 FBPixelId（字段） 查询
		/// </summary>
		/// /// <param name = "fBPixelId">facebook pixelid</param>
		/// <return>实体对象集合</return>
		public List<S_channelEO> GetByFBPixelId(string fBPixelId)
		{
			return GetByFBPixelId(fBPixelId, 0, string.Empty, null);
		}
		public async Task<List<S_channelEO>> GetByFBPixelIdAsync(string fBPixelId)
		{
			return await GetByFBPixelIdAsync(fBPixelId, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 FBPixelId（字段） 查询
		/// </summary>
		/// /// <param name = "fBPixelId">facebook pixelid</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_channelEO> GetByFBPixelId(string fBPixelId, TransactionManager tm_)
		{
			return GetByFBPixelId(fBPixelId, 0, string.Empty, tm_);
		}
		public async Task<List<S_channelEO>> GetByFBPixelIdAsync(string fBPixelId, TransactionManager tm_)
		{
			return await GetByFBPixelIdAsync(fBPixelId, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FBPixelId（字段） 查询
		/// </summary>
		/// /// <param name = "fBPixelId">facebook pixelid</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_channelEO> GetByFBPixelId(string fBPixelId, int top_)
		{
			return GetByFBPixelId(fBPixelId, top_, string.Empty, null);
		}
		public async Task<List<S_channelEO>> GetByFBPixelIdAsync(string fBPixelId, int top_)
		{
			return await GetByFBPixelIdAsync(fBPixelId, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 FBPixelId（字段） 查询
		/// </summary>
		/// /// <param name = "fBPixelId">facebook pixelid</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_channelEO> GetByFBPixelId(string fBPixelId, int top_, TransactionManager tm_)
		{
			return GetByFBPixelId(fBPixelId, top_, string.Empty, tm_);
		}
		public async Task<List<S_channelEO>> GetByFBPixelIdAsync(string fBPixelId, int top_, TransactionManager tm_)
		{
			return await GetByFBPixelIdAsync(fBPixelId, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FBPixelId（字段） 查询
		/// </summary>
		/// /// <param name = "fBPixelId">facebook pixelid</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_channelEO> GetByFBPixelId(string fBPixelId, string sort_)
		{
			return GetByFBPixelId(fBPixelId, 0, sort_, null);
		}
		public async Task<List<S_channelEO>> GetByFBPixelIdAsync(string fBPixelId, string sort_)
		{
			return await GetByFBPixelIdAsync(fBPixelId, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 FBPixelId（字段） 查询
		/// </summary>
		/// /// <param name = "fBPixelId">facebook pixelid</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_channelEO> GetByFBPixelId(string fBPixelId, string sort_, TransactionManager tm_)
		{
			return GetByFBPixelId(fBPixelId, 0, sort_, tm_);
		}
		public async Task<List<S_channelEO>> GetByFBPixelIdAsync(string fBPixelId, string sort_, TransactionManager tm_)
		{
			return await GetByFBPixelIdAsync(fBPixelId, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 FBPixelId（字段） 查询
		/// </summary>
		/// /// <param name = "fBPixelId">facebook pixelid</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_channelEO> GetByFBPixelId(string fBPixelId, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(fBPixelId != null ? "`FBPixelId` = @FBPixelId" : "`FBPixelId` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (fBPixelId != null)
				paras_.Add(Database.CreateInParameter("@FBPixelId", fBPixelId, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_channelEO.MapDataReader);
		}
		public async Task<List<S_channelEO>> GetByFBPixelIdAsync(string fBPixelId, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(fBPixelId != null ? "`FBPixelId` = @FBPixelId" : "`FBPixelId` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (fBPixelId != null)
				paras_.Add(Database.CreateInParameter("@FBPixelId", fBPixelId, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_channelEO.MapDataReader);
		}
		#endregion // GetByFBPixelId
		#region GetByFBAccessToken
		
		/// <summary>
		/// 按 FBAccessToken（字段） 查询
		/// </summary>
		/// /// <param name = "fBAccessToken">Facebook AccessToken</param>
		/// <return>实体对象集合</return>
		public List<S_channelEO> GetByFBAccessToken(string fBAccessToken)
		{
			return GetByFBAccessToken(fBAccessToken, 0, string.Empty, null);
		}
		public async Task<List<S_channelEO>> GetByFBAccessTokenAsync(string fBAccessToken)
		{
			return await GetByFBAccessTokenAsync(fBAccessToken, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 FBAccessToken（字段） 查询
		/// </summary>
		/// /// <param name = "fBAccessToken">Facebook AccessToken</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_channelEO> GetByFBAccessToken(string fBAccessToken, TransactionManager tm_)
		{
			return GetByFBAccessToken(fBAccessToken, 0, string.Empty, tm_);
		}
		public async Task<List<S_channelEO>> GetByFBAccessTokenAsync(string fBAccessToken, TransactionManager tm_)
		{
			return await GetByFBAccessTokenAsync(fBAccessToken, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FBAccessToken（字段） 查询
		/// </summary>
		/// /// <param name = "fBAccessToken">Facebook AccessToken</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_channelEO> GetByFBAccessToken(string fBAccessToken, int top_)
		{
			return GetByFBAccessToken(fBAccessToken, top_, string.Empty, null);
		}
		public async Task<List<S_channelEO>> GetByFBAccessTokenAsync(string fBAccessToken, int top_)
		{
			return await GetByFBAccessTokenAsync(fBAccessToken, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 FBAccessToken（字段） 查询
		/// </summary>
		/// /// <param name = "fBAccessToken">Facebook AccessToken</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_channelEO> GetByFBAccessToken(string fBAccessToken, int top_, TransactionManager tm_)
		{
			return GetByFBAccessToken(fBAccessToken, top_, string.Empty, tm_);
		}
		public async Task<List<S_channelEO>> GetByFBAccessTokenAsync(string fBAccessToken, int top_, TransactionManager tm_)
		{
			return await GetByFBAccessTokenAsync(fBAccessToken, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FBAccessToken（字段） 查询
		/// </summary>
		/// /// <param name = "fBAccessToken">Facebook AccessToken</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_channelEO> GetByFBAccessToken(string fBAccessToken, string sort_)
		{
			return GetByFBAccessToken(fBAccessToken, 0, sort_, null);
		}
		public async Task<List<S_channelEO>> GetByFBAccessTokenAsync(string fBAccessToken, string sort_)
		{
			return await GetByFBAccessTokenAsync(fBAccessToken, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 FBAccessToken（字段） 查询
		/// </summary>
		/// /// <param name = "fBAccessToken">Facebook AccessToken</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_channelEO> GetByFBAccessToken(string fBAccessToken, string sort_, TransactionManager tm_)
		{
			return GetByFBAccessToken(fBAccessToken, 0, sort_, tm_);
		}
		public async Task<List<S_channelEO>> GetByFBAccessTokenAsync(string fBAccessToken, string sort_, TransactionManager tm_)
		{
			return await GetByFBAccessTokenAsync(fBAccessToken, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 FBAccessToken（字段） 查询
		/// </summary>
		/// /// <param name = "fBAccessToken">Facebook AccessToken</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_channelEO> GetByFBAccessToken(string fBAccessToken, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(fBAccessToken != null ? "`FBAccessToken` = @FBAccessToken" : "`FBAccessToken` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (fBAccessToken != null)
				paras_.Add(Database.CreateInParameter("@FBAccessToken", fBAccessToken, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_channelEO.MapDataReader);
		}
		public async Task<List<S_channelEO>> GetByFBAccessTokenAsync(string fBAccessToken, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(fBAccessToken != null ? "`FBAccessToken` = @FBAccessToken" : "`FBAccessToken` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (fBAccessToken != null)
				paras_.Add(Database.CreateInParameter("@FBAccessToken", fBAccessToken, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_channelEO.MapDataReader);
		}
		#endregion // GetByFBAccessToken
		#region GetByKwaiConfig
		
		/// <summary>
		/// 按 KwaiConfig（字段） 查询
		/// </summary>
		/// /// <param name = "kwaiConfig">快手打点配置</param>
		/// <return>实体对象集合</return>
		public List<S_channelEO> GetByKwaiConfig(string kwaiConfig)
		{
			return GetByKwaiConfig(kwaiConfig, 0, string.Empty, null);
		}
		public async Task<List<S_channelEO>> GetByKwaiConfigAsync(string kwaiConfig)
		{
			return await GetByKwaiConfigAsync(kwaiConfig, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 KwaiConfig（字段） 查询
		/// </summary>
		/// /// <param name = "kwaiConfig">快手打点配置</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_channelEO> GetByKwaiConfig(string kwaiConfig, TransactionManager tm_)
		{
			return GetByKwaiConfig(kwaiConfig, 0, string.Empty, tm_);
		}
		public async Task<List<S_channelEO>> GetByKwaiConfigAsync(string kwaiConfig, TransactionManager tm_)
		{
			return await GetByKwaiConfigAsync(kwaiConfig, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 KwaiConfig（字段） 查询
		/// </summary>
		/// /// <param name = "kwaiConfig">快手打点配置</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_channelEO> GetByKwaiConfig(string kwaiConfig, int top_)
		{
			return GetByKwaiConfig(kwaiConfig, top_, string.Empty, null);
		}
		public async Task<List<S_channelEO>> GetByKwaiConfigAsync(string kwaiConfig, int top_)
		{
			return await GetByKwaiConfigAsync(kwaiConfig, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 KwaiConfig（字段） 查询
		/// </summary>
		/// /// <param name = "kwaiConfig">快手打点配置</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_channelEO> GetByKwaiConfig(string kwaiConfig, int top_, TransactionManager tm_)
		{
			return GetByKwaiConfig(kwaiConfig, top_, string.Empty, tm_);
		}
		public async Task<List<S_channelEO>> GetByKwaiConfigAsync(string kwaiConfig, int top_, TransactionManager tm_)
		{
			return await GetByKwaiConfigAsync(kwaiConfig, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 KwaiConfig（字段） 查询
		/// </summary>
		/// /// <param name = "kwaiConfig">快手打点配置</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_channelEO> GetByKwaiConfig(string kwaiConfig, string sort_)
		{
			return GetByKwaiConfig(kwaiConfig, 0, sort_, null);
		}
		public async Task<List<S_channelEO>> GetByKwaiConfigAsync(string kwaiConfig, string sort_)
		{
			return await GetByKwaiConfigAsync(kwaiConfig, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 KwaiConfig（字段） 查询
		/// </summary>
		/// /// <param name = "kwaiConfig">快手打点配置</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_channelEO> GetByKwaiConfig(string kwaiConfig, string sort_, TransactionManager tm_)
		{
			return GetByKwaiConfig(kwaiConfig, 0, sort_, tm_);
		}
		public async Task<List<S_channelEO>> GetByKwaiConfigAsync(string kwaiConfig, string sort_, TransactionManager tm_)
		{
			return await GetByKwaiConfigAsync(kwaiConfig, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 KwaiConfig（字段） 查询
		/// </summary>
		/// /// <param name = "kwaiConfig">快手打点配置</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_channelEO> GetByKwaiConfig(string kwaiConfig, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(kwaiConfig != null ? "`KwaiConfig` = @KwaiConfig" : "`KwaiConfig` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (kwaiConfig != null)
				paras_.Add(Database.CreateInParameter("@KwaiConfig", kwaiConfig, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_channelEO.MapDataReader);
		}
		public async Task<List<S_channelEO>> GetByKwaiConfigAsync(string kwaiConfig, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(kwaiConfig != null ? "`KwaiConfig` = @KwaiConfig" : "`KwaiConfig` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (kwaiConfig != null)
				paras_.Add(Database.CreateInParameter("@KwaiConfig", kwaiConfig, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_channelEO.MapDataReader);
		}
		#endregion // GetByKwaiConfig
		#region GetByGAKey
		
		/// <summary>
		/// 按 GAKey（字段） 查询
		/// </summary>
		/// /// <param name = "gAKey">GA关键字</param>
		/// <return>实体对象集合</return>
		public List<S_channelEO> GetByGAKey(string gAKey)
		{
			return GetByGAKey(gAKey, 0, string.Empty, null);
		}
		public async Task<List<S_channelEO>> GetByGAKeyAsync(string gAKey)
		{
			return await GetByGAKeyAsync(gAKey, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 GAKey（字段） 查询
		/// </summary>
		/// /// <param name = "gAKey">GA关键字</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_channelEO> GetByGAKey(string gAKey, TransactionManager tm_)
		{
			return GetByGAKey(gAKey, 0, string.Empty, tm_);
		}
		public async Task<List<S_channelEO>> GetByGAKeyAsync(string gAKey, TransactionManager tm_)
		{
			return await GetByGAKeyAsync(gAKey, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 GAKey（字段） 查询
		/// </summary>
		/// /// <param name = "gAKey">GA关键字</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_channelEO> GetByGAKey(string gAKey, int top_)
		{
			return GetByGAKey(gAKey, top_, string.Empty, null);
		}
		public async Task<List<S_channelEO>> GetByGAKeyAsync(string gAKey, int top_)
		{
			return await GetByGAKeyAsync(gAKey, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 GAKey（字段） 查询
		/// </summary>
		/// /// <param name = "gAKey">GA关键字</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_channelEO> GetByGAKey(string gAKey, int top_, TransactionManager tm_)
		{
			return GetByGAKey(gAKey, top_, string.Empty, tm_);
		}
		public async Task<List<S_channelEO>> GetByGAKeyAsync(string gAKey, int top_, TransactionManager tm_)
		{
			return await GetByGAKeyAsync(gAKey, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 GAKey（字段） 查询
		/// </summary>
		/// /// <param name = "gAKey">GA关键字</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_channelEO> GetByGAKey(string gAKey, string sort_)
		{
			return GetByGAKey(gAKey, 0, sort_, null);
		}
		public async Task<List<S_channelEO>> GetByGAKeyAsync(string gAKey, string sort_)
		{
			return await GetByGAKeyAsync(gAKey, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 GAKey（字段） 查询
		/// </summary>
		/// /// <param name = "gAKey">GA关键字</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_channelEO> GetByGAKey(string gAKey, string sort_, TransactionManager tm_)
		{
			return GetByGAKey(gAKey, 0, sort_, tm_);
		}
		public async Task<List<S_channelEO>> GetByGAKeyAsync(string gAKey, string sort_, TransactionManager tm_)
		{
			return await GetByGAKeyAsync(gAKey, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 GAKey（字段） 查询
		/// </summary>
		/// /// <param name = "gAKey">GA关键字</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_channelEO> GetByGAKey(string gAKey, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(gAKey != null ? "`GAKey` = @GAKey" : "`GAKey` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (gAKey != null)
				paras_.Add(Database.CreateInParameter("@GAKey", gAKey, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_channelEO.MapDataReader);
		}
		public async Task<List<S_channelEO>> GetByGAKeyAsync(string gAKey, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(gAKey != null ? "`GAKey` = @GAKey" : "`GAKey` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (gAKey != null)
				paras_.Add(Database.CreateInParameter("@GAKey", gAKey, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_channelEO.MapDataReader);
		}
		#endregion // GetByGAKey
		#region GetByTrackConfigs
		
		/// <summary>
		/// 按 TrackConfigs（字段） 查询
		/// </summary>
		/// /// <param name = "trackConfigs">埋点配置信息</param>
		/// <return>实体对象集合</return>
		public List<S_channelEO> GetByTrackConfigs(string trackConfigs)
		{
			return GetByTrackConfigs(trackConfigs, 0, string.Empty, null);
		}
		public async Task<List<S_channelEO>> GetByTrackConfigsAsync(string trackConfigs)
		{
			return await GetByTrackConfigsAsync(trackConfigs, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 TrackConfigs（字段） 查询
		/// </summary>
		/// /// <param name = "trackConfigs">埋点配置信息</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_channelEO> GetByTrackConfigs(string trackConfigs, TransactionManager tm_)
		{
			return GetByTrackConfigs(trackConfigs, 0, string.Empty, tm_);
		}
		public async Task<List<S_channelEO>> GetByTrackConfigsAsync(string trackConfigs, TransactionManager tm_)
		{
			return await GetByTrackConfigsAsync(trackConfigs, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 TrackConfigs（字段） 查询
		/// </summary>
		/// /// <param name = "trackConfigs">埋点配置信息</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_channelEO> GetByTrackConfigs(string trackConfigs, int top_)
		{
			return GetByTrackConfigs(trackConfigs, top_, string.Empty, null);
		}
		public async Task<List<S_channelEO>> GetByTrackConfigsAsync(string trackConfigs, int top_)
		{
			return await GetByTrackConfigsAsync(trackConfigs, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 TrackConfigs（字段） 查询
		/// </summary>
		/// /// <param name = "trackConfigs">埋点配置信息</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_channelEO> GetByTrackConfigs(string trackConfigs, int top_, TransactionManager tm_)
		{
			return GetByTrackConfigs(trackConfigs, top_, string.Empty, tm_);
		}
		public async Task<List<S_channelEO>> GetByTrackConfigsAsync(string trackConfigs, int top_, TransactionManager tm_)
		{
			return await GetByTrackConfigsAsync(trackConfigs, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 TrackConfigs（字段） 查询
		/// </summary>
		/// /// <param name = "trackConfigs">埋点配置信息</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_channelEO> GetByTrackConfigs(string trackConfigs, string sort_)
		{
			return GetByTrackConfigs(trackConfigs, 0, sort_, null);
		}
		public async Task<List<S_channelEO>> GetByTrackConfigsAsync(string trackConfigs, string sort_)
		{
			return await GetByTrackConfigsAsync(trackConfigs, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 TrackConfigs（字段） 查询
		/// </summary>
		/// /// <param name = "trackConfigs">埋点配置信息</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_channelEO> GetByTrackConfigs(string trackConfigs, string sort_, TransactionManager tm_)
		{
			return GetByTrackConfigs(trackConfigs, 0, sort_, tm_);
		}
		public async Task<List<S_channelEO>> GetByTrackConfigsAsync(string trackConfigs, string sort_, TransactionManager tm_)
		{
			return await GetByTrackConfigsAsync(trackConfigs, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 TrackConfigs（字段） 查询
		/// </summary>
		/// /// <param name = "trackConfigs">埋点配置信息</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_channelEO> GetByTrackConfigs(string trackConfigs, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(trackConfigs != null ? "`TrackConfigs` = @TrackConfigs" : "`TrackConfigs` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (trackConfigs != null)
				paras_.Add(Database.CreateInParameter("@TrackConfigs", trackConfigs, MySqlDbType.Text));
			return Database.ExecSqlList(sql_, paras_, tm_, S_channelEO.MapDataReader);
		}
		public async Task<List<S_channelEO>> GetByTrackConfigsAsync(string trackConfigs, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(trackConfigs != null ? "`TrackConfigs` = @TrackConfigs" : "`TrackConfigs` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (trackConfigs != null)
				paras_.Add(Database.CreateInParameter("@TrackConfigs", trackConfigs, MySqlDbType.Text));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_channelEO.MapDataReader);
		}
		#endregion // GetByTrackConfigs
		#region GetByNote
		
		/// <summary>
		/// 按 Note（字段） 查询
		/// </summary>
		/// /// <param name = "note">备注信息</param>
		/// <return>实体对象集合</return>
		public List<S_channelEO> GetByNote(string note)
		{
			return GetByNote(note, 0, string.Empty, null);
		}
		public async Task<List<S_channelEO>> GetByNoteAsync(string note)
		{
			return await GetByNoteAsync(note, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Note（字段） 查询
		/// </summary>
		/// /// <param name = "note">备注信息</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_channelEO> GetByNote(string note, TransactionManager tm_)
		{
			return GetByNote(note, 0, string.Empty, tm_);
		}
		public async Task<List<S_channelEO>> GetByNoteAsync(string note, TransactionManager tm_)
		{
			return await GetByNoteAsync(note, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Note（字段） 查询
		/// </summary>
		/// /// <param name = "note">备注信息</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_channelEO> GetByNote(string note, int top_)
		{
			return GetByNote(note, top_, string.Empty, null);
		}
		public async Task<List<S_channelEO>> GetByNoteAsync(string note, int top_)
		{
			return await GetByNoteAsync(note, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Note（字段） 查询
		/// </summary>
		/// /// <param name = "note">备注信息</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_channelEO> GetByNote(string note, int top_, TransactionManager tm_)
		{
			return GetByNote(note, top_, string.Empty, tm_);
		}
		public async Task<List<S_channelEO>> GetByNoteAsync(string note, int top_, TransactionManager tm_)
		{
			return await GetByNoteAsync(note, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Note（字段） 查询
		/// </summary>
		/// /// <param name = "note">备注信息</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_channelEO> GetByNote(string note, string sort_)
		{
			return GetByNote(note, 0, sort_, null);
		}
		public async Task<List<S_channelEO>> GetByNoteAsync(string note, string sort_)
		{
			return await GetByNoteAsync(note, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Note（字段） 查询
		/// </summary>
		/// /// <param name = "note">备注信息</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_channelEO> GetByNote(string note, string sort_, TransactionManager tm_)
		{
			return GetByNote(note, 0, sort_, tm_);
		}
		public async Task<List<S_channelEO>> GetByNoteAsync(string note, string sort_, TransactionManager tm_)
		{
			return await GetByNoteAsync(note, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Note（字段） 查询
		/// </summary>
		/// /// <param name = "note">备注信息</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_channelEO> GetByNote(string note, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(note != null ? "`Note` = @Note" : "`Note` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (note != null)
				paras_.Add(Database.CreateInParameter("@Note", note, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_channelEO.MapDataReader);
		}
		public async Task<List<S_channelEO>> GetByNoteAsync(string note, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(note != null ? "`Note` = @Note" : "`Note` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (note != null)
				paras_.Add(Database.CreateInParameter("@Note", note, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_channelEO.MapDataReader);
		}
		#endregion // GetByNote
		#region GetByStatus
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态(0-无效1-有效)</param>
		/// <return>实体对象集合</return>
		public List<S_channelEO> GetByStatus(int status)
		{
			return GetByStatus(status, 0, string.Empty, null);
		}
		public async Task<List<S_channelEO>> GetByStatusAsync(int status)
		{
			return await GetByStatusAsync(status, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态(0-无效1-有效)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_channelEO> GetByStatus(int status, TransactionManager tm_)
		{
			return GetByStatus(status, 0, string.Empty, tm_);
		}
		public async Task<List<S_channelEO>> GetByStatusAsync(int status, TransactionManager tm_)
		{
			return await GetByStatusAsync(status, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态(0-无效1-有效)</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_channelEO> GetByStatus(int status, int top_)
		{
			return GetByStatus(status, top_, string.Empty, null);
		}
		public async Task<List<S_channelEO>> GetByStatusAsync(int status, int top_)
		{
			return await GetByStatusAsync(status, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态(0-无效1-有效)</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_channelEO> GetByStatus(int status, int top_, TransactionManager tm_)
		{
			return GetByStatus(status, top_, string.Empty, tm_);
		}
		public async Task<List<S_channelEO>> GetByStatusAsync(int status, int top_, TransactionManager tm_)
		{
			return await GetByStatusAsync(status, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态(0-无效1-有效)</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_channelEO> GetByStatus(int status, string sort_)
		{
			return GetByStatus(status, 0, sort_, null);
		}
		public async Task<List<S_channelEO>> GetByStatusAsync(int status, string sort_)
		{
			return await GetByStatusAsync(status, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态(0-无效1-有效)</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_channelEO> GetByStatus(int status, string sort_, TransactionManager tm_)
		{
			return GetByStatus(status, 0, sort_, tm_);
		}
		public async Task<List<S_channelEO>> GetByStatusAsync(int status, string sort_, TransactionManager tm_)
		{
			return await GetByStatusAsync(status, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态(0-无效1-有效)</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_channelEO> GetByStatus(int status, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Status` = @Status", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Status", status, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, S_channelEO.MapDataReader);
		}
		public async Task<List<S_channelEO>> GetByStatusAsync(int status, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Status` = @Status", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Status", status, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_channelEO.MapDataReader);
		}
		#endregion // GetByStatus
		#region GetByRecDate
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <return>实体对象集合</return>
		public List<S_channelEO> GetByRecDate(DateTime recDate)
		{
			return GetByRecDate(recDate, 0, string.Empty, null);
		}
		public async Task<List<S_channelEO>> GetByRecDateAsync(DateTime recDate)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_channelEO> GetByRecDate(DateTime recDate, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, string.Empty, tm_);
		}
		public async Task<List<S_channelEO>> GetByRecDateAsync(DateTime recDate, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_channelEO> GetByRecDate(DateTime recDate, int top_)
		{
			return GetByRecDate(recDate, top_, string.Empty, null);
		}
		public async Task<List<S_channelEO>> GetByRecDateAsync(DateTime recDate, int top_)
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
		public List<S_channelEO> GetByRecDate(DateTime recDate, int top_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, top_, string.Empty, tm_);
		}
		public async Task<List<S_channelEO>> GetByRecDateAsync(DateTime recDate, int top_, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_channelEO> GetByRecDate(DateTime recDate, string sort_)
		{
			return GetByRecDate(recDate, 0, sort_, null);
		}
		public async Task<List<S_channelEO>> GetByRecDateAsync(DateTime recDate, string sort_)
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
		public List<S_channelEO> GetByRecDate(DateTime recDate, string sort_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, sort_, tm_);
		}
		public async Task<List<S_channelEO>> GetByRecDateAsync(DateTime recDate, string sort_, TransactionManager tm_)
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
		public List<S_channelEO> GetByRecDate(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return Database.ExecSqlList(sql_, paras_, tm_, S_channelEO.MapDataReader);
		}
		public async Task<List<S_channelEO>> GetByRecDateAsync(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_channelEO.MapDataReader);
		}
		#endregion // GetByRecDate
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}

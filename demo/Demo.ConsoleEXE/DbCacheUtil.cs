using Demo.ConsoleEXE.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TinyFx;
using TinyFx.DbCaching;

namespace Demo.ConsoleEXE
{
    public class DbCacheUtil
    {
        public static Ss_appEO GetApp(string appId, bool exceptionOnNull = true, string errorCode = null)
        {
            var ret = DbCachingUtil.GetSingle<Ss_appEO>(appId);

            if (ret == null)
            {
                if (exceptionOnNull)
                {
                    if (string.IsNullOrEmpty(errorCode))
                        throw new Exception($"AppId不存在: {appId}");
                    else
                        throw new CustomException(errorCode, $"AppId不存在: {appId}");
                }
                else
                    return null;
            }
            return ret;
        }
        public static Ss_providerEO GetProvider(string providerId, bool excOnNull = true, string errorCode = null)
        {
            var ret = DbCachingUtil.GetSingle<Ss_providerEO>(it => it.ProviderID, providerId);
            if (ret == null)
            {
                if (excOnNull)
                {
                    if (string.IsNullOrEmpty(errorCode))
                        throw new Exception($"providerId不存在: {providerId}");
                    else
                        throw new CustomException(errorCode, $"providerId不存在: {providerId}");
                }
                else
                    return null;
            }
            return ret;
        }
        public static Ss_operator_appEO GetOperatorApp(string operatorId, string appId, bool excOnNull = true, string errorCode = null)
        {
            //var ret = DbCachingUtil.GetSingleByKey<Ss_operator_appEO>($"OperatorID|AppID", $"{operatorId}|{appId}");
            var ret = DbCachingUtil.GetSingle<Ss_operator_appEO>(it => new
            {
                it.OperatorID,
                it.AppID,
            }
            , new Ss_operator_appEO
            {
                OperatorID = operatorId,
                AppID = appId,
            });
            return ret;
        }
    }
}

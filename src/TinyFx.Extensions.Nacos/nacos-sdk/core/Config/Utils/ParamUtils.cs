﻿namespace Nacos.Config.Utils
{
    using Nacos.Common;
    using Nacos.Exceptions;
    using Nacos.Utils;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class ParamUtils
    {
        private static readonly char[] VALID_CHARS = new char[] { '_', '-', '.', ':' };

        private static readonly string CONTENT_INVALID_MSG = "content invalid";

        private static readonly string DATAID_INVALID_MSG = "dataId invalid";

        private static readonly string TENANT_INVALID_MSG = "tenant invalid";

        private static readonly string BETAIPS_INVALID_MSG = "betaIps invalid";

        private static readonly string GROUP_INVALID_MSG = "group invalid";

        private static readonly string DATUMID_INVALID_MSG = "datumId invalid";

        /// <summary>
        /// Check the whitelist method, the legal parameters can only contain letters, numbers, and characters in validChars, and cannot be empty.
        /// </summary>
        /// <param name="param">parameter</param>
        /// <returns>true if valid</returns>
        public static bool IsValid(string param)
        {
            if (param == null) return false;

            int length = param.Length;
            for (int i = 0; i < length; i++)
            {
                char ch = param[i];
                if (!char.IsLetterOrDigit(ch) && !IsValidChar(ch)) return false;
            }

            return true;
        }

        private static bool IsValidChar(char ch)
        {
            foreach (char c in VALID_CHARS)
            {
                if (c == ch) return true;
            }

            return false;
        }

        /// <summary>
        /// Check Tenant, dataId and group.
        /// </summary>
        /// <param name="tenant">tenant</param>
        /// <param name="dataId">dataId</param>
        /// <param name="group">group</param>
        public static void CheckTdg(string tenant, string dataId, string group)
        {
            CheckTenant(tenant);

            CheckDataIds(new List<string> { dataId });

            CheckGroup(group);
        }

        /// <summary>
        /// Check key param.
        /// </summary>
        /// <param name="dataId">dataId</param>
        /// <param name="group">group</param>
        public static void CheckKeyParam(string dataId, string group)
        {
            CheckDataIds(new List<string> { dataId });

            CheckGroup(group);
        }

        /// <summary>
        /// Check key param.
        /// </summary>
        /// <param name="dataId">dataId</param>
        /// <param name="group">group</param>
        /// <param name="datumId">datumId</param>
        public static void CheckKeyParam(string dataId, string group, string datumId)
        {
            CheckDataIds(new List<string> { dataId });

            CheckGroup(group);

            CheckDatumId(datumId);
        }

        /// <summary>
        /// Check key param.
        /// </summary>
        /// <param name="dataIds">dataIds</param>
        /// <param name="group">group</param>
        public static void CheckKeyParam(List<string> dataIds, string group)
        {
            CheckDataIds(dataIds);

            CheckGroup(group);
        }

        /// <summary>
        /// Check parameter.
        /// </summary>
        /// <param name="dataId">dataId</param>
        /// <param name="group">group</param>
        /// <param name="content">content</param>
        public static void CheckParam(string dataId, string group, string content)
        {
            CheckKeyParam(dataId, group);

            CheckContent(content);
        }

        /// <summary>
        /// Check parameter.
        /// </summary>
        /// <param name="dataId">dataId</param>
        /// <param name="group">group</param>
        /// <param name="datumId">datumId</param>
        /// <param name="content">content</param>
        public static void CheckParam(string dataId, string group, string datumId, string content)
        {
            CheckKeyParam(dataId, group, datumId);

            CheckContent(content);
        }

        /// <summary>
        /// Check tenant.
        /// </summary>
        /// <param name="tenant">tenant</param>
        public static void CheckTenant(string tenant)
        {
            if (tenant.IsNullOrWhiteSpace() || !IsValid(tenant))
            {
                throw new NacosException(NacosException.CLIENT_INVALID_PARAM, TENANT_INVALID_MSG);
            }
        }

        /// <summary>
        /// Check dataId list.
        /// </summary>
        /// <param name="dataIds">dataId list</param>
        public static void CheckDataIds(List<string> dataIds)
        {
            if (dataIds == null || !dataIds.Any())
            {
                throw new NacosException(NacosException.CLIENT_INVALID_PARAM, DATAID_INVALID_MSG);
            }

            foreach (var dataId in dataIds)
            {
                if (dataId.IsNullOrWhiteSpace() || !IsValid(dataId))
                {
                    throw new NacosException(NacosException.CLIENT_INVALID_PARAM, DATAID_INVALID_MSG);
                }
            }
        }

        /// <summary>
        /// Check group.
        /// </summary>
        /// <param name="group">group</param>
        public static void CheckGroup(string group)
        {
            if (group.IsNullOrWhiteSpace() || !IsValid(group))
            {
                throw new NacosException(NacosException.CLIENT_INVALID_PARAM, GROUP_INVALID_MSG);
            }
        }

        /// <summary>
        /// Check datumId.
        /// </summary>
        /// <param name="datumId">datumId</param>
        public static void CheckDatumId(string datumId)
        {
            if (datumId.IsNullOrWhiteSpace() || !IsValid(datumId))
            {
                throw new NacosException(NacosException.CLIENT_INVALID_PARAM, DATUMID_INVALID_MSG);
            }
        }

        /// <summary>
        ///  Check beta ips.
        /// </summary>
        /// <param name="betaIps">beta ips</param>
        public static void CheckBetaIps(string betaIps)
        {
            if (betaIps.IsNullOrWhiteSpace())
            {
                throw new NacosException(NacosException.CLIENT_INVALID_PARAM, BETAIPS_INVALID_MSG);
            }

            string[] ipsArr = betaIps.Split(',');
            foreach (var ip in ipsArr)
            {
                if (!IPUtil.IsIP(ip))
                {
                    throw new NacosException(NacosException.CLIENT_INVALID_PARAM, BETAIPS_INVALID_MSG);
                }
            }
        }

        /// <summary>
        /// Check content.
        /// </summary>
        /// <param name="content">content</param>
        public static void CheckContent(string content)
        {
            if (content.IsNullOrWhiteSpace())
            {
                throw new NacosException(NacosException.CLIENT_INVALID_PARAM, CONTENT_INVALID_MSG);
            }
        }

        public static string Null2DefaultGroup(string group) => group == null ? Constants.DEFAULT_GROUP : group.Trim();
    }
}

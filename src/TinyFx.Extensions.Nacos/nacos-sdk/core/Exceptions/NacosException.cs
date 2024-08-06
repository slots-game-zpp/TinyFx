﻿namespace Nacos.Exceptions
{
    using System;

    public class NacosException : Exception
    {
        public NacosException(string message)
            : base(message)
        {
            ErrorMsg = message;
        }

        public NacosException(int code, string message)
            : base(message)
        {
            ErrorCode = code;
            ErrorMsg = message;
        }

        public int ErrorCode { get; set; }

        public string ErrorMsg { get; set; }

        /// <summary>
        /// invalid param（参数错误）.
        /// </summary>
        public static int CLIENT_INVALID_PARAM = -400;

        /// <summary>
        /// client disconnect.
        /// </summary>
        public static int CLIENT_DISCONNECT = -401;

        /// <summary>
        /// over client threshold（超过server端的限流阈值）.
        /// </summary>
        public static int CLIENT_OVER_THRESHOLD = -503;

        /// <summary>
        /// invalid param（参数错误）.
        /// </summary>
        public static int INVALID_PARAM = 400;

        /// <summary>
        /// no right（鉴权失败）.
        /// </summary>
        public static int NO_RIGHT = 403;

        /// <summary>
        /// not found.
        /// </summary>
        public static int NOT_FOUND = 404;

        /// <summary>
        /// conflict（写并发冲突）.
        /// </summary>
        public static int CONFLICT = 409;

        /// <summary>
        /// server error（server异常，如超时）.
        /// </summary>
        public static int SERVER_ERROR = 500;

        /// <summary>
        ///  bad gateway（路由异常，如nginx后面的Server挂掉）.
        /// </summary>
        public static int BAD_GATEWAY = 502;

        /// <summary>
        /// over threshold（超过server端的限流阈值）.
        /// </summary>
        public static int OVER_THRESHOLD = 503;

        /// <summary>
        /// Server is not started.
        /// </summary>
        public static int INVALID_SERVER_STATUS = 300;

        /// <summary>
        /// Connection is not registered.
        /// </summary>
        public static int UN_REGISTER = 301;

        /// <summary>
        /// No Handler Found.
        /// </summary>
        public static int NO_HANDLER = 302;

        public static int RESOURCE_NOT_FOUND = -404;
    }
}

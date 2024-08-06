using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using TinyFx.Net;

namespace TinyFx.Extensions.DotNetty
{
    /// <summary>
    /// protobuf返回客户端的统一结构（无返回数据）
    /// </summary>
    [ProtoContract]
    public class ProtoResponse: IResponseBase
    {
        /// <summary>
        /// 是否成功
        /// </summary>
        [ProtoMember(1)]
        public bool Success { get; set; }
        /// <summary>
        /// 状态码
        /// </summary>
        [ProtoMember(2)]
        public string Code { get; set; }
        /// <summary>
        /// 给客户端的消息
        /// </summary>
        [ProtoMember(3)]
        public string Message { get; set; }
        [ProtoIgnore]
        public Exception Exception { get; set; }
    }

    /// <summary>
    /// protobuf返回客户端的统一结构
    /// </summary>
    /// <typeparam name="T">返回的具体消息</typeparam>
    [ProtoContract]
    public class ProtoResponse<T>: IResponseResult<T>
    {
        /// <summary>
        /// 是否成功
        /// </summary>
        [ProtoMember(1)]
        public bool Success { get; set; }
        /// <summary>
        /// 状态码。0-成功，其他值客户端服务器约定，使用大于0的数
        /// </summary>
        [ProtoMember(2)]
        public string Code { get; set; }
        /// <summary>
        /// 给客户端的消息，也可以提供需要提供给客户端的json数据（与客户端协商）
        /// </summary>
        [ProtoMember(3)]
        public string Message { get; set; }
        /// <summary>
        /// 返回给客户端的数据
        /// </summary>
        [ProtoMember(4)]
        public T Result { get; set; }
        [ProtoIgnore]
        public Exception Exception { get; set; }
        public ProtoResponse()
        {
            Success = true;
        }
        public ProtoResponse(T result)
        {
            Success = true;
            Result = result;
        }

        public static implicit operator ProtoResponse<T>(T value)
        {
            return new ProtoResponse<T>(value);
        }
    }

}

﻿namespace Nacos.Remote.GRpc
{
    using Nacos.Remote;
    using Nacos.Utils;
    using System.Linq;

    public static class GrpcUtils
    {
        public static object Parse(Payload payload)
        {
            var type = payload.Metadata.Type;

            if (!type.Equals(RemoteRequestType.Resp_HealthCheck, System.StringComparison.OrdinalIgnoreCase))
                System.Diagnostics.Trace.WriteLine($"Parse response, type = {type}");

            if (RemoteRequestType.RemoteResponseTypeMapping.TryGetValue(type, out var classType))
            {
                var retStr = payload.Body.Value.ToStringUtf8();
                if (!type.Equals(RemoteRequestType.Resp_HealthCheck, System.StringComparison.OrdinalIgnoreCase))
                    System.Diagnostics.Trace.WriteLine($"parse response result = {retStr} ");

                object obj = retStr.ToObj(classType);

                if (obj is CommonRequest req)
                {
                    foreach (var item in payload.Metadata.Headers) req.PutHeader(item.Key, item.Value);
                }

                return obj;
            }
            else
            {
                System.Console.WriteLine($"Unknown payload type = {type} !!!!!");
                return null;
            }
        }

        public static Payload Convert(CommonRequest request, CommonRequestMeta meta)
        {
            var body = new Google.Protobuf.WellKnownTypes.Any
            {
                // convert the request paramter to a json string, as the body
                Value = Google.Protobuf.ByteString.CopyFromUtf8(request.ToJsonString())
            };

            var payload = new Payload
            {
                Body = body
            };

            if (meta != null)
            {
                payload.Metadata = new Metadata
                {
                    Type = meta.Type,
                    ClientIp = NetUtils.LocalIP(),
                };

                if (request.Headers != null && request.Headers.Any())
                    foreach (var item in request.Headers) payload.Metadata.Headers.Add(item.Key, item.Value);
            }

            return payload;
        }

        public static Payload Convert(CommonResponse response)
        {
            var body = new Google.Protobuf.WellKnownTypes.Any
            {
                // convert the request paramter to a json string, as the body
                Value = Google.Protobuf.ByteString.CopyFromUtf8(response.ToJsonString())
            };

            var payload = new Payload
            {
                Body = body
            };

            payload.Metadata = new Metadata
            {
                Type = response.GetRemoteType(),
            };

            return payload;
        }
    }
}

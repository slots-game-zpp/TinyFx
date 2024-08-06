using Demo.Shared;
using ProtoBuf.Grpc;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Threading.Tasks;

namespace GRPC;

public class GreeterService : IGreeterService
{
    public Task<HelloReply> SayHelloAsync(HelloRequest request, CallContext context = default)
    {
        return Task.FromResult(
                new HelloReply
                {
                    Message = $"Hello {request.Name}"
                });
    }
}
using GrpcLib;
using TinyFx.Configuration;

namespace GrpcDemo1.Services
{
    public class UserService : IUserService
    {
        public async ValueTask<UserDto> Get(UserIpo ipo)
        {
            return new UserDto
            {
                Message = $"{ipo.Id}=> {ConfigUtil.Service.ServiceId}"
            };
        }
    }
}

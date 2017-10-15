using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using tz.saas.Roles.Dto;
using tz.saas.Users.Dto;

namespace tz.saas.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();
    }
}

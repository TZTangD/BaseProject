using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using tzky.saas.Roles.Dto;
using tzky.saas.Users.Dto;

namespace tzky.saas.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();
    }
}

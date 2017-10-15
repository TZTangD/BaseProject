using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using tz.saas.Roles.Dto;

namespace tz.saas.Roles
{
    public interface IRoleAppService : IAsyncCrudAppService<RoleDto, int, PagedResultRequestDto, CreateRoleDto, RoleDto>
    {
        Task<ListResultDto<PermissionDto>> GetAllPermissions();
    }
}

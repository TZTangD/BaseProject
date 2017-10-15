using Abp.Application.Services;
using Abp.Application.Services.Dto;
using tz.saas.MultiTenancy.Dto;

namespace tz.saas.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

using Abp.Application.Services;
using Abp.Application.Services.Dto;
using tzky.saas.MultiTenancy.Dto;

namespace tzky.saas.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

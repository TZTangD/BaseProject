using System.Threading.Tasks;
using Abp.Application.Services;
using tzky.saas.Authorization.Accounts.Dto;

namespace tzky.saas.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}

using System.Threading.Tasks;
using Abp.Application.Services;
using tz.saas.Authorization.Accounts.Dto;

namespace tz.saas.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}

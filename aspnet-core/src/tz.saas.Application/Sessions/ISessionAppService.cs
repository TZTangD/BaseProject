using System.Threading.Tasks;
using Abp.Application.Services;
using tz.saas.Sessions.Dto;

namespace tz.saas.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}

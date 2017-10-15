using System.Threading.Tasks;
using Abp.Application.Services;
using tzky.saas.Sessions.Dto;

namespace tzky.saas.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}

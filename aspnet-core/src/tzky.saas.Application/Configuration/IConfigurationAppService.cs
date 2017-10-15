using System.Threading.Tasks;
using tzky.saas.Configuration.Dto;

namespace tzky.saas.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}

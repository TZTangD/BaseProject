using System.Threading.Tasks;
using tz.saas.Configuration.Dto;

namespace tz.saas.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}

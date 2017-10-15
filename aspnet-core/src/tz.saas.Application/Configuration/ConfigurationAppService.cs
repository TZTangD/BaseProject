using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using tz.saas.Configuration.Dto;

namespace tz.saas.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : saasAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}

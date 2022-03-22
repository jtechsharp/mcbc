using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using mcbc.Configuration.Dto;

namespace mcbc.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : mcbcAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}

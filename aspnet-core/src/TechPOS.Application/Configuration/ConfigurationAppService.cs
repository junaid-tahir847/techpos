using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using TechPOS.Configuration.Dto;

namespace TechPOS.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : TechPOSAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}

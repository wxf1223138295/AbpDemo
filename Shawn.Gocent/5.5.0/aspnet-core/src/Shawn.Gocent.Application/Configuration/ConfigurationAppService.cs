using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Shawn.Gocent.Configuration.Dto;

namespace Shawn.Gocent.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : GocentAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}

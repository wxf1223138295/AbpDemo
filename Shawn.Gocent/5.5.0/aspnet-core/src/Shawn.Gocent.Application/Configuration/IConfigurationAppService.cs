using System.Threading.Tasks;
using Shawn.Gocent.Configuration.Dto;

namespace Shawn.Gocent.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}

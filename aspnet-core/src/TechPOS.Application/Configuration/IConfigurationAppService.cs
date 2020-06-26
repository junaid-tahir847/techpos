using System.Threading.Tasks;
using TechPOS.Configuration.Dto;

namespace TechPOS.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}

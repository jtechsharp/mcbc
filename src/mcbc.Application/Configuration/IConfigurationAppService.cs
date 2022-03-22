using System.Threading.Tasks;
using mcbc.Configuration.Dto;

namespace mcbc.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}

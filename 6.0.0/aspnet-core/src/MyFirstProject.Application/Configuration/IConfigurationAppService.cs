using System.Threading.Tasks;
using MyFirstProject.Configuration.Dto;

namespace MyFirstProject.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}

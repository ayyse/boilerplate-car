using System.Threading.Tasks;
using Abp.Application.Services;
using MyFirstProject.Sessions.Dto;

namespace MyFirstProject.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}

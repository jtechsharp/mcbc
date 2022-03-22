using System.Threading.Tasks;
using Abp.Application.Services;
using mcbc.Sessions.Dto;

namespace mcbc.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}

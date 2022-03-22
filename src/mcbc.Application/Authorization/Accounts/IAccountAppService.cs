using System.Threading.Tasks;
using Abp.Application.Services;
using mcbc.Authorization.Accounts.Dto;

namespace mcbc.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}

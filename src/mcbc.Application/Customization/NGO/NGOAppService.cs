using Abp.Application.Services;
using Abp.Authorization;
using Abp.Domain.Repositories;

namespace mcbc.Customization
{
    [AbpAllowAnonymous]
    public class NGOAppService : AsyncCrudAppService<NGO, NGODto>, INGOAppService
    {
        public NGOAppService(IRepository<NGO> repository)
            : base(repository)
        {

        }
    }

}

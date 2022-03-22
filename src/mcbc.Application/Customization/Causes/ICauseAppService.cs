using Abp.Application.Services;
using Abp.Domain.Repositories;
using mcbc.Customization.Causes.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mcbc.Customization.Causes
{
    

    public interface ICauseAppService : IAsyncCrudAppService<CauseDto>
    {

    }

    public class CauseAppService : AsyncCrudAppService<Cause, CauseDto>, ICauseAppService
    {
        public CauseAppService(IRepository<Cause> repository)
            : base(repository)
        {

        }
    }
}

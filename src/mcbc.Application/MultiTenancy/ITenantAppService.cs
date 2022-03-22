using Abp.Application.Services;
using mcbc.MultiTenancy.Dto;

namespace mcbc.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}


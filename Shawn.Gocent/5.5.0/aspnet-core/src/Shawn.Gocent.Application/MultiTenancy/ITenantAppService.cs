using Abp.Application.Services;
using Shawn.Gocent.MultiTenancy.Dto;

namespace Shawn.Gocent.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}


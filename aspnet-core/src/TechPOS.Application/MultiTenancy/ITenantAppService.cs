using Abp.Application.Services;
using TechPOS.MultiTenancy.Dto;

namespace TechPOS.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}


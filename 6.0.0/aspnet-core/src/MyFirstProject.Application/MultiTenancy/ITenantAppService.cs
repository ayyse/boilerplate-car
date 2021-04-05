using Abp.Application.Services;
using MyFirstProject.MultiTenancy.Dto;

namespace MyFirstProject.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}


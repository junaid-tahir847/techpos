using System.Threading.Tasks;
using Abp.Application.Services;
using TechPOS.Authorization.Accounts.Dto;

namespace TechPOS.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}

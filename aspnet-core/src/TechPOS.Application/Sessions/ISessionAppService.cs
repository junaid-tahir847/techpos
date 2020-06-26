using System.Threading.Tasks;
using Abp.Application.Services;
using TechPOS.Sessions.Dto;

namespace TechPOS.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}

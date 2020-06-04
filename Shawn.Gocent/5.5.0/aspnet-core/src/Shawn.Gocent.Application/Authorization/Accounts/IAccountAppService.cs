using System.Threading.Tasks;
using Abp.Application.Services;
using Shawn.Gocent.Authorization.Accounts.Dto;

namespace Shawn.Gocent.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}

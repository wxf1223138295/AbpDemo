using System.Threading.Tasks;
using Abp.Application.Services;
using Shawn.Gocent.Sessions.Dto;

namespace Shawn.Gocent.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}

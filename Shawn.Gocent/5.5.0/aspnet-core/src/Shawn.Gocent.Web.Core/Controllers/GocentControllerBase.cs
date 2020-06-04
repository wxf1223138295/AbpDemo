using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Shawn.Gocent.Controllers
{
    public abstract class GocentControllerBase: AbpController
    {
        protected GocentControllerBase()
        {
            LocalizationSourceName = GocentConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}

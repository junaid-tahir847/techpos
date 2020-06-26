using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace TechPOS.Controllers
{
    public abstract class TechPOSControllerBase: AbpController
    {
        protected TechPOSControllerBase()
        {
            LocalizationSourceName = TechPOSConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}

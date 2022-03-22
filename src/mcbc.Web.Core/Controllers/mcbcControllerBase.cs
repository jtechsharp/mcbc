using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace mcbc.Controllers
{
    public abstract class mcbcControllerBase: AbpController
    {
        protected mcbcControllerBase()
        {
            LocalizationSourceName = mcbcConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}

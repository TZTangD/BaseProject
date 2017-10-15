using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace tzky.saas.Controllers
{
    public abstract class saasControllerBase: AbpController
    {
        protected saasControllerBase()
        {
            LocalizationSourceName = saasConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}

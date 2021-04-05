using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace MyFirstProject.Controllers
{
    public abstract class MyFirstProjectControllerBase: AbpController
    {
        protected MyFirstProjectControllerBase()
        {
            LocalizationSourceName = MyFirstProjectConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}

using Abp.AspNetCore.Mvc.ViewComponents;

namespace MyFirstProject.Web.Views
{
    public abstract class MyFirstProjectViewComponent : AbpViewComponent
    {
        protected MyFirstProjectViewComponent()
        {
            LocalizationSourceName = MyFirstProjectConsts.LocalizationSourceName;
        }
    }
}

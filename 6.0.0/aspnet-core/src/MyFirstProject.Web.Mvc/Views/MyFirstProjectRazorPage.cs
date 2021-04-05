using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace MyFirstProject.Web.Views
{
    public abstract class MyFirstProjectRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected MyFirstProjectRazorPage()
        {
            LocalizationSourceName = MyFirstProjectConsts.LocalizationSourceName;
        }
    }
}

using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MyFirstProject.EntityFrameworkCore;
using MyFirstProject.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace MyFirstProject.Web.Tests
{
    [DependsOn(
        typeof(MyFirstProjectWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class MyFirstProjectWebTestModule : AbpModule
    {
        public MyFirstProjectWebTestModule(MyFirstProjectEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MyFirstProjectWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(MyFirstProjectWebMvcModule).Assembly);
        }
    }
}
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MyFirstProject.Configuration;

namespace MyFirstProject.Web.Host.Startup
{
    [DependsOn(
       typeof(MyFirstProjectWebCoreModule))]
    public class MyFirstProjectWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public MyFirstProjectWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MyFirstProjectWebHostModule).GetAssembly());
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using MyFirstProject.Configuration;
using MyFirstProject.Web;

namespace MyFirstProject.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class MyFirstProjectDbContextFactory : IDesignTimeDbContextFactory<MyFirstProjectDbContext>
    {
        public MyFirstProjectDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<MyFirstProjectDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            MyFirstProjectDbContextConfigurer.Configure(builder, configuration.GetConnectionString(MyFirstProjectConsts.ConnectionStringName));

            return new MyFirstProjectDbContext(builder.Options);
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using MyFirstProject.Authorization.Roles;
using MyFirstProject.Authorization.Users;
using MyFirstProject.MultiTenancy;

namespace MyFirstProject.EntityFrameworkCore
{
    public class MyFirstProjectDbContext : AbpZeroDbContext<Tenant, Role, User, MyFirstProjectDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public MyFirstProjectDbContext(DbContextOptions<MyFirstProjectDbContext> options)
            : base(options)
        {
        }
    }
}

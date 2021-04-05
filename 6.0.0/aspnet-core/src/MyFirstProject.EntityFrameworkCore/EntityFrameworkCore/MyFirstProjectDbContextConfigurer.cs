using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace MyFirstProject.EntityFrameworkCore
{
    public static class MyFirstProjectDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<MyFirstProjectDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<MyFirstProjectDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}

using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace TechPOS.EntityFrameworkCore
{
    public static class TechPOSDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<TechPOSDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<TechPOSDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}

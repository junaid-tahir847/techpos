using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using TechPOS.Authorization.Roles;
using TechPOS.Authorization.Users;
using TechPOS.MultiTenancy;
using TechPOS.Products;

namespace TechPOS.EntityFrameworkCore
{
    public class TechPOSDbContext : AbpZeroDbContext<Tenant, Role, User, TechPOSDbContext>
    {
        /* Define a DbSet for each entity of the application */

        public DbSet<Product> Products { get; set; }
        public TechPOSDbContext(DbContextOptions<TechPOSDbContext> options)
            : base(options)
        {
        }
    }
}

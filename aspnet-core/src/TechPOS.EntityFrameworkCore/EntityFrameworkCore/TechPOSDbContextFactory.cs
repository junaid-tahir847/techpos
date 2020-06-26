using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using TechPOS.Configuration;
using TechPOS.Web;

namespace TechPOS.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class TechPOSDbContextFactory : IDesignTimeDbContextFactory<TechPOSDbContext>
    {
        public TechPOSDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<TechPOSDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            TechPOSDbContextConfigurer.Configure(builder, configuration.GetConnectionString(TechPOSConsts.ConnectionStringName));

            return new TechPOSDbContext(builder.Options);
        }
    }
}

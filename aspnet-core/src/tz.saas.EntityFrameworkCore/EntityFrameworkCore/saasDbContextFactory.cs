using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using tz.saas.Configuration;
using tz.saas.Web;

namespace tz.saas.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class saasDbContextFactory : IDesignTimeDbContextFactory<saasDbContext>
    {
        public saasDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<saasDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            saasDbContextConfigurer.Configure(builder, configuration.GetConnectionString(saasConsts.ConnectionStringName));

            return new saasDbContext(builder.Options);
        }
    }
}

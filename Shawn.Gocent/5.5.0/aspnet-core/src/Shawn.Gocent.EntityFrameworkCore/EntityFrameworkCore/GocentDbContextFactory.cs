using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Shawn.Gocent.Configuration;
using Shawn.Gocent.Web;

namespace Shawn.Gocent.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class GocentDbContextFactory : IDesignTimeDbContextFactory<GocentDbContext>
    {
        public GocentDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<GocentDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            GocentDbContextConfigurer.Configure(builder, configuration.GetConnectionString(GocentConsts.ConnectionStringName));

            return new GocentDbContext(builder.Options);
        }
    }
}

using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Shawn.Gocent.EntityFrameworkCore
{
    public static class GocentDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<GocentDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<GocentDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}

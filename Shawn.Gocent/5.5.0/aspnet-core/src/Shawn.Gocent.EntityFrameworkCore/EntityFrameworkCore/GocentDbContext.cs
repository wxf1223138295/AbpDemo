using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Shawn.Gocent.Authorization.Roles;
using Shawn.Gocent.Authorization.Users;
using Shawn.Gocent.Demo;
using Shawn.Gocent.EntityConfigration;
using Shawn.Gocent.MultiTenancy;

namespace Shawn.Gocent.EntityFrameworkCore
{
    public class GocentDbContext : AbpZeroDbContext<Tenant, Role, User, GocentDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public virtual DbSet<Sample> Sample { get; set; }
        public GocentDbContext(DbContextOptions<GocentDbContext> options)
            : base(options)
        {
           
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new SampleEntityConfiguration());
            base.OnModelCreating(modelBuilder);

        }
    }
}

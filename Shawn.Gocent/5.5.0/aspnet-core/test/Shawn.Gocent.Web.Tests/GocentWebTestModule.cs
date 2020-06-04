using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Shawn.Gocent.EntityFrameworkCore;
using Shawn.Gocent.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace Shawn.Gocent.Web.Tests
{
    [DependsOn(
        typeof(GocentWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class GocentWebTestModule : AbpModule
    {
        public GocentWebTestModule(GocentEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(GocentWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(GocentWebMvcModule).Assembly);
        }
    }
}
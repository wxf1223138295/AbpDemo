using Abp.Dependency;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Timing;
using Abp.Zero;
using Abp.Zero.Configuration;
using Shawn.Gocent.Authorization.Roles;
using Shawn.Gocent.Authorization.Users;
using Shawn.Gocent.Configuration;
using Shawn.Gocent.Demo;
using Shawn.Gocent.Localization;
using Shawn.Gocent.MultiTenancy;
using Shawn.Gocent.Timing;

namespace Shawn.Gocent
{
    [DependsOn(typeof(AbpZeroCoreModule))]
    public class GocentCoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            // Declare entity types
            Configuration.Modules.Zero().EntityTypes.Tenant = typeof(Tenant);
            Configuration.Modules.Zero().EntityTypes.Role = typeof(Role);
            Configuration.Modules.Zero().EntityTypes.User = typeof(User);

            GocentLocalizationConfigurer.Configure(Configuration.Localization);

            // Enable this line to create a multi-tenant application.
            Configuration.MultiTenancy.IsEnabled = GocentConsts.MultiTenancyEnabled;

            // Configure roles
            AppRoleConfig.Configure(Configuration.Modules.Zero().RoleManagement);

            Configuration.Settings.Providers.Add<AppSettingProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(GocentCoreModule).GetAssembly());
            IocManager.Register<ISampleDomainServer,SampleDomainServer>(DependencyLifeStyle.Transient);
        }

        public override void PostInitialize()
        {
            IocManager.Resolve<AppTimes>().StartupTime = Clock.Now;
        }
    }
}

using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Shawn.Gocent.Authorization;

namespace Shawn.Gocent
{
    [DependsOn(
        typeof(GocentCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class GocentApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<GocentAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(GocentApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}

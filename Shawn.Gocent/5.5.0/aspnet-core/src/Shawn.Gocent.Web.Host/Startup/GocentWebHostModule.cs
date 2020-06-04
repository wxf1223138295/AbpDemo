using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Shawn.Gocent.Configuration;

namespace Shawn.Gocent.Web.Host.Startup
{
    [DependsOn(
       typeof(GocentWebCoreModule))]
    public class GocentWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public GocentWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(GocentWebHostModule).GetAssembly());
        }
    }
}

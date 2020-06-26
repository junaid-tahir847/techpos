using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using TechPOS.Configuration;

namespace TechPOS.Web.Host.Startup
{
    [DependsOn(
       typeof(TechPOSWebCoreModule))]
    public class TechPOSWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public TechPOSWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TechPOSWebHostModule).GetAssembly());
        }
    }
}

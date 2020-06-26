using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using TechPOS.Authorization;

namespace TechPOS
{
    [DependsOn(
        typeof(TechPOSCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class TechPOSApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<TechPOSAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(TechPOSApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}

using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using TechPOS.EntityFrameworkCore;
using TechPOS.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace TechPOS.Web.Tests
{
    [DependsOn(
        typeof(TechPOSWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class TechPOSWebTestModule : AbpModule
    {
        public TechPOSWebTestModule(TechPOSEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TechPOSWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(TechPOSWebMvcModule).Assembly);
        }
    }
}
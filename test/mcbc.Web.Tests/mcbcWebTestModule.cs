using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using mcbc.EntityFrameworkCore;
using mcbc.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace mcbc.Web.Tests
{
    [DependsOn(
        typeof(mcbcWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class mcbcWebTestModule : AbpModule
    {
        public mcbcWebTestModule(mcbcEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(mcbcWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(mcbcWebMvcModule).Assembly);
        }
    }
}
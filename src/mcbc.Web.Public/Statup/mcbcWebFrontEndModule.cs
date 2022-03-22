using Abp.Configuration.Startup;
using Abp.Modules;
using Abp.Reflection.Extensions;
using mcbc.Configuration;
using mcbc.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace mcbc.Web.Public.Startup
{
    [DependsOn(
        typeof(mcbcWebCoreModule)
    )]
    public class mcbcWebFrontEndModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public mcbcWebFrontEndModule(IWebHostEnvironment env , mcbcEntityFrameworkModule abpZeroTemplateEntityFrameworkCoreModule)
        {
            _appConfiguration = env.GetAppConfiguration();
            abpZeroTemplateEntityFrameworkCoreModule.SkipDbSeed = true;
        }

        public override void PreInitialize()
        {
            Configuration.Modules.AbpWebCommon().MultiTenancy.DomainFormat = _appConfiguration["App:WebSiteRootAddress"] ?? "https://localhost:44303/";
           
            //Changed AntiForgery token/cookie names to not conflict to the main application while redirections.
            Configuration.Modules.AbpWebCommon().AntiForgery.TokenCookieName = "Public-XSRF-TOKEN";
            Configuration.Modules.AbpWebCommon().AntiForgery.TokenHeaderName = "Public-X-XSRF-TOKEN";

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;

            Configuration.Navigation.Providers.Add<FrontEndNavigationProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(mcbcWebFrontEndModule).GetAssembly());
        }
    }
}


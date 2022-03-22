using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using mcbc.Configuration;

namespace mcbc.Web.Host.Startup
{
    [DependsOn(
       typeof(mcbcWebCoreModule))]
    public class mcbcWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public mcbcWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(mcbcWebHostModule).GetAssembly());
        }
    }
}

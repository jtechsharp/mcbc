using Abp.Dependency;
using Abp.Extensions;
using Abp.MultiTenancy;

using mcbc.Url;

namespace mcbc.Web.Url
{

    public abstract class AppUrlServiceBase : IAppUrlService, ITransientDependency
    {
        public abstract string EmailActivationRoute { get; }

        public abstract string PasswordResetRoute { get; }

     
        public abstract string RegisterRoute { get; }

        public abstract string LoginRoute { get; }

      

        protected readonly IWebUrlService WebUrlService;
        protected readonly ITenantCache TenantCache;

        protected AppUrlServiceBase(IWebUrlService webUrlService, ITenantCache tenantCache)
        {
            WebUrlService = webUrlService;
            TenantCache = tenantCache;
        }

        public string GetAppUrl(AppUrlType appUrls, int? tenantId)
        {
            var tenantName = GetTenancyName(tenantId);
            var url = "";
            switch (appUrls)
            {
                case AppUrlType.EmailActivationRoute:
                    url = CreateEmailActivationUrlFormat(tenantName);
                    break;
                
                case AppUrlType.PasswordResetRoute:
                    url = CreatePasswordResetUrlFormat(tenantName);
                    break;
                case AppUrlType.RegisterRoute:
                    url = RegisterRouteUrlFormat(tenantName);
                    break;
                case AppUrlType.LoginRoute:
                    url = LoginRouteUrlFormat(tenantName);
                    break;
               
            }
            return url;
        }

        public string CreateEmailActivationUrlFormat(int? tenantId)
        {
            return CreateEmailActivationUrlFormat(GetTenancyName(tenantId));
        }

        public string CreatePasswordResetUrlFormat(int? tenantId)
        {
            return CreatePasswordResetUrlFormat(GetTenancyName(tenantId));
        }

        public string CreateEmailActivationUrlFormat(string tenancyName)
        {
            var activationLink = WebUrlService.GetSiteRootAddress(tenancyName).EnsureEndsWith('/') + EmailActivationRoute + "?userId={userId}&confirmationCode={confirmationCode}";

            if (tenancyName != null)
            {
                activationLink += "&tenantId={tenantId}";
            }

            return activationLink;
        }

        public string CreatePasswordResetUrlFormat(string tenancyName)
        {
            var resetLink = WebUrlService.GetSiteRootAddress(tenancyName).EnsureEndsWith('/') + PasswordResetRoute + "?userId={userId}&resetCode={resetCode}";

            if (tenancyName != null)
            {
                resetLink += "&tenantId={tenantId}";
            }

            return resetLink;
        }

        

        public string RegisterRouteUrlFormat(string tenancyName)
        {
            return WebUrlService.GetSiteRootAddress(tenancyName).EnsureEndsWith('/') + RegisterRoute;
        }

        public string LoginRouteUrlFormat(string tenancyName)
        {
            return WebUrlService.GetSiteRootAddress(tenancyName).EnsureEndsWith('/') + LoginRoute;
        }

       

        public string GetTenancyName(int? tenantId)
        {
            return tenantId.HasValue ? TenantCache.Get(tenantId.Value).TenancyName : null;
        }
    }
}

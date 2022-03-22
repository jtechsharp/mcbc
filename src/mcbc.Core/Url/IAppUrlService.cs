


namespace mcbc.Url
{
    public interface IAppUrlService
    {
        string GetAppUrl(AppUrlType appUrls, int? tenantId);

        string CreateEmailActivationUrlFormat(int? tenantId);

        string CreatePasswordResetUrlFormat(int? tenantId);

        string CreateEmailActivationUrlFormat(string tenancyName);

        string CreatePasswordResetUrlFormat(string tenancyName);

       
        string GetTenancyName(int? tenantId);
    }
}


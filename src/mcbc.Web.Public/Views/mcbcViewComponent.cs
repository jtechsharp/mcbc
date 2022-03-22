using Abp.AspNetCore.Mvc.ViewComponents;

namespace mcbc.Web.Public.Views
{
    public abstract class mcbcViewComponent : AbpViewComponent
    {
        protected mcbcViewComponent()
        {
            LocalizationSourceName = mcbcConsts.LocalizationSourceName;
        }
    }
}

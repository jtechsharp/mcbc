using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace mcbc.Web.Public.Views
{
    public abstract class mcbcRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected mcbcRazorPage()
        {
            LocalizationSourceName = mcbcConsts.LocalizationSourceName;
        }
    }
}


using Abp.MultiTenancy;
using mcbc.Authorization.Users;
using mcbc.Customization;

namespace mcbc.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }

        public NGO NGO { get; set; }
    }
}

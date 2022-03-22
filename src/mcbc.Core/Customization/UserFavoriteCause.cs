using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using mcbc.Authorization.Users;

namespace mcbc.Customization
{
    public class UserFavoriteCause : AuditedEntity, IMayHaveTenant 
    {
        
        public Cause Cause { get; set; }
                
        public User User { get; set; }
        public int? TenantId { get; set; }
    }
}

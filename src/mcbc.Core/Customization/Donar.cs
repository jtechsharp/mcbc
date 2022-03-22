using Abp.Domain.Entities.Auditing;
using mcbc.Authorization.Users;

namespace mcbc.Customization
{
    public class Donar: FullAuditedEntity
    {
       
        public int UserId { get; set; }

        public User User { get; set; }
    }
}

using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;

namespace mcbc.Customization
{
    public class MembershipRequest : AuditedEntity, IMayHaveTenant
    {

        [StringLength(200)]
        public string Title { get; set; }
        [StringLength(200)]
        public string Email { get; set; }
        [StringLength(200)]
        public string Address { get; set; }
        [StringLength(250)]
        public string Message { get; set; }
        [StringLength(250)]
        public string Remarks { get; set; }
        public string Status { get; set; }
        public int? TenantId { get; set; }

    }
}

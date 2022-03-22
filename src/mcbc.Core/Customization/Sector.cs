using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;

namespace mcbc.Customization
{
    public class Sector : FullAuditedEntity
    {
       
        [StringLength(200)]
        public string Name { get; set; }
        public string Description { get; set; }

        [StringLength(200)]
        public string ImagePath { get; set; }
        public bool Active { get; set; }
    }
}

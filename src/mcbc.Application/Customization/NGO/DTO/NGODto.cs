using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using NetTopologySuite.Geometries;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mcbc.Customization
{
    /// <summary>
    /// NGODTO
    /// </summary>
    [AutoMap(typeof(NGO))]
    public class NGODto : EntityDto
    {
        [StringLength(200)]
        public string Title { get; set; }
        [StringLength(100)]
        public string CharityNumber { get; set; }
        [StringLength(100)]
        public string Email { get; set; }
        [StringLength(20)]
        public string PhoneNumber { get; set; }
        public string Description { get; set; }
        [StringLength(400)]
        public string Logo { get; set; }

        [StringLength(100)]
        public string ContactPersonName { get; set; }

        [StringLength(20)]
        public string ContactPersonPhone { get; set; }

        [StringLength(50)]
        public string ContactPersonEmail { get; set; }
        [StringLength(200)]
        public string Website { get; set; }
        [StringLength(50)]
        public string Currency { get; set; }
        [StringLength(10)]
        public string CurrencySign { get; set; }
        [StringLength(200)]
        public string Address1 { get; set; }
        [StringLength(200)]
        public string Address2 { get; set; }
        [StringLength(200)]
        public string Address3 { get; set; }
        [StringLength(100)]
        public string City { get; set; }
        [StringLength(100)]
        public string County { get; set; }
        [StringLength(50)]
        public string PostalCode { get; set; }
        [StringLength(100)]
        public string Country { get; set; }
        public float? Latitude { get; set; }
        public float? Longitude { get; set; }
        [NotMapped]
        public Geometry GeoLocation { get; set; }
        [StringLength(10)]
        public string Status { get; set; }
        public bool Active { get; set; }
        public bool? Featured { get; set; }


        [StringLength(50)]
        public string Sector { get; set; }
        /// <summary>
        /// Sectors
        /// </summary>
        public ICollection<Sector> Sectors { get; set; }
        /// <summary>
        /// Causes
        /// </summary>
        public ICollection<Cause> Causes { get; set; }
      
    }
}

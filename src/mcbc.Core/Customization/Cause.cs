using System;
using System.Collections.Generic;
using NetTopologySuite.Geometries;
using System.ComponentModel.DataAnnotations;

using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;

namespace mcbc.Customization
{
    public class Cause : FullAuditedEntity, IMustHaveTenant
    {
       
        [StringLength(200)]
        public string Title { get; set; }

        [StringLength(100)]
        public string ContactPersonName { get; set; }

        [StringLength(20)]
        public string ContactPersonPhone { get; set; }

        [StringLength(50)]
        public string ContactPersonEmail { get; set; }

        public string Description { get; set; }

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

        public Country? Country { get; set; }
        public float? Latitude { get; set; }
        public float? Longitude { get; set; }
        [NotMapped]
        public Geometry GeoLocation { get; set; }
        [StringLength(10)]
        public string Status { get; set; }
        [StringLength(400)]
        public string ImagePath { get; set; }
        public double TargetAmount { get; set; }
        public double? DonationAmount { get; set; }

        public DateTime? ExpiredOn { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool Active { get; set; }
        public bool? Featured { get; set; }
        public bool? Popular { get; set; }


        public int PeopleDonated { get; set; }
        //public NGO NGO { get; set; }
        public ICollection<Donation> Donations { get; set; }
        public Sector Sector { get; set; }
        public ICollection<UserFavoriteCause> UserFavoriteCause { get; set; }
        public int TenantId { get; set; }
    }



    public class Country : AuditedEntity<int>
    {

        public string ShortCode { get; set; }
        public string Name { get; set; }
    }
}

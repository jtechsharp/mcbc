using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;

namespace mcbc.Customization
{
    public class Donation : FullAuditedEntity, IMustHaveTenant
    {   
        public string Comments { get; set; }
        public int CauseId { get; set; }
        public int UserId { get; set; }
        public long? Amount { get; set; }
        public decimal? ServiceFee { get; set; }
        public decimal? GatewayFee { get; set; }
        public string PaymentGateway { get; set; }
        public string PaymentStatus { get; set; }
        public string TransactionId { get; set; }
        public string CardRef { get; set; }
        public string CardProvider { get; set; }
        public string CardType { get; set; }
        public string MacAddress { get; set; }
        public string Platform { get; set; }
        public string Status { get; set; }
        public DateTime PaymentDate { get; set; }
       
        public Cause Cause { get; set; }
        public int TenantId { get; set; }
    }
}

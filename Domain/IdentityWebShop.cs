using System;

namespace Domain
{
    public class IdentityWebShop
    {
        public Guid Id { get; set; }
        public Guid WebShopId { get; set; }
        public string Country { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string VisitPolicy { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public string CompanyName { get; set; }
        public string ChamberOfCommerce { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedDate { get; set; } = DateTime.UtcNow;
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        
        // Navigation property
        public WebShop WebShop { get; set; }
    }
}
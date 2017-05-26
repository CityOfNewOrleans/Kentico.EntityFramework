using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class ComCustomer
    {
        public ComCustomer()
        {
            ComAddress = new HashSet<ComAddress>();
            ComCustomerCreditHistory = new HashSet<ComCustomerCreditHistory>();
            ComOrder = new HashSet<ComOrder>();
            ComShoppingCart = new HashSet<ComShoppingCart>();
        }

        public int CustomerId { get; set; }
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerFax { get; set; }
        public string CustomerCompany { get; set; }
        public int? CustomerUserId { get; set; }
        public int? CustomerCountryId { get; set; }
        public int? CustomerStateId { get; set; }
        public Guid CustomerGuid { get; set; }
        public string CustomerTaxRegistrationId { get; set; }
        public string CustomerOrganizationId { get; set; }
        public DateTime CustomerLastModified { get; set; }
        public int? CustomerSiteId { get; set; }
        public DateTime? CustomerCreated { get; set; }

        public virtual ICollection<ComAddress> ComAddress { get; set; }
        public virtual ICollection<ComCustomerCreditHistory> ComCustomerCreditHistory { get; set; }
        public virtual ICollection<ComOrder> ComOrder { get; set; }
        public virtual ICollection<ComShoppingCart> ComShoppingCart { get; set; }
        public virtual CmsCountry CustomerCountry { get; set; }
        public virtual CmsSite CustomerSite { get; set; }
        public virtual CmsState CustomerState { get; set; }
        public virtual CmsUser CustomerUser { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class ComAddress
    {
        public ComAddress()
        {
            ComShoppingCartShoppingCartBillingAddress = new HashSet<ComShoppingCart>();
            ComShoppingCartShoppingCartCompanyAddress = new HashSet<ComShoppingCart>();
            ComShoppingCartShoppingCartShippingAddress = new HashSet<ComShoppingCart>();
        }

        public int AddressId { get; set; }
        public string AddressName { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressCity { get; set; }
        public string AddressZip { get; set; }
        public string AddressPhone { get; set; }
        public int AddressCustomerId { get; set; }
        public int AddressCountryId { get; set; }
        public int? AddressStateId { get; set; }
        public string AddressPersonalName { get; set; }
        public Guid? AddressGuid { get; set; }
        public DateTime AddressLastModified { get; set; }

        public virtual ICollection<ComShoppingCart> ComShoppingCartShoppingCartBillingAddress { get; set; }
        public virtual ICollection<ComShoppingCart> ComShoppingCartShoppingCartCompanyAddress { get; set; }
        public virtual ICollection<ComShoppingCart> ComShoppingCartShoppingCartShippingAddress { get; set; }
        public virtual CmsCountry AddressCountry { get; set; }
        public virtual ComCustomer AddressCustomer { get; set; }
        public virtual CmsState AddressState { get; set; }
    }
}

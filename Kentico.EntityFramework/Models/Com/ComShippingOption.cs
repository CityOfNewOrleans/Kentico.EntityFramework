using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class ComShippingOption
    {
        public ComShippingOption()
        {
            ComOrder = new HashSet<ComOrder>();
            ComShippingCost = new HashSet<ComShippingCost>();
            ComShippingOptionTaxClass = new HashSet<ComShippingOptionTaxClass>();
            ComShoppingCart = new HashSet<ComShoppingCart>();
        }

        public int ShippingOptionId { get; set; }
        public string ShippingOptionName { get; set; }
        public string ShippingOptionDisplayName { get; set; }
        public bool ShippingOptionEnabled { get; set; }
        public int? ShippingOptionSiteId { get; set; }
        public Guid ShippingOptionGuid { get; set; }
        public DateTime ShippingOptionLastModified { get; set; }
        public Guid? ShippingOptionThumbnailGuid { get; set; }
        public string ShippingOptionDescription { get; set; }
        public int? ShippingOptionCarrierId { get; set; }
        public string ShippingOptionCarrierServiceName { get; set; }

        public virtual ICollection<ComOrder> ComOrder { get; set; }
        public virtual ICollection<ComShippingCost> ComShippingCost { get; set; }
        public virtual ICollection<ComShippingOptionTaxClass> ComShippingOptionTaxClass { get; set; }
        public virtual ICollection<ComShoppingCart> ComShoppingCart { get; set; }
        public virtual ComCarrier ShippingOptionCarrier { get; set; }
        public virtual Site ShippingOptionSite { get; set; }
    }
}

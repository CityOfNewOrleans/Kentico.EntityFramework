using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class ComPaymentOption
    {
        public ComPaymentOption()
        {
            ComOrder = new HashSet<ComOrder>();
            ComShoppingCart = new HashSet<ComShoppingCart>();
        }

        public int PaymentOptionId { get; set; }
        public string PaymentOptionName { get; set; }
        public string PaymentOptionDisplayName { get; set; }
        public bool PaymentOptionEnabled { get; set; }
        public int? PaymentOptionSiteId { get; set; }
        public string PaymentOptionPaymentGateUrl { get; set; }
        public string PaymentOptionAssemblyName { get; set; }
        public string PaymentOptionClassName { get; set; }
        public int? PaymentOptionSucceededOrderStatusId { get; set; }
        public int? PaymentOptionFailedOrderStatusId { get; set; }
        public Guid PaymentOptionGuid { get; set; }
        public DateTime PaymentOptionLastModified { get; set; }
        public bool? PaymentOptionAllowIfNoShipping { get; set; }
        public Guid? PaymentOptionThumbnailGuid { get; set; }
        public string PaymentOptionDescription { get; set; }

        public virtual ICollection<ComOrder> ComOrder { get; set; }
        public virtual ICollection<ComShoppingCart> ComShoppingCart { get; set; }
        public virtual ComOrderStatus PaymentOptionFailedOrderStatus { get; set; }
        public virtual CmsSite PaymentOptionSite { get; set; }
        public virtual ComOrderStatus PaymentOptionSucceededOrderStatus { get; set; }
    }
}

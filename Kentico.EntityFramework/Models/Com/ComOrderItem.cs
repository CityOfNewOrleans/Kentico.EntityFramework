using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class ComOrderItem
    {
        public ComOrderItem()
        {
            ComOrderItemSkufile = new HashSet<ComOrderItemSkufile>();
        }

        public int OrderItemId { get; set; }
        public int OrderItemOrderId { get; set; }
        public int OrderItemSkuid { get; set; }
        public string OrderItemSkuname { get; set; }
        public double OrderItemUnitPrice { get; set; }
        public int OrderItemUnitCount { get; set; }
        public string OrderItemCustomData { get; set; }
        public Guid OrderItemGuid { get; set; }
        public Guid? OrderItemParentGuid { get; set; }
        public DateTime OrderItemLastModified { get; set; }
        public bool? OrderItemIsPrivate { get; set; }
        public string OrderItemSku { get; set; }
        public DateTime? OrderItemValidTo { get; set; }
        public Guid? OrderItemBundleGuid { get; set; }
        public double? OrderItemTotalPriceInMainCurrency { get; set; }
        public bool? OrderItemSendNotification { get; set; }
        public string OrderItemText { get; set; }
        public double? OrderItemPrice { get; set; }
        public double? OrderItemUnitTotalDiscountInMainCurrency { get; set; }
        public double? OrderItemUnitTotalTaxInMainCurrency { get; set; }
        public string OrderItemProductDiscounts { get; set; }

        public virtual ICollection<ComOrderItemSkufile> ComOrderItemSkufile { get; set; }
        public virtual ComOrder OrderItemOrder { get; set; }
        public virtual ComSku OrderItemSkuNavigation { get; set; }
    }
}

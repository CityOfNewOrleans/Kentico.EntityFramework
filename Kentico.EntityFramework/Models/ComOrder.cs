using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class ComOrder
    {
        public ComOrder()
        {
            ComOrderItem = new HashSet<ComOrderItem>();
            ComOrderStatusUser = new HashSet<ComOrderStatusUser>();
        }

        public int OrderId { get; set; }
        public int OrderBillingAddressId { get; set; }
        public int? OrderShippingAddressId { get; set; }
        public int? OrderShippingOptionId { get; set; }
        public double? OrderTotalShipping { get; set; }
        public double OrderTotalPrice { get; set; }
        public double OrderTotalTax { get; set; }
        public DateTime OrderDate { get; set; }
        public int? OrderStatusId { get; set; }
        public int? OrderCurrencyId { get; set; }
        public int OrderCustomerId { get; set; }
        public int? OrderCreatedByUserId { get; set; }
        public string OrderNote { get; set; }
        public int OrderSiteId { get; set; }
        public int? OrderPaymentOptionId { get; set; }
        public string OrderInvoice { get; set; }
        public string OrderInvoiceNumber { get; set; }
        public int? OrderDiscountCouponId { get; set; }
        public int? OrderCompanyAddressId { get; set; }
        public string OrderTrackingNumber { get; set; }
        public string OrderCustomData { get; set; }
        public string OrderPaymentResult { get; set; }
        public Guid OrderGuid { get; set; }
        public DateTime OrderLastModified { get; set; }
        public double? OrderTotalPriceInMainCurrency { get; set; }
        public bool? OrderIsPaid { get; set; }
        public string OrderCulture { get; set; }
        public string OrderCouponCode { get; set; }
        public double? OrderTotalDiscountInMainCurrency { get; set; }
        public double? OrderTotalShippingInMainCurrency { get; set; }
        public double? OrderTotalTaxInMainCurrency { get; set; }
        public double? OrderExchangeRate { get; set; }
        public string OrderShippingTaxes { get; set; }
        public string OrderDiscounts { get; set; }

        public virtual ICollection<ComOrderItem> ComOrderItem { get; set; }
        public virtual ICollection<ComOrderStatusUser> ComOrderStatusUser { get; set; }
        public virtual ComOrderAddress OrderBillingAddress { get; set; }
        public virtual ComOrderAddress OrderCompanyAddress { get; set; }
        public virtual CmsUser OrderCreatedByUser { get; set; }
        public virtual ComCurrency OrderCurrency { get; set; }
        public virtual ComCustomer OrderCustomer { get; set; }
        public virtual ComDiscountCoupon OrderDiscountCoupon { get; set; }
        public virtual ComPaymentOption OrderPaymentOption { get; set; }
        public virtual ComOrderAddress OrderShippingAddress { get; set; }
        public virtual ComShippingOption OrderShippingOption { get; set; }
        public virtual CmsSite OrderSite { get; set; }
        public virtual ComOrderStatus OrderStatus { get; set; }
    }
}

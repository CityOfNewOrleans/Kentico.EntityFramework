using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class ComDiscountCoupon
    {
        public ComDiscountCoupon()
        {
            ComOrder = new HashSet<ComOrder>();
            ComShoppingCart = new HashSet<ComShoppingCart>();
            ComSkudiscountCoupon = new HashSet<ComSkudiscountCoupon>();
        }

        public int DiscountCouponId { get; set; }
        public string DiscountCouponDisplayName { get; set; }
        public bool DiscountCouponIsExcluded { get; set; }
        public DateTime? DiscountCouponValidFrom { get; set; }
        public DateTime? DiscountCouponValidTo { get; set; }
        public double DiscountCouponValue { get; set; }
        public bool DiscountCouponIsFlatValue { get; set; }
        public string DiscountCouponCode { get; set; }
        public Guid? DiscountCouponGuid { get; set; }
        public DateTime? DiscountCouponLastModified { get; set; }
        public int? DiscountCouponSiteId { get; set; }

        public virtual ICollection<ComOrder> ComOrder { get; set; }
        public virtual ICollection<ComShoppingCart> ComShoppingCart { get; set; }
        public virtual ICollection<ComSkudiscountCoupon> ComSkudiscountCoupon { get; set; }
        public virtual CmsSite DiscountCouponSite { get; set; }
    }
}

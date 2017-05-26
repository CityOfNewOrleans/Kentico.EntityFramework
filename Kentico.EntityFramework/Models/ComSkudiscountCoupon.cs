using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class ComSkudiscountCoupon
    {
        public int Skuid { get; set; }
        public int DiscountCouponId { get; set; }

        public virtual ComDiscountCoupon DiscountCoupon { get; set; }
        public virtual ComSku Sku { get; set; }
    }
}

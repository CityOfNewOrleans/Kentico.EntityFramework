﻿using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class ComCouponCode
    {
        public int CouponCodeId { get; set; }
        public string CouponCodeCode { get; set; }
        public int? CouponCodeUseCount { get; set; }
        public int? CouponCodeUseLimit { get; set; }
        public int CouponCodeDiscountId { get; set; }
        public DateTime CouponCodeLastModified { get; set; }
        public Guid CouponCodeGuid { get; set; }

        public virtual ComDiscount CouponCodeDiscount { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class ComDiscount
    {
        public ComDiscount()
        {
            ComCouponCode = new HashSet<ComCouponCode>();
        }

        public int DiscountId { get; set; }
        public string DiscountDisplayName { get; set; }
        public string DiscountName { get; set; }
        public double DiscountValue { get; set; }
        public bool DiscountEnabled { get; set; }
        public Guid DiscountGuid { get; set; }
        public DateTime DiscountLastModified { get; set; }
        public int? DiscountSiteId { get; set; }
        public string DiscountDescription { get; set; }
        public DateTime? DiscountValidFrom { get; set; }
        public DateTime? DiscountValidTo { get; set; }
        public double DiscountOrder { get; set; }
        public string DiscountProductCondition { get; set; }
        public string DiscountRoles { get; set; }
        public string DiscountCustomerRestriction { get; set; }
        public bool DiscountIsFlat { get; set; }
        public string DiscountCartCondition { get; set; }
        public string DiscountApplyTo { get; set; }
        public bool DiscountApplyFurtherDiscounts { get; set; }
        public double? DiscountOrderAmount { get; set; }
        public bool DiscountUsesCoupons { get; set; }

        public virtual ICollection<ComCouponCode> ComCouponCode { get; set; }
        public virtual Site DiscountSite { get; set; }
    }
}

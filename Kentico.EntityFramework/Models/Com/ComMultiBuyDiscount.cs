using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class ComMultiBuyDiscount
    {
        public ComMultiBuyDiscount()
        {
            ComMultiBuyCouponCode = new HashSet<ComMultiBuyCouponCode>();
            ComMultiBuyDiscountDepartment = new HashSet<ComMultiBuyDiscountDepartment>();
            ComMultiBuyDiscountSku = new HashSet<ComMultiBuyDiscountSku>();
        }

        public int MultiBuyDiscountId { get; set; }
        public string MultiBuyDiscountDisplayName { get; set; }
        public string MultiBuyDiscountName { get; set; }
        public string MultiBuyDiscountDescription { get; set; }
        public bool MultiBuyDiscountEnabled { get; set; }
        public Guid MultiBuyDiscountGuid { get; set; }
        public DateTime MultiBuyDiscountLastModified { get; set; }
        public int? MultiBuyDiscountSiteId { get; set; }
        public bool MultiBuyDiscountApplyFurtherDiscounts { get; set; }
        public int MultiBuyDiscountMinimumBuyCount { get; set; }
        public DateTime? MultiBuyDiscountValidFrom { get; set; }
        public DateTime? MultiBuyDiscountValidTo { get; set; }
        public string MultiBuyDiscountCustomerRestriction { get; set; }
        public string MultiBuyDiscountRoles { get; set; }
        public int? MultiBuyDiscountApplyToSkuid { get; set; }
        public int? MultiBuyDiscountLimitPerOrder { get; set; }
        public bool? MultiBuyDiscountUsesCoupons { get; set; }
        public double? MultiBuyDiscountValue { get; set; }
        public bool? MultiBuyDiscountIsFlat { get; set; }
        public bool MultiBuyDiscountAutoAddEnabled { get; set; }
        public int? MultiBuyDiscountPriority { get; set; }

        public virtual ICollection<ComMultiBuyCouponCode> ComMultiBuyCouponCode { get; set; }
        public virtual ICollection<ComMultiBuyDiscountDepartment> ComMultiBuyDiscountDepartment { get; set; }
        public virtual ICollection<ComMultiBuyDiscountSku> ComMultiBuyDiscountSku { get; set; }
        public virtual ComSku MultiBuyDiscountApplyToSku { get; set; }
        public virtual Site MultiBuyDiscountSite { get; set; }
    }
}

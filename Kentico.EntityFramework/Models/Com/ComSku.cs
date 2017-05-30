using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class ComSku
    {
        public ComSku()
        {
            CmsTree = new HashSet<Tree>();
            ComBundleBundle = new HashSet<ComBundle>();
            ComBundleSku = new HashSet<ComBundle>();
            ComMultiBuyDiscount = new HashSet<ComMultiBuyDiscount>();
            ComMultiBuyDiscountSku = new HashSet<ComMultiBuyDiscountSku>();
            ComOrderItem = new HashSet<ComOrderItem>();
            ComShoppingCartSku = new HashSet<ComShoppingCartSku>();
            ComSkuallowedOptionOptionSku = new HashSet<ComSkuallowedOption>();
            ComSkuallowedOptionSku = new HashSet<ComSkuallowedOption>();
            ComSkudiscountCoupon = new HashSet<ComSkudiscountCoupon>();
            ComSkufile = new HashSet<ComSkufile>();
            ComSkuoptionCategory = new HashSet<ComSkuoptionCategory>();
            ComSkutaxClasses = new HashSet<ComSkutaxClasses>();
            ComVariantOptionOptionSku = new HashSet<ComVariantOption>();
            ComVariantOptionVariantSku = new HashSet<ComVariantOption>();
            ComVolumeDiscount = new HashSet<ComVolumeDiscount>();
            ComWishlist = new HashSet<ComWishlist>();
        }

        public int Skuid { get; set; }
        public string Skunumber { get; set; }
        public string Skuname { get; set; }
        public string Skudescription { get; set; }
        public double Skuprice { get; set; }
        public bool Skuenabled { get; set; }
        public int? SkudepartmentId { get; set; }
        public int? SkumanufacturerId { get; set; }
        public int? SkuinternalStatusId { get; set; }
        public int? SkupublicStatusId { get; set; }
        public int? SkusupplierId { get; set; }
        public int? SkuavailableInDays { get; set; }
        public Guid Skuguid { get; set; }
        public string SkuimagePath { get; set; }
        public double? Skuweight { get; set; }
        public double? Skuwidth { get; set; }
        public double? Skudepth { get; set; }
        public double? Skuheight { get; set; }
        public int? SkuavailableItems { get; set; }
        public bool? SkusellOnlyAvailable { get; set; }
        public string SkucustomData { get; set; }
        public int? SkuoptionCategoryId { get; set; }
        public int? Skuorder { get; set; }
        public DateTime SkulastModified { get; set; }
        public DateTime? Skucreated { get; set; }
        public int? SkusiteId { get; set; }
        public bool? SkuprivateDonation { get; set; }
        public bool? SkuneedsShipping { get; set; }
        public DateTime? SkuvalidUntil { get; set; }
        public string SkuproductType { get; set; }
        public int? SkumaxItemsInOrder { get; set; }
        public double? SkumaxPrice { get; set; }
        public string Skuvalidity { get; set; }
        public int? SkuvalidFor { get; set; }
        public double? SkuminPrice { get; set; }
        public Guid? SkumembershipGuid { get; set; }
        public string SkuconversionName { get; set; }
        public string SkuconversionValue { get; set; }
        public string SkubundleInventoryType { get; set; }
        public int? SkuminItemsInOrder { get; set; }
        public double? SkuretailPrice { get; set; }
        public int? SkuparentSkuid { get; set; }
        public string SkushortDescription { get; set; }
        public int? SkueproductFilesCount { get; set; }
        public int? SkubundleItemsCount { get; set; }
        public DateTime? SkuinStoreFrom { get; set; }
        public int? SkureorderAt { get; set; }
        public string SkutrackInventory { get; set; }

        public virtual ICollection<Tree> CmsTree { get; set; }
        public virtual ICollection<ComBundle> ComBundleBundle { get; set; }
        public virtual ICollection<ComBundle> ComBundleSku { get; set; }
        public virtual ICollection<ComMultiBuyDiscount> ComMultiBuyDiscount { get; set; }
        public virtual ICollection<ComMultiBuyDiscountSku> ComMultiBuyDiscountSku { get; set; }
        public virtual ICollection<ComOrderItem> ComOrderItem { get; set; }
        public virtual ICollection<ComShoppingCartSku> ComShoppingCartSku { get; set; }
        public virtual ICollection<ComSkuallowedOption> ComSkuallowedOptionOptionSku { get; set; }
        public virtual ICollection<ComSkuallowedOption> ComSkuallowedOptionSku { get; set; }
        public virtual ICollection<ComSkudiscountCoupon> ComSkudiscountCoupon { get; set; }
        public virtual ICollection<ComSkufile> ComSkufile { get; set; }
        public virtual ICollection<ComSkuoptionCategory> ComSkuoptionCategory { get; set; }
        public virtual ICollection<ComSkutaxClasses> ComSkutaxClasses { get; set; }
        public virtual ICollection<ComVariantOption> ComVariantOptionOptionSku { get; set; }
        public virtual ICollection<ComVariantOption> ComVariantOptionVariantSku { get; set; }
        public virtual ICollection<ComVolumeDiscount> ComVolumeDiscount { get; set; }
        public virtual ICollection<ComWishlist> ComWishlist { get; set; }
        public virtual ComDepartment Skudepartment { get; set; }
        public virtual ComInternalStatus SkuinternalStatus { get; set; }
        public virtual ComManufacturer Skumanufacturer { get; set; }
        public virtual ComOptionCategory SkuoptionCategory { get; set; }
        public virtual ComSku SkuparentSku { get; set; }
        public virtual ICollection<ComSku> InverseSkuparentSku { get; set; }
        public virtual ComPublicStatus SkupublicStatus { get; set; }
        public virtual Site Skusite { get; set; }
        public virtual ComSupplier Skusupplier { get; set; }
    }
}

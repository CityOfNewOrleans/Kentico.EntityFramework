using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models.Cms
{
    public partial class BannerCategory
    {
        public BannerCategory()
        {
            CmsBanner = new HashSet<Banner>();
        }

        public int BannerCategoryId { get; set; }
        public string BannerCategoryName { get; set; }
        public string BannerCategoryDisplayName { get; set; }
        public int? BannerCategorySiteId { get; set; }
        public Guid BannerCategoryGuid { get; set; }
        public DateTime BannerCategoryLastModified { get; set; }
        public bool BannerCategoryEnabled { get; set; }

        public virtual ICollection<Banner> CmsBanner { get; set; }
        public virtual Site BannerCategorySite { get; set; }
    }
}

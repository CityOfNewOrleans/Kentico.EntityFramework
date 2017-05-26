using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class CmsBannerCategory
    {
        public CmsBannerCategory()
        {
            CmsBanner = new HashSet<CmsBanner>();
        }

        public int BannerCategoryId { get; set; }
        public string BannerCategoryName { get; set; }
        public string BannerCategoryDisplayName { get; set; }
        public int? BannerCategorySiteId { get; set; }
        public Guid BannerCategoryGuid { get; set; }
        public DateTime BannerCategoryLastModified { get; set; }
        public bool BannerCategoryEnabled { get; set; }

        public virtual ICollection<CmsBanner> CmsBanner { get; set; }
        public virtual CmsSite BannerCategorySite { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class CmsBanner
    {
        public int BannerId { get; set; }
        public string BannerName { get; set; }
        public string BannerDisplayName { get; set; }
        public int BannerCategoryId { get; set; }
        public bool BannerEnabled { get; set; }
        public DateTime? BannerFrom { get; set; }
        public DateTime? BannerTo { get; set; }
        public Guid BannerGuid { get; set; }
        public DateTime BannerLastModified { get; set; }
        public int BannerType { get; set; }
        public string BannerUrl { get; set; }
        public bool BannerBlank { get; set; }
        public double BannerWeight { get; set; }
        public int? BannerHitsLeft { get; set; }
        public int? BannerClicksLeft { get; set; }
        public int? BannerSiteId { get; set; }
        public string BannerContent { get; set; }

        public virtual CmsBannerCategory BannerCategory { get; set; }
        public virtual CmsSite BannerSite { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models.Analytics
{
    public partial class CampaignAsset
    {
        public CampaignAsset()
        {
            AnalyticsCampaignAssetUrl = new HashSet<CampaignAssetUrl>();
        }

        public int CampaignAssetId { get; set; }
        public Guid CampaignAssetGuid { get; set; }
        public DateTime CampaignAssetLastModified { get; set; }
        public Guid CampaignAssetAssetGuid { get; set; }
        public int CampaignAssetCampaignId { get; set; }
        public string CampaignAssetType { get; set; }
        public string CampaignAssetSiteName { get; set; }

        public virtual ICollection<CampaignAssetUrl> AnalyticsCampaignAssetUrl { get; set; }
        public virtual Campaign Campaign { get; set; }
    }
}

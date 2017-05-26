using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class AnalyticsCampaignAsset
    {
        public AnalyticsCampaignAsset()
        {
            AnalyticsCampaignAssetUrl = new HashSet<AnalyticsCampaignAssetUrl>();
        }

        public int CampaignAssetId { get; set; }
        public Guid CampaignAssetGuid { get; set; }
        public DateTime CampaignAssetLastModified { get; set; }
        public Guid CampaignAssetAssetGuid { get; set; }
        public int CampaignAssetCampaignId { get; set; }
        public string CampaignAssetType { get; set; }
        public string CampaignAssetSiteName { get; set; }

        public virtual ICollection<AnalyticsCampaignAssetUrl> AnalyticsCampaignAssetUrl { get; set; }
        public virtual AnalyticsCampaign CampaignAssetCampaign { get; set; }
    }
}

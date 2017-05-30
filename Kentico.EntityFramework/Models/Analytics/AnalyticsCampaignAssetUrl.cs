using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class AnalyticsCampaignAssetUrl
    {
        public int CampaignAssetUrlId { get; set; }
        public Guid CampaignAssetUrlGuid { get; set; }
        public string CampaignAssetUrlTarget { get; set; }
        public string CampaignAssetUrlPageTitle { get; set; }
        public int CampaignAssetUrlCampaignAssetId { get; set; }

        public virtual AnalyticsCampaignAsset CampaignAssetUrlCampaignAsset { get; set; }
    }
}

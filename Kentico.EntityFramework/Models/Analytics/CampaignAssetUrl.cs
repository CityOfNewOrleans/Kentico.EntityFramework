using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models.Analytics
{
    public partial class CampaignAssetUrl
    {
        public int CampaignAssetUrlId { get; set; }
        public Guid CampaignAssetUrlGuid { get; set; }
        public string CampaignAssetUrlTarget { get; set; }
        public string CampaignAssetUrlPageTitle { get; set; }
        public int CampaignAssetUrlCampaignAssetId { get; set; }

        public virtual CampaignAsset CampaignAssetUrlCampaignAsset { get; set; }
    }
}

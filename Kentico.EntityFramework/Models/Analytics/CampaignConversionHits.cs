using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models.Analytics
{
    public partial class CampaignConversionHits
    {
        public int CampaignConversionHitsId { get; set; }
        public int CampaignConversionHitsConversionId { get; set; }
        public int CampaignConversionHitsCount { get; set; }
        public string CampaignConversionHitsSourceName { get; set; }

        public virtual CampaignConversion CampaignConversionHitsConversion { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class AnalyticsCampaignConversionHits
    {
        public int CampaignConversionHitsId { get; set; }
        public int CampaignConversionHitsConversionId { get; set; }
        public int CampaignConversionHitsCount { get; set; }
        public string CampaignConversionHitsSourceName { get; set; }

        public virtual AnalyticsCampaignConversion CampaignConversionHitsConversion { get; set; }
    }
}

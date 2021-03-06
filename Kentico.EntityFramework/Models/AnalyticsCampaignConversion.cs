﻿using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class AnalyticsCampaignConversion
    {
        public AnalyticsCampaignConversion()
        {
            AnalyticsCampaignConversionHits = new HashSet<AnalyticsCampaignConversionHits>();
            AnalyticsCampaignObjective = new HashSet<AnalyticsCampaignObjective>();
        }

        public int CampaignConversionId { get; set; }
        public Guid CampaignConversionGuid { get; set; }
        public DateTime CampaignConversionLastModified { get; set; }
        public string CampaignConversionDisplayName { get; set; }
        public string CampaignConversionName { get; set; }
        public int CampaignConversionCampaignId { get; set; }
        public int CampaignConversionOrder { get; set; }
        public string CampaignConversionActivityType { get; set; }
        public int CampaignConversionHits { get; set; }
        public int? CampaignConversionItemId { get; set; }
        public double CampaignConversionValue { get; set; }
        public bool CampaignConversionIsFunnelStep { get; set; }
        public string CampaignConversionUrl { get; set; }

        public virtual ICollection<AnalyticsCampaignConversionHits> AnalyticsCampaignConversionHits { get; set; }
        public virtual ICollection<AnalyticsCampaignObjective> AnalyticsCampaignObjective { get; set; }
        public virtual AnalyticsCampaign CampaignConversionCampaign { get; set; }
    }
}

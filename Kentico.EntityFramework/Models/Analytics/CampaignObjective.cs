using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models.Analytics
{
    public partial class CampaignObjective
    {
        public int CampaignObjectiveId { get; set; }
        public Guid CampaignObjectiveGuid { get; set; }
        public DateTime CampaignObjectiveLastModified { get; set; }
        public int CampaignObjectiveCampaignId { get; set; }
        public int? CampaignObjectiveValue { get; set; }
        public int CampaignObjectiveCampaignConversionId { get; set; }

        public virtual CampaignConversion CampaignObjectiveCampaignConversion { get; set; }
        public virtual Campaign CampaignObjectiveCampaign { get; set; }
    }
}

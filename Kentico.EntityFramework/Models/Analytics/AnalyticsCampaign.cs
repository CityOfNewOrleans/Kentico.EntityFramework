using Kentico.EntityFramework.Models.Cms;
using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class AnalyticsCampaign
    {
        public AnalyticsCampaign()
        {
            AnalyticsCampaignAsset = new HashSet<AnalyticsCampaignAsset>();
            AnalyticsCampaignConversion = new HashSet<AnalyticsCampaignConversion>();
            SmFacebookPost = new HashSet<SmFacebookPost>();
            SmLinkedInPost = new HashSet<SmLinkedInPost>();
            SmTwitterPost = new HashSet<SmTwitterPost>();
        }

        public int CampaignId { get; set; }
        public string CampaignName { get; set; }
        public string CampaignDisplayName { get; set; }
        public string CampaignDescription { get; set; }
        public int CampaignSiteId { get; set; }
        public DateTime? CampaignOpenFrom { get; set; }
        public DateTime? CampaignOpenTo { get; set; }
        public Guid CampaignGuid { get; set; }
        public DateTime CampaignLastModified { get; set; }
        public string CampaignUtmcode { get; set; }
        public DateTime? CampaignCalculatedTo { get; set; }
        public int? CampaignScheduledTaskId { get; set; }
        public int? CampaignVisitors { get; set; }

        public virtual ICollection<AnalyticsCampaignAsset> AnalyticsCampaignAsset { get; set; }
        public virtual ICollection<AnalyticsCampaignConversion> AnalyticsCampaignConversion { get; set; }
        public virtual AnalyticsCampaignObjective AnalyticsCampaignObjective { get; set; }
        public virtual ICollection<SmFacebookPost> SmFacebookPost { get; set; }
        public virtual ICollection<SmLinkedInPost> SmLinkedInPost { get; set; }
        public virtual ICollection<SmTwitterPost> SmTwitterPost { get; set; }
        public virtual ScheduledTask CampaignScheduledTask { get; set; }
        public virtual Site CampaignSite { get; set; }
    }
}

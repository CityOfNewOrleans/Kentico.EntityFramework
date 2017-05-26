using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class SmInsight
    {
        public SmInsight()
        {
            SmInsightHitDay = new HashSet<SmInsightHitDay>();
            SmInsightHitMonth = new HashSet<SmInsightHitMonth>();
            SmInsightHitWeek = new HashSet<SmInsightHitWeek>();
            SmInsightHitYear = new HashSet<SmInsightHitYear>();
        }

        public int InsightId { get; set; }
        public string InsightCodeName { get; set; }
        public string InsightExternalId { get; set; }
        public string InsightPeriodType { get; set; }
        public string InsightValueName { get; set; }

        public virtual ICollection<SmInsightHitDay> SmInsightHitDay { get; set; }
        public virtual ICollection<SmInsightHitMonth> SmInsightHitMonth { get; set; }
        public virtual ICollection<SmInsightHitWeek> SmInsightHitWeek { get; set; }
        public virtual ICollection<SmInsightHitYear> SmInsightHitYear { get; set; }
    }
}

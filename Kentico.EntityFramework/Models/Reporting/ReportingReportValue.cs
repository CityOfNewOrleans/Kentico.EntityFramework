using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class ReportingReportValue
    {
        public ReportingReportValue()
        {
            ReportingReportSubscription = new HashSet<ReportingReportSubscription>();
        }

        public int ValueId { get; set; }
        public string ValueName { get; set; }
        public string ValueDisplayName { get; set; }
        public string ValueQuery { get; set; }
        public bool ValueQueryIsStoredProcedure { get; set; }
        public string ValueFormatString { get; set; }
        public int ValueReportId { get; set; }
        public Guid ValueGuid { get; set; }
        public DateTime ValueLastModified { get; set; }
        public string ValueSettings { get; set; }
        public string ValueConnectionString { get; set; }

        public virtual ICollection<ReportingReportSubscription> ReportingReportSubscription { get; set; }
        public virtual ReportingReport ValueReport { get; set; }
    }
}

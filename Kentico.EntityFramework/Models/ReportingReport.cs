using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class ReportingReport
    {
        public ReportingReport()
        {
            ReportingReportGraph = new HashSet<ReportingReportGraph>();
            ReportingReportSubscription = new HashSet<ReportingReportSubscription>();
            ReportingReportTable = new HashSet<ReportingReportTable>();
            ReportingReportValue = new HashSet<ReportingReportValue>();
            ReportingSavedReport = new HashSet<ReportingSavedReport>();
        }

        public int ReportId { get; set; }
        public string ReportName { get; set; }
        public string ReportDisplayName { get; set; }
        public string ReportLayout { get; set; }
        public string ReportParameters { get; set; }
        public int ReportCategoryId { get; set; }
        public int ReportAccess { get; set; }
        public Guid ReportGuid { get; set; }
        public DateTime ReportLastModified { get; set; }
        public bool? ReportEnableSubscription { get; set; }
        public string ReportConnectionString { get; set; }

        public virtual ICollection<ReportingReportGraph> ReportingReportGraph { get; set; }
        public virtual ICollection<ReportingReportSubscription> ReportingReportSubscription { get; set; }
        public virtual ICollection<ReportingReportTable> ReportingReportTable { get; set; }
        public virtual ICollection<ReportingReportValue> ReportingReportValue { get; set; }
        public virtual ICollection<ReportingSavedReport> ReportingSavedReport { get; set; }
        public virtual ReportingReportCategory ReportCategory { get; set; }
    }
}

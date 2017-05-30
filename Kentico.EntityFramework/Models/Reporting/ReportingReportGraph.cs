using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class ReportingReportGraph
    {
        public ReportingReportGraph()
        {
            ReportingReportSubscription = new HashSet<ReportingReportSubscription>();
        }

        public int GraphId { get; set; }
        public string GraphName { get; set; }
        public string GraphDisplayName { get; set; }
        public string GraphQuery { get; set; }
        public bool GraphQueryIsStoredProcedure { get; set; }
        public string GraphType { get; set; }
        public int GraphReportId { get; set; }
        public string GraphTitle { get; set; }
        public string GraphXaxisTitle { get; set; }
        public string GraphYaxisTitle { get; set; }
        public int? GraphWidth { get; set; }
        public int? GraphHeight { get; set; }
        public int? GraphLegendPosition { get; set; }
        public string GraphSettings { get; set; }
        public Guid GraphGuid { get; set; }
        public DateTime GraphLastModified { get; set; }
        public bool? GraphIsHtml { get; set; }
        public string GraphConnectionString { get; set; }

        public virtual ICollection<ReportingReportSubscription> ReportingReportSubscription { get; set; }
        public virtual ReportingReport GraphReport { get; set; }
    }
}

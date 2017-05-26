using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class ReportingSavedReport
    {
        public ReportingSavedReport()
        {
            ReportingSavedGraph = new HashSet<ReportingSavedGraph>();
        }

        public int SavedReportId { get; set; }
        public int SavedReportReportId { get; set; }
        public Guid SavedReportGuid { get; set; }
        public string SavedReportTitle { get; set; }
        public DateTime SavedReportDate { get; set; }
        public string SavedReportHtml { get; set; }
        public string SavedReportParameters { get; set; }
        public int? SavedReportCreatedByUserId { get; set; }
        public DateTime SavedReportLastModified { get; set; }

        public virtual ICollection<ReportingSavedGraph> ReportingSavedGraph { get; set; }
        public virtual CmsUser SavedReportCreatedByUser { get; set; }
        public virtual ReportingReport SavedReportReport { get; set; }
    }
}

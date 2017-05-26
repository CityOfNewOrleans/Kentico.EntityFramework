using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class ReportingReportCategory
    {
        public ReportingReportCategory()
        {
            ReportingReport = new HashSet<ReportingReport>();
        }

        public int CategoryId { get; set; }
        public string CategoryDisplayName { get; set; }
        public string CategoryCodeName { get; set; }
        public Guid CategoryGuid { get; set; }
        public DateTime CategoryLastModified { get; set; }
        public int? CategoryParentId { get; set; }
        public string CategoryImagePath { get; set; }
        public string CategoryPath { get; set; }
        public int? CategoryLevel { get; set; }
        public int? CategoryChildCount { get; set; }
        public int? CategoryReportChildCount { get; set; }

        public virtual ICollection<ReportingReport> ReportingReport { get; set; }
        public virtual ReportingReportCategory CategoryParent { get; set; }
        public virtual ICollection<ReportingReportCategory> InverseCategoryParent { get; set; }
    }
}

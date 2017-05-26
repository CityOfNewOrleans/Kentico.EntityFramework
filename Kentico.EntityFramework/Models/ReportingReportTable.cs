using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class ReportingReportTable
    {
        public ReportingReportTable()
        {
            ReportingReportSubscription = new HashSet<ReportingReportSubscription>();
        }

        public int TableId { get; set; }
        public string TableName { get; set; }
        public string TableDisplayName { get; set; }
        public string TableQuery { get; set; }
        public bool TableQueryIsStoredProcedure { get; set; }
        public int TableReportId { get; set; }
        public string TableSettings { get; set; }
        public Guid TableGuid { get; set; }
        public DateTime TableLastModified { get; set; }
        public string TableConnectionString { get; set; }

        public virtual ICollection<ReportingReportSubscription> ReportingReportSubscription { get; set; }
        public virtual ReportingReport TableReport { get; set; }
    }
}

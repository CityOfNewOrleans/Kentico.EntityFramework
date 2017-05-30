using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models.Cms
{
    public partial class AbuseReport
    {
        public int ReportId { get; set; }
        public Guid ReportGuid { get; set; }
        public string ReportTitle { get; set; }
        public string ReportUrl { get; set; }
        public string ReportCulture { get; set; }
        public int? ReportObjectId { get; set; }
        public string ReportObjectType { get; set; }
        public string ReportComment { get; set; }
        public int? ReportUserId { get; set; }
        public DateTime ReportWhen { get; set; }
        public int ReportStatus { get; set; }
        public int ReportSiteId { get; set; }

        public virtual Site ReportSite { get; set; }
        public virtual User ReportUser { get; set; }
    }
}

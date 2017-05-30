using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models.Cms
{
    public class ExportHistory
    {
        public int ExportId { get; set; }
        public DateTime ExportDateTime { get; set; }
        public string ExportFileName { get; set; }
        public int? ExportSiteId { get; set; }
        public int? ExportUserId { get; set; }
        public string ExportSettings { get; set; }

        public virtual Site ExportSite { get; set; }
        public virtual User ExportUser { get; set; }
    }
}

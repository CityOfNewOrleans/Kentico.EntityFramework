﻿using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class ExportHistory
    {
        public int ExportId { get; set; }
        public DateTime ExportDateTime { get; set; }
        public string ExportFileName { get; set; }
        public int? ExportSiteId { get; set; }
        public int? ExportUserId { get; set; }
        public string ExportSettings { get; set; }

        public virtual CmsSite ExportSite { get; set; }
        public virtual CmsUser ExportUser { get; set; }
    }
}

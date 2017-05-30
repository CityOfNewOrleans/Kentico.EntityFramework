using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class ReportingSavedGraph
    {
        public int SavedGraphId { get; set; }
        public int SavedGraphSavedReportId { get; set; }
        public Guid SavedGraphGuid { get; set; }
        public byte[] SavedGraphBinary { get; set; }
        public string SavedGraphMimeType { get; set; }
        public DateTime SavedGraphLastModified { get; set; }

        public virtual ReportingSavedReport SavedGraphSavedReport { get; set; }
    }
}

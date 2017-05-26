using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class CmsInlineControl
    {
        public int ControlId { get; set; }
        public string ControlDisplayName { get; set; }
        public string ControlName { get; set; }
        public string ControlDescription { get; set; }
        public Guid ControlGuid { get; set; }
        public DateTime ControlLastModified { get; set; }
        public string ControlFileName { get; set; }
        public int? ControlResourceId { get; set; }

        public virtual CmsResource ControlResource { get; set; }
    }
}

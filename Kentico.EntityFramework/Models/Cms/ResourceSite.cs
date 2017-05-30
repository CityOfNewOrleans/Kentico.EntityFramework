using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models.Cms
{
    public partial class ResourceSite
    {
        public int ResourceId { get; set; }
        public int SiteId { get; set; }

        public virtual Resource Resource { get; set; }
        public virtual Site Site { get; set; }
    }
}

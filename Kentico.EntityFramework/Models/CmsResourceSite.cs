using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class CmsResourceSite
    {
        public int ResourceId { get; set; }
        public int SiteId { get; set; }

        public virtual CmsResource Resource { get; set; }
        public virtual CmsSite Site { get; set; }
    }
}

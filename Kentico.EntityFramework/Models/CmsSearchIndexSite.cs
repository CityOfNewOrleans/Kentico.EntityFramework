using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class CmsSearchIndexSite
    {
        public int IndexId { get; set; }
        public int IndexSiteId { get; set; }

        public virtual CmsSearchIndex Index { get; set; }
        public virtual CmsSite IndexSite { get; set; }
    }
}

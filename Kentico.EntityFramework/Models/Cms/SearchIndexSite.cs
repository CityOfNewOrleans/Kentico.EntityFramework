using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models.Cms
{
    public partial class SearchIndexSite
    {
        public int IndexId { get; set; }
        public int IndexSiteId { get; set; }

        public virtual SearchIndex Index { get; set; }
        public virtual Site IndexSite { get; set; }
    }
}

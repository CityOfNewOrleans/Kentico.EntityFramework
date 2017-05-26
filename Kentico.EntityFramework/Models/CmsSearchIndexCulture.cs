using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class CmsSearchIndexCulture
    {
        public int IndexId { get; set; }
        public int IndexCultureId { get; set; }

        public virtual CmsCulture IndexCulture { get; set; }
        public virtual CmsSearchIndex Index { get; set; }
    }
}

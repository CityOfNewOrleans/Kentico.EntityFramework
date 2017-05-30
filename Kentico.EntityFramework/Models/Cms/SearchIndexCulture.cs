using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models.Cms
{
    public partial class SearchIndexCulture
    {
        public int IndexId { get; set; }
        public int IndexCultureId { get; set; }

        public virtual Culture IndexCulture { get; set; }
        public virtual SearchIndex Index { get; set; }
    }
}

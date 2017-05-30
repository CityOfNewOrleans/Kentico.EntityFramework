using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models.Cms
{
    public partial class SiteCulture
    {
        public int SiteId { get; set; }
        public int CultureId { get; set; }

        public virtual Culture Culture { get; set; }
        public virtual Site Site { get; set; }
    }
}

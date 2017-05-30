using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models.Cms
{
    public partial class PageTemplateSite
    {
        public int PageTemplateId { get; set; }
        public int SiteId { get; set; }

        public virtual PageTemplate PageTemplate { get; set; }
        public virtual Site Site { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class CmsPageTemplateSite
    {
        public int PageTemplateId { get; set; }
        public int SiteId { get; set; }

        public virtual CmsPageTemplate PageTemplate { get; set; }
        public virtual CmsSite Site { get; set; }
    }
}

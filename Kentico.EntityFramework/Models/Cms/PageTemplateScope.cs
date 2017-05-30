using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models.Cms
{
    public partial class PageTemplateScope
    {
        public int PageTemplateScopeId { get; set; }
        public string PageTemplateScopePath { get; set; }
        public string PageTemplateScopeLevels { get; set; }
        public int? PageTemplateScopeCultureId { get; set; }
        public int? PageTemplateScopeClassId { get; set; }
        public int PageTemplateScopeTemplateId { get; set; }
        public int? PageTemplateScopeSiteId { get; set; }
        public DateTime PageTemplateScopeLastModified { get; set; }
        public Guid PageTemplateScopeGuid { get; set; }

        public virtual Class PageTemplateScopeClass { get; set; }
        public virtual Culture PageTemplateScopeCulture { get; set; }
        public virtual Site PageTemplateScopeSite { get; set; }
        public virtual PageTemplate PageTemplateScopeTemplate { get; set; }
    }
}

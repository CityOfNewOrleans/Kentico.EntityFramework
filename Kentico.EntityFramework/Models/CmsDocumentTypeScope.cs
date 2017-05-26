using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class CmsDocumentTypeScope
    {
        public CmsDocumentTypeScope()
        {
            CmsDocumentTypeScopeClass = new HashSet<CmsDocumentTypeScopeClass>();
        }

        public int ScopeId { get; set; }
        public string ScopePath { get; set; }
        public int? ScopeSiteId { get; set; }
        public DateTime ScopeLastModified { get; set; }
        public Guid? ScopeGuid { get; set; }
        public bool? ScopeIncludeChildren { get; set; }
        public bool? ScopeAllowAllTypes { get; set; }
        public bool? ScopeAllowLinks { get; set; }
        public bool? ScopeAllowAbvariant { get; set; }
        public string ScopeMacroCondition { get; set; }

        public virtual ICollection<CmsDocumentTypeScopeClass> CmsDocumentTypeScopeClass { get; set; }
        public virtual CmsSite ScopeSite { get; set; }
    }
}

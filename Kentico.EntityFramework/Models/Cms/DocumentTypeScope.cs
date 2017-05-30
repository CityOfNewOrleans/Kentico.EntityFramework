using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models.Cms
{
    public partial class DocumentTypeScope
    {
        public DocumentTypeScope()
        {
            CmsDocumentTypeScopeClass = new HashSet<DocumentTypeScopeClass>();
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

        public virtual ICollection<DocumentTypeScopeClass> CmsDocumentTypeScopeClass { get; set; }
        public virtual Site ScopeSite { get; set; }
    }
}

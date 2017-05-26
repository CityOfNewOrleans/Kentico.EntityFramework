using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class CmsDocumentTypeScopeClass
    {
        public int ScopeId { get; set; }
        public int ClassId { get; set; }

        public virtual CmsClass Class { get; set; }
        public virtual CmsDocumentTypeScope Scope { get; set; }
    }
}

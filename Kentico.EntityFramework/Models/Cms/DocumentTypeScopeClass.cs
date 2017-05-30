using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models.Cms
{
    public partial class DocumentTypeScopeClass
    {
        public int ScopeId { get; set; }
        public int ClassId { get; set; }

        public virtual Class Class { get; set; }
        public virtual DocumentTypeScope Scope { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class CmsDocumentCategory
    {
        public int DocumentId { get; set; }
        public int CategoryId { get; set; }

        public virtual CmsCategory Category { get; set; }
        public virtual CmsDocument Document { get; set; }
    }
}

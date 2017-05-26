using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class CmsDocumentTag
    {
        public int DocumentId { get; set; }
        public int TagId { get; set; }

        public virtual CmsDocument Document { get; set; }
        public virtual CmsTag Tag { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models.Cms
{
    public partial class DocumentTag
    {
        public int DocumentId { get; set; }
        public int TagId { get; set; }

        public virtual Document Document { get; set; }
        public virtual Tag Tag { get; set; }
    }
}

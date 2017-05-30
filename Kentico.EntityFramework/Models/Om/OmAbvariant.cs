using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class OmAbvariant
    {
        public int AbvariantId { get; set; }
        public string AbvariantDisplayName { get; set; }
        public string AbvariantName { get; set; }
        public int AbvariantTestId { get; set; }
        public string AbvariantPath { get; set; }
        public Guid AbvariantGuid { get; set; }
        public DateTime AbvariantLastModified { get; set; }
        public int AbvariantSiteId { get; set; }

        public virtual Site AbvariantSite { get; set; }
        public virtual OmAbtest AbvariantTest { get; set; }
    }
}

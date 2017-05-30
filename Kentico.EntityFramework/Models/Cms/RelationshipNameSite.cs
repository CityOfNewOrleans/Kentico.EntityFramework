using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models.Cms
{
    public partial class RelationshipNameSite
    {
        public int RelationshipNameId { get; set; }
        public int SiteId { get; set; }

        public virtual RelationshipName RelationshipName { get; set; }
        public virtual Site Site { get; set; }
    }
}

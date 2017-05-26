using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class CmsRelationshipNameSite
    {
        public int RelationshipNameId { get; set; }
        public int SiteId { get; set; }

        public virtual CmsRelationshipName RelationshipName { get; set; }
        public virtual CmsSite Site { get; set; }
    }
}

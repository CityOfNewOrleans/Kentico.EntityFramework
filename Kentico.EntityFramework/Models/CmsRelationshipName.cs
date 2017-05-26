using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class CmsRelationshipName
    {
        public CmsRelationshipName()
        {
            CmsRelationship = new HashSet<CmsRelationship>();
            CmsRelationshipNameSite = new HashSet<CmsRelationshipNameSite>();
        }

        public int RelationshipNameId { get; set; }
        public string RelationshipDisplayName { get; set; }
        public string RelationshipName { get; set; }
        public string RelationshipAllowedObjects { get; set; }
        public Guid RelationshipGuid { get; set; }
        public DateTime RelationshipLastModified { get; set; }
        public bool? RelationshipNameIsAdHoc { get; set; }

        public virtual ICollection<CmsRelationship> CmsRelationship { get; set; }
        public virtual ICollection<CmsRelationshipNameSite> CmsRelationshipNameSite { get; set; }
    }
}

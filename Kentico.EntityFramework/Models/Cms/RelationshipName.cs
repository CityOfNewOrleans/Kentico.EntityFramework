using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models.Cms
{
    public partial class RelationshipName
    {
        public RelationshipName()
        {
            CmsRelationship = new HashSet<Relationship>();
            CmsRelationshipNameSite = new HashSet<RelationshipNameSite>();
        }

        public int RelationshipNameId { get; set; }
        public string RelationshipDisplayName { get; set; }
        public string Name { get; set; }
        public string RelationshipAllowedObjects { get; set; }
        public Guid RelationshipGuid { get; set; }
        public DateTime RelationshipLastModified { get; set; }
        public bool? RelationshipNameIsAdHoc { get; set; }

        public virtual ICollection<Relationship> CmsRelationship { get; set; }
        public virtual ICollection<RelationshipNameSite> CmsRelationshipNameSite { get; set; }
    }
}

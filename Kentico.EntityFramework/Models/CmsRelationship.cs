using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class CmsRelationship
    {
        public int RelationshipId { get; set; }
        public int LeftNodeId { get; set; }
        public int RightNodeId { get; set; }
        public int RelationshipNameId { get; set; }
        public string RelationshipCustomData { get; set; }
        public int? RelationshipOrder { get; set; }
        public bool? RelationshipIsAdHoc { get; set; }

        public virtual CmsTree LeftNode { get; set; }
        public virtual CmsRelationshipName RelationshipName { get; set; }
        public virtual CmsTree RightNode { get; set; }
    }
}

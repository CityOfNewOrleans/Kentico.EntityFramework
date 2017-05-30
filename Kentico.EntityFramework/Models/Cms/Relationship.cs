using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models.Cms
{
    public partial class Relationship
    {
        public int RelationshipId { get; set; }
        public int LeftNodeId { get; set; }
        public int RightNodeId { get; set; }
        public int RelationshipNameId { get; set; }
        public string RelationshipCustomData { get; set; }
        public int? RelationshipOrder { get; set; }
        public bool? RelationshipIsAdHoc { get; set; }

        public virtual Tree LeftNode { get; set; }
        public virtual RelationshipName RelationshipName { get; set; }
        public virtual Tree RightNode { get; set; }
    }
}

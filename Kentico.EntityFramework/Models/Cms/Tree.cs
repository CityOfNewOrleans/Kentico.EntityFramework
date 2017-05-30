using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models.Cms
{
    public partial class Tree
    {
        public Tree()
        {
            CmsDocument = new HashSet<Document>();
            CmsDocumentAlias = new HashSet<DocumentAlias>();
            CmsRelationshipLeftNode = new HashSet<Relationship>();
            CmsRelationshipRightNode = new HashSet<Relationship>();
            EventsAttendee = new HashSet<EventsAttendee>();
            PersonasPersonaNode = new HashSet<PersonasPersonaNode>();
        }

        public int NodeId { get; set; }
        public string NodeAliasPath { get; set; }
        public string NodeName { get; set; }
        public string NodeAlias { get; set; }
        public int NodeClassId { get; set; }
        public int? NodeParentId { get; set; }
        public int NodeLevel { get; set; }
        public int? NodeAclid { get; set; }
        public int NodeSiteId { get; set; }
        public Guid NodeGuid { get; set; }
        public int? NodeOrder { get; set; }
        public bool? IsSecuredNode { get; set; }
        public int? NodeCacheMinutes { get; set; }
        public int? NodeSkuid { get; set; }
        public string NodeDocType { get; set; }
        public string NodeHeadTags { get; set; }
        public string NodeBodyElementAttributes { get; set; }
        public string NodeInheritPageLevels { get; set; }
        public int? RequiresSsl { get; set; }
        public int? NodeLinkedNodeId { get; set; }
        public int? NodeOwner { get; set; }
        public string NodeCustomData { get; set; }
        public int? NodeGroupId { get; set; }
        public int? NodeLinkedNodeSiteId { get; set; }
        public int? NodeTemplateId { get; set; }
        public bool? NodeTemplateForAllCultures { get; set; }
        public bool? NodeInheritPageTemplate { get; set; }
        public bool? NodeAllowCacheInFileSystem { get; set; }
        public bool? NodeHasChildren { get; set; }
        public bool? NodeHasLinks { get; set; }
        public int? NodeOriginalNodeId { get; set; }
        public bool NodeIsContentOnly { get; set; }
        public bool NodeIsAclowner { get; set; }
        public string NodeBodyScripts { get; set; }

        public virtual ICollection<Document> CmsDocument { get; set; }
        public virtual ICollection<DocumentAlias> CmsDocumentAlias { get; set; }
        public virtual ICollection<Relationship> CmsRelationshipLeftNode { get; set; }
        public virtual ICollection<Relationship> CmsRelationshipRightNode { get; set; }
        public virtual ICollection<EventsAttendee> EventsAttendee { get; set; }
        public virtual ICollection<PersonasPersonaNode> PersonasPersonaNode { get; set; }
        public virtual UserLevelPermission NodeAcl { get; set; }
        public virtual Class NodeClass { get; set; }
        public virtual CommunityGroup NodeGroup { get; set; }
        public virtual Tree NodeLinkedNode { get; set; }
        public virtual ICollection<Tree> InverseNodeLinkedNode { get; set; }
        public virtual Site NodeLinkedNodeSite { get; set; }
        public virtual Tree NodeOriginalNode { get; set; }
        public virtual ICollection<Tree> InverseNodeOriginalNode { get; set; }
        public virtual User NodeOwnerNavigation { get; set; }
        public virtual Tree NodeParent { get; set; }
        public virtual ICollection<Tree> InverseNodeParent { get; set; }
        public virtual Site NodeSite { get; set; }
        public virtual ComSku NodeSku { get; set; }
        public virtual PageTemplate NodeTemplate { get; set; }
    }
}

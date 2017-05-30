using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models.Cms
{
    public partial class TagGroup
    {
        public TagGroup()
        {
            CmsDocument = new HashSet<Document>();
            CmsTag = new HashSet<Tag>();
        }

        public int TagGroupId { get; set; }
        public string TagGroupDisplayName { get; set; }
        public string TagGroupName { get; set; }
        public string TagGroupDescription { get; set; }
        public int TagGroupSiteId { get; set; }
        public bool TagGroupIsAdHoc { get; set; }
        public DateTime TagGroupLastModified { get; set; }
        public Guid TagGroupGuid { get; set; }

        public virtual ICollection<Document> CmsDocument { get; set; }
        public virtual ICollection<Tag> CmsTag { get; set; }
        public virtual Site TagGroupSite { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class CmsTagGroup
    {
        public CmsTagGroup()
        {
            CmsDocument = new HashSet<CmsDocument>();
            CmsTag = new HashSet<CmsTag>();
        }

        public int TagGroupId { get; set; }
        public string TagGroupDisplayName { get; set; }
        public string TagGroupName { get; set; }
        public string TagGroupDescription { get; set; }
        public int TagGroupSiteId { get; set; }
        public bool TagGroupIsAdHoc { get; set; }
        public DateTime TagGroupLastModified { get; set; }
        public Guid TagGroupGuid { get; set; }

        public virtual ICollection<CmsDocument> CmsDocument { get; set; }
        public virtual ICollection<CmsTag> CmsTag { get; set; }
        public virtual CmsSite TagGroupSite { get; set; }
    }
}

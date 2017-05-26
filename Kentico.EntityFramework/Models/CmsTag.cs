using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class CmsTag
    {
        public CmsTag()
        {
            CmsDocumentTag = new HashSet<CmsDocumentTag>();
        }

        public int TagId { get; set; }
        public string TagName { get; set; }
        public int TagCount { get; set; }
        public int TagGroupId { get; set; }
        public Guid TagGuid { get; set; }

        public virtual ICollection<CmsDocumentTag> CmsDocumentTag { get; set; }
        public virtual CmsTagGroup TagGroup { get; set; }
    }
}

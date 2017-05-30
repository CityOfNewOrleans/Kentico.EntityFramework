using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models.Cms
{
    public partial class Tag
    {
        public Tag()
        {
            CmsDocumentTag = new HashSet<DocumentTag>();
        }

        public int TagId { get; set; }
        public string TagName { get; set; }
        public int TagCount { get; set; }
        public int TagGroupId { get; set; }
        public Guid TagGuid { get; set; }

        public virtual ICollection<DocumentTag> CmsDocumentTag { get; set; }
        public virtual TagGroup TagGroup { get; set; }
    }
}

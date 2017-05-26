using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class CmsWebPart
    {
        public CmsWebPart()
        {
            CmsWebPartLayout = new HashSet<CmsWebPartLayout>();
            CmsWidget = new HashSet<CmsWidget>();
        }

        public int WebPartId { get; set; }
        public string WebPartName { get; set; }
        public string WebPartDisplayName { get; set; }
        public string WebPartDescription { get; set; }
        public string WebPartFileName { get; set; }
        public string WebPartProperties { get; set; }
        public int WebPartCategoryId { get; set; }
        public int? WebPartParentId { get; set; }
        public string WebPartDocumentation { get; set; }
        public Guid WebPartGuid { get; set; }
        public DateTime WebPartLastModified { get; set; }
        public int? WebPartType { get; set; }
        public int WebPartLoadGeneration { get; set; }
        public string WebPartDefaultValues { get; set; }
        public int? WebPartResourceId { get; set; }
        public string WebPartCss { get; set; }
        public bool? WebPartSkipInsertProperties { get; set; }
        public Guid? WebPartThumbnailGuid { get; set; }
        public string WebPartDefaultConfiguration { get; set; }
        public string WebPartIconClass { get; set; }

        public virtual ICollection<CmsWebPartLayout> CmsWebPartLayout { get; set; }
        public virtual ICollection<CmsWidget> CmsWidget { get; set; }
        public virtual CmsWebPartCategory WebPartCategory { get; set; }
        public virtual CmsWebPart WebPartParent { get; set; }
        public virtual ICollection<CmsWebPart> InverseWebPartParent { get; set; }
        public virtual CmsResource WebPartResource { get; set; }
    }
}

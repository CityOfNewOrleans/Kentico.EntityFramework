using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class CmsWebPartCategory
    {
        public CmsWebPartCategory()
        {
            CmsWebPart = new HashSet<CmsWebPart>();
        }

        public int CategoryId { get; set; }
        public string CategoryDisplayName { get; set; }
        public int? CategoryParentId { get; set; }
        public string CategoryName { get; set; }
        public Guid CategoryGuid { get; set; }
        public DateTime CategoryLastModified { get; set; }
        public string CategoryImagePath { get; set; }
        public string CategoryPath { get; set; }
        public int? CategoryLevel { get; set; }
        public int? CategoryChildCount { get; set; }
        public int? CategoryWebPartChildCount { get; set; }

        public virtual ICollection<CmsWebPart> CmsWebPart { get; set; }
        public virtual CmsWebPartCategory CategoryParent { get; set; }
        public virtual ICollection<CmsWebPartCategory> InverseCategoryParent { get; set; }
    }
}

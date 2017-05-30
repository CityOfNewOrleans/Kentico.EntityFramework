using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models.Cms
{
    public partial class WebPartCategory
    {
        public WebPartCategory()
        {
            CmsWebPart = new HashSet<WebPart>();
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

        public virtual ICollection<WebPart> CmsWebPart { get; set; }
        public virtual WebPartCategory CategoryParent { get; set; }
        public virtual ICollection<WebPartCategory> InverseCategoryParent { get; set; }
    }
}

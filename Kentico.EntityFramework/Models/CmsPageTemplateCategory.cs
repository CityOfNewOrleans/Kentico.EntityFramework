using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class CmsPageTemplateCategory
    {
        public CmsPageTemplateCategory()
        {
            CmsClass = new HashSet<CmsClass>();
            CmsPageTemplate = new HashSet<CmsPageTemplate>();
        }

        public int CategoryId { get; set; }
        public string CategoryDisplayName { get; set; }
        public int? CategoryParentId { get; set; }
        public string CategoryName { get; set; }
        public Guid CategoryGuid { get; set; }
        public DateTime CategoryLastModified { get; set; }
        public string CategoryImagePath { get; set; }
        public int? CategoryChildCount { get; set; }
        public int? CategoryTemplateChildCount { get; set; }
        public string CategoryPath { get; set; }
        public int? CategoryLevel { get; set; }

        public virtual ICollection<CmsClass> CmsClass { get; set; }
        public virtual ICollection<CmsPageTemplate> CmsPageTemplate { get; set; }
        public virtual CmsPageTemplateCategory CategoryParent { get; set; }
        public virtual ICollection<CmsPageTemplateCategory> InverseCategoryParent { get; set; }
    }
}

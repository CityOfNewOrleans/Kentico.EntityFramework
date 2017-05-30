using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models.Cms
{
    public partial class PageTemplateCategory
    {
        public PageTemplateCategory()
        {
            CmsClass = new HashSet<Class>();
            CmsPageTemplate = new HashSet<PageTemplate>();
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

        public virtual ICollection<Class> CmsClass { get; set; }
        public virtual ICollection<PageTemplate> CmsPageTemplate { get; set; }
        public virtual PageTemplateCategory CategoryParent { get; set; }
        public virtual ICollection<PageTemplateCategory> InverseCategoryParent { get; set; }
    }
}

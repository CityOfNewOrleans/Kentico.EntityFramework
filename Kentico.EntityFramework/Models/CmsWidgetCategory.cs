using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class CmsWidgetCategory
    {
        public CmsWidgetCategory()
        {
            CmsWidget = new HashSet<CmsWidget>();
        }

        public int WidgetCategoryId { get; set; }
        public string WidgetCategoryName { get; set; }
        public string WidgetCategoryDisplayName { get; set; }
        public int? WidgetCategoryParentId { get; set; }
        public string WidgetCategoryPath { get; set; }
        public int WidgetCategoryLevel { get; set; }
        public int? WidgetCategoryChildCount { get; set; }
        public int? WidgetCategoryWidgetChildCount { get; set; }
        public string WidgetCategoryImagePath { get; set; }
        public Guid WidgetCategoryGuid { get; set; }
        public DateTime WidgetCategoryLastModified { get; set; }

        public virtual ICollection<CmsWidget> CmsWidget { get; set; }
        public virtual CmsWidgetCategory WidgetCategoryParent { get; set; }
        public virtual ICollection<CmsWidgetCategory> InverseWidgetCategoryParent { get; set; }
    }
}

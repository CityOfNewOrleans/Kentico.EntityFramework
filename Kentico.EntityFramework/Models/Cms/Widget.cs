using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models.Cms
{
    public partial class Widget
    {
        public Widget()
        {
            CmsWidgetRole = new HashSet<WidgetRole>();
        }

        public int WidgetId { get; set; }
        public int WidgetWebPartId { get; set; }
        public string WidgetDisplayName { get; set; }
        public string WidgetName { get; set; }
        public string WidgetDescription { get; set; }
        public int WidgetCategoryId { get; set; }
        public string WidgetProperties { get; set; }
        public int WidgetSecurity { get; set; }
        public Guid WidgetGuid { get; set; }
        public DateTime WidgetLastModified { get; set; }
        public bool WidgetIsEnabled { get; set; }
        public bool WidgetForGroup { get; set; }
        public bool WidgetForEditor { get; set; }
        public bool WidgetForUser { get; set; }
        public bool WidgetForDashboard { get; set; }
        public bool WidgetForInline { get; set; }
        public string WidgetDocumentation { get; set; }
        public string WidgetDefaultValues { get; set; }
        public int? WidgetLayoutId { get; set; }
        public bool? WidgetSkipInsertProperties { get; set; }
        public Guid? WidgetThumbnailGuid { get; set; }
        public string WidgetIconClass { get; set; }

        public virtual ICollection<WidgetRole> CmsWidgetRole { get; set; }
        public virtual WidgetCategory WidgetCategory { get; set; }
        public virtual WebPartLayout WidgetLayout { get; set; }
        public virtual WebPart WidgetWebPart { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class CmsSettingsCategory
    {
        public CmsSettingsCategory()
        {
            CmsSettingsKey = new HashSet<CmsSettingsKey>();
        }

        public int CategoryId { get; set; }
        public string CategoryDisplayName { get; set; }
        public int? CategoryOrder { get; set; }
        public string CategoryName { get; set; }
        public int? CategoryParentId { get; set; }
        public string CategoryIdpath { get; set; }
        public int? CategoryLevel { get; set; }
        public int? CategoryChildCount { get; set; }
        public string CategoryIconPath { get; set; }
        public bool? CategoryIsGroup { get; set; }
        public bool? CategoryIsCustom { get; set; }
        public int? CategoryResourceId { get; set; }

        public virtual ICollection<CmsSettingsKey> CmsSettingsKey { get; set; }
        public virtual CmsSettingsCategory CategoryParent { get; set; }
        public virtual ICollection<CmsSettingsCategory> InverseCategoryParent { get; set; }
        public virtual CmsResource CategoryResource { get; set; }
    }
}

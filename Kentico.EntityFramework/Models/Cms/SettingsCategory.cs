using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models.Cms
{
    public partial class SettingsCategory
    {
        public SettingsCategory()
        {
            CmsSettingsKey = new HashSet<SettingsKey>();
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

        public virtual ICollection<SettingsKey> CmsSettingsKey { get; set; }
        public virtual SettingsCategory CategoryParent { get; set; }
        public virtual ICollection<SettingsCategory> InverseCategoryParent { get; set; }
        public virtual Resource CategoryResource { get; set; }
    }
}

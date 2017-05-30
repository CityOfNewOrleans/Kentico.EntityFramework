using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models.Cms
{
    public partial class Layout
    {
        public Layout()
        {
            CmsDeviceProfileLayoutSourceLayout = new HashSet<DeviceProfileLayout>();
            CmsDeviceProfileLayoutTargetLayout = new HashSet<DeviceProfileLayout>();
            CmsPageTemplate = new HashSet<PageTemplate>();
            CmsTemplateDeviceLayout = new HashSet<TemplateDeviceLayout>();
        }

        public int LayoutId { get; set; }
        public string LayoutCodeName { get; set; }
        public string LayoutDisplayName { get; set; }
        public string LayoutDescription { get; set; }
        public string LayoutCode { get; set; }
        public string LayoutVersionGuid { get; set; }
        public Guid LayoutGuid { get; set; }
        public DateTime LayoutLastModified { get; set; }
        public string LayoutType { get; set; }
        public string LayoutCss { get; set; }
        public Guid? LayoutThumbnailGuid { get; set; }
        public int? LayoutZoneCount { get; set; }
        public bool? LayoutIsConvertible { get; set; }
        public string LayoutIconClass { get; set; }

        public virtual ICollection<DeviceProfileLayout> CmsDeviceProfileLayoutSourceLayout { get; set; }
        public virtual ICollection<DeviceProfileLayout> CmsDeviceProfileLayoutTargetLayout { get; set; }
        public virtual ICollection<PageTemplate> CmsPageTemplate { get; set; }
        public virtual ICollection<TemplateDeviceLayout> CmsTemplateDeviceLayout { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class CmsLayout
    {
        public CmsLayout()
        {
            CmsDeviceProfileLayoutSourceLayout = new HashSet<CmsDeviceProfileLayout>();
            CmsDeviceProfileLayoutTargetLayout = new HashSet<CmsDeviceProfileLayout>();
            CmsPageTemplate = new HashSet<CmsPageTemplate>();
            CmsTemplateDeviceLayout = new HashSet<CmsTemplateDeviceLayout>();
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

        public virtual ICollection<CmsDeviceProfileLayout> CmsDeviceProfileLayoutSourceLayout { get; set; }
        public virtual ICollection<CmsDeviceProfileLayout> CmsDeviceProfileLayoutTargetLayout { get; set; }
        public virtual ICollection<CmsPageTemplate> CmsPageTemplate { get; set; }
        public virtual ICollection<CmsTemplateDeviceLayout> CmsTemplateDeviceLayout { get; set; }
    }
}

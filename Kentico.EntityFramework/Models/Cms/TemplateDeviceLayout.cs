using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models.Cms
{
    public partial class TemplateDeviceLayout
    {
        public int TemplateDeviceLayoutId { get; set; }
        public int PageTemplateId { get; set; }
        public int ProfileId { get; set; }
        public int? LayoutId { get; set; }
        public string LayoutCode { get; set; }
        public string LayoutType { get; set; }
        public string LayoutCss { get; set; }
        public DateTime LayoutLastModified { get; set; }
        public Guid LayoutGuid { get; set; }
        public string LayoutVersionGuid { get; set; }

        public virtual Layout Layout { get; set; }
        public virtual PageTemplate PageTemplate { get; set; }
        public virtual DeviceProfile Profile { get; set; }
    }
}

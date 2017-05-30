using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models.Cms
{
    public partial class WebPartLayout
    {
        public WebPartLayout()
        {
            CmsWidget = new HashSet<Widget>();
        }

        public int WebPartLayoutId { get; set; }
        public string WebPartLayoutCodeName { get; set; }
        public string WebPartLayoutDisplayName { get; set; }
        public string WebPartLayoutDescription { get; set; }
        public string WebPartLayoutCode { get; set; }
        public string WebPartLayoutVersionGuid { get; set; }
        public int WebPartLayoutWebPartId { get; set; }
        public Guid WebPartLayoutGuid { get; set; }
        public DateTime WebPartLayoutLastModified { get; set; }
        public string WebPartLayoutCss { get; set; }
        public bool? WebPartLayoutIsDefault { get; set; }

        public virtual ICollection<Widget> CmsWidget { get; set; }
        public virtual WebPart WebPartLayoutWebPart { get; set; }
    }
}

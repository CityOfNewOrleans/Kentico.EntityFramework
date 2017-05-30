using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models.Cms
{
    public partial class WebPartContainerSite
    {
        public int ContainerId { get; set; }
        public int SiteId { get; set; }

        public virtual WebPartContainer Container { get; set; }
        public virtual Site Site { get; set; }
    }
}

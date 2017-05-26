using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class CmsWebPartContainerSite
    {
        public int ContainerId { get; set; }
        public int SiteId { get; set; }

        public virtual CmsWebPartContainer Container { get; set; }
        public virtual CmsSite Site { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class CmsClassSite
    {
        public int ClassId { get; set; }
        public int SiteId { get; set; }

        public virtual CmsClass Class { get; set; }
        public virtual CmsSite Site { get; set; }
    }
}

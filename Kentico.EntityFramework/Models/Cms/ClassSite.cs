using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models.Cms
{
    public partial class ClassSite
    {
        public int ClassId { get; set; }
        public int SiteId { get; set; }

        public virtual Class Class { get; set; }
        public virtual Site Site { get; set; }
    }
}

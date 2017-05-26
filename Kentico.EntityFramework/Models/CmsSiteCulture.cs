using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class CmsSiteCulture
    {
        public int SiteId { get; set; }
        public int CultureId { get; set; }

        public virtual CmsCulture Culture { get; set; }
        public virtual CmsSite Site { get; set; }
    }
}

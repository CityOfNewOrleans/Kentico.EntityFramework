using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class CmsUserCulture
    {
        public int UserId { get; set; }
        public int CultureId { get; set; }
        public int SiteId { get; set; }

        public virtual CmsCulture Culture { get; set; }
        public virtual CmsSite Site { get; set; }
        public virtual CmsUser User { get; set; }
    }
}

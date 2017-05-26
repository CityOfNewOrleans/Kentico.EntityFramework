using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class CmsUserSite
    {
        public int UserSiteId { get; set; }
        public int UserId { get; set; }
        public int SiteId { get; set; }

        public virtual CmsSite Site { get; set; }
        public virtual CmsUser User { get; set; }
    }
}

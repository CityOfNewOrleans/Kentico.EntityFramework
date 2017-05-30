using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models.Cms
{
    public partial class UserCulture
    {
        public int UserId { get; set; }
        public int CultureId { get; set; }
        public int SiteId { get; set; }

        public virtual Culture Culture { get; set; }
        public virtual Site Site { get; set; }
        public virtual User User { get; set; }
    }
}

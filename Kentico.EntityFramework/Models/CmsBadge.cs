﻿using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class CmsBadge
    {
        public CmsBadge()
        {
            CmsUserSettings = new HashSet<CmsUserSettings>();
        }

        public int BadgeId { get; set; }
        public string BadgeName { get; set; }
        public string BadgeDisplayName { get; set; }
        public string BadgeImageUrl { get; set; }
        public bool BadgeIsAutomatic { get; set; }
        public int? BadgeTopLimit { get; set; }
        public Guid BadgeGuid { get; set; }
        public DateTime BadgeLastModified { get; set; }

        public virtual ICollection<CmsUserSettings> CmsUserSettings { get; set; }
    }
}

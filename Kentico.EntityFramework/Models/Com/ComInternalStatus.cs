using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class ComInternalStatus
    {
        public ComInternalStatus()
        {
            ComSku = new HashSet<ComSku>();
        }

        public int InternalStatusId { get; set; }
        public string InternalStatusName { get; set; }
        public string InternalStatusDisplayName { get; set; }
        public bool InternalStatusEnabled { get; set; }
        public Guid InternalStatusGuid { get; set; }
        public DateTime InternalStatusLastModified { get; set; }
        public int? InternalStatusSiteId { get; set; }

        public virtual ICollection<ComSku> ComSku { get; set; }
        public virtual Site InternalStatusSite { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class ComPublicStatus
    {
        public ComPublicStatus()
        {
            ComSku = new HashSet<ComSku>();
        }

        public int PublicStatusId { get; set; }
        public string PublicStatusName { get; set; }
        public string PublicStatusDisplayName { get; set; }
        public bool PublicStatusEnabled { get; set; }
        public Guid? PublicStatusGuid { get; set; }
        public DateTime PublicStatusLastModified { get; set; }
        public int? PublicStatusSiteId { get; set; }

        public virtual ICollection<ComSku> ComSku { get; set; }
        public virtual CmsSite PublicStatusSite { get; set; }
    }
}

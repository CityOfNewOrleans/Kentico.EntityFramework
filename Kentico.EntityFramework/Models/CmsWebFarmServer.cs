using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class CmsWebFarmServer
    {
        public CmsWebFarmServer()
        {
            CmsWebFarmServerTask = new HashSet<CmsWebFarmServerTask>();
        }

        public int ServerId { get; set; }
        public string ServerDisplayName { get; set; }
        public string ServerName { get; set; }
        public Guid? ServerGuid { get; set; }
        public DateTime ServerLastModified { get; set; }
        public bool? ServerEnabled { get; set; }

        public virtual ICollection<CmsWebFarmServerTask> CmsWebFarmServerTask { get; set; }
    }
}

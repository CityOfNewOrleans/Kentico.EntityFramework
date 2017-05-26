using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class StagingServer
    {
        public StagingServer()
        {
            StagingSynchronization = new HashSet<StagingSynchronization>();
        }

        public int ServerId { get; set; }
        public string ServerName { get; set; }
        public string ServerDisplayName { get; set; }
        public int ServerSiteId { get; set; }
        public string ServerUrl { get; set; }
        public bool ServerEnabled { get; set; }
        public string ServerAuthentication { get; set; }
        public string ServerUsername { get; set; }
        public string ServerPassword { get; set; }
        public string ServerX509clientKeyId { get; set; }
        public string ServerX509serverKeyId { get; set; }
        public Guid ServerGuid { get; set; }
        public DateTime ServerLastModified { get; set; }

        public virtual ICollection<StagingSynchronization> StagingSynchronization { get; set; }
        public virtual CmsSite ServerSite { get; set; }
    }
}

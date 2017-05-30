using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class SharePointSharePointConnection
    {
        public SharePointSharePointConnection()
        {
            SharePointSharePointLibrary = new HashSet<SharePointSharePointLibrary>();
        }

        public int SharePointConnectionId { get; set; }
        public Guid SharePointConnectionGuid { get; set; }
        public int SharePointConnectionSiteId { get; set; }
        public string SharePointConnectionSiteUrl { get; set; }
        public string SharePointConnectionAuthMode { get; set; }
        public string SharePointConnectionDisplayName { get; set; }
        public string SharePointConnectionName { get; set; }
        public string SharePointConnectionSharePointVersion { get; set; }
        public string SharePointConnectionUserName { get; set; }
        public string SharePointConnectionPassword { get; set; }
        public string SharePointConnectionDomain { get; set; }
        public DateTime SharePointConnectionLastModified { get; set; }

        public virtual ICollection<SharePointSharePointLibrary> SharePointSharePointLibrary { get; set; }
        public virtual Site SharePointConnectionSite { get; set; }
    }
}

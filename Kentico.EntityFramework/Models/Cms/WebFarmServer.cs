using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models.Cms
{
    public partial class WebFarmServer
    {
        public WebFarmServer()
        {
            CmsWebFarmServerTask = new HashSet<WebFarmServerTask>();
        }

        public int ServerId { get; set; }
        public string ServerDisplayName { get; set; }
        public string ServerName { get; set; }
        public Guid? ServerGuid { get; set; }
        public DateTime ServerLastModified { get; set; }
        public bool? ServerEnabled { get; set; }

        public virtual ICollection<WebFarmServerTask> CmsWebFarmServerTask { get; set; }
    }
}

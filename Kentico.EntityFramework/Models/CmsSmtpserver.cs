using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class CmsSmtpserver
    {
        public CmsSmtpserver()
        {
            CmsSmtpserverSite = new HashSet<CmsSmtpserverSite>();
        }

        public int ServerId { get; set; }
        public string ServerName { get; set; }
        public string ServerUserName { get; set; }
        public string ServerPassword { get; set; }
        public bool ServerUseSsl { get; set; }
        public bool ServerEnabled { get; set; }
        public bool ServerIsGlobal { get; set; }
        public Guid ServerGuid { get; set; }
        public DateTime ServerLastModified { get; set; }
        public int? ServerPriority { get; set; }
        public int? ServerDeliveryMethod { get; set; }
        public string ServerPickupDirectory { get; set; }

        public virtual ICollection<CmsSmtpserverSite> CmsSmtpserverSite { get; set; }
    }
}

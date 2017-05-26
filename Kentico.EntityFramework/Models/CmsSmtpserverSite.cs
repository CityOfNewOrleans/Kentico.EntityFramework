using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class CmsSmtpserverSite
    {
        public int ServerId { get; set; }
        public int SiteId { get; set; }

        public virtual CmsSmtpserver Server { get; set; }
        public virtual CmsSite Site { get; set; }
    }
}

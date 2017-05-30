using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models.Cms
{
    public partial class SmtpServerSite
    {
        public int ServerId { get; set; }
        public int SiteId { get; set; }

        public virtual SmtpServer Server { get; set; }
        public virtual Site Site { get; set; }
    }
}

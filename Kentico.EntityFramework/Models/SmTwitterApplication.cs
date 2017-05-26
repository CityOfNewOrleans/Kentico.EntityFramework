using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class SmTwitterApplication
    {
        public SmTwitterApplication()
        {
            SmTwitterAccount = new HashSet<SmTwitterAccount>();
        }

        public int TwitterApplicationId { get; set; }
        public string TwitterApplicationDisplayName { get; set; }
        public string TwitterApplicationName { get; set; }
        public DateTime TwitterApplicationLastModified { get; set; }
        public Guid TwitterApplicationGuid { get; set; }
        public int TwitterApplicationSiteId { get; set; }
        public string TwitterApplicationConsumerKey { get; set; }
        public string TwitterApplicationConsumerSecret { get; set; }

        public virtual ICollection<SmTwitterAccount> SmTwitterAccount { get; set; }
        public virtual CmsSite TwitterApplicationSite { get; set; }
    }
}

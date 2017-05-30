using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class SmFacebookApplication
    {
        public SmFacebookApplication()
        {
            SmFacebookAccount = new HashSet<SmFacebookAccount>();
        }

        public int FacebookApplicationId { get; set; }
        public string FacebookApplicationConsumerKey { get; set; }
        public string FacebookApplicationConsumerSecret { get; set; }
        public string FacebookApplicationName { get; set; }
        public string FacebookApplicationDisplayName { get; set; }
        public Guid FacebookApplicationGuid { get; set; }
        public DateTime FacebookApplicationLastModified { get; set; }
        public int FacebookApplicationSiteId { get; set; }

        public virtual ICollection<SmFacebookAccount> SmFacebookAccount { get; set; }
        public virtual Site FacebookApplicationSite { get; set; }
    }
}

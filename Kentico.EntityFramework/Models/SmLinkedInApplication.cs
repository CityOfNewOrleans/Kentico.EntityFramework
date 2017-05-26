using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class SmLinkedInApplication
    {
        public int LinkedInApplicationId { get; set; }
        public string LinkedInApplicationDisplayName { get; set; }
        public string LinkedInApplicationName { get; set; }
        public string LinkedInApplicationConsumerSecret { get; set; }
        public string LinkedInApplicationConsumerKey { get; set; }
        public DateTime LinkedInApplicationLastModified { get; set; }
        public Guid LinkedInApplicationGuid { get; set; }
        public int LinkedInApplicationSiteId { get; set; }

        public virtual CmsSite LinkedInApplicationSite { get; set; }
    }
}

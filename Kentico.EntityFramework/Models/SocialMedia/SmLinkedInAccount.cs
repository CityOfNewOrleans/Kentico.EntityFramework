using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class SmLinkedInAccount
    {
        public SmLinkedInAccount()
        {
            SmLinkedInPost = new HashSet<SmLinkedInPost>();
        }

        public int LinkedInAccountId { get; set; }
        public string LinkedInAccountDisplayName { get; set; }
        public string LinkedInAccountName { get; set; }
        public bool? LinkedInAccountIsDefault { get; set; }
        public string LinkedInAccountAccessToken { get; set; }
        public string LinkedInAccountAccessTokenSecret { get; set; }
        public DateTime LinkedInAccountLastModified { get; set; }
        public Guid LinkedInAccountGuid { get; set; }
        public int LinkedInAccountSiteId { get; set; }
        public string LinkedInAccountProfileId { get; set; }
        public int LinkedInAccountLinkedInApplicationId { get; set; }
        public string LinkedInAccountProfileName { get; set; }
        public DateTime? LinkedInAccountAccessTokenExpiration { get; set; }

        public virtual ICollection<SmLinkedInPost> SmLinkedInPost { get; set; }
    }
}

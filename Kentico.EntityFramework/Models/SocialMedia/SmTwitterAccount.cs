using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class SmTwitterAccount
    {
        public SmTwitterAccount()
        {
            SmTwitterPost = new HashSet<SmTwitterPost>();
        }

        public int TwitterAccountId { get; set; }
        public string TwitterAccountDisplayName { get; set; }
        public string TwitterAccountName { get; set; }
        public DateTime TwitterAccountLastModified { get; set; }
        public Guid TwitterAccountGuid { get; set; }
        public int TwitterAccountSiteId { get; set; }
        public string TwitterAccountAccessToken { get; set; }
        public string TwitterAccountAccessTokenSecret { get; set; }
        public int TwitterAccountTwitterApplicationId { get; set; }
        public int? TwitterAccountFollowers { get; set; }
        public int? TwitterAccountMentions { get; set; }
        public string TwitterAccountMentionsRange { get; set; }
        public string TwitterAccountUserId { get; set; }
        public bool? TwitterAccountIsDefault { get; set; }

        public virtual ICollection<SmTwitterPost> SmTwitterPost { get; set; }
        public virtual Site TwitterAccountSite { get; set; }
        public virtual SmTwitterApplication TwitterAccountTwitterApplication { get; set; }
    }
}

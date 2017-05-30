using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class SmFacebookAccount
    {
        public SmFacebookAccount()
        {
            SmFacebookPost = new HashSet<SmFacebookPost>();
        }

        public int FacebookAccountId { get; set; }
        public Guid FacebookAccountGuid { get; set; }
        public DateTime FacebookAccountLastModified { get; set; }
        public int FacebookAccountSiteId { get; set; }
        public string FacebookAccountName { get; set; }
        public string FacebookAccountDisplayName { get; set; }
        public string FacebookAccountPageId { get; set; }
        public string FacebookAccountPageAccessToken { get; set; }
        public int FacebookAccountFacebookApplicationId { get; set; }
        public DateTime? FacebookAccountPageAccessTokenExpiration { get; set; }
        public string FacebookAccountPageUrl { get; set; }
        public bool? FacebookAccountIsDefault { get; set; }

        public virtual ICollection<SmFacebookPost> SmFacebookPost { get; set; }
        public virtual SmFacebookApplication FacebookAccountFacebookApplication { get; set; }
        public virtual Site FacebookAccountSite { get; set; }
    }
}

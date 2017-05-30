using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models.Cms
{
    public partial class Membership
    {
        public Membership()
        {
            CmsMembershipRole = new HashSet<MembershipRole>();
            CmsMembershipUser = new HashSet<MembershipUser>();
        }

        public int MembershipId { get; set; }
        public string MembershipName { get; set; }
        public string MembershipDisplayName { get; set; }
        public string MembershipDescription { get; set; }
        public DateTime MembershipLastModified { get; set; }
        public Guid MembershipGuid { get; set; }
        public int? MembershipSiteId { get; set; }

        public virtual ICollection<MembershipRole> CmsMembershipRole { get; set; }
        public virtual ICollection<MembershipUser> CmsMembershipUser { get; set; }
        public virtual Site MembershipSite { get; set; }
    }
}

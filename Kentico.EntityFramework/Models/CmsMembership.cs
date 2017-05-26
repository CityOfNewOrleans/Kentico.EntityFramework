using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class CmsMembership
    {
        public CmsMembership()
        {
            CmsMembershipRole = new HashSet<CmsMembershipRole>();
            CmsMembershipUser = new HashSet<CmsMembershipUser>();
        }

        public int MembershipId { get; set; }
        public string MembershipName { get; set; }
        public string MembershipDisplayName { get; set; }
        public string MembershipDescription { get; set; }
        public DateTime MembershipLastModified { get; set; }
        public Guid MembershipGuid { get; set; }
        public int? MembershipSiteId { get; set; }

        public virtual ICollection<CmsMembershipRole> CmsMembershipRole { get; set; }
        public virtual ICollection<CmsMembershipUser> CmsMembershipUser { get; set; }
        public virtual CmsSite MembershipSite { get; set; }
    }
}

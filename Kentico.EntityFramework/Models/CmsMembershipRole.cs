using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class CmsMembershipRole
    {
        public int MembershipId { get; set; }
        public int RoleId { get; set; }

        public virtual CmsMembership Membership { get; set; }
        public virtual CmsRole Role { get; set; }
    }
}

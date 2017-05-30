using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models.Cms
{
    public partial class MembershipRole
    {
        public int MembershipId { get; set; }
        public int RoleId { get; set; }

        public virtual Membership Membership { get; set; }
        public virtual Role Role { get; set; }
    }
}

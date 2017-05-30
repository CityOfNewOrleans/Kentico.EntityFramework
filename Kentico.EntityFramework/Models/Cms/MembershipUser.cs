using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models.Cms
{
    public partial class MembershipUser
    {
        public int MembershipUserId { get; set; }
        public int MembershipId { get; set; }
        public int UserId { get; set; }
        public DateTime? ValidTo { get; set; }
        public bool? SendNotification { get; set; }

        public virtual Membership Membership { get; set; }
        public virtual User User { get; set; }
    }
}

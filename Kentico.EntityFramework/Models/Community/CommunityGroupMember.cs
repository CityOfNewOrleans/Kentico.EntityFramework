﻿using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class CommunityGroupMember
    {
        public int MemberId { get; set; }
        public Guid MemberGuid { get; set; }
        public int MemberUserId { get; set; }
        public int MemberGroupId { get; set; }
        public DateTime MemberJoined { get; set; }
        public DateTime? MemberApprovedWhen { get; set; }
        public DateTime? MemberRejectedWhen { get; set; }
        public int? MemberApprovedByUserId { get; set; }
        public string MemberComment { get; set; }
        public int? MemberInvitedByUserId { get; set; }
        public int? MemberStatus { get; set; }

        public virtual User MemberApprovedByUser { get; set; }
        public virtual CommunityGroup MemberGroup { get; set; }
        public virtual User MemberInvitedByUser { get; set; }
        public virtual User MemberUser { get; set; }
    }
}

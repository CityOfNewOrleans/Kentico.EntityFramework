using Kentico.EntityFramework.Models.Cms;
using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class CommunityInvitation
    {
        public int InvitationId { get; set; }
        public int? InvitedUserId { get; set; }
        public int InvitedByUserId { get; set; }
        public int? InvitationGroupId { get; set; }
        public DateTime? InvitationCreated { get; set; }
        public DateTime? InvitationValidTo { get; set; }
        public string InvitationComment { get; set; }
        public Guid InvitationGuid { get; set; }
        public DateTime InvitationLastModified { get; set; }
        public string InvitationUserEmail { get; set; }

        public virtual CommunityGroup InvitationGroup { get; set; }
        public virtual User InvitedByUser { get; set; }
        public virtual User InvitedUser { get; set; }
    }
}

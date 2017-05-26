using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class CommunityFriend
    {
        public int FriendId { get; set; }
        public int FriendRequestedUserId { get; set; }
        public int FriendUserId { get; set; }
        public DateTime FriendRequestedWhen { get; set; }
        public string FriendComment { get; set; }
        public int? FriendApprovedBy { get; set; }
        public DateTime? FriendApprovedWhen { get; set; }
        public int? FriendRejectedBy { get; set; }
        public DateTime? FriendRejectedWhen { get; set; }
        public Guid FriendGuid { get; set; }
        public int FriendStatus { get; set; }

        public virtual CmsUser FriendApprovedByNavigation { get; set; }
        public virtual CmsUser FriendRejectedByNavigation { get; set; }
        public virtual CmsUser FriendRequestedUser { get; set; }
        public virtual CmsUser FriendUser { get; set; }
    }
}

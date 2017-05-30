using Kentico.EntityFramework.Models.Cms;
using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class CommunityGroup
    {
        public CommunityGroup()
        {
            BoardBoard = new HashSet<BoardBoard>();
            Role = new HashSet<Role>();
            Tree = new HashSet<Tree>();
            CommunityGroupMember = new HashSet<CommunityGroupMember>();
            CommunityGroupRolePermission = new HashSet<CommunityGroupRolePermission>();
            CommunityInvitation = new HashSet<CommunityInvitation>();
            ForumsForum = new HashSet<ForumsForum>();
            ForumsForumGroup = new HashSet<ForumsForumGroup>();
            MediaLibrary = new HashSet<MediaLibrary>();
            PollsPoll = new HashSet<PollsPoll>();
        }

        public int GroupId { get; set; }
        public Guid GroupGuid { get; set; }
        public DateTime GroupLastModified { get; set; }
        public int GroupSiteId { get; set; }
        public string GroupDisplayName { get; set; }
        public string GroupName { get; set; }
        public string GroupDescription { get; set; }
        public Guid? GroupNodeGuid { get; set; }
        public int GroupApproveMembers { get; set; }
        public int GroupAccess { get; set; }
        public int? GroupCreatedByUserId { get; set; }
        public int? GroupApprovedByUserId { get; set; }
        public int? GroupAvatarId { get; set; }
        public bool? GroupApproved { get; set; }
        public DateTime GroupCreatedWhen { get; set; }
        public bool? GroupSendJoinLeaveNotification { get; set; }
        public bool? GroupSendWaitingForApprovalNotification { get; set; }
        public int? GroupSecurity { get; set; }
        public bool? GroupLogActivity { get; set; }

        public virtual ICollection<BoardBoard> BoardBoard { get; set; }
        public virtual ICollection<Role> Role { get; set; }
        public virtual ICollection<Tree> Tree { get; set; }
        public virtual ICollection<CommunityGroupMember> CommunityGroupMember { get; set; }
        public virtual ICollection<CommunityGroupRolePermission> CommunityGroupRolePermission { get; set; }
        public virtual ICollection<CommunityInvitation> CommunityInvitation { get; set; }
        public virtual ICollection<ForumsForum> ForumsForum { get; set; }
        public virtual ICollection<ForumsForumGroup> ForumsForumGroup { get; set; }
        public virtual ICollection<MediaLibrary> MediaLibrary { get; set; }
        public virtual ICollection<PollsPoll> PollsPoll { get; set; }
        public virtual User GroupApprovedByUser { get; set; }
        public virtual Avatar GroupAvatar { get; set; }
        public virtual User GroupCreatedByUser { get; set; }
        public virtual Site GroupSite { get; set; }
    }
}

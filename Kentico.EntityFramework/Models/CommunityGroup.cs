using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class CommunityGroup
    {
        public CommunityGroup()
        {
            BoardBoard = new HashSet<BoardBoard>();
            CmsRole = new HashSet<CmsRole>();
            CmsTree = new HashSet<CmsTree>();
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
        public virtual ICollection<CmsRole> CmsRole { get; set; }
        public virtual ICollection<CmsTree> CmsTree { get; set; }
        public virtual ICollection<CommunityGroupMember> CommunityGroupMember { get; set; }
        public virtual ICollection<CommunityGroupRolePermission> CommunityGroupRolePermission { get; set; }
        public virtual ICollection<CommunityInvitation> CommunityInvitation { get; set; }
        public virtual ICollection<ForumsForum> ForumsForum { get; set; }
        public virtual ICollection<ForumsForumGroup> ForumsForumGroup { get; set; }
        public virtual ICollection<MediaLibrary> MediaLibrary { get; set; }
        public virtual ICollection<PollsPoll> PollsPoll { get; set; }
        public virtual CmsUser GroupApprovedByUser { get; set; }
        public virtual CmsAvatar GroupAvatar { get; set; }
        public virtual CmsUser GroupCreatedByUser { get; set; }
        public virtual CmsSite GroupSite { get; set; }
    }
}

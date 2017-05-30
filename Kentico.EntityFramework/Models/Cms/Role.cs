using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models.Cms
{
    public partial class Role
    {
        public Role()
        {
            BoardRole = new HashSet<BoardRole>();
            CmsAclitem = new HashSet<UserLevelPermissionItem>();
            CmsFormRole = new HashSet<FormRole>();
            CmsMembershipRole = new HashSet<MembershipRole>();
            CmsRoleApplication = new HashSet<RoleApplication>();
            CmsRolePermission = new HashSet<RolePermission>();
            CmsRoleUielement = new HashSet<RoleUiElement>();
            CmsUserRole = new HashSet<UserRole>();
            CmsWidgetRole = new HashSet<WidgetRole>();
            CmsWorkflowStepRoles = new HashSet<WorkflowStepRoles>();
            CommunityGroupRolePermission = new HashSet<CommunityGroupRolePermission>();
            ForumsForumRoles = new HashSet<ForumsForumRoles>();
            MediaLibraryRolePermission = new HashSet<MediaLibraryRolePermission>();
            PollsPollRoles = new HashSet<PollsPollRoles>();
        }

        public int RoleId { get; set; }
        public string RoleDisplayName { get; set; }
        public string RoleName { get; set; }
        public string RoleDescription { get; set; }
        public int? SiteId { get; set; }
        public Guid RoleGuid { get; set; }
        public DateTime RoleLastModified { get; set; }
        public int? RoleGroupId { get; set; }
        public bool? RoleIsGroupAdministrator { get; set; }
        public bool? RoleIsDomain { get; set; }

        public virtual ICollection<BoardRole> BoardRole { get; set; }
        public virtual ICollection<UserLevelPermissionItem> CmsAclitem { get; set; }
        public virtual ICollection<FormRole> CmsFormRole { get; set; }
        public virtual ICollection<MembershipRole> CmsMembershipRole { get; set; }
        public virtual ICollection<RoleApplication> CmsRoleApplication { get; set; }
        public virtual ICollection<RolePermission> CmsRolePermission { get; set; }
        public virtual ICollection<RoleUiElement> CmsRoleUielement { get; set; }
        public virtual ICollection<UserRole> CmsUserRole { get; set; }
        public virtual ICollection<WidgetRole> CmsWidgetRole { get; set; }
        public virtual ICollection<WorkflowStepRoles> CmsWorkflowStepRoles { get; set; }
        public virtual ICollection<CommunityGroupRolePermission> CommunityGroupRolePermission { get; set; }
        public virtual ICollection<ForumsForumRoles> ForumsForumRoles { get; set; }
        public virtual ICollection<MediaLibraryRolePermission> MediaLibraryRolePermission { get; set; }
        public virtual ICollection<PollsPollRoles> PollsPollRoles { get; set; }
        public virtual CommunityGroup RoleGroup { get; set; }
        public virtual Site Site { get; set; }
    }
}

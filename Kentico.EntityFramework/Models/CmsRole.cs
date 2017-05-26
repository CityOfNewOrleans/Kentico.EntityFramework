using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class CmsRole
    {
        public CmsRole()
        {
            BoardRole = new HashSet<BoardRole>();
            CmsAclitem = new HashSet<CmsAclitem>();
            CmsFormRole = new HashSet<CmsFormRole>();
            CmsMembershipRole = new HashSet<CmsMembershipRole>();
            CmsRoleApplication = new HashSet<CmsRoleApplication>();
            CmsRolePermission = new HashSet<CmsRolePermission>();
            CmsRoleUielement = new HashSet<CmsRoleUielement>();
            CmsUserRole = new HashSet<CmsUserRole>();
            CmsWidgetRole = new HashSet<CmsWidgetRole>();
            CmsWorkflowStepRoles = new HashSet<CmsWorkflowStepRoles>();
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
        public virtual ICollection<CmsAclitem> CmsAclitem { get; set; }
        public virtual ICollection<CmsFormRole> CmsFormRole { get; set; }
        public virtual ICollection<CmsMembershipRole> CmsMembershipRole { get; set; }
        public virtual ICollection<CmsRoleApplication> CmsRoleApplication { get; set; }
        public virtual ICollection<CmsRolePermission> CmsRolePermission { get; set; }
        public virtual ICollection<CmsRoleUielement> CmsRoleUielement { get; set; }
        public virtual ICollection<CmsUserRole> CmsUserRole { get; set; }
        public virtual ICollection<CmsWidgetRole> CmsWidgetRole { get; set; }
        public virtual ICollection<CmsWorkflowStepRoles> CmsWorkflowStepRoles { get; set; }
        public virtual ICollection<CommunityGroupRolePermission> CommunityGroupRolePermission { get; set; }
        public virtual ICollection<ForumsForumRoles> ForumsForumRoles { get; set; }
        public virtual ICollection<MediaLibraryRolePermission> MediaLibraryRolePermission { get; set; }
        public virtual ICollection<PollsPollRoles> PollsPollRoles { get; set; }
        public virtual CommunityGroup RoleGroup { get; set; }
        public virtual CmsSite Site { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models.Cms
{
    public partial class Permission
    {
        public Permission()
        {
            CmsRolePermission = new HashSet<RolePermission>();
            CmsWidgetRole = new HashSet<WidgetRole>();
            CommunityGroupRolePermission = new HashSet<CommunityGroupRolePermission>();
            ForumsForumRoles = new HashSet<ForumsForumRoles>();
            MediaLibraryRolePermission = new HashSet<MediaLibraryRolePermission>();
        }

        public int PermissionId { get; set; }
        public string PermissionDisplayName { get; set; }
        public string PermissionName { get; set; }
        public int? ClassId { get; set; }
        public int? ResourceId { get; set; }
        public Guid PermissionGuid { get; set; }
        public DateTime PermissionLastModified { get; set; }
        public string PermissionDescription { get; set; }
        public bool? PermissionDisplayInMatrix { get; set; }
        public int? PermissionOrder { get; set; }
        public bool? PermissionEditableByGlobalAdmin { get; set; }

        public virtual ICollection<RolePermission> CmsRolePermission { get; set; }
        public virtual ICollection<WidgetRole> CmsWidgetRole { get; set; }
        public virtual ICollection<CommunityGroupRolePermission> CommunityGroupRolePermission { get; set; }
        public virtual ICollection<ForumsForumRoles> ForumsForumRoles { get; set; }
        public virtual ICollection<MediaLibraryRolePermission> MediaLibraryRolePermission { get; set; }
        public virtual Class Class { get; set; }
        public virtual Resource Resource { get; set; }
    }
}

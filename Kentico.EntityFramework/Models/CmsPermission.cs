using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class CmsPermission
    {
        public CmsPermission()
        {
            CmsRolePermission = new HashSet<CmsRolePermission>();
            CmsWidgetRole = new HashSet<CmsWidgetRole>();
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

        public virtual ICollection<CmsRolePermission> CmsRolePermission { get; set; }
        public virtual ICollection<CmsWidgetRole> CmsWidgetRole { get; set; }
        public virtual ICollection<CommunityGroupRolePermission> CommunityGroupRolePermission { get; set; }
        public virtual ICollection<ForumsForumRoles> ForumsForumRoles { get; set; }
        public virtual ICollection<MediaLibraryRolePermission> MediaLibraryRolePermission { get; set; }
        public virtual CmsClass Class { get; set; }
        public virtual CmsResource Resource { get; set; }
    }
}

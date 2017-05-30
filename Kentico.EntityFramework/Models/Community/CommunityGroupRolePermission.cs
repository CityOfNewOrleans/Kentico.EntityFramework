using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class CommunityGroupRolePermission
    {
        public int GroupId { get; set; }
        public int RoleId { get; set; }
        public int PermissionId { get; set; }

        public virtual CommunityGroup Group { get; set; }
        public virtual Permission Permission { get; set; }
        public virtual Role Role { get; set; }
    }
}

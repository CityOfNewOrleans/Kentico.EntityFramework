using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models.Cms
{
    public partial class UserLevelPermissionItem
    {
        public int AclitemId { get; set; }
        public int Aclid { get; set; }
        public int? UserId { get; set; }
        public int? RoleId { get; set; }
        public int Allowed { get; set; }
        public int Denied { get; set; }
        public DateTime LastModified { get; set; }
        public int? LastModifiedByUserId { get; set; }
        public Guid AclitemGuid { get; set; }

        public virtual UserLevelPermission Acl { get; set; }
        public virtual User LastModifiedByUser { get; set; }
        public virtual Role Role { get; set; }
        public virtual User User { get; set; }
    }
}

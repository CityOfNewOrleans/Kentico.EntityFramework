using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class ForumsForumRoles
    {
        public int ForumId { get; set; }
        public int RoleId { get; set; }
        public int PermissionId { get; set; }

        public virtual ForumsForum Forum { get; set; }
        public virtual CmsPermission Permission { get; set; }
        public virtual CmsRole Role { get; set; }
    }
}

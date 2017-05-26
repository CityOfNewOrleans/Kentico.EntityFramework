using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class CmsUserRole
    {
        public int UserId { get; set; }
        public int RoleId { get; set; }
        public DateTime? ValidTo { get; set; }
        public int UserRoleId { get; set; }

        public virtual CmsRole Role { get; set; }
        public virtual CmsUser User { get; set; }
    }
}

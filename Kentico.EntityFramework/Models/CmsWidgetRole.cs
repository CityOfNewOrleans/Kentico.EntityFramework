using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class CmsWidgetRole
    {
        public int WidgetId { get; set; }
        public int RoleId { get; set; }
        public int PermissionId { get; set; }

        public virtual CmsPermission Permission { get; set; }
        public virtual CmsRole Role { get; set; }
        public virtual CmsWidget Widget { get; set; }
    }
}

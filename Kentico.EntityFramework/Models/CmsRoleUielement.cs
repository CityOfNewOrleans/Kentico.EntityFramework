using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class CmsRoleUielement
    {
        public int RoleId { get; set; }
        public int ElementId { get; set; }

        public virtual CmsUielement Element { get; set; }
        public virtual CmsRole Role { get; set; }
    }
}

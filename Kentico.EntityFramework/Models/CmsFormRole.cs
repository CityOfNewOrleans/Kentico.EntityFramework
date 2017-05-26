using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class CmsFormRole
    {
        public int FormId { get; set; }
        public int RoleId { get; set; }

        public virtual CmsForm Form { get; set; }
        public virtual CmsRole Role { get; set; }
    }
}

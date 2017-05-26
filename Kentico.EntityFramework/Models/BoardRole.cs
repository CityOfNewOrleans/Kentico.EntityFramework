using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class BoardRole
    {
        public int BoardId { get; set; }
        public int RoleId { get; set; }

        public virtual BoardBoard Board { get; set; }
        public virtual CmsRole Role { get; set; }
    }
}

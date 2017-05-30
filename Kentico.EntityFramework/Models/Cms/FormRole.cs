using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models.Cms
{
    public partial class FormRole
    {
        public int FormId { get; set; }
        public int RoleId { get; set; }

        public virtual Form Form { get; set; }
        public virtual Role Role { get; set; }
    }
}

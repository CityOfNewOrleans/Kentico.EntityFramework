using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models.Cms
{
    public partial class RoleApplication
    {
        public int RoleId { get; set; }
        public int ElementId { get; set; }

        public virtual UiElement Element { get; set; }
        public virtual Role Role { get; set; }
    }
}

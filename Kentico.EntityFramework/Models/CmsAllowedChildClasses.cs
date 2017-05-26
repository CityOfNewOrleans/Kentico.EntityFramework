using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class CmsAllowedChildClasses
    {
        public int ParentClassId { get; set; }
        public int ChildClassId { get; set; }

        public virtual CmsClass ChildClass { get; set; }
        public virtual CmsClass ParentClass { get; set; }
    }
}

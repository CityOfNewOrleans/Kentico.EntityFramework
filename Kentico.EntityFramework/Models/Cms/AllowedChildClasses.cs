using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models.Cms

{
    public partial class AllowedChildClasses
    {
        public int ParentClassId { get; set; }
        public int ChildClassId { get; set; }

        public virtual Class ChildClass { get; set; }
        public virtual Class ParentClass { get; set; }
    }
}

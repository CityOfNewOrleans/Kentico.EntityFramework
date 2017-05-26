using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class CmsResourceLibrary
    {
        public int ResourceLibraryId { get; set; }
        public int ResourceLibraryResourceId { get; set; }
        public string ResourceLibraryPath { get; set; }

        public virtual CmsResource ResourceLibraryResource { get; set; }
    }
}

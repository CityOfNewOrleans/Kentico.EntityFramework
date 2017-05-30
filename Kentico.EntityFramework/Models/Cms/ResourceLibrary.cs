using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models.Cms
{
    public partial class ResourceLibrary
    {
        public int ResourceLibraryId { get; set; }
        public int ResourceLibraryResourceId { get; set; }
        public string ResourceLibraryPath { get; set; }

        public virtual Resource ResourceLibraryResource { get; set; }
    }
}

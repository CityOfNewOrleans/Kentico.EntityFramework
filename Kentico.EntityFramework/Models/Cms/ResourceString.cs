using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models.Cms
{
    public partial class ResourceString
    {
        public ResourceString()
        {
            CmsResourceTranslation = new HashSet<ResourceTranslation>();
        }

        public int StringId { get; set; }
        public string StringKey { get; set; }
        public bool StringIsCustom { get; set; }
        public int StringLoadGeneration { get; set; }
        public Guid StringGuid { get; set; }

        public virtual ICollection<ResourceTranslation> CmsResourceTranslation { get; set; }
    }
}

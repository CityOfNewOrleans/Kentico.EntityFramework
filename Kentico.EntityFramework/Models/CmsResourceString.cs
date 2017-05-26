using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class CmsResourceString
    {
        public CmsResourceString()
        {
            CmsResourceTranslation = new HashSet<CmsResourceTranslation>();
        }

        public int StringId { get; set; }
        public string StringKey { get; set; }
        public bool StringIsCustom { get; set; }
        public int StringLoadGeneration { get; set; }
        public Guid StringGuid { get; set; }

        public virtual ICollection<CmsResourceTranslation> CmsResourceTranslation { get; set; }
    }
}

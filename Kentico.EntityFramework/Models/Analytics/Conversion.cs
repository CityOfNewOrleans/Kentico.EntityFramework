using Kentico.EntityFramework.Models.Cms;
using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models.Analytics
{
    public partial class Conversion
    {
        public int ConversionId { get; set; }
        public string ConversionName { get; set; }
        public string ConversionDisplayName { get; set; }
        public string ConversionDescription { get; set; }
        public Guid ConversionGuid { get; set; }
        public DateTime ConversionLastModified { get; set; }
        public int ConversionSiteId { get; set; }

        public virtual Site ConversionSite { get; set; }
    }
}

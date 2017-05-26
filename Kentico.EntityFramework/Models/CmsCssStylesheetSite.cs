using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class CmsCssStylesheetSite
    {
        public int StylesheetId { get; set; }
        public int SiteId { get; set; }

        public virtual CmsSite Site { get; set; }
        public virtual CmsCssStylesheet Stylesheet { get; set; }
    }
}

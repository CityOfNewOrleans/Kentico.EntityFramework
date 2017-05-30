using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models.Cms
{
    public partial class CssStylesheetSite
    {
        public int StylesheetId { get; set; }
        public int SiteId { get; set; }

        public virtual Site Site { get; set; }
        public virtual CssStylesheet Stylesheet { get; set; }
    }
}

using Kentico.EntityFramework.Models.Cms;
using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models.Cms
{
    public partial class CssStylesheet
    {
        public CssStylesheet()
        {
            CmsCssStylesheetSite = new HashSet<CssStylesheetSite>();
            CmsDocument = new HashSet<Document>();
            CmsSiteSiteDefaultEditorStylesheetNavigation = new HashSet<Site>();
            CmsSiteSiteDefaultStylesheet = new HashSet<Site>();
        }

        public int StylesheetId { get; set; }
        public string StylesheetDisplayName { get; set; }
        public string StylesheetName { get; set; }
        public string StylesheetText { get; set; }
        public Guid? StylesheetVersionGuid { get; set; }
        public Guid? StylesheetGuid { get; set; }
        public DateTime StylesheetLastModified { get; set; }
        public string StylesheetDynamicCode { get; set; }
        public string StylesheetDynamicLanguage { get; set; }

        public virtual ICollection<CssStylesheetSite> CmsCssStylesheetSite { get; set; }
        public virtual ICollection<Document> CmsDocument { get; set; }
        public virtual ICollection<Site> CmsSiteSiteDefaultEditorStylesheetNavigation { get; set; }
        public virtual ICollection<Site> CmsSiteSiteDefaultStylesheet { get; set; }
    }
}

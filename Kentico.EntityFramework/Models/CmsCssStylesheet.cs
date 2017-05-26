using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class CmsCssStylesheet
    {
        public CmsCssStylesheet()
        {
            CmsCssStylesheetSite = new HashSet<CmsCssStylesheetSite>();
            CmsDocument = new HashSet<CmsDocument>();
            CmsSiteSiteDefaultEditorStylesheetNavigation = new HashSet<CmsSite>();
            CmsSiteSiteDefaultStylesheet = new HashSet<CmsSite>();
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

        public virtual ICollection<CmsCssStylesheetSite> CmsCssStylesheetSite { get; set; }
        public virtual ICollection<CmsDocument> CmsDocument { get; set; }
        public virtual ICollection<CmsSite> CmsSiteSiteDefaultEditorStylesheetNavigation { get; set; }
        public virtual ICollection<CmsSite> CmsSiteSiteDefaultStylesheet { get; set; }
    }
}

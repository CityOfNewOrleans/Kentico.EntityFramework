using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class CmsCulture
    {
        public CmsCulture()
        {
            BadWordsWordCulture = new HashSet<BadWordsWordCulture>();
            CmsPageTemplateScope = new HashSet<CmsPageTemplateScope>();
            CmsResourceTranslation = new HashSet<CmsResourceTranslation>();
            CmsSearchIndexCulture = new HashSet<CmsSearchIndexCulture>();
            CmsSiteCulture = new HashSet<CmsSiteCulture>();
            CmsUserCulture = new HashSet<CmsUserCulture>();
            CmsWorkflowScope = new HashSet<CmsWorkflowScope>();
        }

        public int CultureId { get; set; }
        public string CultureName { get; set; }
        public string CultureCode { get; set; }
        public string CultureShortName { get; set; }
        public Guid CultureGuid { get; set; }
        public DateTime CultureLastModified { get; set; }
        public string CultureAlias { get; set; }
        public bool? CultureIsUiculture { get; set; }

        public virtual ICollection<BadWordsWordCulture> BadWordsWordCulture { get; set; }
        public virtual ICollection<CmsPageTemplateScope> CmsPageTemplateScope { get; set; }
        public virtual ICollection<CmsResourceTranslation> CmsResourceTranslation { get; set; }
        public virtual ICollection<CmsSearchIndexCulture> CmsSearchIndexCulture { get; set; }
        public virtual ICollection<CmsSiteCulture> CmsSiteCulture { get; set; }
        public virtual ICollection<CmsUserCulture> CmsUserCulture { get; set; }
        public virtual ICollection<CmsWorkflowScope> CmsWorkflowScope { get; set; }
    }
}

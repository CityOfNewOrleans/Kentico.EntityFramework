using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models.Cms
{
    public partial class Culture
    {
        public Culture()
        {
            BadWordsWordCulture = new HashSet<WordCulture>();
            CmsPageTemplateScope = new HashSet<PageTemplateScope>();
            CmsResourceTranslation = new HashSet<ResourceTranslation>();
            CmsSearchIndexCulture = new HashSet<SearchIndexCulture>();
            CmsSiteCulture = new HashSet<SiteCulture>();
            CmsUserCulture = new HashSet<UserCulture>();
            CmsWorkflowScope = new HashSet<WorkflowScope>();
        }

        public int CultureId { get; set; }
        public string CultureName { get; set; }
        public string CultureCode { get; set; }
        public string CultureShortName { get; set; }
        public Guid CultureGuid { get; set; }
        public DateTime CultureLastModified { get; set; }
        public string CultureAlias { get; set; }
        public bool? CultureIsUiculture { get; set; }

        public virtual ICollection<WordCulture> BadWordsWordCulture { get; set; }
        public virtual ICollection<PageTemplateScope> CmsPageTemplateScope { get; set; }
        public virtual ICollection<ResourceTranslation> CmsResourceTranslation { get; set; }
        public virtual ICollection<SearchIndexCulture> CmsSearchIndexCulture { get; set; }
        public virtual ICollection<SiteCulture> CmsSiteCulture { get; set; }
        public virtual ICollection<UserCulture> CmsUserCulture { get; set; }
        public virtual ICollection<WorkflowScope> CmsWorkflowScope { get; set; }
    }
}

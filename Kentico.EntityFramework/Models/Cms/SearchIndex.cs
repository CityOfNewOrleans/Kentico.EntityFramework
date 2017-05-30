using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models.Cms
{
    public partial class SearchIndex
    {
        public SearchIndex()
        {
            CmsSearchIndexCulture = new HashSet<SearchIndexCulture>();
            CmsSearchIndexSite = new HashSet<SearchIndexSite>();
        }

        public int IndexId { get; set; }
        public string IndexName { get; set; }
        public string IndexDisplayName { get; set; }
        public string IndexAnalyzerType { get; set; }
        public bool IndexIsCommunityGroup { get; set; }
        public string IndexSettings { get; set; }
        public Guid IndexGuid { get; set; }
        public DateTime IndexLastModified { get; set; }
        public DateTime? IndexLastRebuildTime { get; set; }
        public string IndexType { get; set; }
        public string IndexStopWordsFile { get; set; }
        public string IndexCustomAnalyzerAssemblyName { get; set; }
        public string IndexCustomAnalyzerClassName { get; set; }
        public int? IndexBatchSize { get; set; }
        public string IndexStatus { get; set; }
        public DateTime? IndexLastUpdate { get; set; }
        public string IndexCrawlerUserName { get; set; }
        public string IndexCrawlerFormsUserName { get; set; }
        public string IndexCrawlerUserPassword { get; set; }
        public string IndexCrawlerDomain { get; set; }
        public bool? IndexIsOutdated { get; set; }

        public virtual ICollection<SearchIndexCulture> CmsSearchIndexCulture { get; set; }
        public virtual ICollection<SearchIndexSite> CmsSearchIndexSite { get; set; }
    }
}

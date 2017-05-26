using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class CmsSearchEngine
    {
        public int SearchEngineId { get; set; }
        public string SearchEngineDisplayName { get; set; }
        public string SearchEngineName { get; set; }
        public string SearchEngineDomainRule { get; set; }
        public string SearchEngineKeywordParameter { get; set; }
        public Guid SearchEngineGuid { get; set; }
        public DateTime SearchEngineLastModified { get; set; }
        public string SearchEngineCrawler { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class ContentKbarticle
    {
        public int KbarticleId { get; set; }
        public string ArticleIdentifier { get; set; }
        public string ArticleName { get; set; }
        public string ArticleSummary { get; set; }
        public string ArticleAppliesTo { get; set; }
        public string ArticleText { get; set; }
        public string ArticleSeeAlso { get; set; }
    }
}

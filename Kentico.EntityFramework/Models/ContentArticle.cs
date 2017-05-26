using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class ContentArticle
    {
        public int ArticleId { get; set; }
        public string ArticleName { get; set; }
        public string ArticleTeaserText { get; set; }
        public Guid? ArticleTeaserImage { get; set; }
        public string ArticleText { get; set; }
    }
}

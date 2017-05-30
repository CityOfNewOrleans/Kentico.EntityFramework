using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class ContentSimpleArticle
    {
        public int ArticleId { get; set; }
        public string ArticleTitle { get; set; }
        public string ArticleText { get; set; }
    }
}

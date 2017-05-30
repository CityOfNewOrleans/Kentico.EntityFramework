using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models.Content
{
    public partial class SimpleArticle
    {
        public int ArticleId { get; set; }
        public string ArticleTitle { get; set; }
        public string ArticleText { get; set; }
    }
}

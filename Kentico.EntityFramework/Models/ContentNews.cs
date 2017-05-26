using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class ContentNews
    {
        public int NewsId { get; set; }
        public string NewsTitle { get; set; }
        public DateTime NewsReleaseDate { get; set; }
        public string NewsSummary { get; set; }
        public string NewsText { get; set; }
        public Guid? NewsTeaser { get; set; }
    }
}

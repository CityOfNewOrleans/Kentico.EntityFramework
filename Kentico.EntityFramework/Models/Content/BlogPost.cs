using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models.Content
{
    public partial class BlogPost
    {
        public int BlogPostId { get; set; }
        public string BlogPostTitle { get; set; }
        public DateTime BlogPostDate { get; set; }
        public string BlogPostSummary { get; set; }
        public string BlogPostBody { get; set; }
        public Guid? BlogPostTeaser { get; set; }
        public bool BlogPostAllowComments { get; set; }
        public bool? BlogLogActivity { get; set; }
        public string FacebookAutoPost { get; set; }
        public string TwitterAutoPost { get; set; }
        public string LinkedInAutoPost { get; set; }
    }
}

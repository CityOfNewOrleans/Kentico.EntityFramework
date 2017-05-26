using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class NewsletterLink
    {
        public NewsletterLink()
        {
            NewsletterClickedLink = new HashSet<NewsletterClickedLink>();
        }

        public int LinkId { get; set; }
        public int LinkIssueId { get; set; }
        public string LinkTarget { get; set; }
        public string LinkDescription { get; set; }
        public bool LinkOutdated { get; set; }
        public Guid LinkGuid { get; set; }

        public virtual ICollection<NewsletterClickedLink> NewsletterClickedLink { get; set; }
        public virtual NewsletterNewsletterIssue LinkIssue { get; set; }
    }
}

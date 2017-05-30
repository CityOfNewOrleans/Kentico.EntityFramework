using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class NewsletterSubscriber
    {
        public NewsletterSubscriber()
        {
            NewsletterEmails = new HashSet<NewsletterEmails>();
            NewsletterSubscriberNewsletter = new HashSet<NewsletterSubscriberNewsletter>();
        }

        public int SubscriberId { get; set; }
        public string SubscriberEmail { get; set; }
        public string SubscriberFirstName { get; set; }
        public string SubscriberLastName { get; set; }
        public int SubscriberSiteId { get; set; }
        public Guid SubscriberGuid { get; set; }
        public string SubscriberCustomData { get; set; }
        public string SubscriberType { get; set; }
        public int SubscriberRelatedId { get; set; }
        public DateTime SubscriberLastModified { get; set; }
        public string SubscriberFullName { get; set; }
        public int? SubscriberBounces { get; set; }

        public virtual ICollection<NewsletterEmails> NewsletterEmails { get; set; }
        public virtual ICollection<NewsletterSubscriberNewsletter> NewsletterSubscriberNewsletter { get; set; }
        public virtual Site SubscriberSite { get; set; }
    }
}

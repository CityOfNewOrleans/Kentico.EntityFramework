using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class NewsletterNewsletterIssue
    {
        public NewsletterNewsletterIssue()
        {
            NewsletterAbtestTestWinnerIssue = new HashSet<NewsletterAbtest>();
            NewsletterEmails = new HashSet<NewsletterEmails>();
            NewsletterLink = new HashSet<NewsletterLink>();
            NewsletterOpenedEmail = new HashSet<NewsletterOpenedEmail>();
            NewsletterUnsubscription = new HashSet<NewsletterUnsubscription>();
        }

        public int IssueId { get; set; }
        public string IssueSubject { get; set; }
        public string IssueText { get; set; }
        public int IssueUnsubscribed { get; set; }
        public int IssueNewsletterId { get; set; }
        public int? IssueTemplateId { get; set; }
        public int IssueSentEmails { get; set; }
        public DateTime? IssueMailoutTime { get; set; }
        public bool? IssueShowInNewsletterArchive { get; set; }
        public Guid IssueGuid { get; set; }
        public DateTime IssueLastModified { get; set; }
        public int IssueSiteId { get; set; }
        public int? IssueOpenedEmails { get; set; }
        public int? IssueBounces { get; set; }
        public int? IssueStatus { get; set; }
        public bool? IssueIsAbtest { get; set; }
        public int? IssueVariantOfIssueId { get; set; }
        public string IssueVariantName { get; set; }
        public string IssueSenderName { get; set; }
        public string IssueSenderEmail { get; set; }
        public int? IssueScheduledTaskId { get; set; }
        public string IssueUtmsource { get; set; }
        public bool IssueUseUtm { get; set; }
        public string IssueUtmcampaign { get; set; }

        public virtual NewsletterAbtest NewsletterAbtestTestIssue { get; set; }
        public virtual ICollection<NewsletterAbtest> NewsletterAbtestTestWinnerIssue { get; set; }
        public virtual ICollection<NewsletterEmails> NewsletterEmails { get; set; }
        public virtual ICollection<NewsletterLink> NewsletterLink { get; set; }
        public virtual ICollection<NewsletterOpenedEmail> NewsletterOpenedEmail { get; set; }
        public virtual ICollection<NewsletterUnsubscription> NewsletterUnsubscription { get; set; }
        public virtual NewsletterNewsletterIssue Issue { get; set; }
        public virtual NewsletterNewsletterIssue InverseIssue { get; set; }
        public virtual NewsletterNewsletter IssueNewsletter { get; set; }
        public virtual Site IssueSite { get; set; }
        public virtual NewsletterEmailTemplate IssueTemplate { get; set; }
        public virtual NewsletterNewsletterIssue IssueVariantOfIssue { get; set; }
        public virtual ICollection<NewsletterNewsletterIssue> InverseIssueVariantOfIssue { get; set; }
    }
}

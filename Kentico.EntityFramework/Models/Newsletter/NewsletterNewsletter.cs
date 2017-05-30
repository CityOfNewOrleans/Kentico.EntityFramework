using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class NewsletterNewsletter
    {
        public NewsletterNewsletter()
        {
            NewsletterEmailTemplateNewsletter = new HashSet<NewsletterEmailTemplateNewsletter>();
            NewsletterNewsletterIssue = new HashSet<NewsletterNewsletterIssue>();
            NewsletterSubscriberNewsletter = new HashSet<NewsletterSubscriberNewsletter>();
            NewsletterUnsubscription = new HashSet<NewsletterUnsubscription>();
        }

        public int NewsletterId { get; set; }
        public string NewsletterDisplayName { get; set; }
        public string NewsletterName { get; set; }
        public int? NewsletterSubscriptionTemplateId { get; set; }
        public int NewsletterUnsubscriptionTemplateId { get; set; }
        public string NewsletterSenderName { get; set; }
        public string NewsletterSenderEmail { get; set; }
        public string NewsletterDynamicSubject { get; set; }
        public string NewsletterDynamicUrl { get; set; }
        public int? NewsletterDynamicScheduledTaskId { get; set; }
        public int? NewsletterTemplateId { get; set; }
        public int NewsletterSiteId { get; set; }
        public Guid NewsletterGuid { get; set; }
        public string NewsletterUnsubscribeUrl { get; set; }
        public string NewsletterBaseUrl { get; set; }
        public DateTime NewsletterLastModified { get; set; }
        public bool? NewsletterEnableOptIn { get; set; }
        public int? NewsletterOptInTemplateId { get; set; }
        public bool? NewsletterSendOptInConfirmation { get; set; }
        public string NewsletterOptInApprovalUrl { get; set; }
        public bool? NewsletterTrackOpenEmails { get; set; }
        public bool? NewsletterTrackClickedLinks { get; set; }
        public string NewsletterDraftEmails { get; set; }
        public bool? NewsletterLogActivity { get; set; }
        public string NewsletterSource { get; set; }
        public int NewsletterType { get; set; }

        public virtual ICollection<NewsletterEmailTemplateNewsletter> NewsletterEmailTemplateNewsletter { get; set; }
        public virtual ICollection<NewsletterNewsletterIssue> NewsletterNewsletterIssue { get; set; }
        public virtual ICollection<NewsletterSubscriberNewsletter> NewsletterSubscriberNewsletter { get; set; }
        public virtual ICollection<NewsletterUnsubscription> NewsletterUnsubscription { get; set; }
        public virtual ScheduledTask NewsletterDynamicScheduledTask { get; set; }
        public virtual NewsletterEmailTemplate NewsletterOptInTemplate { get; set; }
        public virtual Site NewsletterSite { get; set; }
        public virtual NewsletterEmailTemplate NewsletterTemplate { get; set; }
        public virtual NewsletterEmailTemplate NewsletterUnsubscriptionTemplate { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class NewsletterEmailTemplate
    {
        public NewsletterEmailTemplate()
        {
            NewsletterEmailTemplateNewsletter = new HashSet<NewsletterEmailTemplateNewsletter>();
            NewsletterNewsletterNewsletterOptInTemplate = new HashSet<NewsletterNewsletter>();
            NewsletterNewsletterNewsletterTemplate = new HashSet<NewsletterNewsletter>();
            NewsletterNewsletterNewsletterUnsubscriptionTemplate = new HashSet<NewsletterNewsletter>();
            NewsletterNewsletterIssue = new HashSet<NewsletterNewsletterIssue>();
        }

        public int TemplateId { get; set; }
        public string TemplateDisplayName { get; set; }
        public string TemplateName { get; set; }
        public string TemplateBody { get; set; }
        public int TemplateSiteId { get; set; }
        public string TemplateHeader { get; set; }
        public string TemplateFooter { get; set; }
        public string TemplateType { get; set; }
        public string TemplateStylesheetText { get; set; }
        public Guid TemplateGuid { get; set; }
        public DateTime TemplateLastModified { get; set; }
        public string TemplateSubject { get; set; }
        public Guid? TemplateThumbnailGuid { get; set; }

        public virtual ICollection<NewsletterEmailTemplateNewsletter> NewsletterEmailTemplateNewsletter { get; set; }
        public virtual ICollection<NewsletterNewsletter> NewsletterNewsletterNewsletterOptInTemplate { get; set; }
        public virtual ICollection<NewsletterNewsletter> NewsletterNewsletterNewsletterTemplate { get; set; }
        public virtual ICollection<NewsletterNewsletter> NewsletterNewsletterNewsletterUnsubscriptionTemplate { get; set; }
        public virtual ICollection<NewsletterNewsletterIssue> NewsletterNewsletterIssue { get; set; }
        public virtual CmsSite TemplateSite { get; set; }
    }
}

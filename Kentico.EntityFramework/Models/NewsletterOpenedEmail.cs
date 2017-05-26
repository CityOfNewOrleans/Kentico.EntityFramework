using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class NewsletterOpenedEmail
    {
        public int OpenedEmailId { get; set; }
        public string OpenedEmailEmail { get; set; }
        public Guid OpenedEmailGuid { get; set; }
        public DateTime? OpenedEmailTime { get; set; }
        public int OpenedEmailIssueId { get; set; }

        public virtual NewsletterNewsletterIssue OpenedEmailIssue { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class NewsletterUnsubscription
    {
        public int UnsubscriptionId { get; set; }
        public string UnsubscriptionEmail { get; set; }
        public DateTime UnsubscriptionCreated { get; set; }
        public int? UnsubscriptionNewsletterId { get; set; }
        public int? UnsubscriptionFromIssueId { get; set; }
        public Guid UnsubscriptionGuid { get; set; }

        public virtual NewsletterNewsletterIssue UnsubscriptionFromIssue { get; set; }
        public virtual NewsletterNewsletter UnsubscriptionNewsletter { get; set; }
    }
}

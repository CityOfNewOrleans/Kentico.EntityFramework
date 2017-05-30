using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class NewsletterEmailTemplateNewsletter
    {
        public int TemplateId { get; set; }
        public int NewsletterId { get; set; }

        public virtual NewsletterNewsletter Newsletter { get; set; }
        public virtual NewsletterEmailTemplate Template { get; set; }
    }
}

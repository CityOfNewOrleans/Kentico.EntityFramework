using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class CmsEmail
    {
        public CmsEmail()
        {
            CmsAttachmentForEmail = new HashSet<CmsAttachmentForEmail>();
            CmsEmailUser = new HashSet<CmsEmailUser>();
        }

        public int EmailId { get; set; }
        public string EmailFrom { get; set; }
        public string EmailTo { get; set; }
        public string EmailCc { get; set; }
        public string EmailBcc { get; set; }
        public string EmailSubject { get; set; }
        public string EmailBody { get; set; }
        public string EmailPlainTextBody { get; set; }
        public int EmailFormat { get; set; }
        public int EmailPriority { get; set; }
        public int? EmailSiteId { get; set; }
        public string EmailLastSendResult { get; set; }
        public DateTime? EmailLastSendAttempt { get; set; }
        public Guid EmailGuid { get; set; }
        public DateTime EmailLastModified { get; set; }
        public int? EmailStatus { get; set; }
        public bool? EmailIsMass { get; set; }
        public string EmailSetName { get; set; }
        public int? EmailSetRelatedId { get; set; }
        public string EmailReplyTo { get; set; }
        public string EmailHeaders { get; set; }
        public DateTime? EmailCreated { get; set; }

        public virtual ICollection<CmsAttachmentForEmail> CmsAttachmentForEmail { get; set; }
        public virtual ICollection<CmsEmailUser> CmsEmailUser { get; set; }
    }
}

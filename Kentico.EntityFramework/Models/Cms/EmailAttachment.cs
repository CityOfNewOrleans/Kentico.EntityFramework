using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models.Cms
{
    public partial class EmailAttachment
    {
        public EmailAttachment()
        {
            CmsAttachmentForEmail = new HashSet<AttachmentForEmail>();
        }

        public int AttachmentId { get; set; }
        public string AttachmentName { get; set; }
        public string AttachmentExtension { get; set; }
        public int AttachmentSize { get; set; }
        public string AttachmentMimeType { get; set; }
        public byte[] AttachmentBinary { get; set; }
        public Guid AttachmentGuid { get; set; }
        public DateTime AttachmentLastModified { get; set; }
        public string AttachmentContentId { get; set; }
        public int? AttachmentSiteId { get; set; }

        public virtual ICollection<AttachmentForEmail> CmsAttachmentForEmail { get; set; }
    }
}

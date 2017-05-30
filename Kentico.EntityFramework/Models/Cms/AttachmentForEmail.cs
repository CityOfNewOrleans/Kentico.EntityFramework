using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models.Cms
{
    public partial class AttachmentForEmail
    {
        public int EmailId { get; set; }
        public int AttachmentId { get; set; }

        public virtual EmailAttachment Attachment { get; set; }
        public virtual Email Email { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class CmsAttachmentForEmail
    {
        public int EmailId { get; set; }
        public int AttachmentId { get; set; }

        public virtual CmsEmailAttachment Attachment { get; set; }
        public virtual CmsEmail Email { get; set; }
    }
}

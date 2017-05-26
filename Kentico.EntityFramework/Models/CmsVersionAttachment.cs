using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class CmsVersionAttachment
    {
        public int VersionHistoryId { get; set; }
        public int AttachmentHistoryId { get; set; }

        public virtual CmsAttachmentHistory AttachmentHistory { get; set; }
        public virtual CmsVersionHistory VersionHistory { get; set; }
    }
}

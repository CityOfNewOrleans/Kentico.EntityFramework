using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models.Cms
{
    public partial class VersionAttachment
    {
        public int VersionHistoryId { get; set; }
        public int AttachmentHistoryId { get; set; }

        public virtual AttachmentHistory AttachmentHistory { get; set; }
        public virtual VersionHistory VersionHistory { get; set; }
    }
}

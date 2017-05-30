using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class ForumsAttachment
    {
        public int AttachmentId { get; set; }
        public string AttachmentFileName { get; set; }
        public string AttachmentFileExtension { get; set; }
        public byte[] AttachmentBinary { get; set; }
        public Guid AttachmentGuid { get; set; }
        public DateTime AttachmentLastModified { get; set; }
        public string AttachmentMimeType { get; set; }
        public int AttachmentFileSize { get; set; }
        public int? AttachmentImageHeight { get; set; }
        public int? AttachmentImageWidth { get; set; }
        public int AttachmentPostId { get; set; }
        public int AttachmentSiteId { get; set; }

        public virtual ForumsForumPost AttachmentPost { get; set; }
        public virtual Site AttachmentSite { get; set; }
    }
}

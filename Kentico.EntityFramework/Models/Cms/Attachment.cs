using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models.Cms
{
    public partial class Attachment
    {
        public int AttachmentId { get; set; }
        public string AttachmentName { get; set; }
        public string AttachmentExtension { get; set; }
        public int AttachmentSize { get; set; }
        public string AttachmentMimeType { get; set; }
        public byte[] AttachmentBinary { get; set; }
        public int? AttachmentImageWidth { get; set; }
        public int? AttachmentImageHeight { get; set; }
        public int? AttachmentDocumentId { get; set; }
        public Guid AttachmentGuid { get; set; }
        public int AttachmentSiteId { get; set; }
        public DateTime AttachmentLastModified { get; set; }
        public bool? AttachmentIsUnsorted { get; set; }
        public int? AttachmentOrder { get; set; }
        public Guid? AttachmentGroupGuid { get; set; }
        public Guid? AttachmentFormGuid { get; set; }
        public string AttachmentHash { get; set; }
        public string AttachmentTitle { get; set; }
        public string AttachmentDescription { get; set; }
        public string AttachmentCustomData { get; set; }
        public string AttachmentSearchContent { get; set; }
        public string AttachmentVariantDefinitionIdentifier { get; set; }
        public int? AttachmentVariantParentId { get; set; }

        public virtual Document AttachmentDocument { get; set; }
        public virtual Site AttachmentSite { get; set; }
        public virtual Attachment AttachmentVariantParent { get; set; }
        public virtual ICollection<Attachment> InverseAttachmentVariantParent { get; set; }
    }
}

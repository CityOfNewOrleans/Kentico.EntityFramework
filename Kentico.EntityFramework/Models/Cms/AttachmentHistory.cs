using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models.Cms
{
    public partial class AttachmentHistory
    {
        public AttachmentHistory()
        {
            CmsVersionAttachment = new HashSet<VersionAttachment>();
        }

        public int AttachmentHistoryId { get; set; }
        public string AttachmentName { get; set; }
        public string AttachmentExtension { get; set; }
        public int AttachmentSize { get; set; }
        public string AttachmentMimeType { get; set; }
        public byte[] AttachmentBinary { get; set; }
        public int? AttachmentImageWidth { get; set; }
        public int? AttachmentImageHeight { get; set; }
        public int AttachmentDocumentId { get; set; }
        public Guid AttachmentGuid { get; set; }
        public bool? AttachmentIsUnsorted { get; set; }
        public int? AttachmentOrder { get; set; }
        public Guid? AttachmentGroupGuid { get; set; }
        public string AttachmentHash { get; set; }
        public string AttachmentTitle { get; set; }
        public string AttachmentDescription { get; set; }
        public string AttachmentCustomData { get; set; }
        public DateTime? AttachmentLastModified { get; set; }
        public Guid AttachmentHistoryGuid { get; set; }
        public int AttachmentSiteId { get; set; }
        public string AttachmentSearchContent { get; set; }
        public string AttachmentVariantDefinitionIdentifier { get; set; }
        public int? AttachmentVariantParentId { get; set; }

        public virtual ICollection<VersionAttachment> CmsVersionAttachment { get; set; }
        public virtual Site AttachmentSite { get; set; }
        public virtual AttachmentHistory AttachmentVariantParent { get; set; }
        public virtual ICollection<AttachmentHistory> InverseAttachmentVariantParent { get; set; }
    }
}

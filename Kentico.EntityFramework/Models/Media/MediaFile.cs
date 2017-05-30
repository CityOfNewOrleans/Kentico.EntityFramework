using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class MediaFile
    {
        public int FileId { get; set; }
        public string FileName { get; set; }
        public string FileTitle { get; set; }
        public string FileDescription { get; set; }
        public string FileExtension { get; set; }
        public string FileMimeType { get; set; }
        public string FilePath { get; set; }
        public long FileSize { get; set; }
        public int? FileImageWidth { get; set; }
        public int? FileImageHeight { get; set; }
        public Guid FileGuid { get; set; }
        public int FileLibraryId { get; set; }
        public int FileSiteId { get; set; }
        public int? FileCreatedByUserId { get; set; }
        public DateTime FileCreatedWhen { get; set; }
        public int? FileModifiedByUserId { get; set; }
        public DateTime FileModifiedWhen { get; set; }
        public string FileCustomData { get; set; }

        public virtual User FileCreatedByUser { get; set; }
        public virtual MediaLibrary FileLibrary { get; set; }
        public virtual User FileModifiedByUser { get; set; }
        public virtual Site FileSite { get; set; }
    }
}

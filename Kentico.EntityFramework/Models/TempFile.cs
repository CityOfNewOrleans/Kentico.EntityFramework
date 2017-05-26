using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class TempFile
    {
        public int FileId { get; set; }
        public Guid FileParentGuid { get; set; }
        public int FileNumber { get; set; }
        public string FileExtension { get; set; }
        public long FileSize { get; set; }
        public string FileMimeType { get; set; }
        public int? FileImageWidth { get; set; }
        public int? FileImageHeight { get; set; }
        public byte[] FileBinary { get; set; }
        public Guid FileGuid { get; set; }
        public DateTime FileLastModified { get; set; }
        public string FileDirectory { get; set; }
        public string FileName { get; set; }
        public string FileTitle { get; set; }
        public string FileDescription { get; set; }
    }
}

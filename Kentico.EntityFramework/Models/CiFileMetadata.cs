using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class CiFileMetadata
    {
        public int FileMetadataId { get; set; }
        public string FileLocation { get; set; }
        public string FileHash { get; set; }
    }
}

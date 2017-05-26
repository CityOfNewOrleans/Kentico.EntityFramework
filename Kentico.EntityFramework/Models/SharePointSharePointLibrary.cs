using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class SharePointSharePointLibrary
    {
        public SharePointSharePointLibrary()
        {
            SharePointSharePointFile = new HashSet<SharePointSharePointFile>();
        }

        public int SharePointLibraryId { get; set; }
        public string SharePointLibraryName { get; set; }
        public int? SharePointLibrarySharePointConnectionId { get; set; }
        public string SharePointLibraryListTitle { get; set; }
        public int SharePointLibrarySynchronizationPeriod { get; set; }
        public Guid SharePointLibraryGuid { get; set; }
        public int SharePointLibrarySiteId { get; set; }
        public string SharePointLibraryDisplayName { get; set; }
        public DateTime SharePointLibraryLastModified { get; set; }
        public int SharePointLibraryListType { get; set; }

        public virtual ICollection<SharePointSharePointFile> SharePointSharePointFile { get; set; }
        public virtual SharePointSharePointConnection SharePointLibrarySharePointConnection { get; set; }
        public virtual CmsSite SharePointLibrarySite { get; set; }
    }
}

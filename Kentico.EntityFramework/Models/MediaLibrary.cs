using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class MediaLibrary
    {
        public MediaLibrary()
        {
            MediaFile = new HashSet<MediaFile>();
            MediaLibraryRolePermission = new HashSet<MediaLibraryRolePermission>();
        }

        public int LibraryId { get; set; }
        public string LibraryName { get; set; }
        public string LibraryDisplayName { get; set; }
        public string LibraryDescription { get; set; }
        public string LibraryFolder { get; set; }
        public int? LibraryAccess { get; set; }
        public int? LibraryGroupId { get; set; }
        public int LibrarySiteId { get; set; }
        public Guid? LibraryGuid { get; set; }
        public DateTime? LibraryLastModified { get; set; }
        public string LibraryTeaserPath { get; set; }
        public Guid? LibraryTeaserGuid { get; set; }

        public virtual ICollection<MediaFile> MediaFile { get; set; }
        public virtual ICollection<MediaLibraryRolePermission> MediaLibraryRolePermission { get; set; }
        public virtual CommunityGroup LibraryGroup { get; set; }
        public virtual CmsSite LibrarySite { get; set; }
    }
}

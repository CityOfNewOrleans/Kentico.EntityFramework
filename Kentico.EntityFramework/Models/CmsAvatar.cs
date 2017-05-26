using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class CmsAvatar
    {
        public CmsAvatar()
        {
            CmsUserSettings = new HashSet<CmsUserSettings>();
            CommunityGroup = new HashSet<CommunityGroup>();
        }

        public int AvatarId { get; set; }
        public string AvatarName { get; set; }
        public string AvatarFileName { get; set; }
        public string AvatarFileExtension { get; set; }
        public byte[] AvatarBinary { get; set; }
        public string AvatarType { get; set; }
        public bool AvatarIsCustom { get; set; }
        public Guid AvatarGuid { get; set; }
        public DateTime AvatarLastModified { get; set; }
        public string AvatarMimeType { get; set; }
        public int AvatarFileSize { get; set; }
        public int? AvatarImageHeight { get; set; }
        public int? AvatarImageWidth { get; set; }
        public bool? DefaultMaleUserAvatar { get; set; }
        public bool? DefaultFemaleUserAvatar { get; set; }
        public bool? DefaultGroupAvatar { get; set; }
        public bool? DefaultUserAvatar { get; set; }

        public virtual ICollection<CmsUserSettings> CmsUserSettings { get; set; }
        public virtual ICollection<CommunityGroup> CommunityGroup { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models.Cms
{
    public partial class ObjectVersionHistory
    {
        public ObjectVersionHistory()
        {
            CmsObjectSettingsObjectCheckedOutVersionHistory = new HashSet<ObjectSettings>();
            CmsObjectSettingsObjectPublishedVersionHistory = new HashSet<ObjectSettings>();
        }

        public int VersionId { get; set; }
        public int? VersionObjectId { get; set; }
        public string VersionObjectType { get; set; }
        public int? VersionObjectSiteId { get; set; }
        public string VersionObjectDisplayName { get; set; }
        public string VersionXml { get; set; }
        public string VersionBinaryDataXml { get; set; }
        public int? VersionModifiedByUserId { get; set; }
        public DateTime VersionModifiedWhen { get; set; }
        public int? VersionDeletedByUserId { get; set; }
        public DateTime? VersionDeletedWhen { get; set; }
        public string VersionNumber { get; set; }
        public string VersionSiteBindingIds { get; set; }
        public string VersionComment { get; set; }

        public virtual ICollection<ObjectSettings> CmsObjectSettingsObjectCheckedOutVersionHistory { get; set; }
        public virtual ICollection<ObjectSettings> CmsObjectSettingsObjectPublishedVersionHistory { get; set; }
        public virtual User VersionDeletedByUser { get; set; }
        public virtual User VersionModifiedByUser { get; set; }
        public virtual Site VersionObjectSite { get; set; }
    }
}

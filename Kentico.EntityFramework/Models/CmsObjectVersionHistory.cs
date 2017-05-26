using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class CmsObjectVersionHistory
    {
        public CmsObjectVersionHistory()
        {
            CmsObjectSettingsObjectCheckedOutVersionHistory = new HashSet<CmsObjectSettings>();
            CmsObjectSettingsObjectPublishedVersionHistory = new HashSet<CmsObjectSettings>();
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

        public virtual ICollection<CmsObjectSettings> CmsObjectSettingsObjectCheckedOutVersionHistory { get; set; }
        public virtual ICollection<CmsObjectSettings> CmsObjectSettingsObjectPublishedVersionHistory { get; set; }
        public virtual CmsUser VersionDeletedByUser { get; set; }
        public virtual CmsUser VersionModifiedByUser { get; set; }
        public virtual CmsSite VersionObjectSite { get; set; }
    }
}

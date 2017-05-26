using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class CmsResource
    {
        public CmsResource()
        {
            CmsClass = new HashSet<CmsClass>();
            CmsFormUserControl = new HashSet<CmsFormUserControl>();
            CmsInlineControl = new HashSet<CmsInlineControl>();
            CmsModuleLicenseKey = new HashSet<CmsModuleLicenseKey>();
            CmsPermission = new HashSet<CmsPermission>();
            CmsResourceLibrary = new HashSet<CmsResourceLibrary>();
            CmsResourceSite = new HashSet<CmsResourceSite>();
            CmsScheduledTask = new HashSet<CmsScheduledTask>();
            CmsSettingsCategory = new HashSet<CmsSettingsCategory>();
            CmsUielement = new HashSet<CmsUielement>();
            CmsWebPart = new HashSet<CmsWebPart>();
            CmsWorkflowAction = new HashSet<CmsWorkflowAction>();
        }

        public int ResourceId { get; set; }
        public string ResourceDisplayName { get; set; }
        public string ResourceName { get; set; }
        public string ResourceDescription { get; set; }
        public bool? ShowInDevelopment { get; set; }
        public string ResourceUrl { get; set; }
        public Guid ResourceGuid { get; set; }
        public DateTime ResourceLastModified { get; set; }
        public bool? ResourceIsInDevelopment { get; set; }
        public bool? ResourceHasFiles { get; set; }
        public string ResourceVersion { get; set; }
        public string ResourceAuthor { get; set; }
        public string ResourceInstallationState { get; set; }
        public string ResourceInstalledVersion { get; set; }

        public virtual ICollection<CmsClass> CmsClass { get; set; }
        public virtual ICollection<CmsFormUserControl> CmsFormUserControl { get; set; }
        public virtual ICollection<CmsInlineControl> CmsInlineControl { get; set; }
        public virtual ICollection<CmsModuleLicenseKey> CmsModuleLicenseKey { get; set; }
        public virtual ICollection<CmsPermission> CmsPermission { get; set; }
        public virtual ICollection<CmsResourceLibrary> CmsResourceLibrary { get; set; }
        public virtual ICollection<CmsResourceSite> CmsResourceSite { get; set; }
        public virtual ICollection<CmsScheduledTask> CmsScheduledTask { get; set; }
        public virtual ICollection<CmsSettingsCategory> CmsSettingsCategory { get; set; }
        public virtual ICollection<CmsUielement> CmsUielement { get; set; }
        public virtual ICollection<CmsWebPart> CmsWebPart { get; set; }
        public virtual ICollection<CmsWorkflowAction> CmsWorkflowAction { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models.Cms
{
    public partial class Resource
    {
        public Resource()
        {
            CmsClass = new HashSet<Class>();
            CmsFormUserControl = new HashSet<FormUserControl>();
            CmsInlineControl = new HashSet<InlineControl>();
            CmsModuleLicenseKey = new HashSet<ModuleLicenseKey>();
            CmsPermission = new HashSet<Permission>();
            CmsResourceLibrary = new HashSet<ResourceLibrary>();
            CmsResourceSite = new HashSet<ResourceSite>();
            CmsScheduledTask = new HashSet<ScheduledTask>();
            CmsSettingsCategory = new HashSet<SettingsCategory>();
            CmsUielement = new HashSet<UiElement>();
            CmsWebPart = new HashSet<WebPart>();
            CmsWorkflowAction = new HashSet<WorkflowAction>();
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

        public virtual ICollection<Class> CmsClass { get; set; }
        public virtual ICollection<FormUserControl> CmsFormUserControl { get; set; }
        public virtual ICollection<InlineControl> CmsInlineControl { get; set; }
        public virtual ICollection<ModuleLicenseKey> CmsModuleLicenseKey { get; set; }
        public virtual ICollection<Permission> CmsPermission { get; set; }
        public virtual ICollection<ResourceLibrary> CmsResourceLibrary { get; set; }
        public virtual ICollection<ResourceSite> CmsResourceSite { get; set; }
        public virtual ICollection<ScheduledTask> CmsScheduledTask { get; set; }
        public virtual ICollection<SettingsCategory> CmsSettingsCategory { get; set; }
        public virtual ICollection<UiElement> CmsUielement { get; set; }
        public virtual ICollection<WebPart> CmsWebPart { get; set; }
        public virtual ICollection<WorkflowAction> CmsWorkflowAction { get; set; }
    }
}

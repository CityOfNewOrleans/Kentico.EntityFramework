using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models.Cms
{
    public partial class DeviceProfile
    {
        public DeviceProfile()
        {
            CmsDeviceProfileLayout = new HashSet<DeviceProfileLayout>();
            CmsTemplateDeviceLayout = new HashSet<TemplateDeviceLayout>();
        }

        public int ProfileId { get; set; }
        public string ProfileName { get; set; }
        public string ProfileDisplayName { get; set; }
        public int? ProfileOrder { get; set; }
        public string ProfileMacro { get; set; }
        public string ProfileUserAgents { get; set; }
        public string ProfileDevices { get; set; }
        public bool ProfileEnabled { get; set; }
        public int? ProfilePreviewWidth { get; set; }
        public int? ProfilePreviewHeight { get; set; }
        public Guid? ProfileGuid { get; set; }
        public DateTime? ProfileLastModified { get; set; }

        public virtual ICollection<DeviceProfileLayout> CmsDeviceProfileLayout { get; set; }
        public virtual ICollection<TemplateDeviceLayout> CmsTemplateDeviceLayout { get; set; }
    }
}

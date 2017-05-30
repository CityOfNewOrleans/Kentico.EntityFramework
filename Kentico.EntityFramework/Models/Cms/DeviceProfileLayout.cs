using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models.Cms
{
    public partial class DeviceProfileLayout
    {
        public int DeviceProfileLayoutId { get; set; }
        public int DeviceProfileId { get; set; }
        public int SourceLayoutId { get; set; }
        public int TargetLayoutId { get; set; }
        public Guid DeviceProfileLayoutGuid { get; set; }
        public DateTime DeviceProfileLayoutLastModified { get; set; }

        public virtual DeviceProfile DeviceProfile { get; set; }
        public virtual Layout SourceLayout { get; set; }
        public virtual Layout TargetLayout { get; set; }
    }
}

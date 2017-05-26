﻿using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class CmsDeviceProfileLayout
    {
        public int DeviceProfileLayoutId { get; set; }
        public int DeviceProfileId { get; set; }
        public int SourceLayoutId { get; set; }
        public int TargetLayoutId { get; set; }
        public Guid DeviceProfileLayoutGuid { get; set; }
        public DateTime DeviceProfileLayoutLastModified { get; set; }

        public virtual CmsDeviceProfile DeviceProfile { get; set; }
        public virtual CmsLayout SourceLayout { get; set; }
        public virtual CmsLayout TargetLayout { get; set; }
    }
}

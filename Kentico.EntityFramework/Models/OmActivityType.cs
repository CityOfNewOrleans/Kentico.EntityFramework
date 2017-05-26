﻿using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class OmActivityType
    {
        public int ActivityTypeId { get; set; }
        public string ActivityTypeDisplayName { get; set; }
        public string ActivityTypeName { get; set; }
        public bool? ActivityTypeEnabled { get; set; }
        public bool? ActivityTypeIsCustom { get; set; }
        public string ActivityTypeDescription { get; set; }
        public bool? ActivityTypeManualCreationAllowed { get; set; }
        public string ActivityTypeMainFormControl { get; set; }
        public string ActivityTypeDetailFormControl { get; set; }
        public bool ActivityTypeIsHiddenInContentOnly { get; set; }
    }
}

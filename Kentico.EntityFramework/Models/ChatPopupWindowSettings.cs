using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class ChatPopupWindowSettings
    {
        public int ChatPopupWindowSettingsId { get; set; }
        public string MessageTransformationName { get; set; }
        public string ErrorTransformationName { get; set; }
        public string ErrorClearTransformationName { get; set; }
        public string UserTransformationName { get; set; }
        public int ChatPopupWindowSettingsHashCode { get; set; }
    }
}

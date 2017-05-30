﻿using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models.Cms
{
    public partial class SettingsKey
    {
        public int KeyId { get; set; }
        public string KeyName { get; set; }
        public string KeyDisplayName { get; set; }
        public string KeyDescription { get; set; }
        public string KeyValue { get; set; }
        public string KeyType { get; set; }
        public int? KeyCategoryId { get; set; }
        public int? SiteId { get; set; }
        public Guid KeyGuid { get; set; }
        public DateTime KeyLastModified { get; set; }
        public int? KeyOrder { get; set; }
        public string KeyDefaultValue { get; set; }
        public string KeyValidation { get; set; }
        public string KeyEditingControlPath { get; set; }
        public int KeyLoadGeneration { get; set; }
        public bool? KeyIsGlobal { get; set; }
        public bool? KeyIsCustom { get; set; }
        public bool? KeyIsHidden { get; set; }
        public string KeyFormControlSettings { get; set; }
        public string KeyExplanationText { get; set; }

        public virtual SettingsCategory KeyCategory { get; set; }
        public virtual Site Site { get; set; }
    }
}

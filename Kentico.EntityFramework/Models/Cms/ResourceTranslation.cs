using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models.Cms
{
    public partial class ResourceTranslation
    {
        public int TranslationId { get; set; }
        public int TranslationStringId { get; set; }
        public string TranslationText { get; set; }
        public int TranslationCultureId { get; set; }

        public virtual Culture TranslationCulture { get; set; }
        public virtual ResourceString TranslationString { get; set; }
    }
}

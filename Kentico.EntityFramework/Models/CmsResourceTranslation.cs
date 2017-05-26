using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class CmsResourceTranslation
    {
        public int TranslationId { get; set; }
        public int TranslationStringId { get; set; }
        public string TranslationText { get; set; }
        public int TranslationCultureId { get; set; }

        public virtual CmsCulture TranslationCulture { get; set; }
        public virtual CmsResourceString TranslationString { get; set; }
    }
}

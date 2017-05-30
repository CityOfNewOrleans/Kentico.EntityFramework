using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models.BadWords
{
    public partial class Word
    {
        public Word()
        {
            BadWordsWordCulture = new HashSet<WordCulture>();
        }

        public int WordId { get; set; }
        public Guid WordGuid { get; set; }
        public DateTime WordLastModified { get; set; }
        public string WordExpression { get; set; }
        public string WordReplacement { get; set; }
        public int? WordAction { get; set; }
        public bool WordIsGlobal { get; set; }
        public bool WordIsRegularExpression { get; set; }
        public bool? WordMatchWholeWord { get; set; }

        public virtual ICollection<WordCulture> BadWordsWordCulture { get; set; }
    }
}

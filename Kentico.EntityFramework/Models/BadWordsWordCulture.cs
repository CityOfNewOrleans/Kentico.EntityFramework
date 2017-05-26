using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class BadWordsWordCulture
    {
        public int WordId { get; set; }
        public int CultureId { get; set; }

        public virtual CmsCulture Culture { get; set; }
        public virtual BadWordsWord Word { get; set; }
    }
}

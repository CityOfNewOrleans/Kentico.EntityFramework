using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models.BadWords
{
    public partial class WordCulture
    {
        public int WordId { get; set; }
        public int CultureId { get; set; }

        public virtual Culture Culture { get; set; }
        public virtual Word Word { get; set; }
    }
}

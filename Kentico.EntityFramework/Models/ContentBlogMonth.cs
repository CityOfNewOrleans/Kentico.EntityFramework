using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class ContentBlogMonth
    {
        public int BlogMonthId { get; set; }
        public string BlogMonthName { get; set; }
        public DateTime BlogMonthStartingDate { get; set; }
    }
}

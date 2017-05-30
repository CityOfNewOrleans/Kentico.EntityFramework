using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models.Content
{
    public partial class BlogMonth
    {
        public int BlogMonthId { get; set; }
        public string BlogMonthName { get; set; }
        public DateTime BlogMonthStartingDate { get; set; }
    }
}

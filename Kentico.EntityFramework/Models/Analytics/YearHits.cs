using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models.Analytics
{
    public partial class YearHits
    {
        public int HitsId { get; set; }
        public int HitsStatisticsId { get; set; }
        public DateTime HitsStartTime { get; set; }
        public DateTime HitsEndTime { get; set; }
        public int HitsCount { get; set; }
        public double? HitsValue { get; set; }

        public virtual Statistics HitsStatistics { get; set; }
    }
}

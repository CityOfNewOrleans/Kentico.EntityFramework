using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class AnalyticsStatistics
    {
        public AnalyticsStatistics()
        {
            AnalyticsDayHits = new HashSet<AnalyticsDayHits>();
            AnalyticsHourHits = new HashSet<AnalyticsHourHits>();
            AnalyticsMonthHits = new HashSet<AnalyticsMonthHits>();
            AnalyticsWeekHits = new HashSet<AnalyticsWeekHits>();
            AnalyticsYearHits = new HashSet<AnalyticsYearHits>();
        }

        public int StatisticsId { get; set; }
        public int? StatisticsSiteId { get; set; }
        public string StatisticsCode { get; set; }
        public string StatisticsObjectName { get; set; }
        public int? StatisticsObjectId { get; set; }
        public string StatisticsObjectCulture { get; set; }

        public virtual ICollection<AnalyticsDayHits> AnalyticsDayHits { get; set; }
        public virtual ICollection<AnalyticsHourHits> AnalyticsHourHits { get; set; }
        public virtual ICollection<AnalyticsMonthHits> AnalyticsMonthHits { get; set; }
        public virtual ICollection<AnalyticsWeekHits> AnalyticsWeekHits { get; set; }
        public virtual ICollection<AnalyticsYearHits> AnalyticsYearHits { get; set; }
        public virtual Site StatisticsSite { get; set; }
    }
}

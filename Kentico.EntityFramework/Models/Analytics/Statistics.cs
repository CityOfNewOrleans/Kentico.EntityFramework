using Kentico.EntityFramework.Models.Cms;
using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models.Analytics
{
    public partial class Statistics
    {
        public Statistics()
        {
            AnalyticsDayHits = new HashSet<DayHits>();
            AnalyticsHourHits = new HashSet<HourHits>();
            AnalyticsMonthHits = new HashSet<MonthHits>();
            AnalyticsWeekHits = new HashSet<WeekHits>();
            AnalyticsYearHits = new HashSet<YearHits>();
        }

        public int StatisticsId { get; set; }
        public int? StatisticsSiteId { get; set; }
        public string StatisticsCode { get; set; }
        public string StatisticsObjectName { get; set; }
        public int? StatisticsObjectId { get; set; }
        public string StatisticsObjectCulture { get; set; }

        public virtual ICollection<DayHits> AnalyticsDayHits { get; set; }
        public virtual ICollection<HourHits> AnalyticsHourHits { get; set; }
        public virtual ICollection<MonthHits> AnalyticsMonthHits { get; set; }
        public virtual ICollection<WeekHits> AnalyticsWeekHits { get; set; }
        public virtual ICollection<YearHits> AnalyticsYearHits { get; set; }
        public virtual Site StatisticsSite { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models.Cms
{
    public partial class TimeZone
    {
        public TimeZone()
        {
            CmsUserSettings = new HashSet<UserSettings>();
        }

        public int TimeZoneId { get; set; }
        public string TimeZoneName { get; set; }
        public string TimeZoneDisplayName { get; set; }
        public double TimeZoneGmt { get; set; }
        public bool? TimeZoneDaylight { get; set; }
        public DateTime TimeZoneRuleStartIn { get; set; }
        public string TimeZoneRuleStartRule { get; set; }
        public DateTime TimeZoneRuleEndIn { get; set; }
        public string TimeZoneRuleEndRule { get; set; }
        public Guid TimeZoneGuid { get; set; }
        public DateTime TimeZoneLastModified { get; set; }

        public virtual ICollection<UserSettings> CmsUserSettings { get; set; }
    }
}

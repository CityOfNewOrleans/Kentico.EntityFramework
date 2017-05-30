using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models.Content
{
    public partial class Event
    {
        public int EventId { get; set; }
        public string EventName { get; set; }
        public string EventSummary { get; set; }
        public string EventDetails { get; set; }
        public string EventLocation { get; set; }
        public DateTime? EventDate { get; set; }
    }
}

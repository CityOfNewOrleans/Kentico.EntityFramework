using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models.Cms
{
    public partial class WebFarmServerMonitoring
    {
        public int WebFarmServerMonitoringId { get; set; }
        public int ServerId { get; set; }
        public DateTime? ServerPing { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class AnalyticsExitPages
    {
        public string SessionIdentificator { get; set; }
        public int ExitPageNodeId { get; set; }
        public DateTime ExitPageLastModified { get; set; }
        public int ExitPageSiteId { get; set; }
        public string ExitPageCulture { get; set; }
    }
}

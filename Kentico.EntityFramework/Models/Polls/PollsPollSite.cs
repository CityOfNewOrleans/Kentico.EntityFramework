using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class PollsPollSite
    {
        public int PollId { get; set; }
        public int SiteId { get; set; }

        public virtual PollsPoll Poll { get; set; }
        public virtual Site Site { get; set; }
    }
}

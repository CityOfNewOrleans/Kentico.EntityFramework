using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models.Cms
{
    public partial class Session
    {
        public string SessionIdentificator { get; set; }
        public int? SessionUserId { get; set; }
        public string SessionLocation { get; set; }
        public DateTime SessionLastActive { get; set; }
        public DateTime? SessionLastLogon { get; set; }
        public DateTime SessionExpires { get; set; }
        public bool SessionExpired { get; set; }
        public int? SessionSiteId { get; set; }
        public bool SessionUserIsHidden { get; set; }
        public string SessionFullName { get; set; }
        public string SessionEmail { get; set; }
        public string SessionUserName { get; set; }
        public string SessionNickName { get; set; }
        public DateTime? SessionUserCreated { get; set; }
        public int? SessionContactId { get; set; }
        public int SessionId { get; set; }

        public virtual Site SessionSite { get; set; }
        public virtual User SessionUser { get; set; }
    }
}

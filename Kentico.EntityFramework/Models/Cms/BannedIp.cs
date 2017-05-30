using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models.Cms
{
    public partial class BannedIp
    {
        public int IpaddressId { get; set; }
        public string Ipaddress { get; set; }
        public string IpaddressRegular { get; set; }
        public bool IpaddressAllowed { get; set; }
        public bool IpaddressAllowOverride { get; set; }
        public string IpaddressBanReason { get; set; }
        public string IpaddressBanType { get; set; }
        public bool? IpaddressBanEnabled { get; set; }
        public int? IpaddressSiteId { get; set; }
        public Guid IpaddressGuid { get; set; }
        public DateTime IpaddressLastModified { get; set; }

        public virtual Site IpaddressSite { get; set; }
    }
}

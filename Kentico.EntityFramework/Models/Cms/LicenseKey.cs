using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models.Cms
{
    public partial class LicenseKey
    {
        public int LicenseKeyId { get; set; }
        public string LicenseDomain { get; set; }
        public string Key { get; set; }
        public string LicenseEdition { get; set; }
        public string LicenseExpiration { get; set; }
        public int? LicenseServers { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class CmsOpenIduser
    {
        public int OpenIduserId { get; set; }
        public string OpenId { get; set; }
        public string OpenIdproviderUrl { get; set; }
        public int UserId { get; set; }

        public virtual CmsUser User { get; set; }
    }
}

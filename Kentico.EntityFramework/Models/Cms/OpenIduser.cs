using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models.Cms
{
    public partial class OpenIdUser
    {
        public int OpenIduserId { get; set; }
        public string OpenId { get; set; }
        public string OpenIdproviderUrl { get; set; }
        public int UserId { get; set; }

        public virtual User User { get; set; }
    }
}

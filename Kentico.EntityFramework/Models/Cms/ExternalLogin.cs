using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models.Cms
{
    public partial class ExternalLogin
    {
        public int ExternalLoginId { get; set; }
        public int UserId { get; set; }
        public string LoginProvider { get; set; }
        public string IdentityKey { get; set; }

        public virtual User User { get; set; }
    }
}

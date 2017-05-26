﻿using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class CmsExternalLogin
    {
        public int ExternalLoginId { get; set; }
        public int UserId { get; set; }
        public string LoginProvider { get; set; }
        public string IdentityKey { get; set; }

        public virtual CmsUser User { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class NewsletterIssueContactGroup
    {
        public int IssueContactGroupId { get; set; }
        public int IssueId { get; set; }
        public int ContactGroupId { get; set; }

        public virtual OmContactGroup ContactGroup { get; set; }
    }
}

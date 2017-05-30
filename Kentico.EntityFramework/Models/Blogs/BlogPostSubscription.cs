﻿using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class BlogPostSubscription
    {
        public int SubscriptionId { get; set; }
        public int SubscriptionPostDocumentId { get; set; }
        public int? SubscriptionUserId { get; set; }
        public string SubscriptionEmail { get; set; }
        public DateTime SubscriptionLastModified { get; set; }
        public Guid SubscriptionGuid { get; set; }
        public bool? SubscriptionApproved { get; set; }
        public string SubscriptionApprovalHash { get; set; }

        public virtual Document SubscriptionPostDocument { get; set; }
        public virtual User SubscriptionUser { get; set; }
    }
}

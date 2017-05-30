﻿using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class ForumsForumSubscription
    {
        public int SubscriptionId { get; set; }
        public int? SubscriptionUserId { get; set; }
        public string SubscriptionEmail { get; set; }
        public int SubscriptionForumId { get; set; }
        public int? SubscriptionPostId { get; set; }
        public Guid SubscriptionGuid { get; set; }
        public DateTime SubscriptionLastModified { get; set; }
        public bool? SubscriptionApproved { get; set; }
        public string SubscriptionApprovalHash { get; set; }

        public virtual ForumsForum SubscriptionForum { get; set; }
        public virtual ForumsForumPost SubscriptionPost { get; set; }
        public virtual User SubscriptionUser { get; set; }
    }
}
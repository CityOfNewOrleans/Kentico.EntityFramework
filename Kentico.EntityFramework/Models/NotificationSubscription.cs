using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class NotificationSubscription
    {
        public int SubscriptionId { get; set; }
        public int SubscriptionGatewayId { get; set; }
        public int SubscriptionTemplateId { get; set; }
        public string SubscriptionEventSource { get; set; }
        public string SubscriptionEventCode { get; set; }
        public string SubscriptionEventDisplayName { get; set; }
        public int? SubscriptionEventObjectId { get; set; }
        public DateTime SubscriptionTime { get; set; }
        public int SubscriptionUserId { get; set; }
        public string SubscriptionTarget { get; set; }
        public DateTime SubscriptionLastModified { get; set; }
        public Guid SubscriptionGuid { get; set; }
        public string SubscriptionEventData1 { get; set; }
        public string SubscriptionEventData2 { get; set; }
        public bool? SubscriptionUseHtml { get; set; }
        public int? SubscriptionSiteId { get; set; }

        public virtual NotificationGateway SubscriptionGateway { get; set; }
        public virtual CmsSite SubscriptionSite { get; set; }
        public virtual NotificationTemplate SubscriptionTemplate { get; set; }
        public virtual CmsUser SubscriptionUser { get; set; }
    }
}

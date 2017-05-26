using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class NotificationGateway
    {
        public NotificationGateway()
        {
            NotificationSubscription = new HashSet<NotificationSubscription>();
            NotificationTemplateText = new HashSet<NotificationTemplateText>();
        }

        public int GatewayId { get; set; }
        public string GatewayName { get; set; }
        public string GatewayDisplayName { get; set; }
        public string GatewayAssemblyName { get; set; }
        public string GatewayClassName { get; set; }
        public string GatewayDescription { get; set; }
        public bool? GatewaySupportsEmail { get; set; }
        public bool? GatewaySupportsPlainText { get; set; }
        public bool? GatewaySupportsHtmltext { get; set; }
        public DateTime GatewayLastModified { get; set; }
        public Guid GatewayGuid { get; set; }
        public bool? GatewayEnabled { get; set; }

        public virtual ICollection<NotificationSubscription> NotificationSubscription { get; set; }
        public virtual ICollection<NotificationTemplateText> NotificationTemplateText { get; set; }
    }
}

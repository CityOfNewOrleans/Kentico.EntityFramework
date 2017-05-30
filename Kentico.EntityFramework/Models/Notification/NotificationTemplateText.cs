using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class NotificationTemplateText
    {
        public int TemplateTextId { get; set; }
        public int TemplateId { get; set; }
        public int GatewayId { get; set; }
        public string TemplateSubject { get; set; }
        public string TemplateHtmltext { get; set; }
        public string TemplatePlainText { get; set; }
        public Guid TemplateTextGuid { get; set; }
        public DateTime TemplateTextLastModified { get; set; }

        public virtual NotificationGateway Gateway { get; set; }
        public virtual NotificationTemplate Template { get; set; }
    }
}

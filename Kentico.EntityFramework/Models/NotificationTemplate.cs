using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class NotificationTemplate
    {
        public NotificationTemplate()
        {
            NotificationSubscription = new HashSet<NotificationSubscription>();
            NotificationTemplateText = new HashSet<NotificationTemplateText>();
        }

        public int TemplateId { get; set; }
        public string TemplateName { get; set; }
        public string TemplateDisplayName { get; set; }
        public int? TemplateSiteId { get; set; }
        public DateTime TemplateLastModified { get; set; }
        public Guid TemplateGuid { get; set; }

        public virtual ICollection<NotificationSubscription> NotificationSubscription { get; set; }
        public virtual ICollection<NotificationTemplateText> NotificationTemplateText { get; set; }
        public virtual CmsSite TemplateSite { get; set; }
    }
}

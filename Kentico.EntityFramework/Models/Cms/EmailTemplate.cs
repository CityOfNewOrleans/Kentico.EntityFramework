using Kentico.EntityFramework.Models.Cms;
using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models.Cms
{
    public partial class EmailTemplate
    {
        public int EmailTemplateId { get; set; }
        public string EmailTemplateName { get; set; }
        public string EmailTemplateDisplayName { get; set; }
        public string EmailTemplateText { get; set; }
        public int? EmailTemplateSiteId { get; set; }
        public Guid EmailTemplateGuid { get; set; }
        public DateTime EmailTemplateLastModified { get; set; }
        public string EmailTemplatePlainText { get; set; }
        public string EmailTemplateSubject { get; set; }
        public string EmailTemplateFrom { get; set; }
        public string EmailTemplateCc { get; set; }
        public string EmailTemplateBcc { get; set; }
        public string EmailTemplateType { get; set; }
        public string EmailTemplateDescription { get; set; }
        public string EmailTemplateReplyTo { get; set; }

        public virtual Site EmailTemplateSite { get; set; }
    }
}

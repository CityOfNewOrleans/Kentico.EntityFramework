using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class CmsWebTemplate
    {
        public int WebTemplateId { get; set; }
        public string WebTemplateDisplayName { get; set; }
        public string WebTemplateFileName { get; set; }
        public string WebTemplateDescription { get; set; }
        public Guid WebTemplateGuid { get; set; }
        public DateTime WebTemplateLastModified { get; set; }
        public string WebTemplateName { get; set; }
        public int WebTemplateOrder { get; set; }
        public string WebTemplateLicenses { get; set; }
        public Guid? WebTemplateThumbnailGuid { get; set; }
        public string WebTemplateShortDescription { get; set; }
    }
}

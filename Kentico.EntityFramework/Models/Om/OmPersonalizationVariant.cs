using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class OmPersonalizationVariant
    {
        public int VariantId { get; set; }
        public bool VariantEnabled { get; set; }
        public string VariantName { get; set; }
        public string VariantDisplayName { get; set; }
        public Guid? VariantInstanceGuid { get; set; }
        public string VariantZoneId { get; set; }
        public int VariantPageTemplateId { get; set; }
        public string VariantWebParts { get; set; }
        public int? VariantPosition { get; set; }
        public Guid VariantGuid { get; set; }
        public DateTime VariantLastModified { get; set; }
        public string VariantDescription { get; set; }
        public int? VariantDocumentId { get; set; }
        public string VariantDisplayCondition { get; set; }

        public virtual Document VariantDocument { get; set; }
        public virtual PageTemplate VariantPageTemplate { get; set; }
    }
}

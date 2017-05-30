using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models.Cms
{
    public partial class Transformation
    {
        public int TransformationId { get; set; }
        public string TransformationName { get; set; }
        public string TransformationCode { get; set; }
        public string TransformationType { get; set; }
        public int TransformationClassId { get; set; }
        public string TransformationVersionGuid { get; set; }
        public Guid TransformationGuid { get; set; }
        public DateTime TransformationLastModified { get; set; }
        public bool? TransformationIsHierarchical { get; set; }
        public string TransformationHierarchicalXml { get; set; }
        public string TransformationCss { get; set; }
        public string TransformationPreferredDocument { get; set; }

        public virtual Class TransformationClass { get; set; }
    }
}

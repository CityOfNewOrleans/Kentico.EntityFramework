using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models.Cms
{
    public partial class TranslationService
    {
        public TranslationService()
        {
            CmsTranslationSubmission = new HashSet<TranslationSubmission>();
        }

        public int TranslationServiceId { get; set; }
        public string TranslationServiceAssemblyName { get; set; }
        public string TranslationServiceClassName { get; set; }
        public string TranslationServiceName { get; set; }
        public string TranslationServiceDisplayName { get; set; }
        public bool TranslationServiceIsMachine { get; set; }
        public DateTime TranslationServiceLastModified { get; set; }
        public Guid TranslationServiceGuid { get; set; }
        public bool TranslationServiceEnabled { get; set; }
        public bool? TranslationServiceSupportsInstructions { get; set; }
        public bool? TranslationServiceSupportsPriority { get; set; }
        public bool? TranslationServiceSupportsDeadline { get; set; }
        public bool? TranslationServiceGenerateTargetTag { get; set; }
        public string TranslationServiceParameter { get; set; }
        public bool? TranslationServiceSupportsStatusUpdate { get; set; }
        public bool? TranslationServiceSupportsCancel { get; set; }

        public virtual ICollection<TranslationSubmission> CmsTranslationSubmission { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models.Cms
{
    public partial class TranslationSubmissionItem
    {
        public int SubmissionItemId { get; set; }
        public int SubmissionItemSubmissionId { get; set; }
        public string SubmissionItemSourceXliff { get; set; }
        public string SubmissionItemTargetXliff { get; set; }
        public string SubmissionItemObjectType { get; set; }
        public int SubmissionItemObjectId { get; set; }
        public Guid SubmissionItemGuid { get; set; }
        public DateTime SubmissionItemLastModified { get; set; }
        public string SubmissionItemName { get; set; }
        public int? SubmissionItemWordCount { get; set; }
        public int? SubmissionItemCharCount { get; set; }
        public string SubmissionItemCustomData { get; set; }
        public int SubmissionItemTargetObjectId { get; set; }
        public string SubmissionItemType { get; set; }
        public string SubmissionItemTargetCulture { get; set; }

        public virtual TranslationSubmission SubmissionItemSubmission { get; set; }
    }
}

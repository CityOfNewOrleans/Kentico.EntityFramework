﻿using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class CmsForm
    {
        public CmsForm()
        {
            CmsFormRole = new HashSet<CmsFormRole>();
        }

        public int FormId { get; set; }
        public string FormDisplayName { get; set; }
        public string FormName { get; set; }
        public string FormSendToEmail { get; set; }
        public string FormSendFromEmail { get; set; }
        public string FormEmailSubject { get; set; }
        public string FormEmailTemplate { get; set; }
        public bool? FormEmailAttachUploadedDocs { get; set; }
        public int FormClassId { get; set; }
        public int FormItems { get; set; }
        public string FormReportFields { get; set; }
        public string FormRedirectToUrl { get; set; }
        public string FormDisplayText { get; set; }
        public bool FormClearAfterSave { get; set; }
        public string FormSubmitButtonText { get; set; }
        public int FormSiteId { get; set; }
        public string FormConfirmationEmailField { get; set; }
        public string FormConfirmationTemplate { get; set; }
        public string FormConfirmationSendFromEmail { get; set; }
        public string FormConfirmationEmailSubject { get; set; }
        public int? FormAccess { get; set; }
        public string FormSubmitButtonImage { get; set; }
        public Guid FormGuid { get; set; }
        public DateTime FormLastModified { get; set; }
        public bool? FormLogActivity { get; set; }

        public virtual ICollection<CmsFormRole> CmsFormRole { get; set; }
        public virtual CmsClass FormClass { get; set; }
        public virtual CmsSite FormSite { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class CmsUielement
    {
        public CmsUielement()
        {
            CmsRoleApplication = new HashSet<CmsRoleApplication>();
            CmsRoleUielement = new HashSet<CmsRoleUielement>();
        }

        public int ElementId { get; set; }
        public string ElementDisplayName { get; set; }
        public string ElementName { get; set; }
        public string ElementCaption { get; set; }
        public string ElementTargetUrl { get; set; }
        public int ElementResourceId { get; set; }
        public int? ElementParentId { get; set; }
        public int ElementChildCount { get; set; }
        public int? ElementOrder { get; set; }
        public int ElementLevel { get; set; }
        public string ElementIdpath { get; set; }
        public string ElementIconPath { get; set; }
        public bool? ElementIsCustom { get; set; }
        public DateTime ElementLastModified { get; set; }
        public Guid ElementGuid { get; set; }
        public int? ElementSize { get; set; }
        public string ElementDescription { get; set; }
        public string ElementFromVersion { get; set; }
        public int? ElementPageTemplateId { get; set; }
        public string ElementType { get; set; }
        public string ElementProperties { get; set; }
        public bool? ElementIsMenu { get; set; }
        public string ElementFeature { get; set; }
        public string ElementIconClass { get; set; }
        public bool? ElementIsGlobalApplication { get; set; }
        public bool? ElementCheckModuleReadPermission { get; set; }
        public string ElementAccessCondition { get; set; }
        public string ElementVisibilityCondition { get; set; }

        public virtual ICollection<CmsRoleApplication> CmsRoleApplication { get; set; }
        public virtual ICollection<CmsRoleUielement> CmsRoleUielement { get; set; }
        public virtual CmsPageTemplate ElementPageTemplate { get; set; }
        public virtual CmsUielement ElementParent { get; set; }
        public virtual ICollection<CmsUielement> InverseElementParent { get; set; }
        public virtual CmsResource ElementResource { get; set; }
    }
}

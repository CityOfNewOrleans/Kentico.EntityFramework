using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class CmsPageTemplate
    {
        public CmsPageTemplate()
        {
            CmsClass = new HashSet<CmsClass>();
            CmsDocument = new HashSet<CmsDocument>();
            CmsPageTemplateScope = new HashSet<CmsPageTemplateScope>();
            CmsPageTemplateSite = new HashSet<CmsPageTemplateSite>();
            CmsTemplateDeviceLayout = new HashSet<CmsTemplateDeviceLayout>();
            CmsTree = new HashSet<CmsTree>();
            CmsUielement = new HashSet<CmsUielement>();
            OmMvtvariant = new HashSet<OmMvtvariant>();
            OmPersonalizationVariant = new HashSet<OmPersonalizationVariant>();
        }

        public int PageTemplateId { get; set; }
        public string PageTemplateDisplayName { get; set; }
        public string PageTemplateCodeName { get; set; }
        public string PageTemplateDescription { get; set; }
        public string PageTemplateFile { get; set; }
        public int? PageTemplateCategoryId { get; set; }
        public int? PageTemplateLayoutId { get; set; }
        public string PageTemplateWebParts { get; set; }
        public bool? PageTemplateIsReusable { get; set; }
        public bool? PageTemplateShowAsMasterTemplate { get; set; }
        public string PageTemplateInheritPageLevels { get; set; }
        public string PageTemplateLayout { get; set; }
        public string PageTemplateVersionGuid { get; set; }
        public string PageTemplateHeader { get; set; }
        public Guid PageTemplateGuid { get; set; }
        public DateTime PageTemplateLastModified { get; set; }
        public int? PageTemplateSiteId { get; set; }
        public bool? PageTemplateForAllPages { get; set; }
        public string PageTemplateType { get; set; }
        public string PageTemplateLayoutType { get; set; }
        public string PageTemplateCss { get; set; }
        public bool? PageTemplateIsAllowedForProductSection { get; set; }
        public bool? PageTemplateInheritParentHeader { get; set; }
        public bool? PageTemplateAllowInheritHeader { get; set; }
        public Guid? PageTemplateThumbnailGuid { get; set; }
        public bool? PageTemplateCloneAsAdHoc { get; set; }
        public string PageTemplateDefaultController { get; set; }
        public string PageTemplateDefaultAction { get; set; }
        public Guid? PageTemplateNodeGuid { get; set; }
        public int? PageTemplateMasterPageTemplateId { get; set; }
        public string PageTemplateProperties { get; set; }
        public bool? PageTemplateIsLayout { get; set; }
        public string PageTemplateIconClass { get; set; }

        public virtual ICollection<CmsClass> CmsClass { get; set; }
        public virtual ICollection<CmsDocument> CmsDocument { get; set; }
        public virtual ICollection<CmsPageTemplateScope> CmsPageTemplateScope { get; set; }
        public virtual ICollection<CmsPageTemplateSite> CmsPageTemplateSite { get; set; }
        public virtual ICollection<CmsTemplateDeviceLayout> CmsTemplateDeviceLayout { get; set; }
        public virtual ICollection<CmsTree> CmsTree { get; set; }
        public virtual ICollection<CmsUielement> CmsUielement { get; set; }
        public virtual ICollection<OmMvtvariant> OmMvtvariant { get; set; }
        public virtual ICollection<OmPersonalizationVariant> OmPersonalizationVariant { get; set; }
        public virtual CmsPageTemplateCategory PageTemplateCategory { get; set; }
        public virtual CmsLayout PageTemplateLayoutNavigation { get; set; }
        public virtual CmsSite PageTemplateSite { get; set; }
    }
}

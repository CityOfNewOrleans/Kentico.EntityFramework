using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class CmsClass
    {
        public CmsClass()
        {
            CmsAllowedChildClassesChildClass = new HashSet<CmsAllowedChildClasses>();
            CmsAllowedChildClassesParentClass = new HashSet<CmsAllowedChildClasses>();
            CmsAlternativeFormFormClass = new HashSet<CmsAlternativeForm>();
            CmsAlternativeFormFormCoupledClass = new HashSet<CmsAlternativeForm>();
            CmsClassSite = new HashSet<CmsClassSite>();
            CmsDocumentTypeScopeClass = new HashSet<CmsDocumentTypeScopeClass>();
            CmsForm = new HashSet<CmsForm>();
            CmsPageTemplateScope = new HashSet<CmsPageTemplateScope>();
            CmsPermission = new HashSet<CmsPermission>();
            CmsQuery = new HashSet<CmsQuery>();
            CmsTransformation = new HashSet<CmsTransformation>();
            CmsTree = new HashSet<CmsTree>();
            CmsVersionHistory = new HashSet<CmsVersionHistory>();
            CmsWorkflowScope = new HashSet<CmsWorkflowScope>();
        }

        public int ClassId { get; set; }
        public string ClassDisplayName { get; set; }
        public string ClassName { get; set; }
        public bool ClassUsesVersioning { get; set; }
        public bool ClassIsDocumentType { get; set; }
        public bool ClassIsCoupledClass { get; set; }
        public string ClassXmlSchema { get; set; }
        public string ClassFormDefinition { get; set; }
        public string ClassEditingPageUrl { get; set; }
        public string ClassListPageUrl { get; set; }
        public string ClassNodeNameSource { get; set; }
        public string ClassTableName { get; set; }
        public string ClassViewPageUrl { get; set; }
        public string ClassPreviewPageUrl { get; set; }
        public string ClassFormLayout { get; set; }
        public string ClassNewPageUrl { get; set; }
        public bool? ClassShowAsSystemTable { get; set; }
        public bool? ClassUsePublishFromTo { get; set; }
        public bool? ClassShowTemplateSelection { get; set; }
        public string ClassSkumappings { get; set; }
        public bool? ClassIsMenuItemType { get; set; }
        public string ClassNodeAliasSource { get; set; }
        public int? ClassDefaultPageTemplateId { get; set; }
        public DateTime ClassLastModified { get; set; }
        public Guid ClassGuid { get; set; }
        public bool? ClassCreateSku { get; set; }
        public bool? ClassIsProduct { get; set; }
        public bool ClassIsCustomTable { get; set; }
        public string ClassShowColumns { get; set; }
        public int? ClassLoadGeneration { get; set; }
        public string ClassSearchTitleColumn { get; set; }
        public string ClassSearchContentColumn { get; set; }
        public string ClassSearchImageColumn { get; set; }
        public string ClassSearchCreationDateColumn { get; set; }
        public string ClassSearchSettings { get; set; }
        public int? ClassInheritsFromClassId { get; set; }
        public bool? ClassSearchEnabled { get; set; }
        public string ClassSkudefaultDepartmentName { get; set; }
        public int? ClassSkudefaultDepartmentId { get; set; }
        public string ClassContactMapping { get; set; }
        public bool? ClassContactOverwriteEnabled { get; set; }
        public string ClassSkudefaultProductType { get; set; }
        public string ClassConnectionString { get; set; }
        public bool? ClassIsProductSection { get; set; }
        public int? ClassPageTemplateCategoryId { get; set; }
        public string ClassFormLayoutType { get; set; }
        public string ClassVersionGuid { get; set; }
        public string ClassDefaultObjectType { get; set; }
        public bool? ClassIsForm { get; set; }
        public int? ClassResourceId { get; set; }
        public string ClassCustomizedColumns { get; set; }
        public string ClassCodeGenerationSettings { get; set; }
        public string ClassIconClass { get; set; }
        public bool? ClassIsContentOnly { get; set; }
        public string ClassUrlpattern { get; set; }

        public virtual ICollection<CmsAllowedChildClasses> CmsAllowedChildClassesChildClass { get; set; }
        public virtual ICollection<CmsAllowedChildClasses> CmsAllowedChildClassesParentClass { get; set; }
        public virtual ICollection<CmsAlternativeForm> CmsAlternativeFormFormClass { get; set; }
        public virtual ICollection<CmsAlternativeForm> CmsAlternativeFormFormCoupledClass { get; set; }
        public virtual ICollection<CmsClassSite> CmsClassSite { get; set; }
        public virtual ICollection<CmsDocumentTypeScopeClass> CmsDocumentTypeScopeClass { get; set; }
        public virtual ICollection<CmsForm> CmsForm { get; set; }
        public virtual ICollection<CmsPageTemplateScope> CmsPageTemplateScope { get; set; }
        public virtual ICollection<CmsPermission> CmsPermission { get; set; }
        public virtual ICollection<CmsQuery> CmsQuery { get; set; }
        public virtual ICollection<CmsTransformation> CmsTransformation { get; set; }
        public virtual ICollection<CmsTree> CmsTree { get; set; }
        public virtual ICollection<CmsVersionHistory> CmsVersionHistory { get; set; }
        public virtual ICollection<CmsWorkflowScope> CmsWorkflowScope { get; set; }
        public virtual CmsPageTemplate ClassDefaultPageTemplate { get; set; }
        public virtual CmsClass Class { get; set; }
        public virtual CmsClass InverseClass { get; set; }
        public virtual CmsPageTemplateCategory ClassPageTemplateCategory { get; set; }
        public virtual CmsResource ClassResource { get; set; }
    }
}

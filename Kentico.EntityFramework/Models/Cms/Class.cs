using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models.Cms
{
    public partial class Class
    {
        public Class()
        {
            CmsAllowedChildClassesChildClass = new HashSet<AllowedChildClasses>();
            CmsAllowedChildClassesParentClass = new HashSet<AllowedChildClasses>();
            CmsAlternativeFormFormClass = new HashSet<AlternativeForm>();
            CmsAlternativeFormFormCoupledClass = new HashSet<AlternativeForm>();
            CmsClassSite = new HashSet<ClassSite>();
            CmsDocumentTypeScopeClass = new HashSet<DocumentTypeScopeClass>();
            CmsForm = new HashSet<Form>();
            CmsPageTemplateScope = new HashSet<PageTemplateScope>();
            CmsPermission = new HashSet<Permission>();
            CmsQuery = new HashSet<Query>();
            CmsTransformation = new HashSet<Transformation>();
            CmsTree = new HashSet<Tree>();
            CmsVersionHistory = new HashSet<VersionHistory>();
            CmsWorkflowScope = new HashSet<WorkflowScope>();
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

        public virtual ICollection<AllowedChildClasses> CmsAllowedChildClassesChildClass { get; set; }
        public virtual ICollection<AllowedChildClasses> CmsAllowedChildClassesParentClass { get; set; }
        public virtual ICollection<AlternativeForm> CmsAlternativeFormFormClass { get; set; }
        public virtual ICollection<AlternativeForm> CmsAlternativeFormFormCoupledClass { get; set; }
        public virtual ICollection<ClassSite> CmsClassSite { get; set; }
        public virtual ICollection<DocumentTypeScopeClass> CmsDocumentTypeScopeClass { get; set; }
        public virtual ICollection<Form> CmsForm { get; set; }
        public virtual ICollection<PageTemplateScope> CmsPageTemplateScope { get; set; }
        public virtual ICollection<Permission> CmsPermission { get; set; }
        public virtual ICollection<Query> CmsQuery { get; set; }
        public virtual ICollection<Transformation> CmsTransformation { get; set; }
        public virtual ICollection<Tree> CmsTree { get; set; }
        public virtual ICollection<VersionHistory> CmsVersionHistory { get; set; }
        public virtual ICollection<WorkflowScope> CmsWorkflowScope { get; set; }
        public virtual PageTemplate ClassDefaultPageTemplate { get; set; }
        
        #warning Figure out what Class.Class should be called.
        //public virtual Class Class { get; set; }
        public virtual Class InverseClass { get; set; }
        public virtual PageTemplateCategory ClassPageTemplateCategory { get; set; }
        public virtual Resource ClassResource { get; set; }
    }
}

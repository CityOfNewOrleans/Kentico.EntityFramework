using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models.Cms
{
    public partial class WorkflowScope
    {
        public int ScopeId { get; set; }
        public string ScopeStartingPath { get; set; }
        public int ScopeWorkflowId { get; set; }
        public int? ScopeClassId { get; set; }
        public int ScopeSiteId { get; set; }
        public Guid ScopeGuid { get; set; }
        public DateTime ScopeLastModified { get; set; }
        public int? ScopeCultureId { get; set; }
        public bool? ScopeExcludeChildren { get; set; }
        public bool ScopeExcluded { get; set; }
        public string ScopeMacroCondition { get; set; }

        public virtual Class ScopeClass { get; set; }
        public virtual Culture ScopeCulture { get; set; }
        public virtual Site ScopeSite { get; set; }
        public virtual Workflow ScopeWorkflow { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models.Cms
{
    public partial class WorkflowAction
    {
        public WorkflowAction()
        {
            CmsWorkflowStep = new HashSet<WorkflowStep>();
        }

        public int ActionId { get; set; }
        public string ActionDisplayName { get; set; }
        public string ActionName { get; set; }
        public string ActionParameters { get; set; }
        public string ActionDescription { get; set; }
        public string ActionAssemblyName { get; set; }
        public string ActionClass { get; set; }
        public int? ActionResourceId { get; set; }
        public Guid? ActionThumbnailGuid { get; set; }
        public Guid ActionGuid { get; set; }
        public DateTime ActionLastModified { get; set; }
        public bool ActionEnabled { get; set; }
        public string ActionAllowedObjects { get; set; }
        public Guid? ActionIconGuid { get; set; }
        public int? ActionWorkflowType { get; set; }
        public string ActionIconClass { get; set; }
        public string ActionThumbnailClass { get; set; }

        public virtual ICollection<WorkflowStep> CmsWorkflowStep { get; set; }
        public virtual Resource ActionResource { get; set; }
    }
}

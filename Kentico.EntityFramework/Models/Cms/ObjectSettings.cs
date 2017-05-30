using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models.Cms
{
    public partial class ObjectSettings
    {
        public int ObjectSettingsId { get; set; }
        public string ObjectTags { get; set; }
        public int? ObjectCheckedOutByUserId { get; set; }
        public DateTime? ObjectCheckedOutWhen { get; set; }
        public int? ObjectCheckedOutVersionHistoryId { get; set; }
        public int? ObjectWorkflowStepId { get; set; }
        public int? ObjectPublishedVersionHistoryId { get; set; }
        public int ObjectSettingsObjectId { get; set; }
        public string ObjectSettingsObjectType { get; set; }
        public string ObjectComments { get; set; }
        public bool? ObjectWorkflowSendEmails { get; set; }

        public virtual User ObjectCheckedOutByUser { get; set; }
        public virtual ObjectVersionHistory ObjectCheckedOutVersionHistory { get; set; }
        public virtual ObjectVersionHistory ObjectPublishedVersionHistory { get; set; }
        public virtual WorkflowStep ObjectWorkflowStep { get; set; }
    }
}

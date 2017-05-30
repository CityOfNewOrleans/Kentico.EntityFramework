using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class OmContactGroup
    {
        public OmContactGroup()
        {
            NewsletterIssueContactGroup = new HashSet<NewsletterIssueContactGroup>();
            OmContactGroupMember = new HashSet<OmContactGroupMember>();
        }

        public int ContactGroupId { get; set; }
        public string ContactGroupName { get; set; }
        public string ContactGroupDisplayName { get; set; }
        public string ContactGroupDescription { get; set; }
        public string ContactGroupDynamicCondition { get; set; }
        public bool? ContactGroupEnabled { get; set; }
        public DateTime? ContactGroupLastModified { get; set; }
        public Guid? ContactGroupGuid { get; set; }
        public int? ContactGroupStatus { get; set; }

        public virtual ICollection<NewsletterIssueContactGroup> NewsletterIssueContactGroup { get; set; }
        public virtual ICollection<OmContactGroupMember> OmContactGroupMember { get; set; }
    }
}

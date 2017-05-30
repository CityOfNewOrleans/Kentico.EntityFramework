using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class OmRule
    {
        public OmRule()
        {
            OmScoreContactRule = new HashSet<OmScoreContactRule>();
        }

        public int RuleId { get; set; }
        public int RuleScoreId { get; set; }
        public string RuleDisplayName { get; set; }
        public string RuleName { get; set; }
        public int RuleValue { get; set; }
        public bool? RuleIsRecurring { get; set; }
        public int? RuleMaxPoints { get; set; }
        public DateTime? RuleValidUntil { get; set; }
        public string RuleValidity { get; set; }
        public int? RuleValidFor { get; set; }
        public int RuleType { get; set; }
        public string RuleParameter { get; set; }
        public string RuleCondition { get; set; }
        public DateTime RuleLastModified { get; set; }
        public Guid RuleGuid { get; set; }
        public bool RuleBelongsToPersona { get; set; }

        public virtual ICollection<OmScoreContactRule> OmScoreContactRule { get; set; }
        public virtual OmScore RuleScore { get; set; }
    }
}

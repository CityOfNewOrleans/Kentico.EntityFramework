using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class OmScoreContactRule
    {
        public int ScoreId { get; set; }
        public int ContactId { get; set; }
        public int RuleId { get; set; }
        public int Value { get; set; }
        public DateTime? Expiration { get; set; }
        public int ScoreContactRuleId { get; set; }

        public virtual OmContact Contact { get; set; }
        public virtual OmRule Rule { get; set; }
        public virtual OmScore Score { get; set; }
    }
}

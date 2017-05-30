﻿using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class OmScore
    {
        public OmScore()
        {
            OmRule = new HashSet<OmRule>();
            OmScoreContactRule = new HashSet<OmScoreContactRule>();
        }

        public int ScoreId { get; set; }
        public string ScoreName { get; set; }
        public string ScoreDisplayName { get; set; }
        public string ScoreDescription { get; set; }
        public bool ScoreEnabled { get; set; }
        public int? ScoreEmailAtScore { get; set; }
        public string ScoreNotificationEmail { get; set; }
        public DateTime ScoreLastModified { get; set; }
        public Guid ScoreGuid { get; set; }
        public int? ScoreStatus { get; set; }
        public int? ScoreScheduledTaskId { get; set; }
        public bool ScoreBelongsToPersona { get; set; }

        public virtual ICollection<OmRule> OmRule { get; set; }
        public virtual ICollection<OmScoreContactRule> OmScoreContactRule { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class PollsPollAnswer
    {
        public int AnswerId { get; set; }
        public string AnswerText { get; set; }
        public int? AnswerOrder { get; set; }
        public int? AnswerCount { get; set; }
        public bool? AnswerEnabled { get; set; }
        public int AnswerPollId { get; set; }
        public Guid AnswerGuid { get; set; }
        public DateTime AnswerLastModified { get; set; }
        public string AnswerForm { get; set; }
        public string AnswerAlternativeForm { get; set; }
        public bool? AnswerHideForm { get; set; }

        public virtual PollsPoll AnswerPoll { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class SmInsightHitMonth
    {
        public int InsightHitId { get; set; }
        public DateTime InsightHitPeriodFrom { get; set; }
        public DateTime InsightHitPeriodTo { get; set; }
        public long InsightHitValue { get; set; }
        public int InsightHitInsightId { get; set; }

        public virtual SmInsight InsightHitInsight { get; set; }
    }
}

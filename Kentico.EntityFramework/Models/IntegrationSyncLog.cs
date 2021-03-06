﻿using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class IntegrationSyncLog
    {
        public int SyncLogId { get; set; }
        public int SyncLogSynchronizationId { get; set; }
        public DateTime SyncLogTime { get; set; }
        public string SyncLogErrorMessage { get; set; }

        public virtual IntegrationSynchronization SyncLogSynchronization { get; set; }
    }
}

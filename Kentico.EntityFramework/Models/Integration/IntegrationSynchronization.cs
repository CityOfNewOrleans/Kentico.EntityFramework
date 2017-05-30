using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class IntegrationSynchronization
    {
        public IntegrationSynchronization()
        {
            IntegrationSyncLog = new HashSet<IntegrationSyncLog>();
        }

        public int SynchronizationId { get; set; }
        public int SynchronizationTaskId { get; set; }
        public int SynchronizationConnectorId { get; set; }
        public DateTime SynchronizationLastRun { get; set; }
        public string SynchronizationErrorMessage { get; set; }
        public bool? SynchronizationIsRunning { get; set; }

        public virtual ICollection<IntegrationSyncLog> IntegrationSyncLog { get; set; }
        public virtual IntegrationConnector SynchronizationConnector { get; set; }
        public virtual IntegrationTask SynchronizationTask { get; set; }
    }
}

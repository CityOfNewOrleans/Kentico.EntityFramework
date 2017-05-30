using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class IntegrationConnector
    {
        public IntegrationConnector()
        {
            IntegrationSynchronization = new HashSet<IntegrationSynchronization>();
        }

        public int ConnectorId { get; set; }
        public string ConnectorName { get; set; }
        public string ConnectorDisplayName { get; set; }
        public string ConnectorAssemblyName { get; set; }
        public string ConnectorClassName { get; set; }
        public bool ConnectorEnabled { get; set; }
        public DateTime ConnectorLastModified { get; set; }

        public virtual ICollection<IntegrationSynchronization> IntegrationSynchronization { get; set; }
    }
}

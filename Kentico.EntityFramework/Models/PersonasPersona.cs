using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class PersonasPersona
    {
        public int PersonaId { get; set; }
        public string PersonaDisplayName { get; set; }
        public string PersonaName { get; set; }
        public string PersonaDescription { get; set; }
        public bool PersonaEnabled { get; set; }
        public Guid PersonaGuid { get; set; }
        public int PersonaScoreId { get; set; }
        public Guid? PersonaPictureMetafileGuid { get; set; }
        public int PersonaPointsThreshold { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class PersonasPersonaNode
    {
        public int PersonaId { get; set; }
        public int NodeId { get; set; }

        public virtual Tree Node { get; set; }
    }
}

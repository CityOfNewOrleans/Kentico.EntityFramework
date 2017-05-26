using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class OmMvtcombinationVariation
    {
        public int MvtcombinationId { get; set; }
        public int MvtvariantId { get; set; }

        public virtual OmMvtcombination Mvtcombination { get; set; }
        public virtual OmMvtvariant Mvtvariant { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class PollsPollRoles
    {
        public int PollId { get; set; }
        public int RoleId { get; set; }

        public virtual PollsPoll Poll { get; set; }
        public virtual Role Role { get; set; }
    }
}

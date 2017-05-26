using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class PollsPoll
    {
        public PollsPoll()
        {
            PollsPollAnswer = new HashSet<PollsPollAnswer>();
            PollsPollRoles = new HashSet<PollsPollRoles>();
            PollsPollSite = new HashSet<PollsPollSite>();
        }

        public int PollId { get; set; }
        public string PollCodeName { get; set; }
        public string PollDisplayName { get; set; }
        public string PollTitle { get; set; }
        public DateTime? PollOpenFrom { get; set; }
        public DateTime? PollOpenTo { get; set; }
        public bool PollAllowMultipleAnswers { get; set; }
        public string PollQuestion { get; set; }
        public int PollAccess { get; set; }
        public string PollResponseMessage { get; set; }
        public Guid PollGuid { get; set; }
        public DateTime PollLastModified { get; set; }
        public int? PollGroupId { get; set; }
        public int? PollSiteId { get; set; }
        public bool? PollLogActivity { get; set; }

        public virtual ICollection<PollsPollAnswer> PollsPollAnswer { get; set; }
        public virtual ICollection<PollsPollRoles> PollsPollRoles { get; set; }
        public virtual ICollection<PollsPollSite> PollsPollSite { get; set; }
        public virtual CommunityGroup PollGroup { get; set; }
        public virtual CmsSite PollSite { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class ForumsUserFavorites
    {
        public int FavoriteId { get; set; }
        public int UserId { get; set; }
        public int? PostId { get; set; }
        public int? ForumId { get; set; }
        public string FavoriteName { get; set; }
        public int SiteId { get; set; }
        public Guid FavoriteGuid { get; set; }
        public DateTime FavoriteLastModified { get; set; }

        public virtual ForumsForum Forum { get; set; }
        public virtual ForumsForumPost Post { get; set; }
        public virtual Site Site { get; set; }
        public virtual User User { get; set; }
    }
}

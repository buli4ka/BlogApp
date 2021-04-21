using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Context
{
    public class Article
    {
        public int ArticleId { get; set; }
        public string FilePath { get; set; }
        public string Title { get; set; }
        public virtual User Creator { get; set; }
        public virtual ICollection<HashTag> HashTags { get; set; }
        public virtual ICollection<User> LikedUsers { get; set; }
        public virtual ICollection<User> ViewedUsers { get; set; }
        public virtual ICollection<User> FavoritedUsers { get; set; }
       
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Context
{
    public class User
    {
        public int UserId { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Article> LikedArticles { get; set; }
        public virtual ICollection<Article> MyArticles { get; set; }
        public virtual ICollection<Article> Favorites { get; set; }
        
    }
}

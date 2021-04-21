using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public class User
    {
        public int UserId { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public  List<Article> LikedArticles { get; set; }
        public  List<Article> MyArticles { get; set; }
        public  List<Article> Favorites { get; set; }
    }
}

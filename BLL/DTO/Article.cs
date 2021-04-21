using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public class Article
    {
        public int ArticleId { get; set; }
        public string FilePath { get; set; }
        public string Title { get; set; }
        public User Creator { get; set; }
        public  List<HashTag> HashTags { get; set; }
        public int LikesCount { get; set; }
        public int ViewCount { get; set; }
    }
}

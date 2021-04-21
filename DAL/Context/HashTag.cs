using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Context
{
    public class HashTag
    {
        public int HashTagId { get; set; }
        public string Tag { get; set; }
        public virtual ICollection<Article> Articles { get; set; }
    }
}

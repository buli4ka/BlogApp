using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Context
{
    public class BlogContext : DbContext
    {
        public BlogContext() : base("name=BlogApp")
        {

        }
        public virtual DbSet<Article> Article { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<HashTag> HashTag { get; set; }
    }
}

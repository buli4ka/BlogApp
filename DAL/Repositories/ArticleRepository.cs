using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Context;
using System.Data.Entity;

namespace DAL.Repositories
{
    class ArticleRepository : RepositoryBase<Article>
    {
        public ArticleRepository(DbContext context) : base(context)
        {

        }
    }
}

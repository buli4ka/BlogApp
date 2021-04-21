using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Context;
using System.Data.Entity;

namespace DAL.Repositories
{
    class HashTagRepository : RepositoryBase<HashTag>
    {
        public HashTagRepository(DbContext context) : base(context)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Context;
using System.Data.Entity;

namespace DAL.Repositories
{
    class UserRepository : RepositoryBase<User>
    {
        public UserRepository(DbContext context) : base(context)
        {

        }
    }
}

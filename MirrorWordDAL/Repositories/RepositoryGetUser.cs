using MirrorWordDAL.EFCore;
using MirrorWordDAL.Entities;
using MirrorWordDAL.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MirrorWordDAL.Repositories
{
    public class RepositoryGetUser : IRepositoryGetUser<RegisterUser>
    {
        public IEnumerable<RegisterUser> GetUsers()
        {
            using (UserContext db = new UserContext())
            {
                var query = db.RegisterUsers.ToList();

                return query;
            }
        }
    }
}


using System;
using System.Collections.Generic;
using System.Text;

namespace MirrorWordDAL.interfaces
{
    public interface IRepositoryGetUser <T> where T : class
    {
        public IEnumerable<T> GetUsers();
        
    }
}

using System;
using blogum_db.models;
using blogum_db.repository;

namespace blogum_db.repositories
{
    public interface IUserRepository : IBaseRepository<User> { }

    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository()
        {
            
        }
    }
}

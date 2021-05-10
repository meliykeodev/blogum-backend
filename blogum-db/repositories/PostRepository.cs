using System;
using blogum_db.models;
using blogum_db.repository;

namespace blogum_db.repositories
{
    public interface IPostRepository: IBaseRepository<Post> { }

    public class PostRepository: BaseRepository<Post>, IPostRepository
    {
        
    }
}

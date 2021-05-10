using System;
using blogum_db.models;
using blogum_db.repository;

namespace blogum_db.repositories
{
    public interface ICommentRepository: IBaseRepository<Comment> { }

    public class CommentRepository: BaseRepository<Comment>, ICommentRepository
    {
        public CommentRepository()
        {
        }
    }
}

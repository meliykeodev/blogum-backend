using System;
using blogum_db.models;
using blogum_db.repository;

namespace blogum_db.repositories
{
    public interface ICategoryRepository: IBaseRepository<Category> { }

    public class CategoryRepository: BaseRepository<Category>, ICategoryRepository
    {
        public CategoryRepository()
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Security.Principal;
using System.Threading.Tasks;
using blogum_db.models;

namespace blogum_db.repository
{
    public interface IBaseRepository<T> where T : class, IBaseEntity, new()
    {
        Task<T> Get(Expression<Func<T, bool>> filter);

        Task<List<T>> GetAll(Expression<Func<T, bool>> filter = null);

        Task<List<T>> GetAll(object filter);

        Task<List<T>> GetAllActive();

        Task<long> Insert(T entity);

        Task<bool> Update(T entity);

        Task<bool> Delete(T entity);
    }
}

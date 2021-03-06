using System;
using System.Collections.Generic;
using System.Data;
using System.Linq.Expressions;
using System.Threading.Tasks;
using blogum_core.Helpers;
using blogum_db.models;
using Dapper;

namespace blogum_db.repository
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity>
        where TEntity : class, IBaseEntity, new()
    {
        protected IDbConnection Connection => DatabaseHelper.Connection;

        public async Task<TEntity> Get(Expression<Func<TEntity, bool>> filter)
        {
            // var result = await Task.Run(() => Connection.Get<TEntity>(filter));

            var result = await Connection.GetAsync<TEntity>(filter);

            return result;
        }

        public async Task<List<TEntity>> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            var result = (await Connection.GetListAsync<TEntity>(filter));

            return result.AsList();
        }

        public async Task<List<TEntity>> GetAll(object filter)
        {
            var result = await Connection.GetListAsync<TEntity>();

            return result.AsList();
        }

        public async Task<List<TEntity>> GetAllActive()
        {
            var result = (await Connection.GetListAsync<TEntity>()).AsList();

            var filtered = result.FindAll(x => x.IsActive);

            return filtered;
        }

        public async Task<long> Insert(TEntity entity)
        {
            var result = await Connection.InsertAsync<TEntity>(entity);

            return (long)result;
        }

        public async Task<bool> Update(TEntity entity)
        {
            var result = await Connection.UpdateAsync<TEntity>(entity);

            return result > 0;
        }

        public async Task<bool> Delete(TEntity entity)
        {
            entity.IsActive = false;

            var result = await Connection.UpdateAsync<TEntity>(entity);

            return result > 0;
        }
    }
}

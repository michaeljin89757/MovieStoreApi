using MusicStoreApi.Services.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MusicStoreApi.Repositories
{
    public class GeneralServices<T> : IGeneralServices<T> where T : class
    {
        protected readonly Repository<T> _table;
        public GeneralServices(Repository<T> table)
        {
            _table = table;

        }

        public async Task<T> AddAsync(T entity)
        {
            return await _table.AddAsync(entity);
        }

        public async Task DeleteAsync(T entity)
        {
            await _table.DeleteAsync(entity);
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _table.GetByIdAsync(id);
        }

        public async Task<int> GetCountAsync(Expression<Func<T, bool>> filter = null)
        {
            return await _table.GetCountAsync(filter);
        }

        public async Task<bool> GetExistsAsync(Expression<Func<T, bool>> filter = null)
        {
            return await _table.GetExistsAsync(filter);
        }

        public async Task<IEnumerable<T>> ListAsync(Expression<Func<T, bool>> filter)
        {
            return await _table.ListAsync(filter);
        }

        public async Task<IEnumerable<T>> ListAllAsync()
        {
            return await _table.ListAllAsync();
        }

        public async Task<T> UpdateAsync(T entity)
        {
            return await _table.UpdateAsync(entity);
        }
    }
}

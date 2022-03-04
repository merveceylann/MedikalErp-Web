using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SlnErp102.Core.Models;
using SlnErp102.Core.Repository;

namespace SlnErp102.Data.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly SlnDbContext _db;
        private readonly DbSet<T> _dbSet;

        public Repository(SlnDbContext db)
        {
            _db = db;
            _dbSet = db.Set<T>();
        }
        public async Task AddAsync(T entity)
        {
            if (entity is BaseEntity baseEntity)
            {
                DateTime now = DateTime.Now;
                baseEntity.CreatedOn = now;
                baseEntity.ModifiedOn = now;
                baseEntity.ModifiedUser = "system";
            }
            await _dbSet.AddAsync(entity);
        }

        public async Task AddRangeAsync(IEnumerable<T> entities)
        {
            await _dbSet.AddRangeAsync(entities);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
            //return await _dbSet.FirstOrDefaultAsync();
        }

        public IQueryable<T> QList()
        {
            return _dbSet.AsQueryable<T>();
        }

        public void Remove(T entity)
        {
            _dbSet.Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            _dbSet.RemoveRange(entities);
        }

        public async Task<T> SingleOrDefaultAsync(Expression<Func<T, bool>> predicate)
        {
            return await _dbSet.SingleOrDefaultAsync(predicate);
        }

        public T Update(T entity)
        {
            
            if (entity is BaseEntity baseEntity)
            {
                baseEntity.ModifiedOn = DateTime.Now;
                baseEntity.ModifiedUser = "system";
            }
            _db.Entry(entity).State = EntityState.Modified;
            return entity;
        }

        public async Task<IEnumerable<T>> Where(Expression<Func<T, bool>> predicate)
        {
            return await _dbSet.Where(predicate).ToListAsync();
        }
    }
}


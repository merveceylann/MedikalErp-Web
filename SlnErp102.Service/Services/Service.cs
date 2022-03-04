using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using SlnErp102.Core.Repository;
using SlnErp102.Core.Service;
using SlnErp102.Core.UnitOfWork;

namespace SlnErp102.Service.Services
{
    public class Service<T> : IService<T> where T : class
    {
        public IUnitOfWork _unitOfWork;
        private IRepository<T> _repo;

        public Service(IUnitOfWork unitOfWork, IRepository<T> repository)
        {
            _unitOfWork = unitOfWork;
            _repo = repository;
        }

        public async Task<T> AddAsync(T entity)
        {
            await _repo.AddAsync(entity);
            await _unitOfWork.CommitAsync();
            return entity;
        }

        public async Task<IEnumerable<T>> AddRangeAsync(IEnumerable<T> entities)
        {
            await _repo.AddRangeAsync(entities);
            await _unitOfWork.CommitAsync();
            return entities;
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _repo.GetAllAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _repo.GetByIdAsync(id);
        }

        public IQueryable<T> QList()
        {
            return _repo.QList();
        }

        public void Remove(T entity)
        {
            _repo.Remove(entity);
            _unitOfWork.Commit();
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            _repo.RemoveRange(entities);
            _unitOfWork.Commit();
        }

        public async Task<T> SingleOrDefaultAsync(Expression<Func<T, bool>> predicate)
        {
            return await _repo.SingleOrDefaultAsync(predicate);
        }

        public T Update(T entity)
        {
            T upd = _repo.Update(entity);
            _unitOfWork.Commit();
            return upd;
        }

        public async Task<IEnumerable<T>> Where(Expression<Func<T, bool>> predicate)
        {
            return await _repo.Where(predicate);
        }
    }
}

using Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    internal class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        private readonly DataContext _dataContext;
        public BaseRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public void Add(T entity)
        {
            _dataContext.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            _dataContext.Set<T>().Remove(entity);
        }

        public void Edit(T entity)
        {
            _dataContext.Entry(entity).State = EntityState.Modified;
        }

        public IQueryable<T> GetAll(Expression<Func<T, bool>> where = null)
        {
            if (where != null)
                return _dataContext.Set<T>().Where(where);
            return _dataContext.Set<T>();
        }

        public T GetById(int id)
        {
            return _dataContext.Set<T>().Find(id);
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _dataContext.Set<T>().FindAsync(id);
        }

        public int SaveChange()
        {
            return _dataContext.SaveChanges();
        }

        public async Task<int> SaveChangeAsync()
        {
            return await _dataContext.SaveChangesAsync();
        }
    }

    public interface IBaseRepository<T> where T : BaseEntity
    {
        void Add(T entity);
        void Edit(T entity);
        void Delete(T entity);
        T GetById(int id);
        Task<T> GetByIdAsync(int id);
        IQueryable<T> GetAll(Expression<Func<T, bool>> where = null);
        int SaveChange();
        Task<int> SaveChangeAsync();
    }
}

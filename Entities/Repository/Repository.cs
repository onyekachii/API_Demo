using Entities.Interfaces;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Repository
{
    public abstract class Repository<T> : IRepository<T> where T : class
    {
        protected ApplicationContext Context;
        public Repository(ApplicationContext context)
        {
            Context = context;
        }

        public IQueryable<T> FindAll(bool trackChanges) =>
            !trackChanges ? Context.Set<T>().AsNoTracking() : Context.Set<T>();

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, bool trackChanges) =>
            !trackChanges ? Context.Set<T>().Where(expression).AsNoTracking() : Context.Set<T>().Where(expression);
        
        public T GetById(Guid id)
        {
            return Context.Set<T>().Find(id);
        }

        public void Create(T entity) => Context.Set<T>().Add(entity);
        public void Update(T entity) => Context.Set<T>().Update(entity);
        public void Delete(T entity) => Context.Set<T>().Remove(entity);
    }
}

using DevDemoApp.Domain.Contracts;
using DevDemoApp.Infra.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace DevDemoApp.Infra
{
    public abstract class Repository<T> : IRepository<T> where T : class
    {
        private DevDemoAppContext _context;

        public Repository(DevDemoAppContext context)
        {
            _context = context;
        }

        public void Create(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public virtual IEnumerable<T> Read()
        {
            return _context.Set<T>().AsEnumerable<T>();
        }

        public IEnumerable<T> Read(int skip, int take)
        {
            return _context.Set<T>().Skip(skip).Take(take).AsEnumerable<T>();
        }

        public virtual T FindOne(Expression<Func<T, bool>> predicate)
        {
            return _context.Set<T>().Where(predicate).FirstOrDefault();
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
        {
            return _context.Set<T>().Where(predicate).AsEnumerable();
        }

        public void Update(T entity)
        {
            _context.Entry<T>(entity).State = EntityState.Modified;
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}

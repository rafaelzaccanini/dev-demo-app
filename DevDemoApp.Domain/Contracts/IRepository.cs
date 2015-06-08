using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DevDemoApp.Domain.Contracts
{
    public interface IRepository<T> : IDisposable where T : class
    {
        void Create(T entity);
        IEnumerable<T> Read();
        IEnumerable<T> Read(int skip, int take);
        IEnumerable<T> Find(Expression<Func<T, bool>> predicate);
        T FindOne(Expression<Func<T, bool>> predicate);
        void Update(T entity);
        void Delete(T entity);
    }
}

using System;
using System.Linq;
using System.Linq.Expressions;

namespace DevDemoApp.Domain.Contracts
{
    public interface IRepository<T> : IDisposable where T : class
    {
        void Create(T entity);

        IQueryable<T> Read();

        IQueryable<T> Read(Expression<Func<T, bool>> predicate);

        void Update(T entity);

        void Delete(T entity);
    }
}

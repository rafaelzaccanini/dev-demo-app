using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DevDemoApp.Domain.Services.Base
{
    public interface IServiceBase<T> where T : class
    {
        void Create(T entity);

        IList<T> Read();

        T FindOne(Expression<Func<T, bool>> predicate);

        void Update(T entity);

        void Delete(T entity);
    }
}

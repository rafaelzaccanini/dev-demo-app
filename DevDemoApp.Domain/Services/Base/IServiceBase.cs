using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DevDemoApp.Domain.Services
{
    public interface IServiceBase<T> where T : class
    {
        void Create(T entity);

        IList<T> Read();

        void Update(T entity);

        void Delete(T entity);
    }
}

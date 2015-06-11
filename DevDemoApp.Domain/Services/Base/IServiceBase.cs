using System.Collections.Generic;
using System.Linq;

namespace DevDemoApp.Domain.Services
{
    public interface IServiceBase<T> where T : class
    {
        void Create(T entity);

        IQueryable<T> Read();

        void Update(T entity);

        void Delete(T entity);
    }
}

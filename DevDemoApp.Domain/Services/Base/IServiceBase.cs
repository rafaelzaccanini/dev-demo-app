using System.Collections.Generic;

namespace DevDemoApp.Domain.Services.Base
{
    public interface IServiceBase<T> where T : class
    {
        void Create(T entity);

        IEnumerable<T> Read();

        void Update(T entity);

        void Delete(T entity);
    }
}

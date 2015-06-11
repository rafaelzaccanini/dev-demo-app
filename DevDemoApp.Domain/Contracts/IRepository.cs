using System.Linq;

namespace DevDemoApp.Domain.Contracts
{
    public interface IRepository
    {
        void Create<T>(T entity) where T : class;

        IQueryable<T> Read<T>() where T : class;

        void Update<T>(T entity) where T : class;

        void Delete<T>(T entity) where T : class;
    }
}

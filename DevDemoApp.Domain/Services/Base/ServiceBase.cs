using DevDemoApp.Domain.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace DevDemoApp.Domain.Services
{
    public class ServiceBase<T> : IServiceBase<T> where T : class
    {
        private readonly IRepository _repository;

        public ServiceBase(IRepository repository)
        {
            _repository = repository;
        }


        public void Create(T entity)
        {
            _repository.Create(entity);
        }

        public IQueryable<T> Read()
        {
            return _repository.Read<T>();
        }

        public void Update(T entity)
        {
            _repository.Update(entity);
        }

        public void Delete(T entity)
        {
            _repository.Delete(entity);
        }
    }
}

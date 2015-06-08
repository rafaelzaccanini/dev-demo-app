using DevDemoApp.Domain.Contracts;
using System.Collections.Generic;

namespace DevDemoApp.Domain.Services.Base
{
    public abstract class ServiceBase<T> : IServiceBase<T> where T : class
    {
        #region Construtor

        private readonly IRepository<T> _repository;

        public ServiceBase(IRepository<T> repository)
        {
            _repository = repository;
        }

        #endregion

        public void Create(T entity)
        {
            _repository.Create(entity);
        }

        public abstract IEnumerable<T> Read();
        //{
        //    return _repository.Read();
        //}

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

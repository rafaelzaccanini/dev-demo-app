using DevDemoApp.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DevDemoApp.Domain.Services
{
    public class ServiceBase<T> : IServiceBase<T> where T : class
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

        public IList<T> Read()
        {
            return _repository.Read().ToList();
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

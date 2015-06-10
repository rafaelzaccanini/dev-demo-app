using DevDemoApp.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

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

        public virtual IList<T> Read()
        {
            return _repository.Read().ToList();
        }

        public T FindOne(Expression<Func<T, bool>> predicate)
        {
            return _repository.FindOne(predicate);
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

using DevDemoApp.Domain.Contracts;
using DevDemoApp.Infra.Data.Context;
using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace DevDemoApp.Infra.Data
{
    public class Repository : IRepository
    {
        protected DevDemoAppContext _context;

        public Repository(DevDemoAppContext context)
        {
            _context = context;
        }

        public void Create<T>(T entity) where T : class
        {
            try
            {
                _context.Set<T>().Add(entity);
                Commit();
            }
            catch (Exception e)
            {
                _context.Entry(entity).State = EntityState.Unchanged;
                throw new Exception(Error(e));
            }
        }

        public IQueryable<T> Read<T>() where T : class
        {
            try
            {
                return _context.Set<T>();
            }
            catch (Exception e)
            {
                throw new Exception(Error(e));
            }
        }

        public void Update<T>(T entity) where T : class
        {
            try
            {
                _context.Entry<T>(entity).State = EntityState.Modified;
                Commit();
            }
            catch (Exception e)
            {
                _context.Entry(entity).State = EntityState.Unchanged;
                throw new Exception(Error(e));
            }
        }

        public void Delete<T>(T entity) where T : class
        {
            try
            {
                _context.Set<T>().Remove(entity);
                Commit();
            }
            catch (Exception e)
            {
                throw new Exception(Error(e));
            }
        }

        private void Commit()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        private string Error(Exception e)
        {
            var erros = _context.GetValidationErrors().SelectMany(a => a.ValidationErrors.Select(b => b.ErrorMessage)).ToList();

            if (erros.Count > 0)
                return e.Message + " - " + erros.Aggregate((atual, prox) => atual + ", " + prox);

            if (e.InnerException != null)
                return e.InnerException.GetBaseException().Message + " - " + e.Message;

            return e.Message;
        }
    }
}

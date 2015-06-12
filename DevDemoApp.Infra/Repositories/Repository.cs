using DevDemoApp.Domain.Contracts;
using DevDemoApp.Infra.Data.Context;
using System;
using System.Data.Entity;
using System.Linq;

namespace DevDemoApp.Infra.Data
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected DevDemoAppContext _context;
        protected DbSet<T> _dbSet;

        public Repository(DevDemoAppContext context)
        {
            if (context == null)
                throw new ArgumentNullException("DbContext is null!");

            _context = context;
            _dbSet = _context.Set<T>();
        }


        public void Create(T entity)
        {
            try
            {
                _dbSet.Add(entity);
                Commit();
            }
            catch (Exception e)
            {
                _context.Entry(entity).State = EntityState.Unchanged;
                throw new Exception(Error(e));
            }
        }

        public IQueryable<T> Read()
        {
            try
            {
                return _dbSet;
            }
            catch (Exception e)
            {
                throw new Exception(Error(e));
            }
        }

        public void Update(T entity)
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

        public void Delete(T entity)
        {
            try
            {
                _dbSet.Remove(entity);
                Commit();
            }
            catch (Exception e)
            {
                throw new Exception(Error(e));
            }
        }

        public void Dispose()
        {
            _context.Dispose();
        }
        private void Commit()
        {
            _context.SaveChanges();
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

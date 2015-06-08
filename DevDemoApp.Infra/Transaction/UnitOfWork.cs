using DevDemoApp.Domain.Contracts;
using DevDemoApp.Infra.Context;

namespace DevDemoApp.Infra
{
    public sealed class UnitOfWork : IUnitOfWork
    {
        private DevDemoAppContext _context;

        public UnitOfWork(DevDemoAppContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
        }

        private void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_context != null)
                {
                    _context.Dispose();
                    _context = null;
                }
            }
        }
    }
}

using System;

namespace DevDemoApp.Domain.Contracts
{
    public interface IUnitOfWork : IDisposable
    {
        void Commit();
    }
}

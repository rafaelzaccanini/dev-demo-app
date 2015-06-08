using DevDemoApp.Domain.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace DevDemoApp.Domain.Services.Base
{
    public class ServiceUser : ServiceBase<User>, IServiceUser
    {
        private IRepositoryUser _repository;

        public ServiceUser(IRepositoryUser repository)
            : base(repository)
        {
            _repository = repository;
        }

        public override IEnumerable<User> Read()
        {
            return _repository.Read();
        }

    }
}

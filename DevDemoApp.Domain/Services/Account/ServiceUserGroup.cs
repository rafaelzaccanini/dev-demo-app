using DevDemoApp.Domain.Contracts;
using System.Linq;

namespace DevDemoApp.Domain.Services
{
    public class ServiceUserGroup : ServiceBase<UserGroup>, IServiceUserGroup
    {
        private IRepository<UserGroup> _repository;

        public ServiceUserGroup(IRepository<UserGroup> repository)
            : base(repository)
        {
            _repository = repository;
        }

        public UserGroup Get(int cod)
        {
            return _repository.Read().FirstOrDefault(u => u.CodUserGroup == cod);
        }
    }
}

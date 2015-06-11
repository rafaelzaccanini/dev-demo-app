using DevDemoApp.Domain.Contracts;
using System.Linq;

namespace DevDemoApp.Domain.Services
{
    public class ServiceUser : ServiceBase<User>, IServiceUser
    {
        private IRepository _repository;

        public ServiceUser(IRepository repository)
            : base(repository)
        {
            _repository = repository;
        }

        public User Get(int cod)
        {
            return _repository.Read<User>().FirstOrDefault(u => u.CodUser == cod);
        }
    }
}

using DevDemoApp.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DevDemoApp.Domain.Services.Base
{
    public class ServiceUser : ServiceBase<User>, IServiceUser
    {
        private IRepositoryUser _repositoryUser;

        public ServiceUser(IRepositoryUser repositoryUser)
            : base(repositoryUser)
        {
            _repositoryUser = repositoryUser;
        }

        public User FindOne(Expression<Func<User, bool>> predicate)
        {
            return _repositoryUser.FindOne(predicate);
        }

        public override IList<User> Read()
        {
            return _repositoryUser.Read().ToList();
        }

    }
}

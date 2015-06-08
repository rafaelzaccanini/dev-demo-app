using DevDemoApp.Domain;
using DevDemoApp.Domain.Contracts;
using DevDemoApp.Infra.Context;
using System.Collections.Generic;
using System.Data.Entity;

namespace DevDemoApp.Infra.Repositories
{
    public class RepositoryUser : Repository<User>, IRepositoryUser
    {
        private DevDemoAppContext _context;

        public RepositoryUser(DevDemoAppContext context)
            : base(context)
        {
            this._context = context;
        }

        public override IEnumerable<User> Read()
        {
            return _context.Users.Include(x => x.UserGroup);
        }
    }
}

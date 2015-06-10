using DevDemoApp.Domain;
using DevDemoApp.Domain.Contracts;
using DevDemoApp.Infra.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

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

        public override User FindOne(Expression<Func<User, bool>> predicate)
        {
            return _context.Users.Include(x => x.UserGroup).FirstOrDefault(predicate);
        }

        public override IEnumerable<User> Read()
        {
            return _context.Users.Include(x => x.UserGroup);
        }
    }
}

using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

using DevDemoApp.Domain;
using DevDemoApp.Domain.Services;
using System;

namespace DevDemoApp.Api.Controllers
{
    public class UserController : ApiController
    {
        private IServiceUser _serviceUser;

        public UserController(IServiceUser serviceUser)
        {
            _serviceUser = serviceUser;
        }

        public IEnumerable<User> Get()
        {
            User uer = _serviceUser.FindByCod(3);

            //User u = new User() { Name = "Teste 333", CodUserGroup = 1, Active = true, BornDate = DateTime.Now };

            //_serviceUser.Create(u);

            var users2 = _serviceUser.Read();

            return users2.ToArray();
        }
    }
}

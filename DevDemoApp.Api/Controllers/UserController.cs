using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using DevDemoApp.Domain;
using DevDemoApp.Domain.Services.Base;

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
            var users = _serviceUser.Read().ToArray();
            
            return users;
        }
    }
}

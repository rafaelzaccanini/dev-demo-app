using System.Collections.Generic;
using System.Web.Http;
using DevDemoApp.Application;

namespace DevDemoApp.Api.Controllers
{
    public class AccountController : ApiController
    {
        private IApplicationServiceAccount _appServiceAccount;

        public AccountController(IApplicationServiceAccount appServiceAccount)
        {
            _appServiceAccount = appServiceAccount;
        }

        public IList<UserDTO> GetAllUsers()
        {
            var users = _appServiceAccount.GetAllUsers();

            return users;
        }
    }
}

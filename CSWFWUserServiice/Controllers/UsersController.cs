using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CSWFWInterface;
using CSWFWModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CSWFWUserServiice.Controllers
{
    public class UsersController : Controller
    {
        private readonly ILogger<UsersController> _logger;
        private readonly IUserseSvice _IUserseSvice;
        public UsersController(ILogger<UsersController> logger, IUserseSvice UserServe) {
            this._logger = logger;
            this._IUserseSvice = UserServe;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("api/GetUser")]
        public User GetUser(string name) {
            return this._IUserseSvice.getUser(name);
        }

        [HttpGet]
        [Route("api/GetAllUser")]
        public IEnumerable<User> GetAllUser() {
            return this._IUserseSvice.getAllUser();
        }
    }
}
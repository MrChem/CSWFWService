using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CSWFWInterface;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CSWFWUserDemo.Controllers
{
    public class UserController : Controller
    {
        private readonly ILogger<UserController> _logger;
        private readonly IUserseSvice _userseSvice;
        public UserController(ILogger<UserController> logger, IUserseSvice userSer) {
            this._logger = logger;
            this._userseSvice = userSer;
        }
        public IActionResult Index()
        {
            //base.ViewBag.user=this
            return View();
        }
    }
}
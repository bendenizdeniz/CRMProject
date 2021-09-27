using Business.Interfaces;
using Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRMProject.Controllers
{
    public class LoginController : Controller
    {
        private readonly ICustomerService customerServices;
        private readonly IUserService userServices;

        public LoginController(ICustomerService _customerService, IUserService _userService)
        {
            customerServices = _customerService;
            userServices = _userService;
        }

        [HttpGet]
        public IActionResult UserLogin()
        {
            return View();
        }

        [HttpPost]
        public bool UserLogin(User user)
        {
            var _user = userServices.UserLogin(user);
            if (_user != null)
            {
                HttpContext.Session.SetString("SessionUser", JsonConvert.SerializeObject(user));
                return true;
            }

            return false;
        }

        public PartialViewResult _UserLoginSessionPartial()
        {
            return PartialView();
        }

        public PartialViewResult LoginErrorPartial()
        {
            return PartialView();
        }
    }
}

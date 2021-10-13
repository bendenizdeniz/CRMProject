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
    public class RegisterController : Controller
    {
        private readonly IUserService userServices;
        private readonly ICustomerService customerServices;
        public RegisterController(ICustomerService _customerService, IUserService _userService)
        {
            customerServices = _customerService;
            userServices = _userService;
        }

        [HttpGet]
        public IActionResult UserRegister()
        {
            return View();
        }

        [HttpPost]
        public bool UserRegister(User user)
        {

            var _user = userServices.UserRegister(user);
            if (_user != null)
            {
                HttpContext.Session.SetString("SessionUser", JsonConvert.SerializeObject(user));
                return true;
            }

            return false;
        }
    }
}

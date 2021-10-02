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
        static int randNumber;
        Random rand = new Random();
        static string _email;

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
        [HttpGet]
        public IActionResult ForgotPassword()
        {
            return View();
        }

        public string SendCodeToUser(string email)
        {
            User user = userServices.GetUserByEmail(email);
            if (user != null)
            {
                randNumber = rand.Next(9999, 99999);
                string textEmail = "Hi, Your Code Is " + randNumber + " Thanx.";
                sendEmail.TryEmail(email, textEmail);
                return email;
            }

            return null;
        }

        [HttpGet]
        public IActionResult VerifyPassword()
        {

            return View();
        }

        [HttpPost]
        public bool VerifyPassword(string? email, int? verifyCode)
        {
            if (email is not null)  //function trigged by ForgotPassword
            {
                _email = SendCodeToUser(email);

                if (_email != null)
                    return true;

                return false;

            }

            if (verifyCode is not null) //function trigged by VerifyPassword
            {
                User user = userServices.GetUserByEmail(_email);

                if (user is not null && randNumber == verifyCode)
                {
                    string textEmail = "Hi, Your Password Is " + user.Password + " Thanx.";
                    sendEmail.TryEmail(user.Email, textEmail);
                    return true;
                }
                return false;
            }
            return false;
        }
    }
}

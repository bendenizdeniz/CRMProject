using Business.Interfaces;
using CRMProject.Models;
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
    public class CustomerController : Controller
    {
        private readonly ICustomerService customerServices;
        private readonly IUserService userServices;

        public CustomerController(ICustomerService _customerService, IUserService _userService)
        {
            customerServices = _customerService;
            userServices = _userService;
        }


        [HttpGet]
        public IActionResult CreateCustomer()
        {
            CustomerUserModel model = new();
            model.User = JsonConvert.DeserializeObject<User>(HttpContext.Session.GetString("SessionUser"));
            model.UserList = userServices.GetAllUser();

            return View(model: model);
        }

        [HttpPost]
        public bool CreateCustomer(Customer customer)
        {
            Customer _customer = customerServices.GetCustomerById(customer.Id);
            if (_customer is null)
            {
                customerServices.CreateCustomer(customer);
                return true;
            }

            return false;
        }
    }
}

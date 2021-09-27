using Business.Interfaces;
using CRMProject.Models;
using Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CRMProject.Controllers
{
    public class HomeController : Controller
    {
        //CrmsystemContext context = new CrmsystemContext();
        private readonly ICustomerService customerServices;
        private readonly IUserService userServices;

        private readonly ILogger<HomeController> _logger;
        List<User> userList = new();

        public HomeController(ILogger<HomeController> logger, ICustomerService _customerService, IUserService _userService)
        {
            customerServices = _customerService;
            userServices = _userService;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Home()
        {
            User user = JsonConvert.DeserializeObject<User>(HttpContext.Session.GetString("SessionUser"));

            return View(model: user);
        }

        [HttpPost]
        public IActionResult Home(int id)
        {
            return View();
        }

        [HttpGet]
        public IActionResult GetCustomer()
        {
            CustomerUserModel customerUserModel = new();
            User user = JsonConvert.DeserializeObject<User>(HttpContext.Session.GetString("SessionUser"));
            List<Customer> customerList = customerServices.GetAllCustomer();
            customerUserModel.CustomerList = customerList;
            customerUserModel.User = user;

            return View(model: customerUserModel);
        }

        [HttpGet]
        public IActionResult CustomerDetails(int id)
        {
            CustomerUserModel customerUserModel = new();
            customerUserModel.Customer = customerServices.GetCustomerById(id);
            customerUserModel.UserList = userServices.GetAllUser();
            customerUserModel.User = userServices.GetUserById((int)customerUserModel.Customer.UserId);
            customerUserModel.AccountUser = JsonConvert.DeserializeObject<User>(HttpContext.Session.GetString("SessionUser"));

            return View(model: customerUserModel);
        }

        [HttpPost]
        public bool CustomerDetails(Customer _customer)
        {
            Customer customer = new();
            customer = customerServices.GetCustomerById(_customer.Id);

            customer.FirstName = _customer.FirstName;
            customer.Email = _customer.Email;
            customer.JobTitle = _customer.JobTitle;
            customer.City = _customer.City;
            customer.CompanyName = _customer.CompanyName;
            customer.UserId = _customer.UserId;

            customerServices.UpdateCustomer(customer);
            return true;
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

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
            //var data = context.Customer.Include(x => x.User).ToList();

            List<Customer> customerList = customerServices.GetAllCustomer();

            return View(model: customerList);
        }

        [HttpPost]
        public IActionResult GetCustomer(Customer customer)
        {
            return View();
        }

        [HttpGet]
        public IActionResult CustomerDetails(int id)
        {
            CustomerUserListModel customerUserListModel = new();
            Customer customer = customerServices.GetCustomerById(id);

            customerUserListModel.customer = customer;
            customerUserListModel.userList = userServices.GetAllUser();

            User user = userServices.GetUserById((int)customer.UserId);
            customerUserListModel.customersUserName = user.Username;
            customerUserListModel.customersUserId = user.Id;
            return View(model: customerUserListModel);
        }

        [HttpPost]
        public bool CustomerDetails(int id, string userName, string email, string title, string city, string companyName, int customerUserID)
        {
            Customer customer = customerServices.GetCustomerById(id);
            customer.FirstName = userName;
            customer.Email = email;
            customer.JobTitle = title;
            customer.City = city;
            customer.CompanyName = companyName;
            customer.UserId = (userServices.GetUserById(customerUserID)).Id;
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

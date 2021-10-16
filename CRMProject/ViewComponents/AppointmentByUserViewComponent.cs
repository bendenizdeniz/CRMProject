using Business.Interfaces;
using Entity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRMProject.ViewComponents
{
    public class AppointmentByUserViewComponent : ViewComponent
    {
        private readonly ICustomerService customerService;
        private readonly IUserService userService;
        private readonly IAppointmentService appointmentService;

        public AppointmentByUserViewComponent(ICustomerService _customerService, IUserService _userService, IAppointmentService _appointmentService)
        {
            userService = _userService;
            customerService = _customerService;
            appointmentService = _appointmentService;
        }

        public IViewComponentResult Invoke(Appointment model)
        {
            
            model.Customer = customerService.GetCustomerById((int)model.CustomerId);
            model.User = userService.GetUserById((int)model.UserId);
            return View(model: model);
        }
    }
}

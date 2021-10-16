using Business.Interfaces;
using Entity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRMProject.ViewComponents
{
    public class AppointmentListByUserViewComponent : ViewComponent
    {
        private readonly ICustomerService customerService;
        private readonly IUserService userService;
        private readonly IAppointmentService appointmentService;

        public AppointmentListByUserViewComponent(ICustomerService _customerService, IUserService _userService, IAppointmentService _appointmentService)
        {
            userService = _userService;
            customerService = _customerService;
            appointmentService = _appointmentService;
        }

        public IViewComponentResult Invoke(List<Appointment> list)
        {
            if (list.Count > 0)
            {
                foreach (var item in list)
                {
                    item.Customer = customerService.GetCustomerById((int)item.CustomerId);
                    item.User = userService.GetUserById((int)item.UserId);
                }

                return View(model: list);
            }

            return View();
        }
    }
}

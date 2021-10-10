using Business.Interfaces;
using CRMProject.Models;
using Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;

namespace CRMProject.Controllers
{
    public class AppointmentController : Controller
    {
        private readonly ICustomerService customerService;
        private readonly IUserService userService;
        private readonly IAppointmentService appointmentService;

        public AppointmentController(ICustomerService _customerService, IUserService _userService, IAppointmentService _appointmentService)
        {
            userService = _userService;
            customerService = _customerService;
            appointmentService = _appointmentService;
        }

        [HttpGet]
        public IActionResult Appointment()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Appointment(Appointment appointment)
        {
            return View();
        }

        public IActionResult AppointmentListByUserViewComponent(DateTime? time = null, byte statusId = 0)
        {
            Appointment appointmentModel = appointmentService.GetAppointmentByUser(statusId, time);
            return ViewComponent("AppointmentByUser", appointmentModel);
        }

        [HttpGet]
        public IActionResult CreateAppointment()
        {
            AppointmentUserModel appointmentUserModel = new();
            appointmentUserModel.user = JsonConvert.DeserializeObject<User>(HttpContext.Session.GetString("SessionUser"));

            appointmentUserModel.userList = userService.GetAllUser();
            return View(model: appointmentUserModel);
        }

        [HttpPost]
        public bool CreateAppointment(string appointmentCustomerName, DateTime appointmentDate, string appointmentTime, int appointmentPersonel)
        {
            string partOfDay = "", time = "";

            Appointment appointment = new();
            appointment.ScheduledDate = appointmentDate;
            appointment.CustomerId = (customerService.GetCustomerByName(appointmentCustomerName)).Id;
            appointment.UserId = appointmentPersonel;
            appointment.Status = 0;

            if (appointmentTime.Length == 7)
            {
                partOfDay = appointmentTime.Substring(5);
                time = appointmentTime.Substring(0, 5);
            }
            if (appointmentTime.Length == 8)
            {
                partOfDay = appointmentTime.Substring(6);
                time = appointmentTime.Substring(0, 6);
            }

            appointment.ScheduledTime = TimeSpan.Parse(time);
            appointment.PartOfDay = partOfDay;
            appointmentService.CreateAppointment(appointment);
            return true;
        }
    }
}
